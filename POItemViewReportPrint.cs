using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class POItemViewReportPrint : Form
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ims";
        MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
        public POItemViewReportPrint()
        {
            InitializeComponent();
        }

        private void POItemViewReportPrint_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM po_item", conn);
            MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM store", conn);
            var commandBuilder = new MySqlCommandBuilder(sda);
            var commandBuilder1 = new MySqlCommandBuilder(sda1);
           
            DataSet dst = new DataSet();
            //DataTable dt = new DataTable();
            Console.WriteLine("In now NEW");
            //Console.WriteLine(dt);
            sda.Fill(dst, "po_item");
            sda1.Fill(dst, "store");
           
            //Console.WriteLine("Data Table is "+ dt);
            poItemViewReport1.SetDataSource(dst);
            //allPurchaseOrdes1.SetParameterValue("pDateTime", DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            //poItemViewReport1.SetParameterValue("pCreaedBy", GlobalLoginData.username);
            crystalReportViewer1.ReportSource = poItemViewReport1;

            conn.Close();
        }
    }
}
