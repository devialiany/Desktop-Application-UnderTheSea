using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using UnderTheSea.View;

namespace UnderTheSea
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginHandler.CheckLogin(tbUsername.Text, tbPassword.Password);
            if(LoginHandler.login == 1)
            {
                this.Close();
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LoginHandler.login = 0;
        }
    }
}
