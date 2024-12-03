using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "Madhu");
            dt.Rows.Add(2, "Madhavi");
            dt.Rows.Add(3, "Keerthi");
            dt.Rows.Add(4, "Devi");
            dt.Rows.Add(5, "CHinni");

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            
        }
    }
}
