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
        DataTable table = new DataTable();
        List<Reservations> allReservations = ListManager.LoadSampleData();
        public MainMenu()
        {
            InitializeComponent();
        }

        public void fillData()
        {
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("StartDate", typeof(string));
            table.Columns.Add("EndDate", typeof(string));
            table.Columns.Add("TotalPrice", typeof(string));
            table.Columns.Add("GuestName", typeof(string));
            table.Columns.Add("WorkerId", typeof(string));

            categoryCombobox.Items.Add("Id");
            categoryCombobox.Items.Add("StartDate");
            categoryCombobox.Items.Add("EndDate");
            categoryCombobox.Items.Add("TotalPrice");
            categoryCombobox.Items.Add("GuestName");
            categoryCombobox.Items.Add("WorkerId");
            
            for(int i = 0; i < allReservations.Count; i++)
            {
                table.Rows.Add(
                     allReservations[i].id, allReservations[i].startDate, allReservations[i].endDate, allReservations[i].totalPrice, allReservations[i].lastName, allReservations[i].workerId
                    );
            }

            dataGridView1.DataSource = table;

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            fillData();
            categoryCombobox.SelectedIndex = 0;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(searchTextbox.Text))
            {
                table.DefaultView.RowFilter = "";
                dataGridView1.Sort(dataGridView1.Columns[categoryCombobox.SelectedIndex], ListSortDirection.Ascending);  
            }
            else
            {
                string type = categoryCombobox.SelectedItem.ToString();
                string value = searchTextbox.Text;
                table.DefaultView.RowFilter = type + " Like '" + value + "' OR " + type + " Like '" + value + "*'";
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            NewReservation NR = new NewReservation();
            NR.TopMost = true;
            NR.Show();


            // stworz nowa tabele reservationDetails
            // w niej wyszczegolnione dane o rezerwacji ile pokoi ile osob lub 
            // + cena calkowita 

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
