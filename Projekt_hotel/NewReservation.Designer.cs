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
            this.PayerListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNGB = new System.Windows.Forms.Button();
            this.GuestLB = new System.Windows.Forms.ListBox();
            this.AddNPB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomLB = new System.Windows.Forms.ListBox();
            this.RoomSelectedLB = new System.Windows.Forms.ListBox();
            this.SelectRoom = new System.Windows.Forms.Button();
            this.ReturnRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GuestSelectedLB = new System.Windows.Forms.ListBox();
            this.SelectGuest = new System.Windows.Forms.Button();
            this.ReturnGuest = new System.Windows.Forms.Button();
            this.labelSameRoom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditPB = new System.Windows.Forms.Button();
            this.EditGB = new System.Windows.Forms.Button();
            this.DeletePB = new System.Windows.Forms.Button();
            this.DeleteGB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayerListBox
            // 
            this.PayerListBox.BackColor = System.Drawing.Color.White;
            this.PayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayerListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PayerListBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.PayerListBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PayerListBox.FormattingEnabled = true;
            this.PayerListBox.ItemHeight = 18;
            this.PayerListBox.Location = new System.Drawing.Point(847, 632);
            this.PayerListBox.Name = "PayerListBox";
            this.PayerListBox.ScrollAlwaysVisible = true;
            this.PayerListBox.Size = new System.Drawing.Size(375, 236);
            this.PayerListBox.TabIndex = 8;
            this.PayerListBox.TabStop = false;
            this.PayerListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(845, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(845, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guests";
            // 
            // AddNGB
            // 
            this.AddNGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AddNGB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.AddNGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.AddNGB.Location = new System.Drawing.Point(739, 333);
            this.AddNGB.Name = "AddNGB";
            this.AddNGB.Size = new System.Drawing.Size(100, 63);
            this.AddNGB.TabIndex = 10;
            this.AddNGB.Text = "Add";
            this.AddNGB.UseVisualStyleBackColor = false;
            // 
            // GuestLB
            // 
            this.GuestLB.BackColor = System.Drawing.Color.White;
            this.GuestLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuestLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GuestLB.Enabled = false;
            this.GuestLB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.GuestLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GuestLB.FormattingEnabled = true;
            this.GuestLB.ItemHeight = 18;
            this.GuestLB.Location = new System.Drawing.Point(847, 333);
            this.GuestLB.Margin = new System.Windows.Forms.Padding(5);
            this.GuestLB.Name = "GuestLB";
            this.GuestLB.ScrollAlwaysVisible = true;
            this.GuestLB.Size = new System.Drawing.Size(375, 236);
            this.GuestLB.TabIndex = 6;
            this.GuestLB.TabStop = false;
            this.GuestLB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.GuestLB.SelectedIndexChanged += new System.EventHandler(this.GuestLB_SelectedIndexChanged);
            // 
            // AddNPB
            // 
            this.AddNPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AddNPB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.AddNPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.AddNPB.Location = new System.Drawing.Point(741, 632);
            this.AddNPB.Name = "AddNPB";
            this.AddNPB.Size = new System.Drawing.Size(100, 63);
            this.AddNPB.TabIndex = 11;
            this.AddNPB.Text = "Add";
            this.AddNPB.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button3.Location = new System.Drawing.Point(1039, 902);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 86);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add New Reservation";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button4.Location = new System.Drawing.Point(768, 902);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 86);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancel ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // RoomLB
            // 
            this.RoomLB.BackColor = System.Drawing.Color.White;
            this.RoomLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomLB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.RoomLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RoomLB.FormattingEnabled = true;
            this.RoomLB.ItemHeight = 18;
            this.RoomLB.Location = new System.Drawing.Point(848, 49);
            this.RoomLB.Margin = new System.Windows.Forms.Padding(5);
            this.RoomLB.Name = "RoomLB";
            this.RoomLB.ScrollAlwaysVisible = true;
            this.RoomLB.Size = new System.Drawing.Size(375, 236);
            this.RoomLB.Sorted = true;
            this.RoomLB.TabIndex = 15;
            this.RoomLB.TabStop = false;
            this.RoomLB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.RoomLB.SelectedIndexChanged += new System.EventHandler(this.RoomLB_SelectedIndexChanged);
            // 
            // RoomSelectedLB
            // 
            this.RoomSelectedLB.BackColor = System.Drawing.Color.White;
            this.RoomSelectedLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomSelectedLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomSelectedLB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.RoomSelectedLB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RoomSelectedLB.FormattingEnabled = true;
            this.RoomSelectedLB.ItemHeight = 18;
            this.RoomSelectedLB.Location = new System.Drawing.Point(1407, 49);
            this.RoomSelectedLB.Name = "RoomSelectedLB";
            this.RoomSelectedLB.ScrollAlwaysVisible = true;
            this.RoomSelectedLB.Size = new System.Drawing.Size(375, 236);
            this.RoomSelectedLB.TabIndex = 16;
            this.RoomSelectedLB.TabStop = false;
            this.RoomSelectedLB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.RoomSelectedLB.SelectedIndexChanged += new System.EventHandler(this.RoomSelectedLB_SelectedIndexChanged);
            // 
            // SelectRoom
            // 
            this.SelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectRoom.Enabled = false;
            this.SelectRoom.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.SelectRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SelectRoom.Location = new System.Drawing.Point(1255, 86);
            this.SelectRoom.Name = "SelectRoom";
            this.SelectRoom.Size = new System.Drawing.Size(119, 65);
            this.SelectRoom.TabIndex = 17;
            this.SelectRoom.Text = "->";
            this.SelectRoom.UseVisualStyleBackColor = false;
            this.SelectRoom.Click += new System.EventHandler(this.SelectRoom_Click);
            // 
            // ReturnRoom
            // 
            this.ReturnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReturnRoom.Enabled = false;
            this.ReturnRoom.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.ReturnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ReturnRoom.Location = new System.Drawing.Point(1255, 157);
            this.ReturnRoom.Name = "ReturnRoom";
            this.ReturnRoom.Size = new System.Drawing.Size(119, 65);
            this.ReturnRoom.TabIndex = 18;
            this.ReturnRoom.Text = "<-";
            this.ReturnRoom.UseVisualStyleBackColor = false;
            this.ReturnRoom.Click += new System.EventHandler(this.ReturnRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(843, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Free Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1403, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected Rooms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1407, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selected Guests";
            // 
            // GuestSelectedLB
            // 
            this.GuestSelectedLB.BackColor = System.Drawing.Color.White;
            this.GuestSelectedLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuestSelectedLB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GuestSelectedLB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.GuestSelectedLB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.GuestSelectedLB.FormattingEnabled = true;
            this.GuestSelectedLB.ItemHeight = 18;
            this.GuestSelectedLB.Location = new System.Drawing.Point(1411, 333);
            this.GuestSelectedLB.Name = "GuestSelectedLB";
            this.GuestSelectedLB.ScrollAlwaysVisible = true;
            this.GuestSelectedLB.Size = new System.Drawing.Size(375, 236);
            this.GuestSelectedLB.TabIndex = 21;
            this.GuestSelectedLB.TabStop = false;
            this.GuestSelectedLB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.GuestSelectedLB.SelectedIndexChanged += new System.EventHandler(this.GuestSelectedLB_SelectedIndexChanged);
            // 
            // SelectGuest
            // 
            this.SelectGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectGuest.Enabled = false;
            this.SelectGuest.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.SelectGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SelectGuest.Location = new System.Drawing.Point(1255, 368);
            this.SelectGuest.Name = "SelectGuest";
            this.SelectGuest.Size = new System.Drawing.Size(119, 65);
            this.SelectGuest.TabIndex = 24;
            this.SelectGuest.Text = "->";
            this.SelectGuest.UseVisualStyleBackColor = false;
            this.SelectGuest.Click += new System.EventHandler(this.SelectGuest_Click);
            // 
            // ReturnGuest
            // 
            this.ReturnGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReturnGuest.Enabled = false;
            this.ReturnGuest.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.ReturnGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ReturnGuest.Location = new System.Drawing.Point(1255, 439);
            this.ReturnGuest.Name = "ReturnGuest";
            this.ReturnGuest.Size = new System.Drawing.Size(119, 65);
            this.ReturnGuest.TabIndex = 25;
            this.ReturnGuest.Text = "<-";
            this.ReturnGuest.UseVisualStyleBackColor = false;
            this.ReturnGuest.Click += new System.EventHandler(this.ReturnGuest_Click);
            // 
            // labelSameRoom
            // 
            this.labelSameRoom.AutoSize = true;
            this.labelSameRoom.ForeColor = System.Drawing.Color.Red;
            this.labelSameRoom.Location = new System.Drawing.Point(1292, 632);
            this.labelSameRoom.Name = "labelSameRoom";
            this.labelSameRoom.Size = new System.Drawing.Size(217, 17);
            this.labelSameRoom.TabIndex = 27;
            this.labelSameRoom.Text = "you cannot select the same room";
            this.labelSameRoom.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelType);
            this.panel2.Controls.Add(this.labelFloor);
            this.panel2.Controls.Add(this.labelMax);
            this.panel2.Controls.Add(this.labelRoomName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 651);
            this.panel2.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(29, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 316);
            this.panel4.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(208, 500);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(36, 25);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "??";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFloor.ForeColor = System.Drawing.Color.White;
            this.labelFloor.Location = new System.Drawing.Point(208, 456);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 25);
            this.labelFloor.TabIndex = 21;
            this.labelFloor.Text = "??";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMax.ForeColor = System.Drawing.Color.White;
            this.labelMax.Location = new System.Drawing.Point(208, 410);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(36, 25);
            this.labelMax.TabIndex = 20;
            this.labelMax.Text = "??";
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomName.ForeColor = System.Drawing.Color.White;
            this.labelRoomName.Location = new System.Drawing.Point(208, 31);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(36, 25);
            this.labelRoomName.TabIndex = 19;
            this.labelRoomName.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "On floor: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Maximum person:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "ABOUT ROOM";
            // 
            // TimePickerStart
            // 
            this.TimePickerStart.CalendarForeColor = System.Drawing.Color.Black;
            this.TimePickerStart.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.TimePickerStart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.TimePickerStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.TimePickerStart.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.TimePickerStart.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimePickerStart.Location = new System.Drawing.Point(98, 61);
            this.TimePickerStart.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.TimePickerStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.TimePickerStart.Name = "TimePickerStart";
            this.TimePickerStart.Size = new System.Drawing.Size(366, 28);
            this.TimePickerStart.TabIndex = 33;
            this.TimePickerStart.ValueChanged += new System.EventHandler(this.TimePickerStart_ValueChanged);
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.CalendarForeColor = System.Drawing.Color.Black;
            this.TimePickerEnd.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.TimePickerEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.TimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.TimePickerEnd.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.TimePickerEnd.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold);
            this.TimePickerEnd.Location = new System.Drawing.Point(98, 108);
            this.TimePickerEnd.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.TimePickerEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(366, 28);
            this.TimePickerEnd.TabIndex = 34;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchButton.Location = new System.Drawing.Point(98, 168);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(366, 55);
            this.SearchButton.TabIndex = 35;
            this.SearchButton.Text = "Search for rooms";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Projekt_hotel.Properties.Resources.tlo_5;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.EditPB);
            this.panel1.Controls.Add(this.EditGB);
            this.panel1.Controls.Add(this.DeletePB);
            this.panel1.Controls.Add(this.DeleteGB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.TimePickerEnd);
            this.panel1.Controls.Add(this.TimePickerStart);
            this.panel1.Controls.Add(this.labelSameRoom);
            this.panel1.Controls.Add(this.ReturnGuest);
            this.panel1.Controls.Add(this.SelectGuest);
            this.panel1.Controls.Add(this.GuestSelectedLB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ReturnRoom);
            this.panel1.Controls.Add(this.SelectRoom);
            this.panel1.Controls.Add(this.RoomSelectedLB);
            this.panel1.Controls.Add(this.RoomLB);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.AddNPB);
            this.panel1.Controls.Add(this.GuestLB);
            this.panel1.Controls.Add(this.AddNGB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PayerListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 1081);
            this.panel1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1411, 724);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 126);
            this.textBox1.TabIndex = 41;
            // 
            // EditPB
            // 
            this.EditPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EditPB.Enabled = false;
            this.EditPB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.EditPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditPB.Location = new System.Drawing.Point(741, 770);
            this.EditPB.Name = "EditPB";
            this.EditPB.Size = new System.Drawing.Size(100, 63);
            this.EditPB.TabIndex = 40;
            this.EditPB.Text = "Edit";
            this.EditPB.UseVisualStyleBackColor = false;
            // 
            // EditGB
            // 
            this.EditGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EditGB.Enabled = false;
            this.EditGB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.EditGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditGB.Location = new System.Drawing.Point(739, 471);
            this.EditGB.Name = "EditGB";
            this.EditGB.Size = new System.Drawing.Size(100, 63);
            this.EditGB.TabIndex = 39;
            this.EditGB.Text = "Edit";
            this.EditGB.UseVisualStyleBackColor = false;
            // 
            // DeletePB
            // 
            this.DeletePB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeletePB.Enabled = false;
            this.DeletePB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.DeletePB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DeletePB.Location = new System.Drawing.Point(741, 701);
            this.DeletePB.Name = "DeletePB";
            this.DeletePB.Size = new System.Drawing.Size(100, 63);
            this.DeletePB.TabIndex = 38;
            this.DeletePB.Text = "Delete";
            this.DeletePB.UseVisualStyleBackColor = false;
            // 
            // DeleteGB
            // 
            this.DeleteGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteGB.Enabled = false;
            this.DeleteGB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DeleteGB.Location = new System.Drawing.Point(739, 402);
            this.DeleteGB.Name = "DeleteGB";
            this.DeleteGB.Size = new System.Drawing.Size(100, 63);
            this.DeleteGB.TabIndex = 37;
            this.DeleteGB.Text = "Delete";
            this.DeleteGB.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(62, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 657);
            this.panel3.TabIndex = 36;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1918, 1081);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewReservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PayerListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddNGB;
        private System.Windows.Forms.ListBox GuestLB;
        private System.Windows.Forms.Button AddNPB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox RoomLB;
        private System.Windows.Forms.ListBox RoomSelectedLB;
        private System.Windows.Forms.Button SelectRoom;
        private System.Windows.Forms.Button ReturnRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox GuestSelectedLB;
        private System.Windows.Forms.Button SelectGuest;
        private System.Windows.Forms.Button ReturnGuest;
        private System.Windows.Forms.Label labelSameRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker TimePickerStart;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeletePB;
        private System.Windows.Forms.Button DeleteGB;
        private System.Windows.Forms.Button EditPB;
        private System.Windows.Forms.Button EditGB;
        private System.Windows.Forms.TextBox textBox1;
    }
}