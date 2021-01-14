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
    public partial class ListOfUsers : Form
    {
        readonly databaseHotelDataContext contextDB = new databaseHotelDataContext();
        readonly User LoggedUser = new User();
        public int Choice = 0;
        public ListOfUsers(User user)
        {
            InitializeComponent();
            LoadData();
            LoggedUser = user;
        }


// LOAD PERSONS FROM DB
        private void LoadData()
        {
            listBox1.Items.Clear();

            var users = from worker in contextDB.Worker select worker;

            foreach (var item in users)
            {
                listBox1.Items.Add(item);
            }
        Choice = 0;
        }

// CLOSE THIS FORM
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                ChangeView("EDIT");
                FillTable();

                // jesli wybrales to mozesz usunac/ zmienic haslo/ edytowac
                SearchB.Enabled = true;
                DeleteB.Enabled = true;
                ChangeB.Enabled = true;
                EditB.Enabled = true;
            }
            else if (listBox1.SelectedItems.Count < 1)
            {
                SearchB.Enabled = false;
                DeleteB.Enabled = false;
                ChangeB.Enabled = false;
                EditB.Enabled = false;

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


// CHANGE VIEW OF FORM
        private void ChangeView(string x)
        {

            switch (x)
            {
                case "ADD":
                    {
                        // ADD USER
                        label1.Text = "First Name";
                        label2.Text = "LastName";
                        label3.Text = "Email";
                        textBox5.Text = "User";

                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        textBox6.Visible = true;
                        textBox7.Visible = true;
                        checkBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;


                        ClearTable();

                        // przyciski
                    }
                    break;
                case "EDIT":
                    {
                        // EDIT USER
                        label1.Text = "First Name";
                        label2.Text = "LastName";
                        label3.Text = "Email";

                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        checkBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

                        ClearTable();
                    }
                    break;
                case "CHANGE":
                    {
                        // CHANGE PASSWORD 
                        label1.Text = "Old Password";
                        label2.Text = "New Password";
                        label3.Text = "Repeate Password";

                        listBox1.Enabled = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        checkBox1.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;

                        ClearTable();
                    }
                    break;
            }// switch end
        }

        private void ViewToSave()
        {
            listBox1.Enabled = false;
            panel2.Enabled = true;
            SearchB.Enabled = false;
        }

        private void ViewNotToSave()
        {
            ChangeView("ADD");
            listBox1.SelectedIndex = -1;
            DeleteB.Enabled = false;
            ChangeB.Enabled = false;
            EditB.Enabled = false;
            listBox1.Enabled = true;
            panel2.Enabled = false;
            SearchB.Enabled = true;
        }


// GETTING DATA TO TABLELAYOUT
        private void FillTable()
        {

            Worker SelectedWorker = listBox1.SelectedItem as Worker;

            textBox1.Text = SelectedWorker.FirstName;
            textBox2.Text = SelectedWorker.LastName;
            textBox3.Text = SelectedWorker.Email;
            textBox4.Text = SelectedWorker.UserLogin;
            textBox5.Text = Type(SelectedWorker);
            
            if(SelectedWorker.Manager == true)
            {
                checkBox1.Checked = true;
            }
            else if(SelectedWorker.Manager == false)
            {
                checkBox1.Checked = false;
            }
        }

        string Type(Worker x)
        {
            string t = "";

            if (x.Type == 'u' || x.Type == 'U')
                t = "User";
            else if (x.Type == 'a' || x.Type == 'A')
                t = "Admin";
            return t;
        }

// CLEAR TABLELAYOUT
        private void ClearTable()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            checkBox1.Checked = false;


        }


// BUTTONS TO EDIT GUEST INFORMATION IN PANEL 2
        private void CancelButtonTLO_Click(object sender, EventArgs e)
        {
            // czy na pewno chcesz porzucic zaminy ?
            ViewNotToSave();
        }

        private void ConfirmButtonTLO_Click(object sender, EventArgs e)
        {
            // publiczna zmienna co wybralismy edit add czy haslo
            // i zaleznie od tego wykonac ponizsze dzialania 
            
            ViewNotToSave();
        }


        // BUTTONS TO EDIT LISTBOX ITEMS

        private void DeleteB_Click(object sender, EventArgs e)
        {
            // nalezy sprawdzic czy sa na niego rezerwacje jesli sa to mozna np przepisac na managera 
            // zapewne poki co blad podczas usuwania 
            Worker WorkerToDelete = listBox1.SelectedItem as Worker;
            contextDB.Worker.DeleteOnSubmit(WorkerToDelete);
            contextDB.SubmitChanges();

            ViewNotToSave();
        }

        private void ChangeB_Click(object sender, EventArgs e)
        {
            Choice = 1;
            // mozna zmieniac tylko jesli jestes adminem
            // w wiadomosci do uzytkowika ze moze zmieniac tylko i wylacznie swoje haslo
            ChangeView("CHANGE");
            ViewToSave();


        }

        private void EditB_Click(object sender, EventArgs e)
        {
            Choice = 2;
            ChangeView("EDIT");
            ViewToSave();


            //sprawdz czy dobre dane
            SaveToDB(2);
            
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            Choice = 3;
            listBox1.SelectedIndex = -1;
            ChangeView("ADD");
            ViewToSave();


            // sprawdz czy dobre dane
            SaveToDB(1);
        }

        private void SaveToDB(int EditOrAdd)
        {
            Worker WorkerToSave = null;
            if(EditOrAdd == 1)
            {
                // Add
                WorkerToSave = new Worker();
            }
            else if(EditOrAdd == 2)
            {
                // Edit
                WorkerToSave = listBox1.SelectedItem as Worker;
                contextDB.Worker.InsertOnSubmit(WorkerToSave);
            }

            WorkerToSave.FirstName = textBox1.Text;
            WorkerToSave.LastName = textBox2.Text;
            WorkerToSave.Email = textBox3.Text;
            WorkerToSave.UserLogin = textBox4.Text;
            WorkerToSave.Manager = checkBox1.Checked;
            WorkerToSave.Type = 'U';

            WorkerToSave.UserPassword = textBox6.Text;

            contextDB.SubmitChanges();

        }

    }
}
