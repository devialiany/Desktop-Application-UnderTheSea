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
    /// Interaction logic for SalesAndMarketingDepartment.xaml
    /// </summary>
    public partial class SalesAndMarketingDepartment : Window
    {
        public object DatabaseConnectionController { get; private set; }

        public SalesAndMarketingDepartment()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void dataAdvertisement_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Advertisement
                        select new
                        {
                            AdsId = x.AdvertisementId,
                            AdsName = x.AdvertisementName,
                            AdsStatus = x.AdvertisementStatus
                        }).ToList();
            dataAdvertisement.ItemsSource = rslt;
        }

        private void btnSearchAAds_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbAdsId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().Advertisement.Where(x => x.AdvertisementId == id).FirstOrDefault();
            tbNameAds.Text = rslt.AdvertisementName;
            tbDetailAds.Text = rslt.AdvertisementDetail;
        }

        private void btnAddAds_Click(object sender, RoutedEventArgs e)
        {
            AdvertisementHandler.addAdds(tbNameAds.Text, tbDetailAds.Text);
            MessageBox.Show("Added Ads");
        }

        private void btnUpdAds_Click(object sender, RoutedEventArgs e)
        {
            AdvertisementHandler.updAds(Int32.Parse(tbAdsId.Text), tbNameAds.Text, tbDetailAds.Text);
            MessageBox.Show("Updated Ads");
        }

        private void btnDelAds_Click(object sender, RoutedEventArgs e)
        {
            AdvertisementHandler.delAds(Int32.Parse(tbAdsId.Text));
            MessageBox.Show("Deleted Ads");
        }

        private void dataRequestPurchase_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestPurchase.Where(x => x.EmployeeId == LoginHandler.idEmp)
                        select new
                        {
                            RequestPurchaseId = x.RequestPurchaseId,
                            RequestDate = x.RequestPurchaseDate,
                            RequestStatus = x.RequestPurchaseStatus
                        }).ToList();
            dataRequestPurchase.ItemsSource = rslt;
        }

        private void btnPurId_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbPurId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestPurchase.Where(x => x.RequestPurchaseId == id).FirstOrDefault();
            tbReqDet.Text = rslt.RequestPurchaseDetail;
            dpNeed.SelectedDate = rslt.RequestDateNeed;
        }

        private void btnRequestPurchase_Click(object sender, RoutedEventArgs e)
        {
            RequestPurchaseHandler.insertReqPurchase(tbReqDet.Text, dpNeed.SelectedDate.Value.Date, tbTimeNeed.Text);
            MessageBox.Show("Purchase Requested");
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

        private void RequestFund_Click(object sender, RoutedEventArgs e)
        {
            RequestFundHandler.insertReqFund(tbFundDet.Text, Int32.Parse(tbFundAmount.Text));
            MessageBox.Show("Funding Requested");
        }

        private void btnSearchFundId_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbFundId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestFund.Where(x => x.RequestFundId == id).FirstOrDefault();
            tbFundDet.Text = rslt.RequestFundDetail;
            tbFundAmount.Text = rslt.PredictedAmount.ToString();
            tbReasonNoAcc.Text = rslt.RequestReason;
        }
    }
}
