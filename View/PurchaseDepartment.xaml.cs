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
    /// Interaction logic for PurchaseDepartment.xaml
    /// </summary>
    public partial class PurchaseDepartment : Window
    {
        public PurchaseDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void dataReqPur_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestPurchase
                        select new
                        {
                            ReqId = x.RequestPurchaseId,
                            DateNeed = x.RequestDateNeed,
                            TimeNeed =x.PurchaseTimeNeed,
                            Detail =x.RequestPurchaseDetail
                        }).ToList();
            dataReqPur.ItemsSource = rslt;
        }

        private void RequestFund_Click(object sender, RoutedEventArgs e)
        {
            RequestFundHandler.insertReqFund(tbFundDet.Text, Int32.Parse(tbFundAmount.Text));
            MessageBox.Show("Funding Requested");
        }

        private void dataRequestFund_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestFund.Where(x => x.EmployeeId == LoginHandler.idEmp)
                        select new
                        {
                            RequestPurchaseId = x.RequestFundId,
                            RequestDate = x.RequestFundDate,
                            RequestStatus = x.RequestFundStatus
                        }).ToList();
            dataRequestFund.ItemsSource = rslt;
        }

        private void btnFundId_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbFundId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestFund.Where(x => x.RequestFundId == id).FirstOrDefault();
            tbFundDet.Text = rslt.RequestFundDetail;
            tbFundAmount.Text = rslt.PredictedAmount.ToString();
            tbReasonNoAcc.Text = rslt.RequestReason;
        }
    }
}
