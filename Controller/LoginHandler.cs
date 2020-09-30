using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UnderTheSea.Model;
using UnderTheSea.View;

namespace UnderTheSea.Controller
{
    class LoginHandler
    {
        public static int login = 0;

        public static int idEmp;

        public static void CheckLogin(String username, String password)
        {
            Employee emp = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeUsername.Equals(username) && x.EmployeePassword.Equals(password)).ToList().FirstOrDefault();
            
            if (emp == null)
            {
                MessageBox.Show("Invalid Username and Password");
            }
            else
            {
                idEmp = emp.EmployeeId;
                if(emp.EmployeeDepartmentId == 1)
                {
                    ManagementDepartment md = new ManagementDepartment();
                    md.Show();
                    login = 1;
                }else if(emp.EmployeeDepartmentId == 2)
                {
                    AttractionDepartment ad = new AttractionDepartment();
                    if (emp.EmployeeRole.Equals("Selling Ticket"))
                    {
                        ad.viewSellingEmployee();
                        ad.Show();
                        login = 1;
                    }
                    else
                    {
                        ad.viewEntranceGateEmployee();
                        ad.Show();
                        login = 1;
                    }
                }else if(emp.EmployeeDepartmentId == 3)
                {
                    MaintenanceDepartment md = new MaintenanceDepartment();
                    md.Show();
                    login = 1;
                }else if(emp.EmployeeDepartmentId == 4)
                {
                    RideandAttarctionCreativeDepartment rad = new RideandAttarctionCreativeDepartment();
                    rad.Show();
                    login = 1;
                }else if(emp.EmployeeDepartmentId == 5)
                {
                    ConstructionDepartment cd = new ConstructionDepartment();
                    cd.Show();
                    login = 1;
                }else if(emp.EmployeeDepartmentId == 6)
                {
                    RestaurantDepartment rd = new RestaurantDepartment();
                    if (emp.EmployeeRole.Equals("Waiter"))
                    {
                        rd.Show();
                        login = 1;
                    }
                    else
                    {
                        rd.Show();
                        login = 1;
                    }
                }
                else if (emp.EmployeeDepartmentId == 7)
                {
                    PurchaseDepartment pd = new PurchaseDepartment();
                    pd.Show();
                    login = 1;
                }
                else if (emp.EmployeeDepartmentId == 8)
                {
                    FundDepartment fd = new FundDepartment();
                    fd.Show();
                    login = 1;
                }
                else if (emp.EmployeeDepartmentId == 9)
                {
                    HotelDepartment hd = new HotelDepartment();
                    hd.Show();
                    login = 1;
                }
                else if (emp.EmployeeDepartmentId == 10)
                {
                    SalesAndMarketingDepartment smd = new SalesAndMarketingDepartment();
                    smd.Show();
                    login = 1;
                }
                else if (emp.EmployeeDepartmentId == 11)
                {
                    HumanResourceDepartment hrd = new HumanResourceDepartment();
                    hrd.Show();
                    login = 1;
                }
            }

        }

        
    }
}
