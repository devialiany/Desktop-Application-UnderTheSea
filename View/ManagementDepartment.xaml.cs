using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UnderTheSea.Controller;

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for ManagementDepartment.xaml
    /// </summary>
    public partial class ManagementDepartment : Window
    {
        public ManagementDepartment()
        {
            InitializeComponent();
            lbTcSoldAll.Content = DataManagementHandler.getQtyTicketSoldAll();
            lbTcSoldToday.Content = DataManagementHandler.getQtyTicketSoldToday();
            showDataVizualization();
        }

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

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        public void showDataVizualization()
        {
            List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
            valueList.Add(new KeyValuePair<string, int>("30/05/2020", 2));
            valueList.Add(new KeyValuePair<string, int>("01/06/2020", 2));
            valueList.Add(new KeyValuePair<string, int>("02/06/2020", 6));
            valueList.Add(new KeyValuePair<string, int>("04/06/2020", 2));
            valueList.Add(new KeyValuePair<string, int>("18/06/2020", 1));

            //Setting data for column chart
            LineChartTicket.DataContext = valueList;
        }

        private void dataRequestRide_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideStatus.Contains("Waiting"))
                        select new
                        {
                            RequestRideId = x.ReqRideId,
                            RequestRideName = x.ReqRideName,
                            AttractionStatus = x.ReqRideStatus
                        }).ToList();
            dataRequestRide.ItemsSource = rslt;
        }

        private void btnAccRide_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.accReqRide(Int32.Parse(tbReqRideId.Text));
            MessageBox.Show("Accept Successfully");
        }

        private void btnNoAccRide_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.decReqRide(Int32.Parse(tbReqRideId.Text));
            MessageBox.Show("Not Accept Sucessfully");
        }

        private void btnSearchRide_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqRideId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id)
                        select new
                        {
                            x.ReqRideName, x.ReqRideDescription
                        }).ToList();
            foreach (var item in rslt)
            {
                lbNameRide.Content = item.ReqRideName;
                lbDescRide.Content = item.ReqRideDescription;
            }
        }

        private void btnSeacrhIdResign_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqResignId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestResign.Where(x => x.RequestResignId == id).FirstOrDefault();
            tbReason.Text = rslt.ResignReason;
        }

        private void dataRequestResign_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestResign.Where(x => x.ResignStatus.Contains("Wait"))
                        select new
                        {
                            RequestId = x.RequestResignId,
                            ResignStatus = x.ResignStatus
                        }).ToList();
            dataRequestResign.ItemsSource = rslt;
        }

        private void btnNoAccResign_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqResignId.Text);
            var rr = DatabaseConnectionHandler.GetInstance().RequestResign.Where(x => x.RequestResignId == id).FirstOrDefault();
            rr.ResignStatus = "Decline";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
            MessageBox.Show("Decline Successfully");
        }

        private void btnAccResign_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqResignId.Text);
            var rr = DatabaseConnectionHandler.GetInstance().RequestResign.Where(x => x.RequestResignId == id).FirstOrDefault();
            rr.ResignStatus = "Accept";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
            MessageBox.Show("Accept Successfully");
        }

        private void dataRequestAtt_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttStatus.Contains("Waiting"))
                        select new
                        {
                            RequestAttId = x.ReqAttId,
                            RequestAttName = x.ReqAttName,
                            AttractionStatus = x.ReqAttStatus
                        }).ToList();
            dataRequestAtt.ItemsSource = rslt;
        }

        private void btnSearchAtt_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqAttId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id)
                        select new
                        {
                            x.ReqAttName,
                            x.ReqAttDescription
                        }).ToList();
            foreach (var item in rslt)
            {
                lbNameAtt.Content = item.ReqAttName;
                lbDescAtt.Content = item.ReqAttDescription;
            }
        }

        private void btnAccAtt_Click(object sender, RoutedEventArgs e)
        {
            RequestAttractionHandler.accReqAtt(Int32.Parse(tbReqAttId.Text));
            MessageBox.Show("Accept Successfully");
        }

        private void btnNoAccAtt_Click(object sender, RoutedEventArgs e)
        {
            RequestAttractionHandler.decReqAtt(Int32.Parse(tbReqAttId.Text));
            MessageBox.Show("No Accept Successfully");
        }

        private void LoadLineChartData()
        {

        }

        private void dataWorkPerformance_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Employee
                        select new
                        {
                            EmployeeName = x.EmployeeName,
                            EmployeePerformance = x.EmployeePerformance
                        }).ToList();
            dataWorkPerformance.ItemsSource = rslt;
        }

        private void dataRestaurantTransactionView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RestaurantTransaction
                        select new
                        {
                            TransactionId = x.ResturantTransaction,
                            EmployeeName = x.Employee.EmployeeName,
                            TransactionDate = x.TransactionDate,
                            Amount = x.Payment
                        }).ToList();
            dataRestaurantTransactionView.ItemsSource = rslt;
        }

        private void dataHotelTransactionView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().HotelTransaction
                        select new
                        {
                            TransactionId = x.HotelTransactionId,
                            TransactionDate = x.HotelTransactionDate,
                            Amount = x.Payment
                        }).ToList();
            dataHotelTransactionView.ItemsSource = rslt;
        }
    }
}
