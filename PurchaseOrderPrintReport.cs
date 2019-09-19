using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class PurchaseOrderPrintReport : Form
    {

        //ReportDocument cryrpt = new ReportDocument();
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ims";
        MySqlConnection conn = new MySqlConnection(MySQLConnectionString);


        public PurchaseOrderPrintReport()
        {
            InitializeComponent();
        }

        private void PurchaseOrderPrintReport_Load(object sender, EventArgs e)
        {
            Console.WriteLine("In the required place");
            //cryrpt.Load(@"C:\Users\Home\Desktop\InventoryManagementSystemV02\ApprovedPurchaseOrdersReport.rpt");

            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM purchaseorder", conn);
            MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM supplier", conn);
            var commandBuilder = new MySqlCommandBuilder(sda);
            var commandBuilder1 = new MySqlCommandBuilder(sda1);
            DataSet dst = new DataSet();
            //DataTable dt = new DataTable();
            Console.WriteLine("In now");
            //Console.WriteLine(dt);
            sda.Fill(dst,"purchaseorder");
            sda1.Fill(dst, "supplier");
            //Console.WriteLine("Data Table is "+ dt);
            allPurchaseReport1.SetDataSource(dst);
            //allPurchaseOrdes1.SetParameterValue("pDateTime", DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            allPurchaseReport1.SetParameterValue("pReportedBy", GlobalLoginData.username);
            crystalReportViewer1.ReportSource = allPurchaseReport1;

            conn.Close();
        }

        private void ApprovedPurchaseOrdersReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
