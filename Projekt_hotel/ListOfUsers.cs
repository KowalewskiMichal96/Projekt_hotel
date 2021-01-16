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
        public int Selected = 0;
        List<int> x = new List<int>();
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
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        checkBox1.Visible = true;

                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = false;
                        label8.Visible = false;

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
            ChangeView("EDIT");
            listBox1.SelectedIndex = -1;
            DeleteB.Enabled = false;
            ChangeB.Enabled = false;
            EditB.Enabled = false;
            listBox1.Enabled = true;
            panel2.Enabled = false;
            SearchB.Enabled = true;
            ClearTable();
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
            AddB.Enabled = true;
            textBox1.PasswordChar = '\0';
            textBox2.PasswordChar = '\0';
            textBox3.PasswordChar = '\0';

            if (x.Count != 0)
            {
                SearchNextB.Enabled = true;
                SearchPreviousB.Enabled = true;
            }     
        }

        private void ConfirmButtonTLO_Click(object sender, EventArgs e)
        {
            switch (Choice)
            {
                case 1:
                    {
                        //change password
                        CheckPasswords();   
                    }
                    break;
                case 2:
                    {
                        // edit worker
                        CheckWorkerInfo();   
                        // sprawdz czy dobrze wypelnione dane
                    }
                    break;
                case 3:
                    {
                        // add worker
                        CheckWorkerInfo();
                        // sprawdz czy dobrze wypelnione dane
                    }
                    break;

                default:
                    break;
            }
        }


// BUTTONS TO EDIT LISTBOX ITEMS

        private void DeleteB_Click(object sender, EventArgs e)
        {
            string ErrorText = "";
            CustomDialog ErrorForm = null;

            // SPRAWDZAMY CZY ADMIN
            if (LoggedUser.GetRole() == true)
            {
                Worker ToCheck = listBox1.SelectedItem as Worker;
                
                if(ToCheck.Id == LoggedUser.GetId())
                {
                    ErrorText = "Are you sure you wanna delete your profile??";
                    ErrorForm = new CustomDialog(ErrorText, 2);
                    ErrorForm.ShowDialog();

                    if(ErrorForm.DialogResult == DialogResult.Yes)
                    {
                        // czy jestes pewny ze chcesz usunac swoj profil ?
                        DeleteUser(ToCheck);
//textBox8.Text = "profil admina usuniety";

                    }
                    else if(ErrorForm.DialogResult == DialogResult.No)
                    {
                        ViewNotToSave();
//textBox8.Text = "nie udalo sie usunac profilu admina";
                    }
                }
                else if(ToCheck.Id != LoggedUser.GetId())
                {
                    ErrorText = "Are you sure you wanna delete this profile??";
                    ErrorForm = new CustomDialog(ErrorText, 2);
                    ErrorForm.ShowDialog();

                    if (ErrorForm.DialogResult == DialogResult.Yes)
                    {
                        // czy jestes pewny ze chcesz usunac swoj profil ?
                        DeleteUser(ToCheck);
//textBox8.Text = "profil uzytkownika usuniety przez admina";
//////////////////////////////////////////////////////////////////////////////////////////WYLOGUJ
                    }
                    else if (ErrorForm.DialogResult == DialogResult.No)
                    {
                        ViewNotToSave();
//textBox8.Text = "nie udalo sie usunac profilu przez admina";
                    }
                }

            }
            else if(LoggedUser.GetRole() == false)
            {
                // sprawdzamy czy wybierasz siebie
                Worker CheckWhoYouAre = listBox1.SelectedItem as Worker;
                if (CheckWhoYouAre.Id == LoggedUser.GetId())
                {
                    ErrorText = "Are you sure you wanna delete your profile??";
                    ErrorForm = new CustomDialog(ErrorText, 2);
                    ErrorForm.ShowDialog();

                    if (ErrorForm.DialogResult == DialogResult.Yes)
                    {
                        // czy jestes pewny ze chcesz usunac swoj profil ?
                        
                        DeleteUser(CheckWhoYouAre);
//textBox8.Text = "profil pracownika usuniety";
//////////////////////////////////////////////////////////////////////////////////////////WYLOGUJ
                    }
                    else if (ErrorForm.DialogResult == DialogResult.No)
                    {
//textBox8.Text = "nie udalo sie usunac profilu pracownika";
                        ViewNotToSave();
                    }
                }
                else if (CheckWhoYouAre.Id != LoggedUser.GetId())
                {
                    ErrorText = "You have no power here, ha ha ha!";
                    ErrorForm = new CustomDialog(ErrorText, 1);
                    ErrorForm.ShowDialog();
                }
            }

            ViewNotToSave();
            // wyczysz search 
        }

        private void DeleteUser(Worker ToCheck)
        {
            // nalezy sprawdzic czy sa na niego rezerwacje jesli sa to mozna np przepisac na managera 
            if (contextDB.Reservation.Any(res => res.Worker_ID == ToCheck.Id))
            {
                textBox8.Text = " sa rezerwacje na ta osobe";
                // szukamy admina // lub managera innego niz obecny aby moc przepisac obecne rezerwacje
                var query = contextDB.Worker.Where(user => (user.Manager == true || user.Type == 'A') && user.Id != ToCheck.Id).FirstOrDefault();

                // zmieniamy rezerwacje
                var reservations = contextDB.Reservation.Where(res => res.Worker_ID == ToCheck.Id);
                foreach (var item in reservations)
                {
                    Reservation ResToSave = item;
                    ResToSave.Worker_ID = query.Id;
                    contextDB.SubmitChanges();
                }
                contextDB.Worker.DeleteOnSubmit(ToCheck);
            }
            else if(!contextDB.Reservation.Any(res => res.Worker_ID == ToCheck.Id))
            {
                // teraz mozna usunac osobe
                contextDB.Worker.DeleteOnSubmit(ToCheck);
            }
            contextDB.SubmitChanges();
            ClearAfterDelete();
        }

        private void ClearAfterDelete()
        {
            ViewNotToSave();
            LoadData();
            SearchTB.Clear();
            SearchStatusL.Text = "Number of results: " + Selected + "/" + x.Count;

        }

        private void ChangeB_Click(object sender, EventArgs e)
        {


            //ClearTable();
            string ErrorText = "";
            CustomDialog ErrorForm = null;


            if (LoggedUser.GetRole() == true)
            {
                SearchNextB.Enabled = false;
                SearchPreviousB.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.PasswordChar = '*';
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';

                //textBox8.Text = "Jestes Adminem";
                Choice = 1;
                ChangeView("CHANGE");
                ViewToSave();
            }
            else if (LoggedUser.GetRole() == false)
            {
                Worker CheckWhoYouAre = listBox1.SelectedItem as Worker;
                if(CheckWhoYouAre.Id == LoggedUser.GetId())
                {
                    SearchNextB.Enabled = false;
                    SearchPreviousB.Enabled = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.PasswordChar = '*';
                    textBox2.PasswordChar = '*';
                    textBox3.PasswordChar = '*';

                    Choice = 1;
                    ChangeView("CHANGE");
                    ViewToSave();
                }
                else if(CheckWhoYouAre.Id != LoggedUser.GetId())
                {
                    ErrorText = "As a user, you can change the only yourself password";
                    ErrorForm = new CustomDialog(ErrorText,1);
                    ErrorForm.ShowDialog();
                }
            }
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            string ErrorText = "";
            CustomDialog ErrorForm = null;

            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
                FillTable();
            }

            if (LoggedUser.GetRole() == true)
            {
                SearchNextB.Enabled = false;
                SearchPreviousB.Enabled = false;

                Choice = 2;
                ChangeView("EDIT");
                ViewToSave();

            }
            else if (LoggedUser.GetRole() == false)
            {
                Worker CheckWhoYouAre = listBox1.SelectedItem as Worker;
                if (CheckWhoYouAre.Id == LoggedUser.GetId())
                {
                    SearchNextB.Enabled = false;
                    SearchPreviousB.Enabled = false;

                    Choice = 2;
                    ChangeView("EDIT");
                    ViewToSave();
                }
                else if (CheckWhoYouAre.Id != LoggedUser.GetId())
                {
                    ErrorText = "As a user, you can change the only yourself information";
                    ErrorForm = new CustomDialog(ErrorText, 1);
                    ErrorForm.ShowDialog();
                }
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            string ErrorText = "";
            CustomDialog ErrorForm = null;


            if (LoggedUser.GetRole() == true)
            {
                Choice = 3;
                listBox1.SelectedIndex = -1;
                ClearTable();
                ChangeView("ADD");
                ViewToSave();
                AddB.Enabled = false;
            }
            else if (LoggedUser.GetRole() == false)
            {
                ErrorText = "As a user, you can't add new users";
                ErrorForm = new CustomDialog(ErrorText, 1);
                ErrorForm.ShowDialog();
            }
        }

// Save info to database 

        private void SaveToDB(int EditOrAdd)
        {
            string s = "";
            Worker WorkerToSave = null;
            if(EditOrAdd == 1)
            {
                // Add
                WorkerToSave = new Worker();
                contextDB.Worker.InsertOnSubmit(WorkerToSave);
                s = AccessOperation.EncryptPassword(textBox6.Text);
                WorkerToSave.UserPassword = s;
                WorkerToSave.Type = 'U';
            }
            else if(EditOrAdd == 2)
            {
                // Edit
                WorkerToSave = listBox1.SelectedItem as Worker;
            }

            WorkerToSave.FirstName = textBox1.Text;
            WorkerToSave.LastName = textBox2.Text;
            WorkerToSave.Email = textBox3.Text;
            WorkerToSave.UserLogin = textBox4.Text;
            WorkerToSave.Manager = checkBox1.Checked;

            contextDB.SubmitChanges();

            LoadData();
        }

        private void CheckWorkerInfo()
        {
            string ErrorText = "";
            CustomDialog ErrorForm = null;

            if(String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(textBox4.Text))
            {
                ErrorText = "Check that you have not left any free fields";
                ErrorForm = new CustomDialog(ErrorText, 1);
                ErrorForm.ShowDialog();            
            }
            else
            {

                //if(contextDB.Worker.Any(x => x.UserLogin == textBox4.Text))

                    if (Choice == 3)
                    {

                        if (contextDB.Worker.Any(x => x.UserLogin.Contains(textBox4.Text)))
                        {
                            textBox8.Text = "niestety istnieje juz podany login";
                            ErrorText = "There is already a given login in the database, choose another one";
                            ErrorForm = new CustomDialog(ErrorText, 1);
                            ErrorForm.ShowDialog();
                        }
                        else
                        {
                            if (textBox6.Text != textBox7.Text)
                            {
                                ErrorText = "The given passwords do not match";
                                ErrorForm = new CustomDialog(ErrorText, 1);
                                ErrorForm.ShowDialog();
                            }
                            else
                            {
                                // dodaj nowego
                                SaveToDB(1);
                                ViewNotToSave();
                            if (x.Count != 0)
                            {
                                SearchNextB.Enabled = true;
                                SearchPreviousB.Enabled = true;
                            }
                        }
                        }
                    }
                    else if(Choice == 2)
                    {

                        Worker WhoYouAre = listBox1.SelectedItem as Worker;
                        if (contextDB.Worker.Any(x => x.UserLogin.Contains(textBox4.Text) && x.UserLogin != WhoYouAre.UserLogin))
                        {
//textBox8.Text = "niestety istnieje juz podany login";
                            ErrorText = "There is already a given login in the database, choose another one";
                            ErrorForm = new CustomDialog(ErrorText, 1);
                            ErrorForm.ShowDialog();
                        }
                        else
                        {
                            // edytuj starego
                            SaveToDB(2);
                            ViewNotToSave();
                            if (x.Count != 0)
                            {
                                SearchNextB.Enabled = true;
                                SearchPreviousB.Enabled = true;
                            }

                        }
                    }
                
            }
        }

        private void CheckPasswords()
        {

            if(Choice == 1)
            {
                string s = "";
                string g = "";
                string ErrorText = "";
                CustomDialog ErrorForm = null;

                if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
                {
                    ErrorText = "Make sure you fill in all the fields";
                    ErrorForm = new CustomDialog(ErrorText, 1);
                    ErrorForm.ShowDialog();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    // sprawdz czy podane haslo jest takie samo jak w bazie danych

                        Worker WorkerToSave = listBox1.SelectedItem as Worker;
                        s = AccessOperation.EncryptPassword(textBox1.Text);
                        var usr = contextDB.Worker.Where(c => c.UserLogin == WorkerToSave.UserLogin && c.UserPassword == s).SingleOrDefault();

                        if (usr != null)
                        {
                            if (textBox2.Text != textBox3.Text || textBox2.Text == textBox1.Text)
                            {
                                ErrorText = "Check if your new password was entered correctly 2 times and if it differs from the old one";
                                ErrorForm = new CustomDialog(ErrorText, 1);
                                ErrorForm.ShowDialog();

                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();

                            }
                            else if(textBox2.Text != textBox1.Text && textBox2.Text == textBox3.Text)
                            {
                                g = AccessOperation.EncryptPassword(textBox2.Text);        
                                WorkerToSave.UserPassword = g;
                                contextDB.SubmitChanges();

                            if (x.Count != 0)
                            {
                                SearchNextB.Enabled = true;
                                SearchPreviousB.Enabled = true;
                            }
                            textBox1.PasswordChar = '\0';
                            textBox2.PasswordChar = '\0';
                            textBox3.PasswordChar = '\0';
                            ViewNotToSave();
                            }
                        }
                        else
                        {
                            ErrorText = "To change the password you must enter the correct one first";
                            ErrorForm = new CustomDialog(ErrorText, 1);
                            ErrorForm.ShowDialog();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                        }
                }
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            x = new List<int>();
            Selected = 0;



            if(string.IsNullOrWhiteSpace(SearchTB.Text))
            {

            }
            else if (!string.IsNullOrWhiteSpace(SearchTB.Text))
            {
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox1.Items[i].ToString().ToLower().StartsWith(SearchTB.Text.ToLower()))
                    {
                        x.Add(i);
                    }
                }
            }

            if (x.Count == 0)
            {
                SearchNextB.Enabled = false;
                SearchPreviousB.Enabled = false;
                SearchStatusL.Text = "Number of results: " + Selected + "/" + x.Count;
            }
            else if (x.Count > 0)
            {
                listBox1.SetSelected(x[Selected], true);
                SearchStatusL.Text = "Number of results: " + (Selected + 1).ToString() + "/" + x.Count;
                SearchNextB.Enabled = true;
                SearchPreviousB.Enabled = true;
            }
        }

        private void SearchNextB_Click(object sender, EventArgs e)
        {
            if(Selected < x.Count -1)
            {
                Selected += 1;
                listBox1.SelectedIndex = x[Selected];
                SearchStatusL.Text = "Number of results: " + (Selected + 1).ToString() + "/" + x.Count;
            }
        }

        private void SearchPreviousB_Click(object sender, EventArgs e)
        {
            if(Selected > 0)
            {
                Selected -= 1;
                listBox1.SelectedIndex = x[Selected];
                SearchStatusL.Text = "Number of results: " + (Selected + 1).ToString() + "/" + x.Count;
            }
        }
    }
}
