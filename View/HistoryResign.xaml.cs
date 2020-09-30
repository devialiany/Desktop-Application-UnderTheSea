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
    /// Interaction logic for HistoryResign.xaml
    /// </summary>
    public partial class HistoryResign : Page
    {
        public HistoryResign()
        {
            InitializeComponent();
        }

        private void DataRequestResignView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestResign
                        select new
                        {
                            ApplyDate = x.AssignDate,
                            ResignReason = x.ResignReason,
                            ResponStatus = x.ResignStatus
                        }).ToList();
            DataRequestResignView.ItemsSource = rslt;
        }
    }
}
