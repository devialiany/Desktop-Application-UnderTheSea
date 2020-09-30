using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RequestPurchaseHandler
    {
        public static void insertReqPurchase(string detil, DateTime needDate, string time)
        {
            RequestPurchase newRp = new RequestPurchase();
            newRp.EmployeeId = LoginHandler.idEmp;
            newRp.RequestPurchaseDetail = detil;
            newRp.RequestPurchaseDate = DateTime.Now;
            newRp.PurchaseTimeNeed = time;
            newRp.RequestPurchaseStatus = "Waiting Approval";
            
            DatabaseConnectionHandler.GetInstance().RequestPurchase.Add(newRp);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
