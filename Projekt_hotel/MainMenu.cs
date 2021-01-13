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
        readonly databaseHotelDataContext contextDB = new databaseHotelDataContext();
        readonly DataTable table = new DataTable();
        List<Reservations> allReservations;// = ListManager.LoadSampleReservation();
        readonly User LoggedUser = new User();

        public MainMenu(User user)
        {

            LoggedUser = user;
            InitializeComponent();
            
        }
        public void FillComboBox()
        {
            categoryCombobox.Items.Clear();

            categoryCombobox.Items.Add("StartDate");
            categoryCombobox.Items.Add("EndDate");
            categoryCombobox.Items.Add("TotalPrice");
            categoryCombobox.Items.Add("GuestName");
            categoryCombobox.Items.Add("WorkerId");

            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("StartDate", typeof(string));
            table.Columns.Add("EndDate", typeof(string));
            table.Columns.Add("TotalPrice", typeof(string));
            table.Columns.Add("GuestName", typeof(string));
            table.Columns.Add("WorkerId", typeof(string));


        }
        public void FillData()
        {
            allReservations = ListManager.LoadSampleReservation();
            //table.Reset();

           //table.Columns.Clear();
           table.Rows.Clear();

            
            for(int i = 0; i < allReservations.Count; i++)
            {
                table.Rows.Add(
                     allReservations[i].Id, allReservations[i].StartDate, allReservations[i].EndDate, allReservations[i].TotalPrice, allReservations[i].LastName, allReservations[i].WorkerId
                    );
            }

            DGView.DataSource = table;
            categoryCombobox.SelectedIndex = 0;
            DGView.Columns[0].Visible = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //textBox1.Text = LoggedUser.GetId().ToString() + " " + LoggedUser.GetRole();

            FillComboBox();
            FillData();
            categoryCombobox.SelectedIndex = 0;
            DGView.Rows[0].Selected = true;
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
                DGView.Sort(DGView.Columns[categoryCombobox.SelectedIndex+1], ListSortDirection.Ascending);  
            }
            else
            {
                string type = categoryCombobox.SelectedItem.ToString();
                string value = searchTextbox.Text;
                table.DefaultView.RowFilter = type + " Like '" + value + "' OR " + type + " Like '" + value + "*'";
            }
        }

        
        private void AddReservation_Click(object sender, EventArgs e)
        {
            NewReservation NR = new NewReservation(LoggedUser.GetId(), Convert.ToInt32(DGView[0, DGView.CurrentRow.Index].Value), 1);
            NR.TopMost = true;
            NR.Show();


        }

        private void DGView_SelectionChanged(object sender, EventArgs e)
        {
            if(DGView.SelectedRows.Count > 0)
            {
                EditReservation.Visible = true;
                DeleteReservation.Visible = true;
            }
            else
            {
                EditReservation.Visible = false;
                DeleteReservation.Visible = false;
            }
        }


        private void EditReservation_Click(object sender, EventArgs e)
        {
            NewReservation EditReservation = new NewReservation(LoggedUser.GetId(), Convert.ToInt32(DGView[0, DGView.CurrentRow.Index].Value), 2);
            EditReservation.TopMost = true;
            EditReservation.Show();
        }

        private void DGView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int x = Convert.ToInt32(DGView.Rows[e.RowIndex].Cells[0].Value);
            var query = (from roomres in contextDB.RoomReserved
                         where roomres.Reservation_ID == x
                         select new
                         {
                             roomres.Room.RoomNameUnique
                         }).ToList();


            DGViewRooms.DataSource = query; 
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {

            if(DGView.SelectedRows.Count > 0)
            {
                
                string info = "Are you sure you want to delete this Reservation?";
                CustomDialog DeleteRes = new CustomDialog(info, 2);
                DeleteRes.ShowDialog();

                if(DeleteRes.DialogResult.Equals(DialogResult.Yes))
                {
                int y = Convert.ToInt32(DGView[0, DGView.CurrentRow.Index].Value);
                    var query1 = from roomres in contextDB.RoomReserved
                                 where roomres.Reservation_ID == y
                                 select roomres;
                    foreach (var item in query1)
                    {
                        contextDB.RoomReserved.DeleteOnSubmit(item);
                    }
                    contextDB.SubmitChanges();

                    var query2 = from reservation in contextDB.Reservation
                                 where reservation.Id == y
                                 select reservation;

                    foreach (var item in query2)
                    {
                        contextDB.Reservation.DeleteOnSubmit(item);
                    }
                    contextDB.SubmitChanges();
                    FillData();
                }
            }
        }




    }
}
