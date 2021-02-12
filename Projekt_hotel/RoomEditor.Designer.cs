namespace Projekt_hotel
{
    partial class RoomEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchStatusL = new System.Windows.Forms.Label();
            this.LabelMain = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listOfRooms = new System.Windows.Forms.ListBox();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.ConfirmButtonTLO = new System.Windows.Forms.Button();
            this.CancelButtonTLO = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInformation.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelInformation);
            this.panel1.Controls.Add(this.listOfRooms);
            this.panel1.Controls.Add(this.SearchStatusL);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(1491, 863);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 863);
            this.panel1.TabIndex = 3;
            // 
            // SearchStatusL
            // 
            this.SearchStatusL.AutoSize = true;
            this.SearchStatusL.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchStatusL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchStatusL.Location = new System.Drawing.Point(37, 82);
            this.SearchStatusL.Name = "SearchStatusL";
            this.SearchStatusL.Size = new System.Drawing.Size(139, 34);
            this.SearchStatusL.TabIndex = 37;
            this.SearchStatusL.Text = "All Rooms";
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold);
            this.LabelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.LabelMain.Location = new System.Drawing.Point(626, 9);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(315, 50);
            this.LabelMain.TabIndex = 4;
            this.LabelMain.Text = "ROOM EDITOR";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ButtonExit.Location = new System.Drawing.Point(1424, 6);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(61, 46);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pictureBox1.Location = new System.Drawing.Point(302, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 294);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // listOfRooms
            // 
            this.listOfRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listOfRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listOfRooms.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listOfRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listOfRooms.ItemHeight = 30;
            this.listOfRooms.Items.AddRange(new object[] {
            "asdsadas",
            "dsadas",
            "ola raczynska"});
            this.listOfRooms.Location = new System.Drawing.Point(43, 127);
            this.listOfRooms.Margin = new System.Windows.Forms.Padding(0);
            this.listOfRooms.MinimumSize = new System.Drawing.Size(415, 692);
            this.listOfRooms.Name = "listOfRooms";
            this.listOfRooms.Size = new System.Drawing.Size(415, 692);
            this.listOfRooms.Sorted = true;
            this.listOfRooms.TabIndex = 48;
            this.listOfRooms.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListOfRooms_DrawItem);
            this.listOfRooms.SelectedIndexChanged += new System.EventHandler(this.listOfRooms_SelectedIndexChanged);
            // 
            // panelInformation
            // 
            this.panelInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInformation.Controls.Add(this.pictureBox1);
            this.panelInformation.Controls.Add(this.panel3);
            this.panelInformation.Enabled = false;
            this.panelInformation.Location = new System.Drawing.Point(697, 127);
            this.panelInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInformation.MinimumSize = new System.Drawing.Size(691, 700);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(693, 701);
            this.panelInformation.TabIndex = 49;
            // 
            // ConfirmButtonTLO
            // 
            this.ConfirmButtonTLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ConfirmButtonTLO.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmButtonTLO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ConfirmButtonTLO.Location = new System.Drawing.Point(361, 589);
            this.ConfirmButtonTLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButtonTLO.Name = "ConfirmButtonTLO";
            this.ConfirmButtonTLO.Size = new System.Drawing.Size(239, 59);
            this.ConfirmButtonTLO.TabIndex = 26;
            this.ConfirmButtonTLO.Tag = "1";
            this.ConfirmButtonTLO.Text = "Confirm";
            this.ConfirmButtonTLO.UseVisualStyleBackColor = false;
            this.ConfirmButtonTLO.Click += new System.EventHandler(this.ConfirmButtonTLO_Click);
            // 
            // CancelButtonTLO
            // 
            this.CancelButtonTLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CancelButtonTLO.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.CancelButtonTLO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CancelButtonTLO.Location = new System.Drawing.Point(99, 589);
            this.CancelButtonTLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButtonTLO.Name = "CancelButtonTLO";
            this.CancelButtonTLO.Size = new System.Drawing.Size(238, 59);
            this.CancelButtonTLO.TabIndex = 25;
            this.CancelButtonTLO.Tag = "1";
            this.CancelButtonTLO.Text = "Cancel";
            this.CancelButtonTLO.UseVisualStyleBackColor = false;
            this.CancelButtonTLO.Click += new System.EventHandler(this.CancelButtonTLO_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.loadButton);
            this.panel3.Controls.Add(this.categoryCombobox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CancelButtonTLO);
            this.panel3.Controls.Add(this.ConfirmButtonTLO);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 693);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(17, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 48;
            this.label1.Text = "Room Name Unique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(695, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 34);
            this.label2.TabIndex = 50;
            this.label2.Text = "Room Information";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox1.Location = new System.Drawing.Point(23, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 39);
            this.textBox1.TabIndex = 49;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(19, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 34);
            this.label5.TabIndex = 54;
            this.label5.Text = "Room Type";
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryCombobox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.categoryCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.ItemHeight = 36;
            this.categoryCombobox.Location = new System.Drawing.Point(23, 311);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(214, 44);
            this.categoryCombobox.TabIndex = 55;
            this.categoryCombobox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loadButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.loadButton.Location = new System.Drawing.Point(493, 402);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(160, 59);
            this.loadButton.TabIndex = 56;
            this.loadButton.Tag = "1";
            this.loadButton.Text = "Load File";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(296, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 300);
            this.panel4.TabIndex = 57;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectButton.Enabled = false;
            this.selectButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.selectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.selectButton.Location = new System.Drawing.Point(461, 191);
            this.selectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(170, 59);
            this.selectButton.TabIndex = 51;
            this.selectButton.Tag = "1";
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addButton.Location = new System.Drawing.Point(461, 128);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 59);
            this.addButton.TabIndex = 52;
            this.addButton.Tag = "1";
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.deleteButton.Location = new System.Drawing.Point(461, 252);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 59);
            this.deleteButton.TabIndex = 53;
            this.deleteButton.Tag = "1";
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RoomEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1500, 926);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomEditor";
            this.Load += new System.EventHandler(this.RoomEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInformation.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SearchStatusL;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listOfRooms;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Button ConfirmButtonTLO;
        private System.Windows.Forms.Button CancelButtonTLO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}