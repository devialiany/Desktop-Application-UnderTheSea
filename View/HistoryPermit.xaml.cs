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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnderTheSea.Controller;

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for HistoryPermit.xaml
    /// </summary>
    public partial class HistoryPermit : Page
    {
        public HistoryPermit()
        {
            InitializeComponent();
        }

        private void DataRequestPermitView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestPermit
                        select new
                        {
                            RequestPermitId = x.RequestPermitId,
                            StartDate = x.FromDate,
                            ToDate = x.ToDate,
                            CategoryPermit = x.Category,
                            Reason = x.ReasonPermit,
                            ResponStatus = x.PermitStatus
                        }).ToList();
            DataRequestPermitView.ItemsSource = rslt;
        }
    }
}
