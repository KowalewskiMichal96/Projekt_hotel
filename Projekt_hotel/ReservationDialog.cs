using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_hotel
{
    public partial class ReservationDialog : Form
    {

        readonly databaseHotelDataContext contextDB = new databaseHotelDataContext();

        byte task;              // 0 = add new reservation, 1 = edit exist reservation
        bool personToEdit;      // true = person to edit, false = person to add
        int reservationId;      // number of the edited reservation
        int workerId;           // on whom to make reservations
        public ReservationDialog(int WORKERID, int RESERVATIONID, byte WHATTASK)
        {
            InitializeComponent();
            OperationRecognition(WORKERID, RESERVATIONID, WHATTASK);
        }

        void OperationRecognition(int WORKERID, int RESERVATIONID, byte WHATTASK)
        {
            workerId = WORKERID;
            if (WHATTASK == 0) // add
            {
                reservationId = 0;
                task = 0;
                LoadForm();
            }
            else if(WHATTASK == 1) // edit
            {
                reservationId = RESERVATIONID;
                FillForm();
                task = 1;
            }
        }

        // filling out the booking editing form
        void FillForm()
        {

            var queryReservation = (from reservation in contextDB.Reservation
                                    where reservation.Id == reservationId
                                    select reservation).Single();
            timePickerStart.Value = queryReservation.StartDate;
            timePickerEnd.Value = queryReservation.EndDate;
            LoadRooms();
            // Booked rooms
            IEnumerable<Room> filledRooms = from roomRes in contextDB.RoomReserved
                                            where roomRes.Reservation_ID.Equals(reservationId)
                                            select roomRes.Room;

            if (filledRooms.Count() > 0)
            {
                foreach (Room rooms in filledRooms)
                {
                    roomsSelectedListbox.Items.Add(rooms.ToString());
                }
            }
            // for whom the booking
            LabelResOn.Text = queryReservation.Guest.LastName + " " + queryReservation.Guest.FirstName + "\n" + queryReservation.Guest.IdProof;
            LoadGuests();
        }

        void ClearAll()
        {
            roomsListbox.Items.Clear();
            roomsSelectedListbox.Items.Clear();
            
        }



        // Loading the form and data
        void LoadForm()
        {
            SetTime();
            LoadGuests();
            LoadRooms();
        }
        void LoadRooms()
        {
            List<Rooms> freeRooms;
            ClearAll();
            if(task == 0)
            {
                freeRooms = ListManager.LoadSampleRooms(timePickerStart.Value, timePickerEnd.Value, 1);
            }    
            else
            {
                freeRooms = ListManager.LoadSampleRooms(timePickerStart.Value, timePickerEnd.Value, reservationId);
            }

            for (int i = 0; i < freeRooms.Count; i++)
            {
                roomsListbox.Items.Add(freeRooms[i].RoomName.ToString());
            }
        }
        void LoadGuests()
        {
            guestsListbox.Items.Clear();
            foreach (Guest x in contextDB.Guest)
            {
                guestsListbox.Items.Add(x);
            }
        }

        // set the correct dates in tmp
        void SetTime()
        {
            timePickerStart.Value = DateTime.Today;
            timePickerEnd.Value = timePickerStart.Value.AddDays(1);
        }
        private void TimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            timePickerEnd.MinDate = timePickerStart.Value.AddDays(1);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
                // czy jestes pewny ze chcesz cofnac wszystkie zmiany ?
                LoadRooms();
        }

        // changing the appearance of listboxes
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

        // booking and de-booking of rooms
        private void SelectRoom_Click(object sender, EventArgs e)
        {
            if(!roomsSelectedListbox.Items.Contains(roomsListbox.SelectedItem))
            {
                roomsSelectedListbox.Items.Add(roomsListbox.SelectedItem);
                roomsListbox.Items.Remove(roomsListbox.SelectedItem);
            }
        }
        private void roomsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roomsListbox.SelectedItems.Count > 0)
            {
                SelectRoom.Enabled = true;
                LoadViewOfRoom();
            }
            else
            {
                SelectRoom.Enabled = false;
            }
        }
        void LoadViewOfRoom()
        {
            Room roomToLoad = contextDB.Room.FirstOrDefault(x => x.RoomNameUnique == roomsListbox.SelectedItem.ToString()) as Room;

            try
            {
                var st = (from room in contextDB.Room where room.RoomNameUnique == roomToLoad.RoomNameUnique select room).First();
                if (st.Data != null)
                    pictureBox1.Image = ConvertByteArrayToImage(st.Data.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            labelRoomName.Text = roomToLoad.RoomNameUnique;
            labelMax.Text = roomToLoad.RoomType.Capacity.ToString();
            roomToLoad.RoomNameUnique.ToCharArray();
            labelFloor.Text = roomToLoad.RoomNameUnique[1].ToString();
            labelType.Text = roomToLoad.RoomType.RoomName;

        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;

            }
        }
        private void roomsSelectedListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roomsSelectedListbox.SelectedItems.Count > 0)
            {
                ReturnRoom.Enabled = true;
            }
            else
            {
                ReturnRoom.Enabled = false;
            }
        }
        private void ReturnRoom_Click(object sender, EventArgs e)
        {
            if(!roomsListbox.Items.Contains(roomsSelectedListbox.SelectedItem))
            {
                roomsListbox.Items.Add(roomsSelectedListbox.SelectedItem);
                roomsSelectedListbox.Items.Remove(roomsSelectedListbox.SelectedItem);
            }
        }


        // na kogo jest rezerwacja 
        private void SelectGuest_Click(object sender, EventArgs e)
        {
            ReservationOn(PersonId());
        }
        public int PersonId()
        {
            Guest toCheck = guestsListbox.SelectedItem as Guest;
            return toCheck.Id;
        }
        void ReservationOn(int id)
        {
            var queryPerson = (from guest in contextDB.Guest
                               where guest.Id == id
                               select guest).SingleOrDefault();

            LabelResOn.Text = queryPerson.LastName + " " + queryPerson.FirstName + "\n" + queryPerson.IdProof;
        }



        private void guestsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guestsListbox.SelectedItems.Count > 0)
            {
                SelectGuest.Enabled = true;
                DeleteGuest.Enabled = true;
                EditGuest.Enabled = true;
            }
            else
            {
                SelectGuest.Enabled = false;
                DeleteGuest.Enabled = false;
                EditGuest.Enabled = false;
            }
        }

        // load the person's data into the form
        void DataPerson()
        {
            Guest toLoad = guestsListbox.SelectedItem as Guest;

            Text1.Text = toLoad.FirstName;
            Text2.Text = toLoad.LastName;
            Text3.Text = toLoad.Nationality;
            Text4.Text = toLoad.IdProof;
            TPDateOfBirth.Value = toLoad.DateOfBirth;
        }


        // Actions on the person
        private void AddGuest_Click(object sender, EventArgs e)
        {
            personToEdit = false;

            Text1.Clear();
            Text2.Clear();
            Text3.Clear();
            Text4.Clear();
            TPDateOfBirth.Value = DateTime.Today;

            Panel_Reservation.Enabled = false;
            Panel_Guest.Visible = true;
        }
        private void EditGuest_Click(object sender, EventArgs e)
        {
            personToEdit = true;

            Panel_Reservation.Enabled = false;
            Panel_Guest.Visible = true;
            DataPerson();
        }
        private void DeleteGuest_Click(object sender, EventArgs e)
        {
            if (guestsListbox.SelectedItems.Count > 0)
            {
                Guest toDelete = guestsListbox.SelectedItem as Guest;

                if (!contextDB.Reservation.Any(res => res.Guest_ID.Equals(toDelete.Id)))
                {
                    if (LabelResOn.Text.StartsWith(toDelete.LastName))
                        LabelResOn.Text = "EMPTY";
                    contextDB.Guest.DeleteOnSubmit(toDelete);
                    contextDB.SubmitChanges();
                    LoadGuests();
                }
                else
                {
                    CustomDialog cd = new CustomDialog("It is not possible to delete a guest who already has a reservation", 1);
                    cd.ShowDialog();
                }
            }
            else
            {
                CustomDialog cd = new CustomDialog("Please select a guest", 1);
                cd.ShowDialog();
            }
        }


        // Actions on personal forms
        private void TBConfirm_Click(object sender, EventArgs e)
        {
            if
            (
            !(string.IsNullOrWhiteSpace(Text1.Text) && 
            string.IsNullOrWhiteSpace(Text2.Text) && 
            string.IsNullOrWhiteSpace(Text3.Text) && 
            string.IsNullOrWhiteSpace(Text4.Text))
            )
            {
                Guest guestToSave; 

                if(personToEdit == true)
                {
                    guestToSave = contextDB.Guest.Where(x => x.Id == PersonId()).SingleOrDefault();
                }
                else
                {
                    guestToSave = new Guest();
                    contextDB.Guest.InsertOnSubmit(guestToSave);
                }

                guestToSave.FirstName = Text1.Text;
                guestToSave.LastName = Text2.Text;
                guestToSave.Nationality = Text3.Text;
                guestToSave.IdProof = Text4.Text;
                guestToSave.DateOfBirth = TPDateOfBirth.Value;


                contextDB.SubmitChanges();

                personToEdit = false;
                Panel_Guest.Visible = false;
                LoadGuests();
                Panel_Reservation.Enabled = true;
                LabelResOn.Text = "EMPTY";
            }
            else
            {
                CustomDialog cd = new CustomDialog("You should fill in the gaps",1);
                cd.ShowDialog();
            }
        }
        private void TBClose_Click(object sender, EventArgs e)
        {
            Panel_Reservation.Enabled = true;
            Panel_Guest.Visible = false;
        }


        // room price calculation
        decimal TakePrice()
        {
            decimal TotalPrice = 0M;
            for (int i = 0; i < roomsSelectedListbox.Items.Count; i++)
            {
                decimal price = (from room in contextDB.Room
                                 where room.RoomNameUnique == roomsSelectedListbox.Items[i].ToString()
                                 select (decimal)room.RoomType.CurrentPrice).Single();
                TotalPrice += price;
            }
            return TotalPrice;
        }


        // Saving reservations in the database
        private void ReservationConfirmButton_Click(object sender, EventArgs e)
        {
            CustomDialog cd;
            if(roomsSelectedListbox.Items.Count > 0 && LabelResOn.Text != "EMPTY")
            {
                Reservation ResToSave = null;
                RoomReserved RoomToSave = null;

                // New booking has been added old is edit \/
                if (task == 0)
                {
                    ResToSave = new Reservation();
                    contextDB.Reservation.InsertOnSubmit(ResToSave);
                }
                else if(task == 1)
                {
                    ResToSave = (from reservation in contextDB.Reservation where reservation.Id == reservationId select reservation).SingleOrDefault();
                }

                ResToSave.StartDate = timePickerStart.Value;
                ResToSave.EndDate = timePickerEnd.Value;
                ResToSave.Total_price = TakePrice();
                ResToSave.Guest = contextDB.Guest.Single(c => c.Id == (from guest in contextDB.Guest
                                                                       where guest.Id == PersonId()
                                                                       select guest.Id).Single());
                ResToSave.Worker_ID = workerId;
                contextDB.SubmitChanges();
                


                // when a new reservation adds room reservations \/
                if (task == 0) 
                {

                    for (int i = 0; i < roomsSelectedListbox.Items.Count; i++)
                    {
                        RoomToSave = new RoomReserved();
                        contextDB.RoomReserved.InsertOnSubmit(RoomToSave);

                        RoomToSave.PriceFromDate = TakePrice();
                        RoomToSave.Reservation_ID = (from res in contextDB.Reservation select res.Id).Max();
                        RoomToSave.Room_ID = (from room in contextDB.Room
                                              where room.RoomNameUnique.ToString() == roomsSelectedListbox.Items[i].ToString()
                                              select room.Id).First();
                        contextDB.SubmitChanges();
                    }
                }
                // New room reservations added

                // when an old booking has been edited deleted room bookings
                else if (task == 1) 
                {
                    // *** find all rooms that are reserved for this id ***
                    
                                        var query2 = (from roomres in contextDB.RoomReserved where roomres.Reservation_ID == reservationId select roomres).ToList();


                    for (int i = 0; i < roomsSelectedListbox.Items.Count; i++)
                    {
                        if (!contextDB.RoomReserved.Any(x => x.Room.RoomNameUnique == roomsSelectedListbox.Items[i].ToString() && x.Reservation_ID == reservationId))
                        {
                            // if it does not exist in the database add
                            RoomToSave = new RoomReserved();
                            contextDB.RoomReserved.InsertOnSubmit(RoomToSave);

                            RoomToSave.PriceFromDate = TakePrice();
                            RoomToSave.Reservation_ID = (from res in contextDB.Reservation select res.Id).Max();
                            RoomToSave.Room_ID = (from room in contextDB.Room
                                                  where room.RoomNameUnique.ToString() == roomsSelectedListbox.Items[i].ToString()
                                                  select room.Id).First();

                        }
                        else if (contextDB.RoomReserved.Any(x => x.Room.RoomNameUnique == roomsSelectedListbox.Items[i].ToString() && x.Reservation_ID == reservationId))
                        {
                            // if there is an extension in the database
                        }
                        contextDB.SubmitChanges();
                    }

                    for (int i = 0; i < query2.Count; i++)
                        if (!roomsSelectedListbox.Items.Contains(query2[i].Room.RoomNameUnique) && query2[i].Reservation_ID.Equals(reservationId))
                        {
                            // delete from the database there is no such room reservation in the listbox

                            RoomToSave = query2[i];
                            contextDB.RoomReserved.DeleteOnSubmit(RoomToSave);
                            contextDB.SubmitChanges();
                        }
                }

                // load database in Mainmenu Form and close active form

                task = 0;
                var mainForm = Application.OpenForms.OfType<MainMenu>().Single();
                mainForm.RefreshData();
                this.Close();
            }
            else
            {
                cd = new CustomDialog("Select the room and guest needed to make the booking", 1);
                cd.ShowDialog();
            }
        }

        // close the booking window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
