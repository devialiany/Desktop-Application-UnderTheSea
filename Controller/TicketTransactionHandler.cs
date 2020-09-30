using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using UnderTheSea.Model;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using System.Drawing.Imaging;

namespace UnderTheSea.Controller
{
    class TicketTransactionHandler
    {
        public static int getTransactionId()
        {
            TicketTransaction tct = DatabaseConnectionHandler.GetInstance().TicketTransaction.ToArray().LastOrDefault();

            return tct.TicketTransactionId;
        }

        public static void insertRecordTicketTransaction(int empId, DateTime date, int qty)
        {
            TicketTransaction newTct = new TicketTransaction();
            newTct.EmployeeId = empId;
            newTct.TicketTransactionDate = date;
            newTct.TicketQuantity = qty;
            newTct.TicketTransactionStatus = "Pending";

            DatabaseConnectionHandler.GetInstance().TicketTransaction.Add(newTct);
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void updateQty(int qty, int id)
        {
             
        }

        public static void updateStatus(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().TicketTransaction.Where(x => x.TicketTransactionId == id).ToList();
            rslt.ForEach(x => x.TicketTransactionStatus = "Success");
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        public static void deleteTransaction(int id)
        {
            var rslt = DatabaseConnectionHandler.GetInstance().TicketTransaction.Where(x => x.TicketTransactionId == id).ToList();
            rslt.ForEach(x => x.TicketTransactionStatus = "Cancel");
            DatabaseConnectionHandler.GetInstance().SaveChanges();
        }

        //=========================================================================================
        //QR CODE GENERATOR
        //=========================================================================================

        static QRCodeEncoder encoder = new QRCodeEncoder();
        static Bitmap bitmap;
        static SaveFileDialog sfd = new SaveFileDialog();
        static string ticketId;

        public static void createQR()
        {
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(ticketId);
        }

        public static void saveQR()
        {
            sfd.Filter = "PNG|*.png";
            sfd.FileName = ticketId;
            if (sfd.ShowDialog() == true)
            {
                if (bitmap != null)
                {
                    bitmap.Save(string.Concat(sfd.FileName), ImageFormat.Png);
                    insertTicket();
                }
            }
        }

        public static string generateTicketId()
        {
            Ticket tc = DatabaseConnectionHandler.GetInstance().Ticket.ToArray().LastOrDefault();
            ticketId = tc.TicketId.Substring(8);
            string id = "" + (Int32.Parse(ticketId) + 1);
            string nol = "";
            if (id.Length == 1)
            {
                nol = "00";
            }
            else if (id.Length == 2)
            {
                nol = "0";
            }
            else if (id.Length == 3)
            {
                nol = "";
            }
            ticketId = DateTime.Now.ToString("yyyyMMdd") + nol + id;
            return ticketId;
        }

        public static void insertTicket()
        {
            Ticket newTc = new Ticket();
            newTc.TicketId = ticketId;

            DatabaseConnectionHandler.GetInstance().Ticket.Add(newTc);
            DatabaseConnectionHandler.GetInstance().SaveChanges();

        }

        public static void printTicket()
        {
            TicketTransaction tct = DatabaseConnectionHandler.GetInstance().TicketTransaction.ToArray().LastOrDefault();
            int qty = tct.TicketQuantity;
            for(int i = 0; i < qty; i++)
            {
                ticketId = generateTicketId();
                createQR();
                saveQR();
            }
        }
    }
}
