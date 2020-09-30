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
using UnderTheSea.Model;

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for ConstructionDepartment.xaml
    /// </summary>
    public partial class ConstructionDepartment : Window
    {
        public ConstructionDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void btnStartCons_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqRideId.Text);
            Ride rd = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            if (rd.RideStatus.Contains("Add"))
            {
                rd.RideStatus = "Adding.. In Progress of Constructing";
            }else if (rd.RideStatus.Contains("Upd"))
            {
                rd.RideStatus = "Updating.. In Progress of Constructing";
            }else if (rd.RideStatus.Contains("Rem"))
            {
                rd.RideStatus = "Removing.. In Progress of Constructing";
            }
            DatabaseConnectionHandler.GetInstance().SaveChanges();
            MessageBox.Show("Start Construction");
        }

        private void dataConsRide_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideStatus.Contains("wait") || x.RideStatus.Contains("progress"))
                        select new
                        {
                            RideId = x.RideId,
                            RideName = x.RideName,
                            RideKind = x.RideKind,
                            RideStatus = x.RideStatus
                        }).ToList();
            dataConsRide.ItemsSource = rslt;
        }

        private void btnSearchRide_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqRideId.Text);
            Ride rd = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            tbNameReRide.Text = rd.RideName;
        }

        private void btnfinishCons_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqRideId.Text);
            Ride rd = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            if (rd.RideStatus.Contains("Add"))
            {
                rd.RideStatus = "Active";
            }
            else if (rd.RideStatus.Contains("Upd"))
            {
                rd.RideStatus = "Active";
            }
            else if (rd.RideStatus.Contains("Rem"))
            {
                rd.RideStatus = "Remove";
            }
            DatabaseConnectionHandler.GetInstance().SaveChanges();
            MessageBox.Show("Finish Construction");
        }

        private void btnLookRide_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbRideId.Text);
            Ride rd = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            tbNameRide.Text = rd.RideName;
            tbDescRide.Text = rd.RideDescription;
            tbHowWorkRide.Text = rd.RideHowToWork;
            tbSafetyRide.Text = rd.RideSafetyInformation;
            cbKindRide.Text = rd.RideKind;
        }

        private void dataRide_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Ride
                        select new
                        {
                            RideId = x.RideId,
                            RideName = x.RideName,
                            RideKind = x.RideKind,
                            RideStatus = x.RideStatus
                        }).ToList();
            dataRide.ItemsSource = rslt;
        }
    }
}
