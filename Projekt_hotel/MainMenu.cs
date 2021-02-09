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
        readonly User LoggedUser;
        List<Reservations> allReservations;
        
        public MainMenu(User user)
        {
            LoggedUser = user;
            InitializeComponent();
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


                    // remove all rooms under this booking
                    var query1 = from roomres in contextDB.RoomReserved
                                 where roomres.Reservation_ID == y
                                 select roomres;

                    foreach (var item in query1)
                    {
                        contextDB.RoomReserved.DeleteOnSubmit(item);
                    }
                    contextDB.SubmitChanges();

                    /*
                     * 
                     * 
                     *  USUN WSZYSTKIE OSOBY POD TA REZERWACJA 
                     * 
                     */

                    // delete this booking
                    var query2 = (from reservation in contextDB.Reservation
                                  where reservation.Id == y
                                  select reservation).SingleOrDefault();

                    
                    contextDB.Reservation.DeleteOnSubmit(query2);
                    //foreach (var item in query2)
                    //{
                    //    contextDB.Reservation.DeleteOnSubmit(item);
                    //}
                    contextDB.SubmitChanges();
                    RefreshData();
                }
            }
        }


        // data loading
        public void RefreshData()
        {
           allReservations = ListManager.LoadSampleReservation();
           table.Rows.Clear();

            for(int i = 0; i < allReservations.Count; i++)
            {
                table.Rows.Add(
                     allReservations[i].Id, 
                     allReservations[i].StartDate, 
                     allReservations[i].EndDate, 
                     allReservations[i].TotalPrice, 
                     allReservations[i].LastName, 
                     allReservations[i].WorkerId
                    );
            }

            DGView.DataSource = table;
            DGView.Columns[0].Visible = false;
            categoryCombobox.SelectedIndex = 0;
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
        private void MainMenu_Load(object sender, EventArgs e)
        {
            FillComboBox();
            RefreshData();
            categoryCombobox.SelectedIndex = 0;
            DGView.Rows[0].Selected = false;
            label1.Text += " " + LoggedUser.GetName();
        }



        // changes to the form
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // if we do not provide any data, search according to combobox
            if (string.IsNullOrWhiteSpace(searchTextbox.Text))
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
        private void DGView_SelectionChanged(object sender, EventArgs e)
        {
            if(DGView.SelectedRows.Count > 0)
            {
                CheckOutB.Enabled = true;
                EditReservation.Enabled = true;
                DeleteReservation.Enabled = true;
            }
            else
            {
                CheckOutB.Enabled = false;
                EditReservation.Enabled = false;
                DeleteReservation.Enabled = false;
            }
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



        // data management
        private void CheckInB_Click(object sender, EventArgs e)
        {
            NewReservation NR = new NewReservation(LoggedUser.GetId(),0, 1);
            NR.ShowDialog();
        }
        private void CheckOutB_Click(object sender, EventArgs e)
        {
            CheckOut CO = new CheckOut(Convert.ToInt32(DGView[0, DGView.CurrentRow.Index].Value));
            CO.ShowDialog();
        }
        private void EditReservation_Click(object sender, EventArgs e)
        {
            NewReservation EditReservation = new NewReservation(LoggedUser.GetId(), Convert.ToInt32(DGView[0, DGView.CurrentRow.Index].Value), 2);
            EditReservation.ShowDialog();
        }
        private void ListOfUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfUsers LOU = new ListOfUsers(LoggedUser);
            LOU.ShowDialog();
        }


        // closing the interface
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            //find working form 
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is LogIn);

            if (formToShow != null)
                formToShow.Show();
            
        }
        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
