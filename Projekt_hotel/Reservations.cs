using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{
    public class Reservations
    {
        public int id { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public decimal totalPrice { get; set; }
        public string lastName { get; set; }
        public int workerId { get; set; }

        public Reservations()
        {
            id = 0;
            startDate = "";
            endDate = "";
            totalPrice = 0;
            lastName = "";
            workerId = 0;
        }
        public Reservations(int ID, string STARTDATE, string ENDDATE, decimal TOTALPRICE, string LASTNAME, int WORKERID)
        {
            id = ID;
            startDate = STARTDATE;
            endDate = ENDDATE;
            totalPrice = TOTALPRICE;
            lastName = LASTNAME;
            workerId = WORKERID;
        }
    }
}
