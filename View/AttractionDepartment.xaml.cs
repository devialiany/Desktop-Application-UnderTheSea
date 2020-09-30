using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using Microsoft.Win32;
using System.Drawing.Imaging;
using UnderTheSea.Controller;
using System.Linq;

namespace UnderTheSea.View
{
    public partial class AttractionDepartment : Window
    {

        int id = LoginHandler.idEmp;

        //String date;
        int quantity = 0;
        int totalPrice = 0;
        int change = 0;

        //string ticketID = "";

        public AttractionDepartment()
        {
            InitializeComponent();

            //generate date
            lbDate.Content = DateTime.Now.ToString("ddd, dd MMM yyyy");

            //getIdTransaction
            lbTransactionId.Content = TicketTransactionHandler.getTransactionId() + 1 ;

            // show profile
            lbeid.Content = id.ToString();
            lbeName.Content = MyProfileHandler.getEmployeeName(id);
            lbeGender.Content = MyProfileHandler.getEmployeeGender(id);
            lbeDob.Content = MyProfileHandler.getEmployeeDOB(id);
            lbeRole.Content = MyProfileHandler.getEmployeeRole(id);
            lbeDepartment.Content = MyProfileHandler.getEmployeeDepartment(id);

            //control flow
            btnPayment.IsEnabled = true;
            btnUpdate.IsEnabled = false;
            btnOk.IsEnabled = false;
            btnCancel.IsEnabled = false;
            btnPrint.IsEnabled = false;
            tbPaid.IsEnabled = false;
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            // insert to DB
            if(tbQuantity.Text == "")
            {
                MessageBox.Show("Quantity field must be filled");
            }else
            {
                TicketTransactionHandler.insertRecordTicketTransaction(id, DateTime.Now, Int32.Parse(tbQuantity.Text));
                MessageBox.Show("Total Payment : " + lbTotalPrice.Content);

                btnPayment.IsEnabled = false;
                tbPaid.IsEnabled = true;
                btnUpdate.IsEnabled = true;
                btnOk.IsEnabled = true;
                btnCancel.IsEnabled = true;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //update to db for qty
            TicketTransactionHandler.updateQty(Int32.Parse(tbQuantity.Text), Int32.Parse(lbTransactionId.Content.ToString()));
            MessageBox.Show("Quantity is updated");
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int paid = 0;
            try
            {
                paid = (Int32.Parse(tbPaid.Text));
                if (paid >= totalPrice)
                {
                    change = paid - totalPrice;
                    lbChanges.Content = "Rp. " + change.ToString();
                    TicketTransactionHandler.updateStatus(Int32.Parse(lbTransactionId.Content.ToString()));
                    tbQuantity.IsEnabled = false;
                    btnPrint.IsEnabled = true;
                    btnOk.IsEnabled = false;
                    btnUpdate.IsEnabled = false;
                    btnCancel.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Not Enough!");
                }
            }
            catch
            {
                tbPaid.Text = "";
                MessageBox.Show("Input number!");
            }

        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        { 
            TicketTransactionHandler.printTicket();
            btnPrint.IsEnabled = false;
            refreshForm();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            TicketTransactionHandler.deleteTransaction(Int32.Parse(lbTransactionId.Content.ToString()));
            MessageBox.Show("You cancel this record ticket transaction");
            refreshForm();
        }

        private void refreshForm()
        {
            lbTransactionId.Content = TicketTransactionHandler.getTransactionId() + 1;
            btnPayment.IsEnabled = true;
            btnUpdate.IsEnabled = false;
            btnOk.IsEnabled = false;
            btnCancel.IsEnabled = false;
            btnPrint.IsEnabled = false;
            tbPaid.IsEnabled = false;
            tbQuantity.IsEnabled = true;
            tbQuantity.Text = "";
            lbQuantity.Content = 0;
            lbTotalPrice.Content = "Rp. 0";
            tbPaid.Text = "";
            lbChanges.Content = "Rp. 0";
        }

        private void showTotalPrice_tbTextChange(object sender, TextChangedEventArgs e)
        {
            string a = tbQuantity.Text;
            if (a != "")
            {
                try
                {
                    quantity = (Int32.Parse(a));
                    if (quantity < 1 || quantity > 50)
                    {
                        tbQuantity.Text = "";
                        MessageBox.Show("Please input 1 - 50");
                    }
                }
                catch (Exception)
                {
                    tbQuantity.Text = "";
                    MessageBox.Show("Please input number");

                }
                totalPrice = quantity * 70000;
                lbQuantity.Content = quantity;
                lbTotalPrice.Content = "Rp. " + totalPrice.ToString();
            }
            else
            {
                lbQuantity.Content = 0;
                lbTotalPrice.Content = "Rp. 0";
            }
        }

        private void tbPaid_tbTextChange(object sender, TextChangedEventArgs e)
        {
            string a = tbPaid.Text;
            if (a != "")
            {
                btnOk.IsEnabled = true;
            }
            else
            {
                btnOk.IsEnabled = false;
            }
        }

        //select data
        private void dataTicketTransactionView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().TicketTransaction
                        select new
                        {
                            TransactionId = x.TicketTransactionId,
                            EmployeeName = x.Employee.EmployeeName,
                            TicketTransactionDate = x.TicketTransactionDate,
                            TicketQuantity = x.TicketQuantity,
                            TransactionStatus = x.TicketTransactionStatus
                        }).ToList();
            dataTicketTransactionView.ItemsSource = rslt;
        }

        //control view role
        public void viewSellingEmployee()
        {
            CheckTicket.IsEnabled = false;
        }

        public void viewEntranceGateEmployee()
        {
            DataTicketTransaction.IsEnabled = false;
            FormTicket.IsEnabled = false;
            CheckTicket.IsSelected = true;
        }

        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog ofd = new OpenFileDialog();

        private void btnScan_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                imgQRCode.Source = new BitmapImage(new Uri(ofd.FileName));
                tbQrCode.Text = decoder.Decode(new QRCodeBitmapImage(new Bitmap(ofd.FileName)));
            }
        }

        private void tbQrCode_TextChange(object sender, TextChangedEventArgs e)
        {
            string conCode = tbQrCode.Text.Substring(0, 8);
            if (CheckingTicketHandler.checkValidityTicket(conCode) == true)
            {
                lbMessage.Content = "Enjoy your day!";
            }
            else
            {
                lbMessage.Content = "Your Ticket Expired";
            }
        }

        private void rqPermit_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new RequestPermit();
        }

        private void rqResign_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new RequestResign();
        }

        private void historyPermit_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HistoryPermit();
        }

        private void historyResign_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HistoryResign();
        }
    }    
}
