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

namespace UnderTheSea.Controller
{
    /// <summary>
    /// Interaction logic for HotelDepartment.xaml
    /// </summary>
    public partial class HotelDepartment : Window
    {
        public HotelDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void dataRoom_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().RoomHotel.ToList();
            dataRoom.ItemsSource = rslt;
        }
    }
}
