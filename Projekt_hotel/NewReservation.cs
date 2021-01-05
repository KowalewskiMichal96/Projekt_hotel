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
        List<SelectedRoom> AddedRooms = new List<SelectedRoom>();
        List<string> SelectedRooms = new List<string>();
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
                GuestLB.Items.Add(x);
            }

            TimePickerEnd.MinDate = TimePickerStart.Value.AddDays(1);
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
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SearchButton_Click(object sender, EventArgs e)
        {
            RoomLB.Items.Clear();

            DateTime checkIn;
            DateTime CheckOut;

            checkIn = TimePickerStart.Value;
            CheckOut = TimePickerEnd.Value;

            List<Rooms> freeRooms = ListManager.LoadSampleRooms(checkIn,CheckOut);
            foreach (Rooms item in freeRooms)
            {
                RoomLB.Items.Add(item.RoomName.ToString());
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
        // find index

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


        // return guests to their listbox
        private void ReturnGuests()
        {
            if(AddedRooms[RoomIndex()].guests.Count > 0)
            {
                for(int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i ++)
                {
                    GuestLB.Items.Add(AddedRooms[RoomIndex()].guests[i]);
                }
            }

        }


        // container handling
        private void RoomLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RoomLB.SelectedItems.Count > 0)
            {
                SelectRoom.Enabled = true;

                textBox1.Clear();
                foreach (SelectedRoom item in AddedRooms)
                {
                    textBox1.Text += item.Name;
                }
            }
            else
            {
                SelectRoom.Enabled = false;
            }    
        }


        private void SelectRoom_Click(object sender, EventArgs e)
        {
            if(!RoomSelectedLB.Items.Contains(RoomLB.SelectedItem))
            {
                AddedRooms.Add( new SelectedRoom(RoomLB.SelectedItem.ToString()));
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
                // wyswietlanie gosci w pokoju 
                if(AddedRooms[RoomIndex()].guests != null)
                {
                    for(int i = 0; i < AddedRooms[RoomIndex()].guests.Count; i++)
                    {
                        GuestSelectedLB.Items.Add(AddedRooms[RoomIndex()].guests[i]);
                    }
                }
                                                                                                            // index pokoju i ilosc gosci 
                textBox1.Text = RoomIndex().ToString();
                textBox1.Text += " - " + AddedRooms[RoomIndex()].guests.Count;

                ReturnRoom.Enabled = true;
                GuestLB.Enabled = true;
                GuestSelectedLB.Enabled = true;
            }
            else
            {
                ReturnRoom.Enabled = false;
                GuestLB.Enabled = false;
                GuestLB.SelectedIndex = -1;


            }
        }

        private void ReturnRoom_Click(object sender, EventArgs e)
        {
            // zwroc gosci do listboxu
            ReturnGuests();
            GuestSelectedLB.Enabled = false;
            GuestSelectedLB.Items.Clear();

            // zwroc pokoj do listboxu
            AddedRooms.RemoveAt(RoomIndex());
            RoomLB.Items.Add(RoomSelectedLB.SelectedItem);
            RoomSelectedLB.Items.Remove(RoomSelectedLB.SelectedItem);

        }

        private void GuestLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GuestLB.SelectedItems.Count > 0)
            {
                SelectGuest.Enabled = true;
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
            if(GuestSelectedLB.SelectedItems.Count > 0)
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
            // metoda znajdujaca id konkretnego goscia na liscie 
            // usun goscia z listy i listboxu
            // dodaj go do drugiego 
        }
    }
}
