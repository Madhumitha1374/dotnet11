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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextWriter tx =new StreamWriter("D:\\DotNetWorking\\WindowsFormsApp1\\StudentFormData.txt");
            //tx.Write(textBox1.Text + " " +   textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text);
            //tx.Close();
            //MessageBox.Show("copied to notepad!");

            Utility u = new Utility();

            string name = txtname.Text;
            string id = txtId.Text;
            string homeTown = txtHomeTown.Text;
            string emailId = txtEmail.Text;
            bool t = u.ValidateEmail(emailId);
            string phone = txtPhone.Text;
            bool p = u.ValidatePhoneNumber(phone);
            string gender;
            if (rdoMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string location = " ";
            if(cbHyd.Checked == true)
            {
                location += "Hyderabad ";
            }
            if (cbBang.Checked == true)
            {
                location += "Bangalore ";
            }
            if (cbChennai.Checked == true)
            {
                location += "Chennai ";
            }
            if(cbDelhi.Checked == true)
            {
                location += "Delhi ";
            }

           
            if (!string.IsNullOrEmpty(name))
            {
                label2.ForeColor = Color.Black;
                        if(!string.IsNullOrWhiteSpace(id))
                        {
                    if (string.IsNullOrWhiteSpace(homeTown))
                    {
                        if (t)
                        {
                            if (p)
                            {

                                string myfile = @"D:\\DotNetWorking\\WindowsFormsApp1\\StudentFormData.txt";

                                using (StreamWriter sw = File.AppendText(myfile))
                                {
                                    sw.WriteLine("Name : " + name);
                                    sw.WriteLine("Id : " + id);
                                    sw.WriteLine("Gender : " + gender);
                                    sw.WriteLine("HomeTown : " + homeTown);
                                    sw.WriteLine("Location : " + location);
                                    sw.WriteLine("Email : " + emailId);
                                    sw.WriteLine("Phone Number : " + phone);
                                    sw.WriteLine("-------------------------------");
                                }
                                MessageBox.Show("copied to notepad!");
                            }
                            else
                            {
                                //MessageBox.Show("Enter a valid phone number");
                                errorPhonenum.SetError(txtPhone, "phone number is not Valid");
                            }

                        }
                        else
                        {
                            //MessageBox.Show("Invalid EMail address");
                            errorEmail.SetError(txtEmail, "Email is not Valid");
                        }

                    }
                    else
                    {
                        errorPhonenum.SetError(txtHomeTown, "phone number is not Valid");
                    }

                        }
                        else
                        {
                            errorPhonenum.SetError(txtId, "phone number is not Valid");
                        }
                    }
                    else
                    {
                        label2.ForeColor = Color.Red;
                        errorPhonenum.SetError(txtname, "phone number is not Valid");
                    }
                    
                }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
