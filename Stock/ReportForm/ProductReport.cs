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
    public partial class ProductReport : Form
    {
        ReportDocument crypt = new ReportDocument();
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {
            crypt.Load(@"C:\Users\DNS\source\repos\Stock\Stock\ReportForm\Reports\Product.rpt");
            SqlConnection con = Connection.GetConnection();
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            crypt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crypt;
        }
    }
}
