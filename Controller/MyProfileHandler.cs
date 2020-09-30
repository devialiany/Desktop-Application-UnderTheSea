using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class MyProfileHandler
    {
        public static string getEmployeeName(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            return rslt.EmployeeName;
        }

        public static string getEmployeeGender(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            return rslt.EmployeeGender;
        }

        public static DateTime getEmployeeDOB(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            return rslt.EmployeeDOB;
        }

        public static string getEmployeeRole(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            return rslt.EmployeeRole;
        }

        public static string getEmployeeDepartment(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Employee.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            return rslt.EmployeeDepartment.EmployeeDepartmentName;
        }
    }
}
