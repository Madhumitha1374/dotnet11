using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentMarks : Form
    {
        public StudentMarks()
        {
            InitializeComponent();
        }

        private void StudentMarks_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id;
            string name;
            double maths;
            double science;
            double social;
            string result;
            int percentage;
            string grade;

            lblReset.Visible = true;


            Results r = new Results();

            id = txtId.Text;
            name = txtName.Text;
            maths = Convert.ToDouble(txtMaths.Text);
            science = Convert.ToDouble(txtScience.Text);
            social = Convert.ToDouble(txtSocial.Text);

            if (maths >= 0 && social >= 0 && science >= 0 && maths <= 100 && social <=100 && science <= 100)
            {
                if (maths >= 35 && social >= 35 && science >= 35)
                {
                    string per = r.Percentage(maths, social, science);
                    lblPerResult.Text = per + "%";
                    lblPercentage.Visible = true;
                    lblPerResult.Visible = true;


                    char gr = r.Grade(Convert.ToInt32(Math.Round(Convert.ToDouble(per), 0)));
                    if (gr == 'F')
                    {
                        lblgr.ForeColor = Color.Red;
                        lblGrade.Visible = true;
                        lblgr.Visible = false;
                        lblPercentage.Visible= false;
                        lblPerResult.Visible= false;
                    }
                    lblgr.Text = gr.ToString();
                    lblgr.Visible = true;
                    lblGrade.Visible = true;

                    result = "Passed";
                    lblResult.Text = result;
                    lblResult.ForeColor = Color.Green;
                    lblResultH.Visible = true;
                    lblResult.Visible = true;

                    lblmark.Visible = true;
                    lbltotalMarks.Text = (Convert.ToInt32(maths) + Convert.ToInt32(science) + Convert.ToInt32(social)).ToString();
                    lbltotalMarks.Visible = true;


                    string filePath = @"D:\\DotNetWorking\\WindowsFormsApp1\\StudentMarks.txt\";

                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine("Student Id : " + id);
                        sw.WriteLine("Student Name : " + name);
                        sw.WriteLine("Total Marks : " + (Convert.ToInt32(maths)+ Convert.ToInt32(science) + Convert.ToInt32(social)));
                        sw.WriteLine("Percentage : " + per);
                        sw.WriteLine("Grade id : " + gr);
                        sw.WriteLine("Result : " + result);
                        sw.WriteLine();
                        sw.WriteLine("-------------------------------");
                        sw.WriteLine();

                        MessageBox.Show("Copied to Student Marks file!");

                    }


                }
                else
                {
                    result = "Failed";
                    lblResult.Text = result;
                    lblResult.ForeColor = Color.Red;
                    lblResultH.Visible = true;
                    lblResult.Visible = true;

                    lblgr.Text = 'F'.ToString();
                    lblgr.Visible = true;
                    lblgr.ForeColor = Color.Red;
                    lblGrade.Visible = true;

                    string per = r.Percentage(maths, social, science);
                    lblPerResult.Text = per + "%";
                    lblPercentage.Visible = true;
                    lblPerResult.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Enter valid marks");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtId.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";
            txtSocial.Text = "";
            lblResult.Visible = false;
            lblResultH.Visible=false;
            lblgr.Visible=false;
            lblGrade.Visible=false;
            lblPerResult.Visible=false;
            lblPercentage.Visible=false;
            lblReset.Visible=false;

        }
    }
}
