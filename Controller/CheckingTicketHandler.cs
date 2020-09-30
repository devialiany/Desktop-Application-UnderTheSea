using MessagingToolkit.QRCode.Codec;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace UnderTheSea.Controller
{
    class CheckingTicketHandler
    {
        static string date = DateTime.Now.ToString("yyyyMMdd");

        public static bool checkValidityTicket(string code)
        {
            if (code.Equals(date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
