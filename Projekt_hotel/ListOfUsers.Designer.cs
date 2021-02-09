namespace Projekt_hotel
{
    partial class ListOfUsers
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchStatusL = new System.Windows.Forms.Label();
            this.SearchPreviousB = new System.Windows.Forms.Button();
            this.SearchNextB = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableLO = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ConfirmButtonTLO = new System.Windows.Forms.Button();
            this.CancelButtonTLO = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listOfWorkers = new System.Windows.Forms.ListBox();
            this.LabelMain = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TableLO.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonExit.Location = new System.Drawing.Point(1424, 7);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(61, 46);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.SearchStatusL);
            this.panel1.Controls.Add(this.SearchPreviousB);
            this.panel1.Controls.Add(this.SearchNextB);
            this.panel1.Controls.Add(this.changeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.SearchTB);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.listOfWorkers);
            this.panel1.Location = new System.Drawing.Point(4, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(1491, 863);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 863);
            this.panel1.TabIndex = 1;
            // 
            // SearchStatusL
            // 
            this.SearchStatusL.AutoSize = true;
            this.SearchStatusL.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchStatusL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchStatusL.Location = new System.Drawing.Point(39, 42);
            this.SearchStatusL.Name = "SearchStatusL";
            this.SearchStatusL.Size = new System.Drawing.Size(259, 29);
            this.SearchStatusL.TabIndex = 36;
            this.SearchStatusL.Text = "Number of results: 0/0";
            // 
            // SearchPreviousB
            // 
            this.SearchPreviousB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchPreviousB.Enabled = false;
            this.SearchPreviousB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.SearchPreviousB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchPreviousB.Location = new System.Drawing.Point(464, 173);
            this.SearchPreviousB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchPreviousB.Name = "SearchPreviousB";
            this.SearchPreviousB.Size = new System.Drawing.Size(151, 39);
            this.SearchPreviousB.TabIndex = 35;
            this.SearchPreviousB.Tag = "1";
            this.SearchPreviousB.Text = "Previous";
            this.SearchPreviousB.UseVisualStyleBackColor = false;
            this.SearchPreviousB.Click += new System.EventHandler(this.SearchPreviousB_Click);
            // 
            // SearchNextB
            // 
            this.SearchNextB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchNextB.Enabled = false;
            this.SearchNextB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.SearchNextB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchNextB.Location = new System.Drawing.Point(464, 130);
            this.SearchNextB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchNextB.Name = "SearchNextB";
            this.SearchNextB.Size = new System.Drawing.Size(151, 39);
            this.SearchNextB.TabIndex = 34;
            this.SearchNextB.Tag = "1";
            this.SearchNextB.Text = "Next";
            this.SearchNextB.UseVisualStyleBackColor = false;
            this.SearchNextB.Click += new System.EventHandler(this.SearchNextB_Click);
            // 
            // ChangeB
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.changeButton.Location = new System.Drawing.Point(464, 652);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "ChangeB";
            this.changeButton.Size = new System.Drawing.Size(235, 39);
            this.changeButton.TabIndex = 20;
            this.changeButton.Tag = "1";
            this.changeButton.Text = "Change Password";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeB_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TableLO);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(704, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.MinimumSize = new System.Drawing.Size(691, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 701);
            this.panel2.TabIndex = 19;
            // 
            // TableLO
            // 
            this.TableLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.TableLO.ColumnCount = 3;
            this.TableLO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.TableLO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.38754F));
            this.TableLO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.61246F));
            this.TableLO.Controls.Add(this.label1, 1, 2);
            this.TableLO.Controls.Add(this.textBox1, 2, 2);
            this.TableLO.Controls.Add(this.textBox2, 2, 3);
            this.TableLO.Controls.Add(this.textBox3, 2, 4);
            this.TableLO.Controls.Add(this.LabelTable, 1, 1);
            this.TableLO.Controls.Add(this.label2, 1, 3);
            this.TableLO.Controls.Add(this.label3, 1, 4);
            this.TableLO.Controls.Add(this.label4, 1, 5);
            this.TableLO.Controls.Add(this.checkBox1, 2, 7);
            this.TableLO.Controls.Add(this.textBox4, 2, 5);
            this.TableLO.Controls.Add(this.label5, 1, 6);
            this.TableLO.Controls.Add(this.textBox5, 2, 6);
            this.TableLO.Controls.Add(this.label6, 1, 7);
            this.TableLO.Controls.Add(this.label8, 1, 9);
            this.TableLO.Controls.Add(this.label7, 1, 8);
            this.TableLO.Controls.Add(this.textBox7, 2, 9);
            this.TableLO.Controls.Add(this.textBox6, 2, 8);
            this.TableLO.Controls.Add(this.ConfirmButtonTLO, 2, 10);
            this.TableLO.Controls.Add(this.CancelButtonTLO, 1, 10);
            this.TableLO.Location = new System.Drawing.Point(3, 2);
            this.TableLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLO.Name = "TableLO";
            this.TableLO.RowCount = 12;
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.TableLO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.TableLO.Size = new System.Drawing.Size(685, 694);
            this.TableLO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(110, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox1.Location = new System.Drawing.Point(354, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 39);
            this.textBox1.TabIndex = 16;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox2.Location = new System.Drawing.Point(354, 166);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 39);
            this.textBox2.TabIndex = 17;
            this.textBox2.TabStop = false;
            this.textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox3.Location = new System.Drawing.Point(354, 221);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 39);
            this.textBox3.TabIndex = 18;
            this.textBox3.TabStop = false;
            this.textBox3.WordWrap = false;
            // 
            // LabelTable
            // 
            this.LabelTable.AutoSize = true;
            this.TableLO.SetColumnSpan(this.LabelTable, 2);
            this.LabelTable.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelTable.Location = new System.Drawing.Point(110, 39);
            this.LabelTable.Name = "LabelTable";
            this.LabelTable.Size = new System.Drawing.Size(451, 46);
            this.LabelTable.TabIndex = 20;
            this.LabelTable.Text = "      USER INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(110, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(110, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(110, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Login";
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBox1.Location = new System.Drawing.Point(354, 386);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 36);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox4.Location = new System.Drawing.Point(354, 276);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 39);
            this.textBox4.TabIndex = 19;
            this.textBox4.TabStop = false;
            this.textBox4.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(110, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "User Type";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox5.Location = new System.Drawing.Point(354, 331);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 39);
            this.textBox5.TabIndex = 28;
            this.textBox5.TabStop = false;
            this.textBox5.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(110, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Manager";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(110, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Repeat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(110, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Password";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox7.Location = new System.Drawing.Point(354, 496);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(239, 39);
            this.textBox7.TabIndex = 32;
            this.textBox7.TabStop = false;
            this.textBox7.WordWrap = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox6.Location = new System.Drawing.Point(354, 441);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.Size = new System.Drawing.Size(239, 39);
            this.textBox6.TabIndex = 31;
            this.textBox6.TabStop = false;
            this.textBox6.WordWrap = false;
            // 
            // ConfirmButtonTLO
            // 
            this.ConfirmButtonTLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ConfirmButtonTLO.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmButtonTLO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ConfirmButtonTLO.Location = new System.Drawing.Point(354, 571);
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
            this.CancelButtonTLO.Location = new System.Drawing.Point(110, 571);
            this.CancelButtonTLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButtonTLO.Name = "CancelButtonTLO";
            this.CancelButtonTLO.Size = new System.Drawing.Size(238, 59);
            this.CancelButtonTLO.TabIndex = 25;
            this.CancelButtonTLO.Tag = "1";
            this.CancelButtonTLO.Text = "Cancel";
            this.CancelButtonTLO.UseVisualStyleBackColor = false;
            this.CancelButtonTLO.Click += new System.EventHandler(this.CancelButtonTLO_Click);
            // 
            // DeleteB
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.deleteButton.Location = new System.Drawing.Point(464, 609);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "DeleteB";
            this.deleteButton.Size = new System.Drawing.Size(235, 39);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Tag = "1";
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // EditB
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.editButton.Location = new System.Drawing.Point(464, 695);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "EditB";
            this.editButton.Size = new System.Drawing.Size(235, 39);
            this.editButton.TabIndex = 17;
            this.editButton.Tag = "1";
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditB_Click);
            // 
            // AddB
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addButton.Location = new System.Drawing.Point(464, 738);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "AddB";
            this.addButton.Size = new System.Drawing.Size(235, 41);
            this.addButton.TabIndex = 16;
            this.addButton.Tag = "1";
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.SearchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchTB.Location = new System.Drawing.Point(43, 78);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(415, 39);
            this.SearchTB.TabIndex = 15;
            this.SearchTB.TabStop = false;
            this.SearchTB.WordWrap = false;
            // 
            // SearchB
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.searchButton.Location = new System.Drawing.Point(464, 78);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "SearchB";
            this.searchButton.Size = new System.Drawing.Size(151, 39);
            this.searchButton.TabIndex = 11;
            this.searchButton.Tag = "1";
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ListOfWorkers
            // 
            this.listOfWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listOfWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfWorkers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listOfWorkers.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listOfWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listOfWorkers.ItemHeight = 30;
            this.listOfWorkers.Items.AddRange(new object[] {
            "asdsadas",
            "dsadas",
            "ola raczynska"});
            this.listOfWorkers.Location = new System.Drawing.Point(43, 129);
            this.listOfWorkers.Margin = new System.Windows.Forms.Padding(0);
            this.listOfWorkers.MinimumSize = new System.Drawing.Size(415, 692);
            this.listOfWorkers.Name = "ListOfWorkers";
            this.listOfWorkers.Size = new System.Drawing.Size(415, 692);
            this.listOfWorkers.Sorted = true;
            this.listOfWorkers.TabIndex = 3;
            this.listOfWorkers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListOfWorkers_DrawItem);
            this.listOfWorkers.SelectedIndexChanged += new System.EventHandler(this.ListOfWorkers_SelectedIndexChanged);
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold);
            this.LabelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.LabelMain.Location = new System.Drawing.Point(627, 7);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(243, 40);
            this.LabelMain.TabIndex = 2;
            this.LabelMain.Text = "LIST OF USERS";
            // 
            // ListOfUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1500, 927);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1500, 927);
            this.MinimumSize = new System.Drawing.Size(1499, 926);
            this.Name = "ListOfUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.TableLO.ResumeLayout(false);
            this.TableLO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.ListBox listOfWorkers;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel TableLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LabelTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button CancelButtonTLO;
        private System.Windows.Forms.Button ConfirmButtonTLO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button SearchPreviousB;
        private System.Windows.Forms.Button SearchNextB;
        private System.Windows.Forms.Label SearchStatusL;
    }
}