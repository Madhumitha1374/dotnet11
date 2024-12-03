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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsWithDatabase
{
    public partial class DeleteData : Form
    {
        public DeleteData()
        {
            InitializeComponent();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_test where id = "+id+"", scon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successful");
            textId.Text = "";
        }
    }
}
