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
        databaseHotelDataContext contextDC = new databaseHotelDataContext();
        public LogIn()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(155, Color.Black);
            panel2.BackColor = Color.FromArgb(155, Color.Black);



        }

// interakcje z przyciskiem exit
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            button_exit.FlatAppearance.BorderSize = 2;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            button_exit.FlatAppearance.BorderSize = 0;
        }


// logowanie do konta z bazy danych
        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                // sprawdzanie hasla 

                string s;
                s = AccessOperation.EncryptPassword(password_text.Text);
                var usr = contextDC.Worker.Where(c => c.UserLogin == login_text.Text && c.UserPassword == s).Single();

                if(usr != null)
                {
                    MainMenu mm = new MainMenu();
                    mm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                login_text.Clear();
                password_text.Clear();

                MessageBox.Show("Username or Password is invaild !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (login_text.Text == "qwerty" && password_text.Text == "qwerty")
            {
                labelError.Visible = false;
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.Show();
            }
            else
            {
                labelError.Visible = true;

            }*/
        }

// przejscie do okna rejestracji
        private void button_register_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

// rejestracja uzytkownika do bazy danych za pomoca przycisku w oknie nr2
        private void button_register_new_user_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text)  || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                labelRegisterError.Text = "MISTAKE IN NAME OR BLANK";
                labelRegisterError.Visible = true;
            }
            else if(txtPassword.Text != txtConfirmPassword.Text || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                labelRegisterError.Text = "MAKE SURE YOU ENTERED THE PASSWORD CORRECTLY";
                labelRegisterError.Visible = true;
            }
            else
            {
                // szyfrowanie 

                string s;
                s = AccessOperation.EncryptPassword(txtPassword.Text);
                // przekazanie danych do bazy danych
                Worker newWorker = new Worker()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Manager = false,
                    UserLogin = txtUsername.Text,
                    UserPassword = s,
                    Type = 'U'
                };

                contextDC.Worker.InsertOnSubmit(newWorker);
                contextDC.SubmitChanges();


                MessageBox.Show("Registration Successfully", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel2.Visible = false;
                panel1.Visible = true;
            }
            
        }
    }
}
