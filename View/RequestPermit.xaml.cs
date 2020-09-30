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
    /// Interaction logic for RequestPermit.xaml
    /// </summary>
    public partial class RequestPermit : Page
    {
        public RequestPermit()
        {
            InitializeComponent();
        }

        private void sendPermitToManager_Click(object sender, RoutedEventArgs e)
        {
            RequestPermitHandler.insertPermitRequest(LoginHandler.idEmp, from.SelectedDate.Value.Date, to.SelectedDate.Value.Date, cbCategoryPermit.SelectionBoxItem.ToString(), reasonDesc.Text);
            MessageBox.Show("Wait Confirmation from manager!");
            sendPermitToManager.IsEnabled = false;
        }
    }
}
