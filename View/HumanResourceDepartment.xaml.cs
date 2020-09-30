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
    /// Interaction logic for HumanResourceDepartment.xaml
    /// </summary>
    public partial class HumanResourceDepartment : Window
    {
        public HumanResourceDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void DataEmployeeView_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Employee
                        select new
                        {
                            Employee_Id = x.EmployeeId,
                            Employee_Name = x.EmployeeName,
                            Employee_Gender = x.EmployeeGender,
                            Employee_DOB = x.EmployeeDOB,
                            Employee_Role = x.EmployeeRole,
                            Employee_Department = x.EmployeeDepartment.EmployeeDepartmentName
                        }).ToList();
            DataEmployeeView.ItemsSource = rslt;
        }

        private void btnSearchRide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAccPermit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataRequestPermit_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestPermit
                        select new
                        {
                            RequestPermitId = x.RequestPermitId,
                            RequestPermitStatus =x.PermitStatus
                        }).ToList();
            dataRequestPermit.ItemsSource = rslt;
        }

        private void btnSearchPermit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNoAccPermit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNoAccPermit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnAccPermit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnFundId_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbFundId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestFund.Where(x => x.RequestFundId == id).FirstOrDefault();
            tbFundDet.Text = rslt.RequestFundDetail;
            tbFundAmount.Text = rslt.PredictedAmount.ToString();
            tbReasonNoAcc.Text = rslt.RequestReason;
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
    }
}
