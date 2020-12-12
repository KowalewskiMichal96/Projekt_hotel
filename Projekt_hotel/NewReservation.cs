using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_hotel
{

    public partial class NewReservation : Form
    {
        databaseHotelDataContext contextDB = new databaseHotelDataContext();
        List<SelectedRoom> roomsReserved = new List<SelectedRoom>();
        

        public NewReservation()
        {

            InitializeComponent();
            LoadForm();



        }

        private void LoadForm()
        {
            
            // Płatnik
            foreach (Payer x in contextDB.Payer)
            {
                PayerListBox.Items.Add(x);
            }

            // Goscie
            foreach (Guest x in contextDB.Guest)
            {
                GuestListBox.Items.Add(x);
            }


            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);

            //RoomToRight.Enabled = false;
        }

     // ile osob w pokoju
     //
     // public void GetCapacity(string type)
     // {
     //     RoomCapacityCombobox.Items.Clear();
     //     int asn = (from a in contextDB.RoomType
     //                where a.RoomName == type
     //                select a).Single().Capacity;
     //
     //     for (int i = 1; i <= asn; i++)
     //         RoomCapacityCombobox.Items.Add(i);
     //     RoomCapacityCombobox.SelectedIndex = 0;
     //
     //     //contextDB.RoomType.Single(a => a.RoomName == type).Capacity;
     // }



        // glowne przyciski
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        ////////////////////////////////////dodawanie tylko unikalnych pokoi bez powtorzen//////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomListBox.SelectedItems.Count == 1)
            {
                LoadRoom();
                labelSameRoom.Visible = false;
                RoomToRight.Enabled = true;
                //textBox1.Text = "aktualnie wybrany element " + RoomListBox.SelectedItem.ToString();

                // pokaz pokoj wybrany i jego opis
                // po lewej stronie
                

            }
            else if (RoomListBox.SelectedItems.Count == 0)
            {
                RoomToRight.Enabled = false;
            }
        }

        private void RoomToRight_Click(object sender, EventArgs e)
        {
            bool czyistnieje = false;
            //int licznik1 = 1;
            //int licznik2 = 1;
            //int licznik3 = 1;
            // czy wybrany jeden element

            if (RoomListBox.SelectedItems.Count == 1)
            {
                if (RoomSelectedListBox.Items.Count == 0)
                {
                    SelectedRoom newRoom = new SelectedRoom();

                    newRoom.Name = RoomListBox.SelectedItem.ToString();
                    roomsReserved.Add(newRoom);
                    RoomSelectedListBox.Items.Add(newRoom.Name);

                }



                else if (RoomSelectedListBox.Items.Count > 0)
                {
                    foreach (string listboxitem in RoomSelectedListBox.Items)
                    {
                        if (listboxitem == RoomListBox.SelectedItem.ToString())
                        {
                            czyistnieje = true;
                            labelSameRoom.Visible = true;
                            break;
                        }
                    }

                    if (czyistnieje == false)
                    {
                        SelectedRoom newRoom = new SelectedRoom();

                        newRoom.Name = RoomListBox.SelectedItem.ToString();
                        roomsReserved.Add(newRoom);
                        RoomSelectedListBox.Items.Add(newRoom.Name);
                    }
                    else if (czyistnieje == true)
                    {
                        // w sumie niepotrzebne na poczatku funkcji jest zmienna false
                        czyistnieje = false;
                    }
                }



            }
        }

        private void RoomToLeft_Click(object sender, EventArgs e)
        {
            if (RoomSelectedListBox.SelectedItems.Count == 1)
            {
                RoomSelectedListBox.Items.RemoveAt(RoomSelectedListBox.SelectedIndex);
                GuestSelectedListBox.Items.Clear();
            }
        }


        private void RoomListBox_Leave(object sender, EventArgs e)
        {
            // aby stracic focus na listboxie nr 1 ale po kliknieciu przycisku wyslac dane
            if (RoomToRight.Focused == true)
                RoomToRight_Click(sender, e);
            RoomListBox.SelectedIndex = -1;

            labelFloor.Text = "??";
            labelMax.Text = "??";
            labelRoomName.Text = "??";
            labelType.Text = "??";
            pictureBox1.Image = null;
        }

        // zarezerwowane pokoje odblokowanie przyciskow i listboxow
        private void RoomSelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            // jesli zaznaczysz zarezerwowany pokoj pokaz jego gosci
            if (RoomSelectedListBox.SelectedItems.Count == 1)
            {
                ShowGuest(); // pokaz gosci 1
                GuestListBox.Enabled = true; // uruchom liste gosci
                RoomToLeft.Enabled = true; // mozliwosc usuwania pokoju
            }
            else if (RoomSelectedListBox.SelectedItems.Count == 0)
            {
                GuestListBox.Enabled = false;
                RoomToLeft.Enabled = false;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //////////////////////////////////dodawanie gosci `unikalnych` do pokoi///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void GuestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GuestListBox.SelectedItems.Count == 1)
            {
                GuestToRight.Enabled = true;
            }
            else if (GuestListBox.SelectedItems.Count == 0)
            {
                GuestToRight.Enabled = false;
            }
        }


        private void GuestToRight_Click(object sender, EventArgs e)
        {
            roomsReserved[RoomID()].guests.Add(GuestListBox.SelectedItem.ToString());
            ShowGuest();


            GuestListBox.Items.RemoveAt(GuestListBox.SelectedIndex);
            GuestListBox.SelectedIndex = -1;

            // jesli guest to right click
            // usun z listboxa
            // podczas usuwania wroc go na miejsce  w guesttoleft


            // dodanie osoby do pokoju
            //sprawdzic czy gosc juz jest w tym pokoju aby go nie przypisywac 
            // a tak wlasciwie sprawdzic czy jest w jakimkolwiek pokoju bo nie moze byc w dwoch pokojach
            // najlepiej usunac go tymczasowo z listboxa aby nie moc go wykorzystac 2 razy
            // to samo mozna zrobic do pokoi aby nie sprawdzac 
        }




        private void GuestToLeft_Click(object sender, EventArgs e)
        {
            if (GuestSelectedListBox.SelectedItems.Count == 1)
            {
                
                GuestListBox.Items.Add(GuestSelectedListBox.SelectedItem);
                roomsReserved[RoomID()].guests.RemoveAt(GuestSelectedListBox.SelectedIndex); // nie wiem czy dobry indeks
                GuestSelectedListBox.Items.RemoveAt(GuestSelectedListBox.SelectedIndex);
            }
        }



        // osoby w zarezerwowanym pokoju
        private void GuestSelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GuestSelectedListBox.SelectedItems.Count == 1)
            {
                GuestToLeft.Enabled = true;
            }
            else if (GuestSelectedListBox.SelectedItems.Count == 0)
            {
                GuestToLeft.Enabled = false;
            }
        }

        private int RoomID()
        {
            int i = 0;
            foreach (SelectedRoom list in roomsReserved)
            {
               // textBox1.Text = list.Name + " == " + RoomSelectedListBox.SelectedItem.ToString();
                if (list.Name == RoomSelectedListBox.SelectedItem.ToString())
                {
                    //textBox4.Text = i.ToString();
                    break;
                }
                i++;
            }
                return i;
        }

        private void ShowGuest()
        {

            GuestSelectedListBox.Items.Clear();
            if (roomsReserved[RoomID()].guests.Count == 0)
            {
                GuestToLeft.Enabled = false;
            }
            else
            {
                for (int j = 0; j < roomsReserved[RoomID()].guests.Count; j++)
                    GuestSelectedListBox.Items.Add(roomsReserved[RoomID()].guests[j].ToString());

                GuestToLeft.Enabled = false;
            }
        }

        private void LoadRoom()
        {

            var checkroom = from a in contextDB.Room
                            where RoomListBox.SelectedItem.ToString() == a.RoomNameUnique.ToString()
                            from b in contextDB.RoomType
                            where a.RoomType_ID == b.Id
                            select new
                            {
                                a.RoomNameUnique,
                                a.RoomType,
                                b.Capacity
                             };

            foreach (var item in checkroom)
            {
                labelRoomName.Text = item.RoomNameUnique.ToString();
                labelMax.Text = item.Capacity.ToString();
                labelType.Text = item.RoomType.ToString();
                ChangeImage(item.RoomType.ToString());
                item.RoomNameUnique.ToCharArray();
                labelFloor.Text = item.RoomNameUnique[1].ToString();
                //labelFloor.Text = item.RoomNameUnique[0] zmien nazwe pietra albo zmien tablice danych
            }

        }

        // Wyswietlaj obraz
        private void ChangeImage(string x)
        {
            switch (x)
            {
                case "Single":
                    pictureBox1.Image = Properties.Resources.obraz001;
                    break;
                case "Double":
                    pictureBox1.Image = Properties.Resources.obraz002;
                    break;
                case "Triple":
                    pictureBox1.Image = Properties.Resources.obraz004;
                    break;
                case "Twin":
                    pictureBox1.Image = Properties.Resources.obraz003;
                    break;
                case "Apartment":
                    pictureBox1.Image = Properties.Resources.obraz005;
                    break;
            }
            pictureBox1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = new DateTime(dateTimePicker1.Value.Ticks);
            dateTimePicker2.MinDate = start.AddDays(1);
        }
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            RoomListBox.Items.Clear();
            // przyklady jakie mamy w tabeli
            //   02.12.2020  10.12.2020
            //   13.12.2020  15.12.2020
            //   15.12.2020  18.12.2020
            // (13, 12,2020 )   (16, 12,2020 ) 
            // day,month,year     </>    year, month , day
            DateTime checkIn = new DateTime(2020, 12, 11);
            DateTime CheckOut = new DateTime(2020, 12, 16);

            //sprawdzamy ktore z pokoi z rezerwacjami mozna zarezerwowac w tym terminie
            //nalezy jeszcze dodac pokoje bez rezerwacji
            var test2 = (from room in contextDB.Room
                         where !contextDB.RoomReserved.Any(f => room.Id == f.Room_ID)
                         select new
                         {
                             room.RoomNameUnique
                         }).Union(


                        from x in contextDB.RoomReserved
                        where contextDB.RoomReserved.All(res =>  
                      !((res.Reservation.StartDate > checkIn && res.Reservation.StartDate < CheckOut) // jesli w srodku jest start
                      || 
                      (res.Reservation.EndDate > checkIn && res.Reservation.EndDate < CheckOut)   // jestli w srodku jest koniec
                      ||
                      (res.Reservation.StartDate < checkIn && res.Reservation.EndDate > checkIn))) // jesli start jest wczesniej ale koniec jest w srodku

                        //where !contextDB.Room.Any(x => res.Reservation.StartDate >= checkIn && res.Reservation.EndDate <= CheckOut)
                        //where (res.Reservation.StartDate < checkIn && res.Reservation.EndDate < CheckOut)
                        select new
                        {
                            x.Room.RoomNameUnique
                        }).ToList();

         // var test1 = (from room in contextDB.Room
         //              where !contextDB.RoomReserved.Any(f => room.Id == f.Room_ID)                         
         //              select new
         //              {
         //                  room.Id
         //              }).ToList();

            //var extraitems = db.table.Where(t => !list.Select(l => l.EntityID).Contains(t.EntityID));

            // var query = (from rooms in context.RoomTypes
            //              where (rooms.Id == modelid) &&
            //              !(context.Reservation_RoomTypes.Any(a => a.ReservationId ==
            //                        (from reservations in context.Reservations
            //                         where (reservations.Arrival <= DateTime.Parse("2017-05-18"))
            //                         && (reservations.Depature => DateTime.Parse("2017-05-18")))
            //



         // var test = from a in contextDB.RoomReserved
         //            where  !contextDB.Room.Any(b => b.Id == a.Room.Id)
         //            select a.Room;
         //
         // var testDate = (from a in contextDB.Reservation
         //                 where !(a.EndDate > checkIn && a.EndDate <= CheckOut) && !(a.StartDate >= checkIn && a.EndDate <= CheckOut) && !(a.StartDate > checkIn && a.StartDate <= CheckOut)
         //                 from b in a.RoomReserved
         //                 where b.Reservation_ID == a.Id && b.Room.Id == b.Room_ID
         //
         //
         //                 // trzeba dodac trzy warunki 
         //                 // jesli data start byla wczesniej ale end jest po start ale nie przed koncem
         //                 // jesli start jest po start i end ciagnie sie dalej
         //                 // i jesli zaczal sie przed i skoczyl daleko po
         //
         //                 select new
         //                 {
         //                     a.Id
         //                 }).ToList();
         //
         // var lookForRoom = (from a in contextDB.RoomReserved
         //                    where a.Room.Id == a.Room_ID 
         //                    where a.Reservation.StartDate < checkIn
         //                    
         //                    select new
         //                    {
         //                        a.Room.RoomNameUnique
         //                    }).ToList();
         //
         // var data = (from a in contextDB.RoomReserved
         //             where !(a.Reservation.StartDate > checkIn)
         //             select new
         //             {
         //                 a.Room.RoomNameUnique
         //             }).ToList();
         //
         // var FullJoin = test1.Union(testDate);


            foreach (var item in test2)
            {
                RoomListBox.Items.Add(item.RoomNameUnique.ToString());
            }

        //   foreach (Room x in contextDB.Room)
        //   {
        //       RoomListBox.Items.Add(x);
        //   }

        }
    }
}
// lista wybranych pokoi z ich nazwa oraz typem
// po dodaniu brak mozliwosci dodania ponownie
// zmiana w bazie danych dotyczaca ilosci pokoi

// oraz zmiana w tabeli pokoi LUB nowa tabel room_reserved aby wiedzial kiedy jest przypisany do jakiego pokoju
// + tabela szczegoly rezerwacji np sniadania barek i tak dalej do faktury
// data kiedy pokoje sa zajete
