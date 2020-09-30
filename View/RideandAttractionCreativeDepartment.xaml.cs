using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for RideandAttarctionCreativeDepartment.xaml
    /// </summary>
    public partial class RideandAttarctionCreativeDepartment : Window
    {
        
        public RideandAttarctionCreativeDepartment()
        {   
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login w = new Login();
            w.Show();
            this.Close();
        }

        private void btnRequestAddRide_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.reqAddRide(tbNameRide.Text,tbDescRide.Text,tbHowWorkRide.Text, 
                cbKindRide.SelectionBoxItem.ToString(),tbSafetyRide.Text);
            MessageBox.Show("Request Adding Send To Manager");
        }

        private void btnRequestUpdateRide_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.reqUpdRide(Int16.Parse(tbRideId.Text),tbNameRide.Text, tbDescRide.Text, tbHowWorkRide.Text,
                cbKindRide.SelectionBoxItem.ToString(), tbSafetyRide.Text);
            MessageBox.Show("Request Update Send To Manager");
        }

        private void btnRequestRemoveRide_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.reqDelRide(Int16.Parse(tbRideId.Text), tbNameRide.Text, tbDescRide.Text, tbHowWorkRide.Text,
                cbKindRide.SelectionBoxItem.ToString(), tbSafetyRide.Text);
            MessageBox.Show("Request Removing Send To Manager");
        }

        private void dataRideForRequest_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Ride
                        select new
                        {
                            RideId = x.RideId,
                            RideName = x.RideName,
                            RideKind = x.RideKind,
                            RideStatus = x.RideStatus
                        }).ToList();
            dataRideForRequest.ItemsSource = rslt;
        }

        private void btnSearchRide_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbRideId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id)
                        select new
                        {
                            x.RideName, x.RideDescription, x.RideHowToWork,
                            x.RideKind, x.RideSafetyInformation
                        }).ToList();
            foreach (var item in rslt)
            {
                tbNameRide.Text = item.RideName;
                tbDescRide.Text = item.RideDescription;
                tbHowWorkRide.Text = item.RideHowToWork;
                tbSafetyRide.Text = item.RideSafetyInformation;
                cbKindRide.Text = item.RideKind;
            }
        }

        private void btnSearchAtt_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbAttId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == id)
                        select new
                        {
                            x.AttractionName,
                            x.AttractionDescription,
                            x.AttractionHowToWork,
                            x.AttractionWhoParticipant,
                            x.AttractionStartDateLaunch
                        }).ToList();
            foreach (var item in rslt)
            {
                tbNameAtt.Text = item.AttractionName;
                tbDescAtt.Text = item.AttractionDescription;
                tbHowWorkRAtt.Text = item.AttractionHowToWork;
                tbWhoPart.Text = item.AttractionWhoParticipant;
                dpDateLaunch.SelectedDate = item.AttractionStartDateLaunch;
            }
        }

        private void btnRequestAddAtt_Click(object sender, RoutedEventArgs e)
        {
            RequestAttractionHandler.reqAddAtt(Int16.Parse(tbAttId.Text), tbNameAtt.Text, tbDescAtt.Text, tbHowWorkRAtt.Text,
                tbWhoPart.Text, dpDateLaunch.SelectedDate.Value.Date);
            MessageBox.Show("Request Add Attraction Successfully");
        }

        private void btnRequestUpdateAtt_Click(object sender, RoutedEventArgs e)
        {
            RequestAttractionHandler.reqUpdAtt(Int16.Parse(tbAttId.Text), tbNameAtt.Text, tbDescAtt.Text, tbHowWorkRAtt.Text,
                tbWhoPart.Text, dpDateLaunch.SelectedDate.Value.Date);
            MessageBox.Show("Request Update Attraction Successfully");

        }

        private void btnRequestRemoveAtt_Click(object sender, RoutedEventArgs e)
        {
            RequestAttractionHandler.reqDelAtt(Int16.Parse(tbAttId.Text), tbNameAtt.Text, tbDescAtt.Text, tbHowWorkRAtt.Text,
                tbWhoPart.Text, dpDateLaunch.SelectedDate.Value.Date);
            MessageBox.Show("Request Removing Attraction Successfully");
        }

        private void dataAttractionForRequest_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().Attraction
                        select new
                        {
                            AttractionId = x.AttractionId,
                            AttractionName = x.AttractionName,
                            AttractionStatus = x.AttractionStatus
                        }).ToList();
            dataAttractionForRequest.ItemsSource = rslt;
        }

        private void dataRequestRide_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide
                        select new
                        {
                            RequestRideId = x.ReqRideId,
                            RequestRideName = x.ReqRideName,
                            AttractionStatus = x.ReqRideStatus
                        }).ToList();
            dataRequestRide.ItemsSource = rslt;
        }

        private void btnAddRideBase_Click(object sender, RoutedEventArgs e)
        {
            RideHandler.addRide(Int32.Parse(tbReqRideId.Text));
            MessageBox.Show("Add Ride Sucessfully");
        }

        private void btnUpdRideBase_Click(object sender, RoutedEventArgs e)
        {
            RideHandler.updateRide(Int32.Parse(tbReqRideId.Text));
            MessageBox.Show("Update Ride Successfully");
        }

        private void btnSearchReRide_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqRideId.Text);
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id)
                        select new
                        {
                            x.ReqRideName,
                            x.ReqRideDescription,
                            x.ReqRideHowToWork,
                            x.ReqRideSafetyInformation,
                            x.ReqRideKind
                        }).ToList();
            foreach (var item in rslt)
            {
                tbNameReRide.Text = item.ReqRideName;
                tbDescReRide.Text = item.ReqRideDescription;
                tbHowWorkReRide.Text = item.ReqRideHowToWork;
                tbSafetyReRide.Text = item.ReqRideSafetyInformation;
                cbKindReRide.Text = item.ReqRideKind;
            }
        }

        private void btnDelRideBase_Click(object sender, RoutedEventArgs e)
        {
            RideHandler.removeRide(Int32.Parse(tbReqRideId.Text));
            MessageBox.Show("remove Ride Successfully");
        }

        private void dataRequestAtt_Loaded(object sender, RoutedEventArgs e)
        {
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestAttraction
                        select new
                        {
                            RequestAttId = x.ReqAttId,
                            RequestAttName = x.ReqAttName,
                            AttractionStatus = x.ReqAttStatus
                        }).ToList();
            dataRequestAtt.ItemsSource = rslt;
        }

        private void btnSearchReAtt_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbReqAttId.Text);
            var rslt = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).FirstOrDefault();
            tbNameReAtt.Text = rslt.ReqAttName;
            tbDescReAtt.Text = rslt.ReqAttDescription;
            tbHowWorkReAtt.Text = rslt.ReqAttHowToWork;
            tbReWhoPart.Text = rslt.ReqAttWhoParticipant;
            dpReDateLaunch.SelectedDate = rslt.ReqAttStartDateLaunch;
        }

        private void btnAddAttBase_Click(object sender, RoutedEventArgs e)
        {
            AttractionHandler.addAtt(Int32.Parse(tbReqAttId.Text));
            MessageBox.Show("Add Attraction Sucessfully");
        }

        private void btnUpdAttBase_Click(object sender, RoutedEventArgs e)
        {
            AttractionHandler.updateAtt(Int32.Parse(tbReqAttId.Text));
            MessageBox.Show("Update Attraction Sucessfully");
        }

        private void btnDelAttBase_Click(object sender, RoutedEventArgs e)
        {
            AttractionHandler.removeAtt(Int32.Parse(tbReqAttId.Text));
            MessageBox.Show("Remove Attraction Sucessfully");
        }

        private void btnUpdateRequestRideData_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.updateRequestRide(Int16.Parse(tbReqRideId.Text), tbNameReRide.Text, tbDescReRide.Text, tbHowWorkReRide.Text,
                cbKindReRide.SelectionBoxItem.ToString(), tbSafetyReRide.Text);
            MessageBox.Show("Update Request Successfully");
        }

        private void btnCancelRequestRideData_Click(object sender, RoutedEventArgs e)
        {
            RequestRideHandler.cancelRequestRide(Int16.Parse(tbReqRideId.Text));
            MessageBox.Show("Cancel Request Successfully");
        }

        private void btnUpdateRequestAttData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelRequestAttData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSendConstruction_Click(object sender, RoutedEventArgs e)
        {
            RideHandler.sendConstruction(Int16.Parse(tbRideId.Text));
            MessageBox.Show("Request to Construction Successfully");
        }

        private void btnRequestPurchase_Click(object sender, RoutedEventArgs e)
        {
            RequestPurchaseHandler.insertReqPurchase(tbReqDet.Text, dpNeed.SelectedDate.Value.Date, tbTimeNeed.Text);
            MessageBox.Show("Purchase Requested");
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
