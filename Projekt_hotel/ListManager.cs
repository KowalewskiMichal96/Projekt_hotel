using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{

    public class ListManager
    {
// wczytywanie rezerwacji
        public static List<Reservations> LoadSampleReservation()
        {
            databaseHotelDataContext contextDB = new databaseHotelDataContext();
            List<Reservations> outputres = new List<Reservations>();

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
                outputres.Add(new Reservations(item.Id, item.StartDate.ToShortDateString(), item.EndDate.ToShortDateString(), item.Total_price, item.LastName + " - " + item.FirstName, item.Worker_ID));
            }
            return outputres;
        }

// wczytywanie gosci
        public static List<Guests> LoadSampleGuests()
        {
            databaseHotelDataContext contextDB = new databaseHotelDataContext();
            List<Guests> outputguest = new List<Guests>();

            var query = (from guest in contextDB.Guest
                         select new
                         {
                             guest.LastName,
                             guest.FirstName,
                             guest.DateOfBirth
                         }).ToList();

            foreach (var item in query)
            {
                outputguest.Add(new Guests(item.LastName, item.FirstName, item.DateOfBirth.ToShortDateString()));
            }
            return outputguest;
        }

// wczytywanie platnikow
        public static List<Payers> LoadSamplePayers()
        {
            databaseHotelDataContext contextDB = new databaseHotelDataContext();
            List<Payers> outputpayer = new List<Payers>();

            var query = (from payer in contextDB.Payer
                         select new
                         {
                             payer.Name
                         }).ToList();

            foreach (var item in query)
            {
                outputpayer.Add(new Payers(item.Name));
            }
            return outputpayer;
        }

// wczytywanie wolnych pokoi
        public static List<Rooms> LoadSampleRooms(DateTime checkIn, DateTime CheckOut,int ResID)
        {
            databaseHotelDataContext contextDB = new databaseHotelDataContext();
            List<Rooms> outputrooms = new List<Rooms>();

            var query = (from room in contextDB.Room
                         select new { room.RoomNameUnique }).Except
                         (from s in contextDB.RoomReserved
                          join x in contextDB.Room
                          on s.Room_ID equals x.Id
                          where 
                          (
                          ((s.Reservation.StartDate >= checkIn && s.Reservation.StartDate < CheckOut)
                          ||
                          (s.Reservation.EndDate > checkIn && s.Reservation.EndDate < CheckOut)
                          ||
                          (s.Reservation.StartDate < checkIn && s.Reservation.EndDate > checkIn)
                          ) && (s.Reservation_ID != ResID)
                          )
                          orderby s.Room_ID
                          select new { s.Room.RoomNameUnique });

            foreach (var item in query)
            {
                outputrooms.Add(new Rooms(item.RoomNameUnique));
            }
            return outputrooms;
        }

        // newreservation //
        // nastepnie stworz edycje gosci oraz platnikow
        // usuwanie gosci i platnikow
        // edytowanie gosci i platnikow

        // dodawnie nowej rezerwacji

        // mainmenu//
        // wysylanie infomracji o edytowanej rezerwacji

        // newreservation//
        // edytowanie istniejacej rezerwacji

        // checkout nowy formularz
    }
}
