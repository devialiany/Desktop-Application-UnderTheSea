using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RequestFundHandler
    {
        public static void insertReqFund(string detil, int amount)
        {
            RequestFund newRp = new RequestFund();
            newRp.EmployeeId = LoginHandler.idEmp;
            newRp.RequestFundDetail = detil;
            newRp.RequestFundDate = DateTime.Now;
            newRp.PredictedAmount = amount;
            newRp.RequestFundStatus = "Waiting Approval";

            DatabaseConnectionHandler.GetInstance().RequestFund.Add(newRp);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
