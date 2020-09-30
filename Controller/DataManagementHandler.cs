using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class DataManagementHandler
    {
        public static int getQtyTicketSoldAll()
        {
            int rslt = (from x in DatabaseConnectionHandler.GetInstance().TicketTransaction.Where(x=>x.TicketTransactionStatus == "Success")
                        select new
                        {
                            TicketQuantity = x.TicketQuantity
                        }).ToList().Sum(x => x.TicketQuantity);
            return rslt;
        }

        public static int getQtyTicketSoldToday()
        {
            int rslt = (from x in DatabaseConnectionHandler.GetInstance().TicketTransaction.Where(x => x.TicketTransactionDate == DateTime.Today)
                        select new
                        {
                            TicketQuantity = x.TicketQuantity
                        }).ToList().Sum(x => x.TicketQuantity);
            return rslt;
        }


        public static void showBarVisualization()
        {

        }
    }
}
