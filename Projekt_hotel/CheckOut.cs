using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projekt_hotel
{
    public partial class CheckOut : Form
    {
        databaseHotelDataContext contextDB = new databaseHotelDataContext();

        int order = 1;
        double total = 0;


        public CheckOut(int ID)
        {

            InitializeComponent();
            receiptBindingSource.DataSource = new List<Receipt>(); // empty list
            FillGridAndList(ID);
        }


// LOAD CHARGES

        private void FillGridAndList(int ID)
        {
            var roomsToList = from roomres in contextDB.RoomReserved
                        where roomres.Reservation_ID.Equals(ID)
                        select roomres;

            var resToDate = (from res in contextDB.Reservation
                             where res.Id.Equals(ID)
                             select res).SingleOrDefault();

            int totalDays = Convert.ToInt32((resToDate.EndDate - resToDate.StartDate).TotalDays);

                    
            foreach (var item in roomsToList)
            {
                Receipt obj = new Receipt() { Id = order++, ProductName = item.Room.RoomNameUnique.ToString(), Price = Convert.ToDouble( item.PriceFromDate ), Quantity = totalDays };
                total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();

                ClearAfterAdd();
            }
            
        }


        private void AddB_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ProductTB.Text) && !string.IsNullOrWhiteSpace(PriceTB.Text) && !string.IsNullOrWhiteSpace(QuantityTB.Text))
            {
                Receipt obj = new Receipt() { Id = order++, ProductName = ProductTB.Text, Price = Convert.ToDouble(PriceTB.Text), Quantity = Convert.ToInt32(QuantityTB.Text) };
                total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();

                ClearAfterAdd();
                
            }
        }


        private void RemoveB_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if(obj != null)
            {
                total -= obj.Price * obj.Quantity;
                TotalTB.Text = string.Format("{0}$", total);
            }
            receiptBindingSource.RemoveCurrent();
        }

        private void PrintB_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(CashTB.Text))
            {
                double x = Convert.ToDouble(CashTB.Text);
                string change = (x - total).ToString();

                using (FormPrint frm = new FormPrint(receiptBindingSource.DataSource as List<Receipt>,string.Format("{0}$",total), string.Format("{0}$",CashTB.Text), string.Format("{0}$",change), DateTime.Now.ToString("MM/dd/yyyy")))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                string Error1 = "Please enter how much the customer has paid";
                CustomDialog Error = new CustomDialog(Error1, 1);
                Error.ShowDialog();
            }
  
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearAfterAdd()
        {
            ProductTB.Text = "";
            QuantityTB.Text = "";
            PriceTB.Text = "";
            TotalTB.Text = string.Format("{0}$", total);
        }


    }
}
