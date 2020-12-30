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
        databaseHotelDataContext contextDB = new databaseHotelDataContext();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var ldb = (from resstat in contextDB.ReservationStatus
                       where resstat.ReservationStatusCatalog_ID == 1
                       from res in contextDB.Reservation
                       where res.Id == resstat.Reservation_ID
                       select new
                       {
                           res.Id,
                           res.StartDate,
                           res.EndDate,
                           res.Total_price,
                           res.Guest_ID,
                           res.Worker_ID
                       }).ToList();

                dataGridView1.DataSource = ldb;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewReservation NR = new NewReservation();
            //NR.TopMost = true;
            NR.Show();
            
            // open new window with 
            // 1 List of rooms  
            //   * which rooms name and floor 
            //   * how many people in room

            // 2 guest name
                
            // 3 payer name


            // stworz nowa tabele reservationDetails
            // w niej wyszczegolnione dane o rezerwacji ile pokoi ile osob lub 
            // + cena calkowita 

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }
    }
}
