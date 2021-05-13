using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.ReportForm
{
    public partial class StockReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();

        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {

        }

        DataSet dst = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            //cryrpt.Load(@"C:\Users\DNS\source\repos\Stock\Stock\Reports\Stock.rpt");
            //SqlConnection con = Connection.GetConnection();
            //con.Open();
            //string s = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            //string s1 = dateTimePicker2.Value.ToString("MM/dd/yyyy");

            //SqlDataAdapter sda = new SqlDataAdapter(string.Format("Select * From [Stock] where TransDate between '{0}' and '{1}'",s, s1), con);
            //sda.Fill(dst, "Stock");
            //cryrpt.SetDataSource(dst);
            //cryrpt.SetParameterValue("@FromDate", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            //cryrpt.SetParameterValue("@ToDate", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            //crystalReportViewer1.ReportSource = cryrpt;
            cryrpt.Load(@"C:\Users\DNS\source\repos\Stock\Stock\ReportForm\Reports\Stock.rpt");
            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Stock where TransDate between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", con);
            sda.Fill(dst, "Stock");
            cryrpt.SetDataSource(dst);
            cryrpt.SetParameterValue("@FromDate", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            cryrpt.SetParameterValue("@ToDate", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
