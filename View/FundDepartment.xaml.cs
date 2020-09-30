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
    /// Interaction logic for FundDepartment.xaml
    /// </summary>
    public partial class FundDepartment : Window
    {
        public FundDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void dataRequestFund_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestFund.Where(x => x.RequestFundStatus.Contains("Wait"))
                        select new
                        {
                            requestFundID = x.RequestFundId,
                            reqDate= x.RequestFundDate,
                            reqStatus = x.RequestFundStatus
                        }).ToList();
            dataRequestFund.ItemsSource = rslt;
        }
    }
}
