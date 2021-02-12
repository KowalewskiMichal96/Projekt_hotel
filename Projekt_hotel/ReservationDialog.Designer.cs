namespace Projekt_hotel
{
    partial class ReservationDialog
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
            this.Panel_Reservation = new System.Windows.Forms.Panel();
            this.SelectGuest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.searchButton = new System.Windows.Forms.Button();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ReservationConfirmButton = new System.Windows.Forms.Button();
            this.EditGuest = new System.Windows.Forms.Button();
            this.DeleteGuest = new System.Windows.Forms.Button();
            this.guestsListbox = new System.Windows.Forms.ListBox();
            this.AddGuest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelResOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnRoom = new System.Windows.Forms.Button();
            this.SelectRoom = new System.Windows.Forms.Button();
            this.roomsSelectedListbox = new System.Windows.Forms.ListBox();
            this.roomsListbox = new System.Windows.Forms.ListBox();
            this.Panel_Guest = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLP = new System.Windows.Forms.TableLayoutPanel();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.LabelText3 = new System.Windows.Forms.Label();
            this.LabelText2 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.LabelText4 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.LabelText5 = new System.Windows.Forms.Label();
            this.LabelText1 = new System.Windows.Forms.Label();
            this.LabelEditPerson = new System.Windows.Forms.Label();
            this.TPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TBClose = new System.Windows.Forms.Button();
            this.TBConfirm = new System.Windows.Forms.Button();
            this.Panel_Reservation.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Panel_Guest.SuspendLayout();
            this.TableLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Reservation
            // 
            this.Panel_Reservation.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Reservation.Controls.Add(this.SelectGuest);
            this.Panel_Reservation.Controls.Add(this.panel3);
            this.Panel_Reservation.Controls.Add(this.searchButton);
            this.Panel_Reservation.Controls.Add(this.timePickerEnd);
            this.Panel_Reservation.Controls.Add(this.timePickerStart);
            this.Panel_Reservation.Controls.Add(this.cancelButton);
            this.Panel_Reservation.Controls.Add(this.ReservationConfirmButton);
            this.Panel_Reservation.Controls.Add(this.EditGuest);
            this.Panel_Reservation.Controls.Add(this.DeleteGuest);
            this.Panel_Reservation.Controls.Add(this.guestsListbox);
            this.Panel_Reservation.Controls.Add(this.AddGuest);
            this.Panel_Reservation.Controls.Add(this.label3);
            this.Panel_Reservation.Controls.Add(this.panel5);
            this.Panel_Reservation.Controls.Add(this.label1);
            this.Panel_Reservation.Controls.Add(this.label6);
            this.Panel_Reservation.Controls.Add(this.label5);
            this.Panel_Reservation.Controls.Add(this.ReturnRoom);
            this.Panel_Reservation.Controls.Add(this.SelectRoom);
            this.Panel_Reservation.Controls.Add(this.roomsSelectedListbox);
            this.Panel_Reservation.Controls.Add(this.roomsListbox);
            this.Panel_Reservation.Location = new System.Drawing.Point(40, 12);
            this.Panel_Reservation.Name = "Panel_Reservation";
            this.Panel_Reservation.Size = new System.Drawing.Size(1865, 1004);
            this.Panel_Reservation.TabIndex = 0;
            // 
            // SelectGuest
            // 
            this.SelectGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectGuest.Enabled = false;
            this.SelectGuest.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.SelectGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SelectGuest.Location = new System.Drawing.Point(1105, 479);
            this.SelectGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectGuest.Name = "SelectGuest";
            this.SelectGuest.Size = new System.Drawing.Size(100, 63);
            this.SelectGuest.TabIndex = 61;
            this.SelectGuest.Tag = "1";
            this.SelectGuest.Text = "Select";
            this.SelectGuest.UseVisualStyleBackColor = false;
            this.SelectGuest.Click += new System.EventHandler(this.SelectGuest_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(28, 277);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 657);
            this.panel3.TabIndex = 60;
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
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 651);
            this.panel2.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(29, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 316);
            this.panel4.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelFloor.Location = new System.Drawing.Point(208, 455);
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
            this.label11.Location = new System.Drawing.Point(27, 500);
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
            this.label10.Location = new System.Drawing.Point(24, 455);
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
            this.label8.Location = new System.Drawing.Point(27, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "ABOUT ROOM";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.searchButton.Location = new System.Drawing.Point(66, 142);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(365, 55);
            this.searchButton.TabIndex = 59;
            this.searchButton.Text = "Search for rooms";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.CalendarForeColor = System.Drawing.Color.Black;
            this.timePickerEnd.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.timePickerEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.timePickerEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.timePickerEnd.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.timePickerEnd.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold);
            this.timePickerEnd.Location = new System.Drawing.Point(66, 83);
            this.timePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerEnd.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timePickerEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(367, 28);
            this.timePickerEnd.TabIndex = 58;
            // 
            // timePickerStart
            // 
            this.timePickerStart.CalendarForeColor = System.Drawing.Color.Black;
            this.timePickerStart.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.timePickerStart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.timePickerStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.timePickerStart.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.timePickerStart.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timePickerStart.Location = new System.Drawing.Point(66, 37);
            this.timePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerStart.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.timePickerStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(367, 28);
            this.timePickerStart.TabIndex = 57;
            this.timePickerStart.ValueChanged += new System.EventHandler(this.TimePickerStart_ValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.cancelButton.Location = new System.Drawing.Point(589, 897);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(265, 86);
            this.cancelButton.TabIndex = 56;
            this.cancelButton.Text = "Cancel ";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ReservationConfirmButton
            // 
            this.ReservationConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReservationConfirmButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.ReservationConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ReservationConfirmButton.Location = new System.Drawing.Point(860, 897);
            this.ReservationConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationConfirmButton.Name = "ReservationConfirmButton";
            this.ReservationConfirmButton.Size = new System.Drawing.Size(265, 86);
            this.ReservationConfirmButton.TabIndex = 55;
            this.ReservationConfirmButton.Text = "Reservation Confirm";
            this.ReservationConfirmButton.UseVisualStyleBackColor = false;
            this.ReservationConfirmButton.Click += new System.EventHandler(this.ReservationConfirmButton_Click);
            // 
            // EditGuest
            // 
            this.EditGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EditGuest.Enabled = false;
            this.EditGuest.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.EditGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditGuest.Location = new System.Drawing.Point(589, 546);
            this.EditGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditGuest.Name = "EditGuest";
            this.EditGuest.Size = new System.Drawing.Size(100, 63);
            this.EditGuest.TabIndex = 54;
            this.EditGuest.Tag = "3";
            this.EditGuest.Text = "Edit";
            this.EditGuest.UseVisualStyleBackColor = false;
            this.EditGuest.Click += new System.EventHandler(this.EditGuest_Click);
            // 
            // DeleteGuest
            // 
            this.DeleteGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteGuest.Enabled = false;
            this.DeleteGuest.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DeleteGuest.Location = new System.Drawing.Point(589, 480);
            this.DeleteGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteGuest.Name = "DeleteGuest";
            this.DeleteGuest.Size = new System.Drawing.Size(100, 63);
            this.DeleteGuest.TabIndex = 53;
            this.DeleteGuest.Tag = "2";
            this.DeleteGuest.Text = "Delete";
            this.DeleteGuest.UseVisualStyleBackColor = false;
            this.DeleteGuest.Click += new System.EventHandler(this.DeleteGuest_Click);
            // 
            // guestsListbox
            // 
            this.guestsListbox.BackColor = System.Drawing.Color.White;
            this.guestsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestsListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guestsListbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.guestsListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guestsListbox.FormattingEnabled = true;
            this.guestsListbox.ItemHeight = 18;
            this.guestsListbox.Location = new System.Drawing.Point(697, 413);
            this.guestsListbox.Margin = new System.Windows.Forms.Padding(5);
            this.guestsListbox.Name = "guestsListbox";
            this.guestsListbox.ScrollAlwaysVisible = true;
            this.guestsListbox.Size = new System.Drawing.Size(375, 290);
            this.guestsListbox.TabIndex = 50;
            this.guestsListbox.TabStop = false;
            this.guestsListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.guestsListbox.SelectedIndexChanged += new System.EventHandler(this.guestsListbox_SelectedIndexChanged);
            // 
            // AddGuest
            // 
            this.AddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AddGuest.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.AddGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.AddGuest.Location = new System.Drawing.Point(589, 413);
            this.AddGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddGuest.Name = "AddGuest";
            this.AddGuest.Size = new System.Drawing.Size(100, 63);
            this.AddGuest.TabIndex = 52;
            this.AddGuest.Tag = "1";
            this.AddGuest.Text = "Add";
            this.AddGuest.UseVisualStyleBackColor = false;
            this.AddGuest.Click += new System.EventHandler(this.AddGuest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(695, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Guests";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(1253, 413);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 197);
            this.panel5.TabIndex = 49;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.panel6.Controls.Add(this.LabelResOn);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 190);
            this.panel6.TabIndex = 48;
            // 
            // LabelResOn
            // 
            this.LabelResOn.AutoSize = true;
            this.LabelResOn.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.LabelResOn.ForeColor = System.Drawing.Color.White;
            this.LabelResOn.Location = new System.Drawing.Point(21, 47);
            this.LabelResOn.MaximumSize = new System.Drawing.Size(333, 0);
            this.LabelResOn.Name = "LabelResOn";
            this.LabelResOn.Size = new System.Drawing.Size(133, 41);
            this.LabelResOn.TabIndex = 47;
            this.LabelResOn.Text = "EMPTY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1249, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Reservation on";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1249, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Selected Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(692, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Free Rooms";
            // 
            // ReturnRoom
            // 
            this.ReturnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReturnRoom.Enabled = false;
            this.ReturnRoom.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.ReturnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ReturnRoom.Location = new System.Drawing.Point(1105, 175);
            this.ReturnRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnRoom.Name = "ReturnRoom";
            this.ReturnRoom.Size = new System.Drawing.Size(119, 65);
            this.ReturnRoom.TabIndex = 24;
            this.ReturnRoom.Text = "<-";
            this.ReturnRoom.UseVisualStyleBackColor = false;
            this.ReturnRoom.Click += new System.EventHandler(this.ReturnRoom_Click);
            // 
            // SelectRoom
            // 
            this.SelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectRoom.Enabled = false;
            this.SelectRoom.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold);
            this.SelectRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SelectRoom.Location = new System.Drawing.Point(1105, 103);
            this.SelectRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectRoom.Name = "SelectRoom";
            this.SelectRoom.Size = new System.Drawing.Size(119, 65);
            this.SelectRoom.TabIndex = 23;
            this.SelectRoom.Text = "->";
            this.SelectRoom.UseVisualStyleBackColor = false;
            this.SelectRoom.Click += new System.EventHandler(this.SelectRoom_Click);
            // 
            // roomsSelectedListbox
            // 
            this.roomsSelectedListbox.BackColor = System.Drawing.Color.White;
            this.roomsSelectedListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomsSelectedListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomsSelectedListbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.roomsSelectedListbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.roomsSelectedListbox.FormattingEnabled = true;
            this.roomsSelectedListbox.ItemHeight = 18;
            this.roomsSelectedListbox.Location = new System.Drawing.Point(1253, 37);
            this.roomsSelectedListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsSelectedListbox.Name = "roomsSelectedListbox";
            this.roomsSelectedListbox.ScrollAlwaysVisible = true;
            this.roomsSelectedListbox.Size = new System.Drawing.Size(375, 254);
            this.roomsSelectedListbox.TabIndex = 22;
            this.roomsSelectedListbox.TabStop = false;
            this.roomsSelectedListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.roomsSelectedListbox.SelectedIndexChanged += new System.EventHandler(this.roomsSelectedListbox_SelectedIndexChanged);
            // 
            // roomsListbox
            // 
            this.roomsListbox.BackColor = System.Drawing.Color.White;
            this.roomsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomsListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomsListbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.roomsListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roomsListbox.FormattingEnabled = true;
            this.roomsListbox.ItemHeight = 18;
            this.roomsListbox.Location = new System.Drawing.Point(697, 37);
            this.roomsListbox.Margin = new System.Windows.Forms.Padding(5);
            this.roomsListbox.Name = "roomsListbox";
            this.roomsListbox.ScrollAlwaysVisible = true;
            this.roomsListbox.Size = new System.Drawing.Size(375, 254);
            this.roomsListbox.Sorted = true;
            this.roomsListbox.TabIndex = 21;
            this.roomsListbox.TabStop = false;
            this.roomsListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.roomsListbox.SelectedIndexChanged += new System.EventHandler(this.roomsListbox_SelectedIndexChanged);
            // 
            // Panel_Guest
            // 
            this.Panel_Guest.Controls.Add(this.TableLP);
            this.Panel_Guest.Location = new System.Drawing.Point(12, 91);
            this.Panel_Guest.Name = "Panel_Guest";
            this.Panel_Guest.Size = new System.Drawing.Size(573, 864);
            this.Panel_Guest.TabIndex = 1;
            this.Panel_Guest.Visible = false;
            // 
            // TableLP
            // 
            this.TableLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TableLP.ColumnCount = 3;
            this.TableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.TableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLP.Controls.Add(this.Text1, 1, 3);
            this.TableLP.Controls.Add(this.LabelText3, 1, 6);
            this.TableLP.Controls.Add(this.LabelText2, 1, 4);
            this.TableLP.Controls.Add(this.Text2, 1, 5);
            this.TableLP.Controls.Add(this.Text3, 1, 7);
            this.TableLP.Controls.Add(this.LabelText4, 1, 8);
            this.TableLP.Controls.Add(this.Text4, 1, 9);
            this.TableLP.Controls.Add(this.LabelText5, 1, 10);
            this.TableLP.Controls.Add(this.LabelText1, 1, 2);
            this.TableLP.Controls.Add(this.LabelEditPerson, 1, 1);
            this.TableLP.Controls.Add(this.TPDateOfBirth, 1, 11);
            this.TableLP.Controls.Add(this.TBClose, 1, 12);
            this.TableLP.Controls.Add(this.TBConfirm, 2, 12);
            this.TableLP.Location = new System.Drawing.Point(4, 4);
            this.TableLP.Margin = new System.Windows.Forms.Padding(4);
            this.TableLP.Name = "TableLP";
            this.TableLP.RowCount = 14;
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.TableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLP.Size = new System.Drawing.Size(565, 851);
            this.TableLP.TabIndex = 43;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLP.SetColumnSpan(this.Text1, 2);
            this.Text1.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Text1.Location = new System.Drawing.Point(70, 169);
            this.Text1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(279, 39);
            this.Text1.TabIndex = 13;
            this.Text1.TabStop = false;
            this.Text1.WordWrap = false;
            // 
            // LabelText3
            // 
            this.LabelText3.AutoSize = true;
            this.LabelText3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.LabelText3.ForeColor = System.Drawing.Color.White;
            this.LabelText3.Location = new System.Drawing.Point(70, 320);
            this.LabelText3.Name = "LabelText3";
            this.LabelText3.Size = new System.Drawing.Size(108, 24);
            this.LabelText3.TabIndex = 10;
            this.LabelText3.Text = "Nationality";
            // 
            // LabelText2
            // 
            this.LabelText2.AutoSize = true;
            this.LabelText2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.LabelText2.ForeColor = System.Drawing.Color.White;
            this.LabelText2.Location = new System.Drawing.Point(70, 232);
            this.LabelText2.Name = "LabelText2";
            this.LabelText2.Size = new System.Drawing.Size(104, 24);
            this.LabelText2.TabIndex = 9;
            this.LabelText2.Text = "Last Name";
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLP.SetColumnSpan(this.Text2, 2);
            this.Text2.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.Text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Text2.Location = new System.Drawing.Point(70, 264);
            this.Text2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(279, 39);
            this.Text2.TabIndex = 14;
            this.Text2.TabStop = false;
            this.Text2.WordWrap = false;
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLP.SetColumnSpan(this.Text3, 2);
            this.Text3.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.Text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Text3.Location = new System.Drawing.Point(70, 353);
            this.Text3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(279, 39);
            this.Text3.TabIndex = 15;
            this.Text3.TabStop = false;
            this.Text3.WordWrap = false;
            // 
            // LabelText4
            // 
            this.LabelText4.AutoSize = true;
            this.LabelText4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.LabelText4.ForeColor = System.Drawing.Color.White;
            this.LabelText4.Location = new System.Drawing.Point(70, 419);
            this.LabelText4.Name = "LabelText4";
            this.LabelText4.Size = new System.Drawing.Size(80, 24);
            this.LabelText4.TabIndex = 12;
            this.LabelText4.Text = "Id Proof";
            // 
            // Text4
            // 
            this.Text4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Text4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLP.SetColumnSpan(this.Text4, 2);
            this.Text4.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.Text4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Text4.Location = new System.Drawing.Point(70, 446);
            this.Text4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(279, 39);
            this.Text4.TabIndex = 17;
            this.Text4.TabStop = false;
            this.Text4.WordWrap = false;
            // 
            // LabelText5
            // 
            this.LabelText5.AutoSize = true;
            this.LabelText5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.LabelText5.ForeColor = System.Drawing.Color.White;
            this.LabelText5.Location = new System.Drawing.Point(70, 551);
            this.LabelText5.Name = "LabelText5";
            this.LabelText5.Size = new System.Drawing.Size(129, 24);
            this.LabelText5.TabIndex = 11;
            this.LabelText5.Text = "Date Of Birth";
            // 
            // LabelText1
            // 
            this.LabelText1.AutoSize = true;
            this.LabelText1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.LabelText1.ForeColor = System.Drawing.Color.White;
            this.LabelText1.Location = new System.Drawing.Point(70, 140);
            this.LabelText1.Name = "LabelText1";
            this.LabelText1.Size = new System.Drawing.Size(107, 24);
            this.LabelText1.TabIndex = 8;
            this.LabelText1.Text = "First Name";
            // 
            // LabelEditPerson
            // 
            this.LabelEditPerson.AutoSize = true;
            this.TableLP.SetColumnSpan(this.LabelEditPerson, 2);
            this.LabelEditPerson.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.LabelEditPerson.ForeColor = System.Drawing.Color.White;
            this.LabelEditPerson.Location = new System.Drawing.Point(70, 37);
            this.LabelEditPerson.Name = "LabelEditPerson";
            this.LabelEditPerson.Size = new System.Drawing.Size(295, 41);
            this.LabelEditPerson.TabIndex = 36;
            this.LabelEditPerson.Text = "Guest information";
            // 
            // TPDateOfBirth
            // 
            this.TPDateOfBirth.CalendarForeColor = System.Drawing.Color.Black;
            this.TPDateOfBirth.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.TPDateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.TPDateOfBirth.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.TPDateOfBirth.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.TPDateOfBirth.CausesValidation = false;
            this.TableLP.SetColumnSpan(this.TPDateOfBirth, 2);
            this.TPDateOfBirth.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPDateOfBirth.Location = new System.Drawing.Point(70, 583);
            this.TPDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPDateOfBirth.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.TPDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TPDateOfBirth.Name = "TPDateOfBirth";
            this.TPDateOfBirth.Size = new System.Drawing.Size(279, 25);
            this.TPDateOfBirth.TabIndex = 35;
            // 
            // TBClose
            // 
            this.TBClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TBClose.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.TBClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.TBClose.Location = new System.Drawing.Point(70, 672);
            this.TBClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(227, 95);
            this.TBClose.TabIndex = 19;
            this.TBClose.Text = "Cancel ";
            this.TBClose.UseVisualStyleBackColor = false;
            this.TBClose.Click += new System.EventHandler(this.TBClose_Click);
            // 
            // TBConfirm
            // 
            this.TBConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TBConfirm.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.TBConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.TBConfirm.Location = new System.Drawing.Point(303, 672);
            this.TBConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBConfirm.Name = "TBConfirm";
            this.TBConfirm.Size = new System.Drawing.Size(227, 95);
            this.TBConfirm.TabIndex = 18;
            this.TBConfirm.Text = "Confirm";
            this.TBConfirm.UseVisualStyleBackColor = false;
            this.TBConfirm.Click += new System.EventHandler(this.TBConfirm_Click);
            // 
            // ReservationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Projekt_hotel.Properties.Resources.tlo_5;
            this.ClientSize = new System.Drawing.Size(1917, 1028);
            this.Controls.Add(this.Panel_Guest);
            this.Controls.Add(this.Panel_Reservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1917, 1028);
            this.Name = "ReservationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationDialog";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel_Reservation.ResumeLayout(false);
            this.Panel_Reservation.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Panel_Guest.ResumeLayout(false);
            this.TableLP.ResumeLayout(false);
            this.TableLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Reservation;
        private System.Windows.Forms.FlowLayoutPanel Panel_Guest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ReturnRoom;
        private System.Windows.Forms.Button SelectRoom;
        private System.Windows.Forms.ListBox roomsSelectedListbox;
        private System.Windows.Forms.ListBox roomsListbox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelResOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditGuest;
        private System.Windows.Forms.Button DeleteGuest;
        private System.Windows.Forms.ListBox guestsListbox;
        private System.Windows.Forms.Button AddGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button ReservationConfirmButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker timePickerEnd;
        private System.Windows.Forms.DateTimePicker timePickerStart;
        private System.Windows.Forms.TableLayoutPanel TableLP;
        private System.Windows.Forms.Button TBClose;
        private System.Windows.Forms.Button TBConfirm;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Label LabelText3;
        private System.Windows.Forms.Label LabelText2;
        private System.Windows.Forms.TextBox Text2;
        private System.Windows.Forms.TextBox Text3;
        private System.Windows.Forms.Label LabelText4;
        private System.Windows.Forms.TextBox Text4;
        private System.Windows.Forms.Label LabelText5;
        private System.Windows.Forms.Label LabelText1;
        private System.Windows.Forms.Label LabelEditPerson;
        private System.Windows.Forms.DateTimePicker TPDateOfBirth;
        private System.Windows.Forms.Button SelectGuest;
    }
}