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
    public partial class CustomDialog : Form
    {
        public CustomDialog(string info, int x)
        {
            InitializeComponent();
            LoadControll(info,x);
        }
        

        private void LoadControll(string INFO,int X)
        {
            LabelInformation.Text = INFO;
            
            if(X == 1)
            {
                button1.Text = "OK";
                button2.Visible = false;
                button1.DialogResult = DialogResult.OK;
                button1.Visible = true;
            }
            else if(X == 2)
            {
                button1.Text = "YES";
                button2.Text = "NO";

                button1.DialogResult = DialogResult.Yes;
                button2.DialogResult = DialogResult.No;

                button1.Visible = true;
                button2.Visible = true;
            }
        }


    }
}
