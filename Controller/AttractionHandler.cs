using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class AttractionHandler
    {
        public static void addAtt(int reqId)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == reqId).FirstOrDefault();
            Attraction newRd = new Attraction();
            newRd.AttractionName = rslt.ReqAttName;
            newRd.AttractionDescription = rslt.ReqAttDescription;
            newRd.AttractionHowToWork = rslt.ReqAttHowToWork;
            newRd.AttractionStartDateLaunch= rslt.ReqAttStartDateLaunch;
            newRd.AttractionWhoParticipant = rslt.ReqAttWhoParticipant;
            newRd.AttractionStatus = "Active";
            DatabaseConnectionHandler.GetInstance().Attraction.Add(newRd);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateAtt(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().RequestAttraction.Where(x => x.ReqAttId == id).FirstOrDefault();
            Attraction rd = DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == rslt.AttractionId).FirstOrDefault();
            rd.AttractionName = rslt.ReqAttName;
            rd.AttractionDescription = rslt.ReqAttDescription;
            rd.AttractionHowToWork = rslt.ReqAttHowToWork;
            rd.AttractionStartDateLaunch = rslt.ReqAttStartDateLaunch;
            rd.AttractionWhoParticipant = rslt.ReqAttWhoParticipant;
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void removeAtt(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == id).FirstOrDefault();
            rslt.AttractionStatus = "Removing";
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
