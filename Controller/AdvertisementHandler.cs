using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Model;

namespace UnderTheSea.Controller
{
    class AdvertisementHandler
    {
        public static void addAdds(string name, string detail)
        {
            Advertisement newAd = new Advertisement();
            newAd.EmployeeId = LoginHandler.idEmp;
            newAd.AdvertisementName = name;
            newAd.AdvertisementDetail = detail;
            
            DatabaseConnectionHandler.GetInstance().Advertisement.Add(newAd);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updAds(int id, string name, string detail)
        {
            Advertisement ad = DatabaseConnectionHandler.GetInstance().Advertisement.Where(x => x.AdvertisementId == id).FirstOrDefault();
            ad.AdvertisementName = name;
            ad.AdvertisementDetail = detail;

            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void delAds(int id)
        {
            Advertisement ad = DatabaseConnectionHandler.GetInstance().Advertisement.Where(x => x.AdvertisementId == id).FirstOrDefault();
            ad.AdvertisementStatus = "Deleted";

            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }
    }
}
