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
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int salary = Convert.ToInt32(textBox3.Text);
            string city = textBox4.Text;

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_test(id, name, salary, city) values("+id+", '"+name+"', "+salary+", '"+city+"')", scon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successful");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            /*SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
            DataTable dt = new DataTable();
            adp.Fill(dt);*/

            scon.Close();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            DeleteData deleteData = new DeleteData();
            deleteData.Show();

           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Form update = new Update_Form();
            update.Show();
        }
    }
}
