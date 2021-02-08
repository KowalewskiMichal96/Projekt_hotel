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
    public partial class LogIn : Form
    {
        readonly databaseHotelDataContext contextDC = new databaseHotelDataContext();
        bool isLogging = true;
        public User user = new User();

        public LogIn()
        {
            InitializeComponent();
        }



// logowanie do konta z bazy danych
        private void Button_Accept_Click(object sender, EventArgs e)
        {
            if(isLogging == true)
            {
                LoginToApp();
            }
            else if(isLogging == false)
            {
                if (CheckData == true)
                    CreateUser();
            }
        }

        bool CheckData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(textbox_1.Text) ||
                    string.IsNullOrWhiteSpace(textbox_2.Text) ||
                    string.IsNullOrWhiteSpace(textbox_3.Text) ||
                    string.IsNullOrWhiteSpace(textbox_4.Text))
                {
                    labelError.Text = "MISTAKE IN NAME OR BLANK";
                    labelError.Visible = true;
                }
                else if (textbox_5.Text != textbox_6.Text ||
                    string.IsNullOrWhiteSpace(textbox_5.Text))
                {
                    labelError.Text = "MAKE SURE YOU ENTERED THE PASSWORD CORRECTLY";
                    labelError.Visible = true;
                }
                else
                {
                    // Is there already such a user
                    bool exist = (from worker in contextDC.Worker
                                  where worker.UserLogin == textbox_4.Text
                                  select worker)
                                  .Any();

                    if (exist == false)
                    {
                        return true;
                    }
                    else if (exist == true)
                    {
                        labelError.Text = "A USER WITH THAT NAME ALREADY EXSIST";
                        labelError.Visible = true;
                    }
                }
                return false;
            }
        }

        private void CreateUser()
        {
            string s = AccessOperation.EncryptPassword(textbox_5.Text);

            Worker newWorker = new Worker()
            {
                FirstName = textbox_1.Text,
                LastName = textbox_2.Text,
                Email = textbox_3.Text,
                Manager = false,
                UserLogin = textbox_4.Text,
                UserPassword = s,
                Type = 'U'
            };

            contextDC.Worker.InsertOnSubmit(newWorker);
            contextDC.SubmitChanges();

            string info = "Registration Successfully";
            CustomDialog RegistrationSucessfully = new CustomDialog(info, 1);
            RegistrationSucessfully.ShowDialog();

            ChangeFunction();
        }

        private void LoginToApp()
        {
            try
            {
                // check password
                string s;
                s = AccessOperation.EncryptPassword(textbox_2.Text);
                var usr = contextDC.Worker.Where(c => c.UserLogin == textbox_1.Text && c.UserPassword == s).Single();

                if (usr != null)
                {
                    int x = 0;
                    char z = 'U';


                    //var query = from worker in contextDC.Worker
                    //            where worker.UserLogin.Equals(textbox_1.Text)
                    //            select new
                    //            {
                    //                worker.Id,
                    //                worker.Type
                    //            };
                    x = usr.Id;
                    z = usr.Type;
                    //foreach (var item in query)
                    //{
                    //    x = item.Id;
                    //    z = item.Type;
                    //}

                    //User user = new User();
                    user.SetRole(x, z);


                    ClearButtons();

                    MainMenu mm = new MainMenu(user);
                    mm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                ClearButtons();

                string error = "Username or Password is invaild !\nPlease try again.";
                CustomDialog Error = new CustomDialog(error, 1);
                Error.ShowDialog();

            }
        }


        void ClearButtons()
        {
            textbox_1.Clear();
            textbox_2.Clear();
            textbox_3.Clear();
            textbox_4.Clear();
            textbox_5.Clear();
            textbox_6.Clear();
        }
        private void ChangeFunction()
        {
            // change the panel appearance depending on the active mode
            ClearButtons();
            labelError.Visible = false;

            if (isLogging == true)
            {
                isLogging = false;

                label_1.Text = "First Name";
                label_2.Text = "Last Name";
                Button_Change.Text = "Cancel";
                Button_Accept.Text = "Register";
                label_Title.Text = "User Registration";


                label_3.Visible = true;
                label_4.Visible = true;
                label_5.Visible = true;
                label_6.Visible = true;
                textbox_2.PasswordChar = '\0';

                textbox_3.Visible = true;
                textbox_4.Visible = true;
                textbox_5.Visible = true;
                textbox_6.Visible = true;
            }
            else if (isLogging == false)
            {
                isLogging = true;

                label_1.Text = "Login";
                label_2.Text = "Password";
                Button_Change.Text = "Register";
                Button_Accept.Text = "Log In";
                label_Title.Text = "User Login";

                label_3.Visible = false;
                label_4.Visible = false;
                label_5.Visible = false;
                label_6.Visible = false;

                textbox_2.PasswordChar = '*';
                textbox_3.Visible = false;
                textbox_4.Visible = false;
                textbox_5.Visible = false;
                textbox_6.Visible = false;
            }
        }
        private void Button_Change_Click(object sender, EventArgs e)
        {
            ChangeFunction();
        }
        private void textbox_1_Enter(object sender, EventArgs e)
        {
            if (labelError.Visible == true)
                labelError.Visible = false;
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
