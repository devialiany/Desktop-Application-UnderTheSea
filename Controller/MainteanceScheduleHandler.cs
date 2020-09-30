using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class MainteanceScheduleHandler
    {
        public static void createScheduleMaintenanceAtt(int id, string name, DateTime date, string timeStart, string timeEnd, string note)
        {
            MaintenanceSchedule newMs = new MaintenanceSchedule();
            newMs.AttractionId = id;
            newMs.AttractionName = name;
            newMs.MaintenanceDate = date;
            newMs.MaintenanceNote = note;
            newMs.MaintenaceStartTime = timeStart;
            newMs.MaintenanceEndTime = timeEnd;

            DatabaseConnectionHandler.GetInstance().MaintenanceSchedule.Add(newMs);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateStatusStartMtn(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == id).ToList();
            rslt.ForEach(x => x.AttractionStatus = "Maintenance");
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateStatusEndMtn(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().Attraction.Where(x => x.AttractionId == id).ToList();
            rslt.ForEach(x => x.AttractionStatus = "Active");
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
