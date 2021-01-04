using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{

    public class ListManager
    {
        public static List<Reservations> LoadSampleData()
        {
            databaseHotelDataContext contextDB = new databaseHotelDataContext();
            List<Reservations> output = new List<Reservations>();

            var query = (from res in contextDB.Reservation
                         select new
                         {
                             res.Id,
                             res.StartDate,
                             res.EndDate,
                             res.Total_price,
                             res.Guest.LastName,
                             res.Guest.FirstName,
                             res.Worker_ID
                         }).ToList();

            foreach (var item in query)
            {
                output.Add(new Reservations(item.Id, item.StartDate.ToShortDateString(), item.EndDate.ToShortDateString(), item.Total_price, item.LastName + " - " + item.FirstName, item.Worker_ID));
            }
            return output;
        }
    }
}
