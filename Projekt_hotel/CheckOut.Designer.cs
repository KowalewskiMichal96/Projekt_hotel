namespace Projekt_hotel
{
    partial class CheckOut
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
            this.LabelMain = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchStatusL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.SearchStatusL);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(4, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(1491, 863);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 863);
            this.panel1.TabIndex = 2;
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold);
            this.LabelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.LabelMain.Location = new System.Drawing.Point(627, 7);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(207, 40);
            this.LabelMain.TabIndex = 3;
            this.LabelMain.Text = "CHECK OUT";
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
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Lato", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "asdsadas",
            "dsadas",
            "ola raczynska"});
            this.listBox1.Location = new System.Drawing.Point(43, 129);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.MinimumSize = new System.Drawing.Size(415, 692);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 692);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 4;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            // 
            // SearchStatusL
            // 
            this.SearchStatusL.AutoSize = true;
            this.SearchStatusL.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchStatusL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.SearchStatusL.Location = new System.Drawing.Point(38, 74);
            this.SearchStatusL.Name = "SearchStatusL";
            this.SearchStatusL.Size = new System.Drawing.Size(151, 33);
            this.SearchStatusL.TabIndex = 37;
            this.SearchStatusL.Text = "All services";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1499, 926);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SearchStatusL;
    }
}