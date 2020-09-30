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
    /// Interaction logic for MaintenanceDepartment.xaml
    /// </summary>
    public partial class MaintenanceDepartment : Window
    {
        public MaintenanceDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void dataAttraction_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Attraction
                        select new
                        {
                            AttractionId = x.AttractionId,
                            AtractionName = x.AttractionName,
                            AttractionStatus = x.AttractionStatus
                        }).ToList();
            dataAttraction.ItemsSource = rslt;
        }

        private void btnSearchAtt_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbAttId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == id)
                        select new
                        {
                            x.AttractionName
                        }).ToList();
            foreach (var item in rslt)
            {
                lbNameAtt.Content = item.AttractionName;
            }
        }

        private void btnCreateScheduleAttMtn_Click(object sender, RoutedEventArgs e)
        {
            MainteanceScheduleHandler.createScheduleMaintenanceAtt(Int32.Parse(tbAttId.Text), lbNameAtt.Content.ToString(), dateMtn.SelectedDate.Value.Date, tbStartTime.Text,tbEndTime.Text,tbNote.Text);
            btnCreateScheduleAttMtn.IsEnabled = false;
            MessageBox.Show("Schedule Created!");
        }

        private void DataScheduleMtn_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().MaintenanceSchedule
                        select new
                        {
                            MaintenanceId = x.MaintenanceScheduleId,
                            AttractionId = x.AttractionId,
                            AttractionName = x.AttractionName,
                            Date = x.MaintenanceDate,
                            StartTime =x.MaintenaceStartTime,
                            EndTime = x.MaintenanceEndTime
                        }).ToList();
            DataScheduleMtn.ItemsSource = rslt;
        }

        private void btnStartMaitenance_Click(object sender, RoutedEventArgs e)
        {
            MainteanceScheduleHandler.updateStatusStartMtn(Int32.Parse(tbScAttId.Text));
            btnStartMaitenance.IsEnabled = false;
            MessageBox.Show("Maintenance Start");
        }

        private void btnEndMaintenance_Click(object sender, RoutedEventArgs e)
        {
            MainteanceScheduleHandler.updateStatusEndMtn(Int32.Parse(tbScAttId.Text));
            btnEndMaintenance.IsEnabled = false;
            MessageBox.Show("Maintenance End");
        }
    }
}
