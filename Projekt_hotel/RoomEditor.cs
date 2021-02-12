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
    public partial class RoomEditor : Form
    {
        readonly databaseHotelDataContext contextDB = new databaseHotelDataContext();


        public RoomEditor()
        {
            InitializeComponent();
        }




        // change view of listbox
        private void ListOfRooms_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox this_listbox = sender as ListBox;
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < this_listbox.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(50, 50, 50) : Color.FromArgb(239, 239, 239));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = this_listbox.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.FromArgb(239, 239, 239)) : new SolidBrush(Color.FromArgb(50, 50, 50));
                g.DrawString(itemText, e.Font, itemTextColorBrush, this_listbox.GetItemRectangle(itemIndex).Location);


                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

        // Loading data
        void LoadForm()
        {
            listOfRooms.Items.Clear();
            foreach (Room x in contextDB.Room)
            {
                listOfRooms.Items.Add(x);
            }

            categoryCombobox.Items.Clear();
            foreach(RoomType y in contextDB.RoomType)
            {
                categoryCombobox.Items.Add(y.RoomName);
            }
        }
        private void RoomEditor_Load(object sender, EventArgs e)
        {
            LoadForm();
        }


        private void listOfRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listOfRooms.SelectedItems.Count > 0)
            {
                selectButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                selectButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        // actions on the rooms
        private void addButton_Click(object sender, EventArgs e)
        {
            panelInformation.Enabled = true;
            listOfRooms.Enabled = false;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            panelInformation.Enabled = true;
            listOfRooms.Enabled = false;

            LoadRoom();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Room toCheck = listOfRooms.SelectedItem as Room;
            if(!contextDB.RoomReserved.Any(x => x.Room_ID == toCheck.Id))
            {
                contextDB.Room.DeleteOnSubmit(toCheck);
                contextDB.SubmitChanges();
            }
            else
            {
                CustomDialog cd = new CustomDialog("it is not possible to delete a room with reservations", 1);
                cd.Show();
            }
        }
        void LoadRoom()
        {
            Room toLoad = listOfRooms.SelectedItem as Room;

            textBox1.Text = toLoad.RoomNameUnique;
            categoryCombobox.SelectedItem = toLoad.RoomType;


        }



        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";
            openFileDialog1.ShowDialog();
            pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }



        private void CancelButtonTLO_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            categoryCombobox.SelectedIndex = -1;
            pictureBox1.BackgroundImage.Dispose();
            panelInformation.Enabled = false;
            listOfRooms.Enabled = true;
        }
        private void ConfirmButtonTLO_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) && (categoryCombobox.SelectedIndex != -1))
            {
                if(pictureBox1.BackgroundImage != null)
                {
                    /*
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] arrImage = ms.ToArray();

                        MyPictures newPicture = new MyPictures();

                        newPicture.FileName = textBox1.Text;
                        newPicture.Data = arrImage;

                        picDB.MyPictures.InsertOnSubmit(newPicture);
                        picDB.SubmitChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    */
                }
                else
                {
                    // wczytaj jakies zdjecie
                }
            }
            else
            {
                // wyplenij dane
            }
        }

        /*
        // konwertuj zdjecie
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;

            }
        }

        // Load image to form
        private void btnLoadFromDB_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    var st = (from pic in picDB.MyPictures where pic.FileName == textBox2.Text select pic).First();
                    pictureBox2.Image = ConvertByteArrayToImage(st.Data.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        */




        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
