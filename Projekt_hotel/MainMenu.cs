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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewReservation NR = new NewReservation();
            NR.Show();
            
            // open new window with 
            // 1 List of rooms  
            //   * which rooms name and floor 
            //   * how many people in room

            // 2 guest name
                
            // 3 payer name


            // stworz nowa tabele reservationDetails
            // w niej wyszczegolnione dane o rezerwacji ile pokoi ile osob 
            // + cena calkowita 

        }
    }
}
