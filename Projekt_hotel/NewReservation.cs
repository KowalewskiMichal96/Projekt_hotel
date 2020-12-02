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
        public NewReservation()
        {
            
            InitializeComponent();
            LoadGuest();
            LoadPayer();
            LoadRooms();

        }

        public void GetCapacity(string type)
        {
            roomCapacity.Items.Clear();
            int asn = (from a in contextDB.RoomType
                          where a.RoomName == type
                          select a).Single().Capacity;

            for (int i = 1; i <= asn; i++)
                roomCapacity.Items.Add(i);
            
           //contextDB.RoomType.Single(a => a.RoomName == type).Capacity;
        }
        private void LoadRooms()
        {
            foreach(RoomType x in contextDB.RoomType)
            {
                roomType.Items.Add(x.ToString());
  
            }
            roomType.SelectedIndex = 0;
            
        }

        private void LoadPayer()
        {
            foreach (Payer x in contextDB.Payer)
            {
                listBox2.Items.Add(x);
            }
        }

        private void LoadGuest()
        {
            foreach (Guest x in contextDB.Guest)
            {
                listBox1.Items.Add(x);
            }
        }

        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (roomType.SelectedItem)
            {
                case "Single":
                    GetCapacity("Single");
                    pictureBox1.Image = Properties.Resources.obraz001;
                    break;
                case "Double":
                    GetCapacity("Double");
                    pictureBox1.Image = Properties.Resources.obraz002;
                    break;
                case "Triple":
                    GetCapacity("Triple");
                    pictureBox1.Image = Properties.Resources.obraz004;
                    break;
                case "Twin":
                    GetCapacity("Twin");
                    pictureBox1.Image = Properties.Resources.obraz003;
                    break;
                case "Apartment":
                    GetCapacity("Apartment");
                    pictureBox1.Image = Properties.Resources.obraz005;
                    break;
            }
            pictureBox1.Refresh();
        }
    }
}
