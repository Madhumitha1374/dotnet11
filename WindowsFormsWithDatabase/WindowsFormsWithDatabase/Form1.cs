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

namespace WindowsFormsWithDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            MessageBox.Show("Successful");
            SqlCommand cmd = new SqlCommand("select * from tbl_test", scon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
            scon.Close();

        }
    }
}
