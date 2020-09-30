using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RequestPermitHandler
    {
        public static void insertPermitRequest(int id, DateTime fromDate, DateTime toDate, string category, string reason)
        {
            RequestPermit newRp = new RequestPermit();
            newRp.EmployeeId = id;
            newRp.FromDate = fromDate;
            newRp.ToDate = toDate;
            newRp.Category = category;
            newRp.ReasonPermit = reason;
            newRp.PermitStatus = "Pending";

            DatabaseConnectionHandler.GetInstance().RequestPermit.Add(newRp);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
