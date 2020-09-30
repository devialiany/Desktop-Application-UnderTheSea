using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RequestAttractionHandler
    {
        public static void reqAddAtt(int id, string name, string desc, string htw, string wp, DateTime launchDate)
        {
            RequestAttraction newRa = new RequestAttraction();
            newRa.EmployeeId = LoginHandler.idEmp;
            newRa.ReqAttName = name;
            newRa.ReqAttDescription = desc;
            newRa.ReqAttHowToWork = htw;
            newRa.ReqAttWhoParticipant = wp;
            newRa.ReqAttStartDateLaunch = launchDate;
            newRa.ReqAttStatus = "Adding.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestAttraction.Add(newRa);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void reqUpdAtt(int id, string name, string desc, string htw, string wp, DateTime launchDate)
        {
            RequestAttraction newRa = new RequestAttraction();
            newRa.EmployeeId = LoginHandler.idEmp;
            newRa.ReqAttName = name;
            newRa.ReqAttDescription = desc;
            newRa.ReqAttHowToWork = htw;
            newRa.ReqAttWhoParticipant = wp;
            newRa.ReqAttStartDateLaunch = launchDate;
            newRa.ReqAttStatus = "Updating.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestAttraction.Add(newRa);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void reqDelAtt(int id, string name, string desc, string htw, string wp, DateTime launchDate)
        {
            RequestAttraction newRa = new RequestAttraction();
            newRa.EmployeeId = LoginHandler.idEmp;
            newRa.ReqAttName = name;
            newRa.ReqAttDescription = desc;
            newRa.ReqAttHowToWork = htw;
            newRa.ReqAttWhoParticipant = wp;
            newRa.ReqAttStartDateLaunch = launchDate;
            newRa.ReqAttStatus = "Removing.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestAttraction.Add(newRa);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void accReqAtt(int id)
        {
            string oldStatus = "";
            string newStatus = "";
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestAttraction
                        select new
                        {
                            AttStatus = x.ReqAttStatus
                        }).ToList();
            foreach (var i in rslt)
            {
                oldStatus = i.AttStatus;
            }
            if (oldStatus.Equals("Adding.. Waiting Approvement"))
            {
                newStatus = "Adding.. Accept";
            }
            else if (oldStatus.Equals("Updating.. Waiting Approvement"))
            {
                newStatus = "Updating.. Accept";
            }
            else if (oldStatus.Equals("Removing.. Waiting Approvement"))
            {
                newStatus = "Removing.. Accept";
            }
            var upd = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).ToList();
            upd.ForEach(x => x.ReqAttStatus = newStatus);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void decReqAtt(int id)
        {
            string oldStatus = "";
            string newStatus = "";
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestAttraction
                        select new
                        {
                            AttractionStatus = x.ReqAttStatus
                        }).ToList();
            foreach (var i in rslt)
            {
                oldStatus = i.AttractionStatus;
            }
            if (oldStatus.Equals("Adding.. Waiting Approvement"))
            {
                newStatus = "Adding.. Decline";
            }
            else if (oldStatus.Equals("Updating.. Waiting Approvement"))
            {
                newStatus = "Updating.. Decline";
            }
            else if (oldStatus.Equals("Removing.. Waiting Approvement"))
            {
                newStatus = "Removing.. Decline";
            }
            var upd = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).ToList();
            upd.ForEach(x => x.ReqAttStatus = newStatus);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateRequestAtt(int id, string name, string desc, string htw, string wp, DateTime launchDate)
        {
            RequestAttraction rrd = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).FirstOrDefault();
            rrd.ReqAttName = name;
            rrd.ReqAttDescription = desc;
            rrd.ReqAttHowToWork = htw;
            rrd.ReqAttWhoParticipant = wp;
            rrd.ReqAttStartDateLaunch = launchDate;
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void cancelRequestAtt(int id)
        {
            RequestAttraction rrd = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).FirstOrDefault();
            rrd.ReqAttStatus = "Cancel";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
