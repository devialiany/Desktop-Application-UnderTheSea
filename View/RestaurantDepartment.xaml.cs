using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Interaction logic for RestaurantDepartment.xaml
    /// </summary>
    public partial class RestaurantDepartment : Window
    {
        public RestaurantDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
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

        private void tbQrCode_TextChanged(object sender, TextChangedEventArgs e)
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

        private void dataListTable_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().NumberTable.ToList();
            dataListTable.ItemsSource = rslt;
        }
    }
}
