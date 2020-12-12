namespace Projekt_hotel
{
    partial class LogIn
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelRegisterError = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button_register_new_user = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.password_text);
            this.panel1.Controls.Add(this.login_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(313, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 555);
            this.panel1.TabIndex = 0;
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.button_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button_register.Location = new System.Drawing.Point(101, 394);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(228, 99);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "REGISTER";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(143, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "You do not have an account ?";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(372, 345);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(253, 17);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "WRONG PASSWORD OR USER NAME";
            this.labelError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(132, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LOGIN";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.button_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button_login.Location = new System.Drawing.Point(391, 394);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(234, 99);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "LOG IN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // password_text
            // 
            this.password_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.password_text.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.password_text.Location = new System.Drawing.Point(401, 228);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(203, 43);
            this.password_text.TabIndex = 2;
            this.password_text.WordWrap = false;
            // 
            // login_text
            // 
            this.login_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.login_text.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_text.Location = new System.Drawing.Point(401, 160);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(203, 43);
            this.login_text.TabIndex = 1;
            this.login_text.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(285, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(323, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Lato", 36F, System.Drawing.FontStyle.Bold);
            this.button_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_exit.Location = new System.Drawing.Point(1828, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 80);
            this.button_exit.TabIndex = 1;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.labelRegisterError);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.labelConfirmPassword);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelLastName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.button_register_new_user);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.labelFirstName);
            this.panel2.Location = new System.Drawing.Point(310, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 552);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button1.Location = new System.Drawing.Point(81, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 72);
            this.button1.TabIndex = 23;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(626, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(626, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(626, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // labelRegisterError
            // 
            this.labelRegisterError.AutoSize = true;
            this.labelRegisterError.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisterError.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.labelRegisterError.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterError.Location = new System.Drawing.Point(199, 400);
            this.labelRegisterError.Name = "labelRegisterError";
            this.labelRegisterError.Size = new System.Drawing.Size(301, 17);
            this.labelRegisterError.TabIndex = 19;
            this.labelRegisterError.Text = "THE PASSWORD IS DIFFERENT FROM ITSELF";
            this.labelRegisterError.Visible = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtConfirmPassword.Location = new System.Drawing.Point(417, 316);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(203, 43);
            this.txtConfirmPassword.TabIndex = 18;
            this.txtConfirmPassword.TabStop = false;
            this.txtConfirmPassword.WordWrap = false;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelConfirmPassword.Location = new System.Drawing.Point(413, 289);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(171, 24);
            this.labelConfirmPassword.TabIndex = 17;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelPassword.Location = new System.Drawing.Point(413, 211);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 24);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelUsername.Location = new System.Drawing.Point(413, 127);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 24);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelEmail.Location = new System.Drawing.Point(93, 290);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 24);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelLastName.Location = new System.Drawing.Point(96, 208);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(104, 24);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "Last Name";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtPassword.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(417, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(203, 43);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TabStop = false;
            this.txtPassword.WordWrap = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtUsername.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(417, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 43);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.TabStop = false;
            this.txtUsername.WordWrap = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtEmail.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(97, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 43);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TabStop = false;
            this.txtEmail.WordWrap = false;
            // 
            // button_register_new_user
            // 
            this.button_register_new_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_register_new_user.FlatAppearance.BorderSize = 0;
            this.button_register_new_user.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.button_register_new_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button_register_new_user.Location = new System.Drawing.Point(398, 437);
            this.button_register_new_user.Name = "button_register_new_user";
            this.button_register_new_user.Size = new System.Drawing.Size(250, 72);
            this.button_register_new_user.TabIndex = 9;
            this.button_register_new_user.Text = "REGISTER";
            this.button_register_new_user.UseVisualStyleBackColor = false;
            this.button_register_new_user.Click += new System.EventHandler(this.button_register_new_user_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lato", 40F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(86, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 80);
            this.label7.TabIndex = 0;
            this.label7.Text = "REGISTRATION";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtLastName.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(97, 235);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 43);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TabStop = false;
            this.txtLastName.WordWrap = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.txtFirstName.Font = new System.Drawing.Font("Lato Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(97, 156);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 43);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TabStop = false;
            this.txtFirstName.WordWrap = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelFirstName.Location = new System.Drawing.Point(96, 129);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(107, 24);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelRegisterError;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button_register_new_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button button1;
    }
}

