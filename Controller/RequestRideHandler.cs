using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RequestRideHandler
    {
        public static void reqAddRide(string name, string desc, string htw, string kindR, string safety)
        {
            RequestRide newRr = new RequestRide();
            newRr.EmployeeId = LoginHandler.idEmp;
            newRr.ReqRideName = name;
            newRr.ReqRideDescription = desc;
            newRr.ReqRideHowToWork = htw;
            newRr.ReqRideKind = kindR;
            newRr.ReqRideSafetyInformation = safety;
            newRr.ReqRideStatus = "Adding.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestRide.Add(newRr);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void reqUpdRide(int id, string name, string desc, string htw, string kindR, string safety)
        {
            RequestRide newRr = new RequestRide();
            newRr.EmployeeId = LoginHandler.idEmp;
            newRr.RideId = id;
            newRr.ReqRideName = name;
            newRr.ReqRideDescription = desc;
            newRr.ReqRideHowToWork = htw;
            newRr.ReqRideKind = kindR;
            newRr.ReqRideSafetyInformation = safety;
            newRr.ReqRideStatus = "Updating.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestRide.Add(newRr);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void reqDelRide(int id, string name, string desc, string htw, string kindR, string safety)
        {
            RequestRide newRr = new RequestRide();
            newRr.EmployeeId = LoginHandler.idEmp;
            newRr.RideId = id;
            newRr.ReqRideName = name;
            newRr.ReqRideDescription = desc;
            newRr.ReqRideHowToWork = htw;
            newRr.ReqRideKind = kindR;
            newRr.ReqRideSafetyInformation = safety;
            newRr.ReqRideStatus = "Removing.. Waiting Approvement";

            DatabaseConnectionHandler.GetInstance().RequestRide.Add(newRr);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void accReqRide(int id)
        {
            string oldStatus = "";
            string newStatus = "";
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide
                        select new
                        {
                           RideStatus = x.ReqRideStatus
                        }).ToList();
            foreach(var i in rslt)
            {
                oldStatus = i.RideStatus;
            }
            if(oldStatus.Equals("Adding.. Waiting Approvement"))
            {
                newStatus = "Adding.. Accept";
            }
            else if(oldStatus.Equals("Updating.. Waiting Approvement"))
            {
                newStatus = "Updating.. Accept";
            }
            else if(oldStatus.Equals("Removing.. Waiting Approvement"))
            {
                newStatus = "Removing.. Accept";
            }
            var upd = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id).ToList();
            upd.ForEach(x => x.ReqRideStatus = newStatus);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void decReqRide(int id)
        {
            string oldStatus = "";
            string newStatus = "";
            var rslt = (from x in DatabaseConnectionHandler.GetInstance().RequestRide
                        select new
                        {
                            AttractionStatus = x.ReqRideStatus
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
            var upd = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id).ToList();
            upd.ForEach(x => x.ReqRideStatus = newStatus);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateRequestRide(int id, string name, string desc, string htw, string kindR, string safety)
        {
            RequestRide rrd = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id).FirstOrDefault();
            rrd.ReqRideName = name;
            rrd.ReqRideDescription = desc;
            rrd.ReqRideHowToWork = htw;
            rrd.ReqRideKind = kindR;
            rrd.ReqRideSafetyInformation = safety;
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void cancelRequestRide(int id)
        {
            RequestRide rrd = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id).FirstOrDefault();
            rrd.ReqRideStatus = "Cancel";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
