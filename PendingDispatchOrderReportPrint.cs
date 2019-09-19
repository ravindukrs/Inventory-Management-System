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
    public partial class PendingDispatchOrderReportPrint : Form
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ims";
        MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
        public PendingDispatchOrderReportPrint()
        {
            InitializeComponent();
        }

        private void PendingDispatchOrderReportPrint_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM requestorder WHERE approval='Pending'", conn);

            var commandBuilder = new MySqlCommandBuilder(sda);

            DataSet dst = new DataSet();
            //DataTable dt = new DataTable();
            Console.WriteLine("In now NEW");
            //Console.WriteLine(dt);
            sda.Fill(dst, "requestorder");

            //Console.WriteLine("Data Table is "+ dt);
            pendingDispatchOrderReport1.SetDataSource(dst);
            //allPurchaseOrdes1.SetParameterValue("pDateTime", DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            pendingDispatchOrderReport1.SetParameterValue("pReportedBy", GlobalLoginData.username);
            crystalReportViewer1.ReportSource = pendingDispatchOrderReport1;

            conn.Close();
        }
    }
}
