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
        readonly databaseHotelDataContext contextDB = new databaseHotelDataContext();
        readonly List<SelectedRoom> AddedRooms = new List<SelectedRoom>();
        public static int SelectedButton = 0;
        public static int WorkerId = 0;
        public static int AddOrEdit = 1;
        public static int ReseravtionID = 0;
        public string[] ReservationOn;

        public NewReservation(int WORKERID, int RESERVATIONID, int WHATTASK)
        {


            InitializeComponent();
            Task(WORKERID, RESERVATIONID, WHATTASK);

            //LoadForm();
        }
        private void LoadPayer()
        {


            // Płatnik
            PayerLB.Items.Clear();
            foreach (Payer x in contextDB.Payer)
            {
                PayerLB.Items.Add(x);
            }
        }

        private void LoadGuest()
        {
            GuestLB.Items.Clear();

            if(RoomSelectedLB.Items.Count > 0)
            {
                List<string> x = new List<string>();
                for(int i = 0; i < AddedRooms.Count; i++)
                { 
                    for(int j = 0; j < AddedRooms[i].guests.Count; j++)
                    {
                        // getting all names and reload list of guest
                        string[] name = AddedRooms[i].guests[j].Split();
                        x.Add(name[0]);
                    }
                }

                foreach(Guest z in contextDB.Guest.Where(guest => !x.Contains(guest.LastName)))
                {
                    GuestLB.Items.Add(z);
                }
            }
            else
            {
                // Goscie
               foreach (Guest x in contextDB.Guest)
               {
                   GuestLB.Items.Add(x);
               }

            }
        }
        private void LoadForm()
        {
            LoadPayer();
            LoadGuest();
            TimePickerEnd.MinDate = TimePickerStart.Value.AddDays(1);
            TPDateOfBirth.MaxDate = DateTime.Today;
        }

        private void LoadRoom()
        {
            var checkroom = from a in contextDB.Room
                            where RoomLB.SelectedItem.ToString() == a.RoomNameUnique.ToString()
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

        private void TimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = new DateTime(TimePickerStart.Value.Ticks);
            TimePickerEnd.MinDate = start.AddDays(1);
        }

        // Getting free rooms in data
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // RoomLB.Items.Clear();
            // jesli data jest inna niz na rezerwacji i jesli jest to opcja edytowania

            DateTime checkIn;
            DateTime CheckOut;

            checkIn = TimePickerStart.Value;
            CheckOut = TimePickerEnd.Value;

            ClearAll();

            if(AddOrEdit == 1)
            {
                List<Rooms> freeRooms = ListManager.LoadSampleRooms(checkIn, CheckOut, 1);
                foreach (Rooms item in freeRooms)
                {
                    RoomLB.Items.Add(item.RoomName.ToString());
                }
            }
            else if(AddOrEdit == 2)
            {
                // czy jestes pewny ze chcesz wszystko wycofac
                List<Rooms> freeRooms = ListManager.LoadSampleRooms(checkIn, CheckOut, ReseravtionID);
                foreach (Rooms item in freeRooms)
                {
                    RoomLB.Items.Add(item.RoomName.ToString());
                }
            }

        }


        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox x = sender as ListBox;
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < x.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(109, 109, 109) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = x.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.FromArgb(109, 109, 109));
                g.DrawString(itemText, e.Font, itemTextColorBrush, x.GetItemRectangle(itemIndex).Location);


                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

        // find index of room
        private int RoomIndex()
        {
            int index = 0;
            for (int i = 0; i < AddedRooms.Count; i++)
            {
                if (AddedRooms[i].Name.Contains(RoomSelectedLB.SelectedItem.ToString()))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // find index of guest in room
        private int GuestIndex()
        {
            int index = 0;
            for (int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i++)
            {
                if (AddedRooms[RoomIndex()].guests[i].Contains(GuestSelectedLB.SelectedItem.ToString()))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        // return guests to their listbox
        private void ReturnGuests()
        {
            if (AddedRooms[RoomIndex()].guests.Count > 0)
            {
                for (int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i++)
                {
                    GuestLB.Items.Add(AddedRooms[RoomIndex()].guests[i]);
                }
            }

        }


        // container handling
        private void RoomLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomLB.SelectedItems.Count > 0)
            {
                LoadRoom();
                SelectRoom.Enabled = true;
            }
            else
            {
                SelectRoom.Enabled = false;
            }
        }


        private void SelectRoom_Click(object sender, EventArgs e)
        {
            if (!RoomSelectedLB.Items.Contains(RoomLB.SelectedItem))
            {
                AddedRooms.Add(new SelectedRoom(RoomLB.SelectedItem.ToString()));
                RoomSelectedLB.Items.Add(RoomLB.SelectedItem);
                RoomLB.Items.Remove(RoomLB.SelectedItem);
            }
            else
            {
                // blad
                // wlasny box
            }
        }

        private void RoomSelectedLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomSelectedLB.SelectedItems.Count > 0)
            {
                GuestSelectedLB.Items.Clear();
                // showing guests 
                if (AddedRooms[RoomIndex()].guests != null)
                {
                    for (int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i++)
                    {
                        GuestSelectedLB.Items.Add(AddedRooms[RoomIndex()].guests[i]);
                    }
                }

                if (GuestLB.SelectedItems.Count > 0)
                {
                    SelectGuest.Enabled = true;
                }
                else
                {
                    SelectGuest.Enabled = false;
                }
                // index of room and number of people in room 
                //textBox1.Text = RoomIndex().ToString();
                //textBox1.Text += " - " + AddedRooms[RoomIndex()].guests.Count;

                ReturnRoom.Enabled = true;

                GuestSelectedLB.Enabled = true;
                ReturnGuest.Enabled = false;
            }
            else
            {
                SelectGuest.Enabled = false;
                ReturnRoom.Enabled = false;
            }
        }

        private void ReturnRoom_Click(object sender, EventArgs e)
        {

            // sprawdz w czy w tych pokojach byl gosc ktory
            // return guest to listbox
            ReturnGuests();
            ReturnGuest.Enabled = false;
            GuestSelectedLB.Enabled = false;

            for (int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i++)
                if (AddedRooms[RoomIndex()].guests[i] == LabelResOn.Text)
                    LabelResOn.Text = "EMPTY";
            GuestSelectedLB.Items.Clear();

            // return room to listbox
            AddedRooms.RemoveAt(RoomIndex());
            RoomLB.Items.Add(RoomSelectedLB.SelectedItem);
            RoomSelectedLB.Items.Remove(RoomSelectedLB.SelectedItem);

        }

        private void GuestLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GuestLB.SelectedItems.Count > 0)
            {
                if (RoomSelectedLB.SelectedItems.Count > 0)
                {
                    SelectGuest.Enabled = true;
                }
                else
                {
                    SelectGuest.Enabled = false;
                }
                DeleteGB.Enabled = true;
                EditGB.Enabled = true;
            }
            else
            {
                SelectGuest.Enabled = false;
                DeleteGB.Enabled = false;
                EditGB.Enabled = false;
            }
        }

        private void SelectGuest_Click(object sender, EventArgs e)
        {
            AddedRooms[RoomIndex()].guests.Add(GuestLB.SelectedItem.ToString());
            GuestSelectedLB.Items.Add(GuestLB.SelectedItem);
            GuestLB.Items.RemoveAt(GuestLB.SelectedIndex);
        }

        private void GuestSelectedLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GuestSelectedLB.SelectedItems.Count > 0)
            {
                ReturnGuest.Enabled = true;
            }
            else
            {
                ReturnGuest.Enabled = false;
            }
        }

        private void ReturnGuest_Click(object sender, EventArgs e)
        {
            GuestLB.Items.Add(GuestSelectedLB.SelectedItem);
            AddedRooms[RoomIndex()].guests.RemoveAt(GuestIndex());

            if (GuestSelectedLB.SelectedItem.ToString() == LabelResOn.Text)
                LabelResOn.Text = "EMPTY";
            GuestSelectedLB.Items.RemoveAt(GuestSelectedLB.SelectedIndex);


            ReturnGuest.Enabled = false;
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            string error3 = "Are you sure you want to abort this operation ??";
            CustomDialog AddReservation = new CustomDialog(error3, 2);
            AddReservation.ShowDialog();
            if (AddReservation.DialogResult.Equals(DialogResult.Yes))
            {
                AddOrEdit = 1;
                var mainForm = Application.OpenForms.OfType<MainMenu>().Single();
                mainForm.FillData();
                this.Close();
            }
            else
            {
                
            }


         //var mainForm = Application.OpenForms.OfType<MainMenu>().Single();
         //mainForm.FillData();
         //
         //this.Close();
        }

        private void PayerLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PayerLB.SelectedItems.Count > 0)
            {
                DeletePB.Enabled = true;
                EditPB.Enabled = true;
            }
            else
            {
                DeletePB.Enabled = false;
                EditPB.Enabled = false;
            }
        }

        // TableLayouPanel Guest/Payer Editor

        private void EditGB_Click(object sender, EventArgs e)
        {
            SelectedButton = 3;
            Button x = sender as Button;
            WhichPanel(Convert.ToInt32(x.Tag));
        }
        private void AddNGB_Click(object sender, EventArgs e)
        {
            SelectedButton = 1;
            Button x = sender as Button;
            WhichPanel(Convert.ToInt32(x.Tag));
        }
        private void EditPB_Click(object sender, EventArgs e)
        {
            SelectedButton = 6;
            Button x = sender as Button;
            WhichPanel(Convert.ToInt32(x.Tag));
        }
        private void AddNPB_Click(object sender, EventArgs e)
        {
            SelectedButton = 4;
            Button x = sender as Button;
            WhichPanel(Convert.ToInt32(x.Tag));
        }



        // TableLayoutPanel change View

        private void SetGuest()
        {
            TableLP.Visible = true;
            TableLP.BringToFront();

            TableLP.SetRow(Text4, 9);
            TableLP.SetRow(CBPayment, 12);

            LabelEditPerson.Text = "Add the new guest";
            LabelText1.Text = "Last Name";
            LabelText2.Text = "First Name";
            LabelText3.Text = "Nationality";
            LabelText4.Text = "Id Proof";
            LabelText5.Text = "Date Of Birth";

            CBPayment.Visible = false;
            Text4.Visible = true;
            LabelText5.Visible = true;
            TPDateOfBirth.Visible = true;
        }

        private void SetPayer()
        {
            TableLP.Visible = true;
            TableLP.BringToFront();

            TableLP.SetRow(Text4, 12);
            TableLP.SetRow(CBPayment, 9);

            LabelEditPerson.Text = "Edit the guest information";
            LabelText1.Text = "Last Name";
            LabelText2.Text = "Address";
            LabelText3.Text = "Account Number";
            LabelText4.Text = "Method Of Payment";

            Text4.Visible = false;
            LabelText5.Visible = false;
            TPDateOfBirth.Visible = false;
            CBPayment.Visible = true;
        }


        // TableLayoutPanel ClearMenu
        private void ClearMenu()
        {
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            TPDateOfBirth.Value = DateTime.Today;
            CBPayment.SelectedIndex = 0;

            TableLP.Visible = true;
            TableLP.BringToFront();
        }



        private void WhichPanel(int x)
        {

            ClearMenu();
            switch (x)
            {
                case 1:
                    SetGuest();
                    break;
                case 3:
                    {
                        SetGuest();
                        // Download data
                        string[] z = GuestLB.SelectedItem.ToString().Split();
                        var queryguest = from guest in contextDB.Guest
                                         where guest.LastName.Contains(z[0])
                                         select guest;

                        // fill textboxes
                        foreach (var item in queryguest)
                        {
                            Text1.Text = item.LastName;
                            Text2.Text = item.FirstName;
                            Text3.Text = item.Nationality;
                            Text4.Text = item.IdProof;
                            TPDateOfBirth.Value = item.DateOfBirth.Date;
                        }
                        break;
                    }
                case 4:
                    SetPayer();
                    break;
                case 6:
                    {
                        SetPayer();
                        // Download data
                        string[] y = PayerLB.SelectedItem.ToString().Split();
                        var querypayer = from payer in contextDB.Payer
                                         where payer.Name.Contains(y[0])
                                         select payer;

                        // fill textboxes
                        foreach (var item in querypayer)
                        {
                            Text1.Text = item.Name;
                            Text2.Text = item.Address;
                            Text3.Text = item.AccountNumber;
                            CBPayment.SelectedItem = item.MethodOfPayment;
                        }
                        break;
                    }


                // Delete Object 
                case 2:
                    break;
                case 5:
                    break;
            }
        }



        private void TBClose_Click(object sender, EventArgs e)
        {
            TableLP.Visible = false;
        }

        private void TBConfirm_Click(object sender, EventArgs e)
        {
            if (SelectedButton == 1 || SelectedButton == 3)
            {
                Guest GuestToSave = null;
                
                if(SelectedButton == 1)
                {
                    GuestToSave = new Guest();
                    contextDB.Guest.InsertOnSubmit(GuestToSave);

                }
                else
                {
                    GuestToSave = GuestLB.SelectedItem as Guest;
                }
                GuestToSave.LastName = Text1.Text;
                GuestToSave.FirstName = Text2.Text;
                GuestToSave.Nationality = Text3.Text;
                GuestToSave.IdProof = Text4.Text;
                GuestToSave.DateOfBirth = TPDateOfBirth.Value;

                SelectGuest.Enabled = false;
                contextDB.SubmitChanges();
                LoadGuest();
            }
            else if(SelectedButton == 4 || SelectedButton == 6)
            {
                Payer PayerToSave = null;
                
                if(SelectedButton == 4)
                {
                    PayerToSave = new Payer();
                    contextDB.Payer.InsertOnSubmit(PayerToSave);
                }
                else
                {
                    PayerToSave = PayerLB.SelectedItem as Payer;
                }
                PayerToSave.Name = Text1.Text;
                PayerToSave.Address = Text2.Text;
                PayerToSave.AccountNumber = Text3.Text;
                PayerToSave.MethodOfPayment = CBPayment.SelectedItem.ToString();

                contextDB.SubmitChanges();
                LoadPayer();
            }

            TableLP.Visible = false;
        }


        private void ReservationConfirmButton_Click(object sender, EventArgs e)
        {
            if(RoomSelectedLB.Items.Count > 0)
            {
                bool AllRoomsGotGuest = true;
                for(int i = 0; i < AddedRooms.Count; i++)
                {
                    if(AddedRooms[i].guests.Count < 1)
                    {
                        AllRoomsGotGuest = false;
                        break;
                    }
                }

                if (AllRoomsGotGuest == true && LabelResOn.Text != "EMPTY")
                {

                    Reservation ResToSave = null;
                    RoomReserved RoomToSave = null;

                    if(AddOrEdit == 1) // when adding new reservation
                    {
                        ResToSave = new Reservation();

                        contextDB.Reservation.InsertOnSubmit(ResToSave);

                    }
                    else if(AddOrEdit == 2) // when edit old reservation
                    {
                        ResToSave = (from reservation in contextDB.Reservation where reservation.Id == ReseravtionID select reservation).SingleOrDefault();
                    }

                    ResToSave.StartDate = TimePickerStart.Value;
                    ResToSave.EndDate = TimePickerEnd.Value;
                    ResToSave.Total_price = TakePrice();
                    ResToSave.Guest = contextDB.Guest.Single(c => c.Id == (from guest in contextDB.Guest 
                                                                           where guest.LastName == ReservationOn[0] 
                                                                           select guest.Id).Single());
                    ResToSave.Worker_ID = WorkerId;
                    contextDB.SubmitChanges();  
                    
                    // save reservation

                    if(AddOrEdit == 1) // when new reservation add new roomres
                    {

                        for (int i = 0; i < RoomSelectedLB.Items.Count; i++)
                        {
                            RoomToSave = new RoomReserved();
                            contextDB.RoomReserved.InsertOnSubmit(RoomToSave);

                            RoomToSave.PriceFromDate = TakePrice();
                            RoomToSave.Reservation_ID = (from res in contextDB.Reservation select res.Id).Max();
                            RoomToSave.Room_ID = (from room in contextDB.Room
                                                  where room.RoomNameUnique.ToString() == RoomSelectedLB.Items[i].ToString()
                                                  select room.Id).First();
                            contextDB.SubmitChanges();
                        }
                    }   // end adding new roomreservation
                    else if(AddOrEdit == 2) // when old reservation edit/delete/add new roomres
                    {
                        //ad.1 wyszukac wszystkie pokoje o tej rezerwacji i warunek zrobic na pokoje z bazy danych nie listbox
                        var query2 = (from roomres in contextDB.RoomReserved where roomres.Reservation_ID == ReseravtionID select roomres).ToList();


                        for (int i = 0; i < RoomSelectedLB.Items.Count; i++)
                        {
                            if (!contextDB.RoomReserved.Any(x => x.Room.RoomNameUnique == RoomSelectedLB.Items[i].ToString() && x.Reservation_ID == ReseravtionID))
                            {
//MessageBox.Show("nie istnieje w bazie danych");
                                RoomToSave = new RoomReserved();
                                contextDB.RoomReserved.InsertOnSubmit(RoomToSave);

                                RoomToSave.PriceFromDate = TakePrice();
                                RoomToSave.Reservation_ID = (from res in contextDB.Reservation select res.Id).Max();
                                RoomToSave.Room_ID = (from room in contextDB.Room
                                                      where room.RoomNameUnique.ToString() == RoomSelectedLB.Items[i].ToString()
                                                      select room.Id).First();

                            }
                            else if (contextDB.RoomReserved.Any(x => x.Room.RoomNameUnique == RoomSelectedLB.Items[i].ToString() && x.Reservation_ID == ReseravtionID))
                            {
//MessageBox.Show("istnieje w bazie danych przedluz moja rezerwacje");
                            }
                            contextDB.SubmitChanges();
                        }

                        for (int i = 0; i < query2.Count; i++)
                            if(!RoomSelectedLB.Items.Contains(query2[i].Room.RoomNameUnique) && query2[i].Reservation_ID.Equals(ReseravtionID))
                            {
//MessageBox.Show("nie istnieje w listboxie ale istnieje w bazie usun mnie");

                                RoomToSave = query2[i];
                                contextDB.RoomReserved.DeleteOnSubmit(RoomToSave);
                                contextDB.SubmitChanges();
                            }
                           

                    } // edit roomreservation


                    // load database in Mainmenu Form and close active form
                    AddOrEdit = 1;
                    var mainForm = Application.OpenForms.OfType<MainMenu>().Single();
                    mainForm.FillData();
                    this.Close();

                }   // end of adding and editing reservation and roomreservation
                else if (AllRoomsGotGuest == false || LabelResOn.Text == "EMPTY")
                {
                    string error1 = "Failed to make a reservation, please check that every room has a guest";
                    CustomDialog AddReservation = new CustomDialog(error1, 1);
                    AddReservation.ShowDialog();
                }
            }
            else
            {
                string error2 = "Failed to make a reservation, please check that you have selected a room";
                CustomDialog AddReservation = new CustomDialog(error2, 1);
                AddReservation.ShowDialog();
            }
        }
            
            decimal TakePrice()
            {
                decimal TotalPrice = 0M;
                for(int i = 0; i < RoomSelectedLB.Items.Count; i++)
                {
                    decimal price = (from room in contextDB.Room
                                    where room.RoomNameUnique == RoomSelectedLB.Items[i].ToString()
                                    select (decimal)room.RoomType.CurrentPrice).Single();
                    TotalPrice += price;                
                }
                return TotalPrice;
            }

        private void GuestSelectedLB_DoubleClick(object sender, EventArgs e)
        {
            ReservationOn = GuestSelectedLB.SelectedItem.ToString().Split();
            LabelResOn.Text = string.Join(" ", ReservationOn);
        }


        private void Task(int WORKERID, Int32 RESERVATIONID, int x)
        {
            WorkerId = WORKERID;
            if(x == 1)
            {
                ReseravtionID = 0;
                AddOrEdit = 1;
                LoadForm();
            }
            if(x == 2)
            {
                ReseravtionID = RESERVATIONID;
                FillForm();
                AddOrEdit = x;
            }
        }

        private void FillForm()
        {

            // wskaz termin rezerwacji
            var queryReservation = (from reservation in contextDB.Reservation
                                   where reservation.Id == ReseravtionID
                                   select reservation).Single();

                TimePickerStart.Value = queryReservation.StartDate;
                TimePickerEnd.Value = queryReservation.EndDate;
                SearchButton_Click(new object(), new EventArgs());
                LabelResOn.Text = queryReservation.Guest.ToString();

            // wypelnij listbox zarezerwowanych pokoi
            var queryRoom = from roomres in contextDB.RoomReserved
                        where roomres.Reservation_ID == ReseravtionID
                        select roomres.Room.RoomNameUnique;
            foreach (var item in queryRoom)
            {
                AddedRooms.Add(new SelectedRoom(item));
                RoomSelectedLB.Items.Add(item);
            }            
            // teoretycznie dodaj gosci w tych pokojach
            // gdy bedzie taka tabela aktualnie nie ma
        } // FILL FORM

        private void ClearAll()
        {
            AddedRooms.Clear();
            LoadGuest();
            LoadPayer();
            RoomLB.Items.Clear();
            RoomSelectedLB.Items.Clear();
            GuestSelectedLB.Items.Clear();
            LabelResOn.Text = "EMPTY";
            ReservationOn = null;
        }


    }   //PUBLIC CLASS NEWRESERVATION
}   // NAMESPACE PROJEKT HOTEL
