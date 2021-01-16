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
    public partial class CheckOut : Form
    {
        databaseHotelDataContext contextDB = new databaseHotelDataContext();
        public int id = 0;
        public CheckOut(int ID)
        {

            InitializeComponent();
            LoadCharges(ID);
        }


// LOAD CHARGES

        private void LoadCharges(int ID)
        {
            id = ID;
            var query = from roomres in contextDB.RoomReserved where roomres.Reservation_ID == id select roomres.Room.Id;
            //DGView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            foreach (var item in query)
            {
                
            }
        }

// CHANGE VIEW OF LISTBOX
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
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(50, 50, 50) : Color.FromArgb(239, 239, 239));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = x.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.FromArgb(239, 239, 239)) : new SolidBrush(Color.FromArgb(50, 50, 50));
                g.DrawString(itemText, e.Font, itemTextColorBrush, x.GetItemRectangle(itemIndex).Location);


                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

    }
}
