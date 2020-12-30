namespace Projekt_hotel
{
    partial class NewReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GuestListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayerListBox = new System.Windows.Forms.ListBox();
            this.AddNewGuestButton = new System.Windows.Forms.Button();
            this.AddNewPayerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSameRoom = new System.Windows.Forms.Label();
            this.GuestToLeft = new System.Windows.Forms.Button();
            this.GuestToRight = new System.Windows.Forms.Button();
            this.GuestSelectedListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomToLeft = new System.Windows.Forms.Button();
            this.RoomToRight = new System.Windows.Forms.Button();
            this.RoomSelectedListBox = new System.Windows.Forms.ListBox();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestListBox
            // 
            this.GuestListBox.Enabled = false;
            this.GuestListBox.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestListBox.FormattingEnabled = true;
            this.GuestListBox.ItemHeight = 18;
            this.GuestListBox.Location = new System.Drawing.Point(732, 302);
            this.GuestListBox.Name = "GuestListBox";
            this.GuestListBox.Size = new System.Drawing.Size(230, 202);
            this.GuestListBox.TabIndex = 6;
            this.GuestListBox.SelectedIndexChanged += new System.EventHandler(this.GuestListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Guests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Payer";
            // 
            // PayerListBox
            // 
            this.PayerListBox.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.PayerListBox.FormattingEnabled = true;
            this.PayerListBox.ItemHeight = 18;
            this.PayerListBox.Location = new System.Drawing.Point(732, 533);
            this.PayerListBox.Name = "PayerListBox";
            this.PayerListBox.Size = new System.Drawing.Size(230, 202);
            this.PayerListBox.TabIndex = 8;
            // 
            // AddNewGuestButton
            // 
            this.AddNewGuestButton.Location = new System.Drawing.Point(473, 302);
            this.AddNewGuestButton.Name = "AddNewGuestButton";
            this.AddNewGuestButton.Size = new System.Drawing.Size(230, 55);
            this.AddNewGuestButton.TabIndex = 10;
            this.AddNewGuestButton.Text = "Add New Guest";
            this.AddNewGuestButton.UseVisualStyleBackColor = true;
            // 
            // AddNewPayerButton
            // 
            this.AddNewPayerButton.Location = new System.Drawing.Point(473, 533);
            this.AddNewPayerButton.Name = "AddNewPayerButton";
            this.AddNewPayerButton.Size = new System.Drawing.Size(230, 55);
            this.AddNewPayerButton.TabIndex = 11;
            this.AddNewPayerButton.Text = "Add New Payer";
            this.AddNewPayerButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1057, 741);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 86);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add New Reservation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(786, 741);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 86);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancel ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelSameRoom);
            this.panel1.Controls.Add(this.GuestToLeft);
            this.panel1.Controls.Add(this.GuestToRight);
            this.panel1.Controls.Add(this.GuestSelectedListBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RoomToLeft);
            this.panel1.Controls.Add(this.RoomToRight);
            this.panel1.Controls.Add(this.RoomSelectedListBox);
            this.panel1.Controls.Add(this.RoomListBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.AddNewPayerButton);
            this.panel1.Controls.Add(this.GuestListBox);
            this.panel1.Controls.Add(this.AddNewGuestButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PayerListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 847);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "Search for rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(453, 157);
            this.dateTimePicker2.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 98);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelType);
            this.panel2.Controls.Add(this.labelFloor);
            this.panel2.Controls.Add(this.labelMax);
            this.panel2.Controls.Add(this.labelRoomName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 794);
            this.panel2.TabIndex = 32;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(198, 500);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 25);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "??";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFloor.Location = new System.Drawing.Point(198, 456);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(34, 25);
            this.labelFloor.TabIndex = 21;
            this.labelFloor.Text = "??";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMax.Location = new System.Drawing.Point(198, 410);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(34, 25);
            this.labelMax.TabIndex = 20;
            this.labelMax.Text = "??";
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomName.Location = new System.Drawing.Point(338, 31);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(34, 25);
            this.labelRoomName.TabIndex = 19;
            this.labelRoomName.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(26, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(24, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "On floor: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(24, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Maximum person:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(26, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "ABOUT ROOM";
            // 
            // labelSameRoom
            // 
            this.labelSameRoom.AutoSize = true;
            this.labelSameRoom.ForeColor = System.Drawing.Color.Red;
            this.labelSameRoom.Location = new System.Drawing.Point(728, 9);
            this.labelSameRoom.Name = "labelSameRoom";
            this.labelSameRoom.Size = new System.Drawing.Size(217, 17);
            this.labelSameRoom.TabIndex = 27;
            this.labelSameRoom.Text = "you cannot select the same room";
            this.labelSameRoom.Visible = false;
            // 
            // GuestToLeft
            // 
            this.GuestToLeft.Enabled = false;
            this.GuestToLeft.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.GuestToLeft.Location = new System.Drawing.Point(995, 419);
            this.GuestToLeft.Name = "GuestToLeft";
            this.GuestToLeft.Size = new System.Drawing.Size(119, 65);
            this.GuestToLeft.TabIndex = 25;
            this.GuestToLeft.Text = "<-";
            this.GuestToLeft.UseVisualStyleBackColor = true;
            this.GuestToLeft.Click += new System.EventHandler(this.GuestToLeft_Click);
            // 
            // GuestToRight
            // 
            this.GuestToRight.Enabled = false;
            this.GuestToRight.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestToRight.Location = new System.Drawing.Point(995, 348);
            this.GuestToRight.Name = "GuestToRight";
            this.GuestToRight.Size = new System.Drawing.Size(119, 65);
            this.GuestToRight.TabIndex = 24;
            this.GuestToRight.Text = "->";
            this.GuestToRight.UseVisualStyleBackColor = true;
            this.GuestToRight.Click += new System.EventHandler(this.GuestToRight_Click);
            // 
            // GuestSelectedListBox
            // 
            this.GuestSelectedListBox.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestSelectedListBox.FormattingEnabled = true;
            this.GuestSelectedListBox.ItemHeight = 18;
            this.GuestSelectedListBox.Location = new System.Drawing.Point(1144, 302);
            this.GuestSelectedListBox.Name = "GuestSelectedListBox";
            this.GuestSelectedListBox.Size = new System.Drawing.Size(230, 202);
            this.GuestSelectedListBox.TabIndex = 21;
            this.GuestSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.GuestSelectedListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1141, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selected Guests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1141, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select Rooms";
            // 
            // RoomToLeft
            // 
            this.RoomToLeft.Enabled = false;
            this.RoomToLeft.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.RoomToLeft.Location = new System.Drawing.Point(995, 157);
            this.RoomToLeft.Name = "RoomToLeft";
            this.RoomToLeft.Size = new System.Drawing.Size(119, 65);
            this.RoomToLeft.TabIndex = 18;
            this.RoomToLeft.Text = "<-";
            this.RoomToLeft.UseVisualStyleBackColor = true;
            this.RoomToLeft.Click += new System.EventHandler(this.RoomToLeft_Click);
            // 
            // RoomToRight
            // 
            this.RoomToRight.Enabled = false;
            this.RoomToRight.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoomToRight.Location = new System.Drawing.Point(995, 86);
            this.RoomToRight.Name = "RoomToRight";
            this.RoomToRight.Size = new System.Drawing.Size(119, 65);
            this.RoomToRight.TabIndex = 17;
            this.RoomToRight.Text = "->";
            this.RoomToRight.UseVisualStyleBackColor = true;
            this.RoomToRight.Click += new System.EventHandler(this.RoomToRight_Click);
            // 
            // RoomSelectedListBox
            // 
            this.RoomSelectedListBox.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.RoomSelectedListBox.FormattingEnabled = true;
            this.RoomSelectedListBox.ItemHeight = 18;
            this.RoomSelectedListBox.Location = new System.Drawing.Point(1144, 67);
            this.RoomSelectedListBox.Name = "RoomSelectedListBox";
            this.RoomSelectedListBox.Size = new System.Drawing.Size(230, 202);
            this.RoomSelectedListBox.TabIndex = 16;
            this.RoomSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.RoomSelectedListBox_SelectedIndexChanged);
            // 
            // RoomListBox
            // 
            this.RoomListBox.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 18;
            this.RoomListBox.Location = new System.Drawing.Point(732, 67);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(230, 202);
            this.RoomListBox.TabIndex = 15;
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            this.RoomListBox.Leave += new System.EventHandler(this.RoomListBox_Leave);
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1410, 847);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewReservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox GuestListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox PayerListBox;
        private System.Windows.Forms.Button AddNewGuestButton;
        private System.Windows.Forms.Button AddNewPayerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RoomToLeft;
        private System.Windows.Forms.Button RoomToRight;
        private System.Windows.Forms.ListBox RoomSelectedListBox;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Button GuestToLeft;
        private System.Windows.Forms.Button GuestToRight;
        private System.Windows.Forms.ListBox GuestSelectedListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSameRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}