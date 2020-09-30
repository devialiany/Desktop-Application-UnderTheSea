using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class RideHandler
    {
        public static void addRide(int reqId)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == reqId).FirstOrDefault();
            Ride newRd = new Ride();
            newRd.RideName = rslt.ReqRideName;
            newRd.RideDescription = rslt.ReqRideDescription;
            newRd.RideHowToWork = rslt.ReqRideHowToWork;
            newRd.RideKind = rslt.ReqRideKind;
            newRd.RideSafetyInformation = rslt.ReqRideSafetyInformation;
            newRd.RideStatus = "Adding.. Prepare To Construction";
            DatabaseConnectionHandler.GetInstance().Ride.Add(newRd);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
        public static void updateRide(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().RequestRide.Where(x => x.ReqRideId == id).FirstOrDefault();
            Ride rd = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == rslt.RideId).FirstOrDefault();
            rd.RideName = rslt.ReqRideName;
            rd.RideDescription = rslt.ReqRideDescription;
            rd.RideHowToWork = rslt.ReqRideHowToWork;
            rd.RideKind = rslt.ReqRideKind;
            rd.RideSafetyInformation = rslt.ReqRideSafetyInformation;
            rd.RideStatus = "Updating.. Prepare To Construction";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void removeRide(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            rslt.RideStatus = "Removing.. Prepare To Construction";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void sendConstruction(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Ride.Where(x => x.RideId == id).FirstOrDefault();
            if (rslt.RideStatus.Contains("Add"))
            {
                rslt.RideStatus = "Adding.. Waiting for constructing";
            }else if(rslt.RideStatus.Contains("Upd"))
            {
                rslt.RideStatus = "Update.. Waiting for constructing";
            }else if (rslt.RideStatus.Contains("Rem"))
            {
                rslt.RideStatus = "Removing.. Waiting for constructing";
            }
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
