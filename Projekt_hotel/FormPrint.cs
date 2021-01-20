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
    public partial class FormPrint : Form
    {
        
        List<Receipt> ListOfReceipt;
        string Total, Cash, Change, Date;

        private void FormPrint_Load(object sender, EventArgs e)
        {

        }

        public FormPrint(List<Receipt> DATASOURCE, string TOTAL, string CASH, string CHANGE, string DATE)
        {
            InitializeComponent();
            ListOfReceipt = DATASOURCE;
            Total = TOTAL;
            Cash = CASH;
            Change = CHANGE;
            Date = DATE;

            load();
        }
        
        private void load()
        {
            reportViewer1.LocalReport.ReportPath = "RaportReceipt.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet", ListOfReceipt);
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pData",Date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",Total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",Cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",Change)
            };
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

        }
    }
}
