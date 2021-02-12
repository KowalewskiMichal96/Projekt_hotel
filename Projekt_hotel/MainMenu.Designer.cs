namespace Projekt_hotel
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cHECKINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTOFUSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nEWUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWROOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckOutB = new System.Windows.Forms.Button();
            this.DeleteReservation = new System.Windows.Forms.Button();
            this.EditReservation = new System.Windows.Forms.Button();
            this.CheckInB = new System.Windows.Forms.Button();
            this.DGViewRooms = new System.Windows.Forms.DataGridView();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.oPTIONToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.cHECKINToolStripMenuItem,
            this.cHECKOUTToolStripMenuItem,
            this.toolStripSeparator3,
            this.lOGOUTToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // cHECKINToolStripMenuItem
            // 
            this.cHECKINToolStripMenuItem.Name = "cHECKINToolStripMenuItem";
            this.cHECKINToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.cHECKINToolStripMenuItem.Text = "CHECK IN";
            // 
            // cHECKOUTToolStripMenuItem
            // 
            this.cHECKOUTToolStripMenuItem.Name = "cHECKOUTToolStripMenuItem";
            this.cHECKOUTToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.cHECKOUTToolStripMenuItem.Text = "CHECK OUT";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // oPTIONToolStripMenuItem
            // 
            this.oPTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTOFUSERSToolStripMenuItem,
            this.toolStripSeparator1,
            this.nEWUSERToolStripMenuItem,
            this.nEWROOMToolStripMenuItem});
            this.oPTIONToolStripMenuItem.Name = "oPTIONToolStripMenuItem";
            this.oPTIONToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.oPTIONToolStripMenuItem.Text = "OPTION";
            // 
            // lISTOFUSERSToolStripMenuItem
            // 
            this.lISTOFUSERSToolStripMenuItem.Name = "lISTOFUSERSToolStripMenuItem";
            this.lISTOFUSERSToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.lISTOFUSERSToolStripMenuItem.Text = "LIST OF USERS";
            this.lISTOFUSERSToolStripMenuItem.Click += new System.EventHandler(this.ListOfUsersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // nEWUSERToolStripMenuItem
            // 
            this.nEWUSERToolStripMenuItem.Name = "nEWUSERToolStripMenuItem";
            this.nEWUSERToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.nEWUSERToolStripMenuItem.Text = "NEW USER";
            // 
            // nEWROOMToolStripMenuItem
            // 
            this.nEWROOMToolStripMenuItem.Name = "nEWROOMToolStripMenuItem";
            this.nEWROOMToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.nEWROOMToolStripMenuItem.Text = "NEW ROOM";
            this.nEWROOMToolStripMenuItem.Click += new System.EventHandler(this.NewRoomToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(38, 32);
            this.toolStripTextBox1.Text = "X";
            this.toolStripTextBox1.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Projekt_hotel.Properties.Resources.tlo_5;
            this.panel1.Controls.Add(this.CheckOutB);
            this.panel1.Controls.Add(this.DeleteReservation);
            this.panel1.Controls.Add(this.EditReservation);
            this.panel1.Controls.Add(this.CheckInB);
            this.panel1.Controls.Add(this.DGViewRooms);
            this.panel1.Controls.Add(this.categoryCombobox);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.DGView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 997);
            this.panel1.TabIndex = 2;
            // 
            // CheckOutB
            // 
            this.CheckOutB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CheckOutB.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.CheckOutB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CheckOutB.Location = new System.Drawing.Point(24, 184);
            this.CheckOutB.Name = "CheckOutB";
            this.CheckOutB.Size = new System.Drawing.Size(290, 48);
            this.CheckOutB.TabIndex = 14;
            this.CheckOutB.Text = "Check Out";
            this.CheckOutB.UseVisualStyleBackColor = false;
            this.CheckOutB.Click += new System.EventHandler(this.CheckOutB_Click);
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteReservation.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.DeleteReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DeleteReservation.Location = new System.Drawing.Point(24, 292);
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.Size = new System.Drawing.Size(290, 48);
            this.DeleteReservation.TabIndex = 12;
            this.DeleteReservation.Text = "Delete Reservation";
            this.DeleteReservation.UseVisualStyleBackColor = false;
            this.DeleteReservation.Click += new System.EventHandler(this.DeleteReservation_Click);
            // 
            // EditReservation
            // 
            this.EditReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EditReservation.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.EditReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditReservation.Location = new System.Drawing.Point(24, 238);
            this.EditReservation.Name = "EditReservation";
            this.EditReservation.Size = new System.Drawing.Size(290, 48);
            this.EditReservation.TabIndex = 11;
            this.EditReservation.Text = "Edit Reservation";
            this.EditReservation.UseVisualStyleBackColor = false;
            this.EditReservation.Click += new System.EventHandler(this.EditReservation_Click);
            // 
            // CheckInB
            // 
            this.CheckInB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CheckInB.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.CheckInB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CheckInB.Location = new System.Drawing.Point(24, 130);
            this.CheckInB.Name = "CheckInB";
            this.CheckInB.Size = new System.Drawing.Size(290, 48);
            this.CheckInB.TabIndex = 10;
            this.CheckInB.Text = "Check In";
            this.CheckInB.UseVisualStyleBackColor = false;
            this.CheckInB.Click += new System.EventHandler(this.CheckInB_Click);
            // 
            // DGViewRooms
            // 
            this.DGViewRooms.AllowUserToAddRows = false;
            this.DGViewRooms.AllowUserToDeleteRows = false;
            this.DGViewRooms.AllowUserToResizeColumns = false;
            this.DGViewRooms.AllowUserToResizeRows = false;
            this.DGViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewRooms.BackgroundColor = System.Drawing.Color.White;
            this.DGViewRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewRooms.ColumnHeadersHeight = 40;
            this.DGViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGViewRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGViewRooms.EnableHeadersVisualStyles = false;
            this.DGViewRooms.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DGViewRooms.Location = new System.Drawing.Point(1475, 130);
            this.DGViewRooms.MultiSelect = false;
            this.DGViewRooms.Name = "DGViewRooms";
            this.DGViewRooms.ReadOnly = true;
            this.DGViewRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGViewRooms.RowHeadersVisible = false;
            this.DGViewRooms.RowHeadersWidth = 50;
            this.DGViewRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGViewRooms.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGViewRooms.RowTemplate.Height = 24;
            this.DGViewRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewRooms.Size = new System.Drawing.Size(373, 576);
            this.DGViewRooms.TabIndex = 9;
            this.DGViewRooms.TabStop = false;
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryCombobox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.categoryCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.ItemHeight = 36;
            this.categoryCombobox.Location = new System.Drawing.Point(804, 35);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(262, 44);
            this.categoryCombobox.TabIndex = 8;
            this.categoryCombobox.TabStop = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchTextbox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.searchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.searchTextbox.Location = new System.Drawing.Point(520, 35);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(278, 43);
            this.searchTextbox.TabIndex = 7;
            this.searchTextbox.TabStop = false;
            this.searchTextbox.WordWrap = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchButton.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.searchButton.Location = new System.Drawing.Point(1072, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(285, 44);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DGView
            // 
            this.DGView.AllowUserToAddRows = false;
            this.DGView.AllowUserToDeleteRows = false;
            this.DGView.AllowUserToResizeColumns = false;
            this.DGView.AllowUserToResizeRows = false;
            this.DGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGView.BackgroundColor = System.Drawing.Color.White;
            this.DGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGView.ColumnHeadersHeight = 40;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGView.EnableHeadersVisualStyles = false;
            this.DGView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DGView.Location = new System.Drawing.Point(330, 130);
            this.DGView.MultiSelect = false;
            this.DGView.Name = "DGView";
            this.DGView.ReadOnly = true;
            this.DGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGView.RowHeadersVisible = false;
            this.DGView.RowHeadersWidth = 50;
            this.DGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.DGView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGView.RowTemplate.Height = 24;
            this.DGView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGView.Size = new System.Drawing.Size(1139, 576);
            this.DGView.TabIndex = 0;
            this.DGView.TabStop = false;
            this.DGView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_RowEnter);
            this.DGView.SelectionChanged += new System.EventHandler(this.DGView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(851, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Witaj";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cHECKINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTOFUSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nEWROOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWUSERToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.DataGridView DGViewRooms;
        private System.Windows.Forms.Button CheckInB;
        private System.Windows.Forms.Button EditReservation;
        private System.Windows.Forms.Button DeleteReservation;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CheckOutB;
        private System.Windows.Forms.Label label1;
    }
}