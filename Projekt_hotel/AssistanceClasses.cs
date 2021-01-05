using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{
    public class Reservations
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string LastName { get; set; }
        public int WorkerId { get; set; }

        /*
        public Reservations()
        {
            id = 0;
            startDate = "";
            endDate = "";
            totalPrice = 0;
            lastName = "";
            workerId = 0;
        }
        */

        public Reservations(int ID, string STARTDATE, string ENDDATE, decimal TOTALPRICE, string LASTNAME, int WORKERID)
        {
            Id = ID;
            StartDate = STARTDATE;
            EndDate = ENDDATE;
            TotalPrice = TOTALPRICE;
            LastName = LASTNAME;
            WorkerId = WORKERID;
        }
    }

    public class Guests
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDay { get; set; }

        public Guests(string LASTNAME, string FIRSTNAME, string BIRTHDAY)
        {
            LastName = LASTNAME;
            FirstName = FIRSTNAME;
            BirthDay = BIRTHDAY;
        }
    }

    public class Payers
    {
        public string LastName { get; set; }

        public Payers(string LASTNAME)
        {
            LastName = LASTNAME;
        }
    }

    public class Rooms
    {
        public string RoomName { get; set; }

        public Rooms(string ROOMNAME)
        {
            RoomName = ROOMNAME;
        }
    }
}
