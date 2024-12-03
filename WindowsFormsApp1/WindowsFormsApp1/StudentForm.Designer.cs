namespace WindowsFormsApp1
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDelhi = new System.Windows.Forms.CheckBox();
            this.cbChennai = new System.Windows.Forms.CheckBox();
            this.cbBang = new System.Windows.Forms.CheckBox();
            this.cbHyd = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhonenum = new System.Windows.Forms.ErrorProvider(this.components);
            this.gender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhonenum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "StudentForm";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Form";
            // 
            // label2
            // 
            this.label2.AccessibleName = "lablName";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lblId";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblGneder";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblHometown";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Town";
            // 
            // label6
            // 
            this.label6.AccessibleName = "lblLocation";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblEmail";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email Id";
            // 
            // label8
            // 
            this.label8.AccessibleName = "lblPhone";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone";
            // 
            // txtname
            // 
            this.txtname.AccessibleName = "txtName";
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(742, 143);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(262, 30);
            this.txtname.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleName = "txtPhone";
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(742, 640);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(262, 30);
            this.txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "txtEmail";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(742, 571);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.AccessibleName = "txtHometown";
            this.txtHomeTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeTown.Location = new System.Drawing.Point(742, 356);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(262, 30);
            this.txtHomeTown.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.AccessibleName = "txtId";
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(742, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(262, 30);
            this.txtId.TabIndex = 13;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.rdoFemale);
            this.gender.Controls.Add(this.rdoMale);
            this.gender.Location = new System.Drawing.Point(742, 278);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(284, 38);
            this.gender.TabIndex = 14;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AccessibleName = "femaleRadio";
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(175, 12);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(102, 29);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AccessibleName = "maleRadio";
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(4, 13);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(80, 29);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDelhi);
            this.groupBox1.Controls.Add(this.cbChennai);
            this.groupBox1.Controls.Add(this.cbBang);
            this.groupBox1.Controls.Add(this.cbHyd);
            this.groupBox1.Location = new System.Drawing.Point(742, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 107);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cbDelhi
            // 
            this.cbDelhi.AccessibleName = "cbDelhi";
            this.cbDelhi.AutoSize = true;
            this.cbDelhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelhi.Location = new System.Drawing.Point(160, 69);
            this.cbDelhi.Name = "cbDelhi";
            this.cbDelhi.Size = new System.Drawing.Size(82, 29);
            this.cbDelhi.TabIndex = 3;
            this.cbDelhi.Text = "Delhi";
            this.cbDelhi.UseVisualStyleBackColor = true;
            // 
            // cbChennai
            // 
            this.cbChennai.AccessibleName = "cbChennai";
            this.cbChennai.AutoSize = true;
            this.cbChennai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChennai.Location = new System.Drawing.Point(6, 70);
            this.cbChennai.Name = "cbChennai";
            this.cbChennai.Size = new System.Drawing.Size(112, 29);
            this.cbChennai.TabIndex = 2;
            this.cbChennai.Text = "Chennai";
            this.cbChennai.UseVisualStyleBackColor = true;
            // 
            // cbBang
            // 
            this.cbBang.AccessibleName = "cbBang";
            this.cbBang.AutoSize = true;
            this.cbBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBang.Location = new System.Drawing.Point(160, 15);
            this.cbBang.Name = "cbBang";
            this.cbBang.Size = new System.Drawing.Size(127, 29);
            this.cbBang.TabIndex = 1;
            this.cbBang.Text = "Bangalore";
            this.cbBang.UseVisualStyleBackColor = true;
            // 
            // cbHyd
            // 
            this.cbHyd.AccessibleName = "checkbHyd";
            this.cbHyd.AutoSize = true;
            this.cbHyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHyd.Location = new System.Drawing.Point(0, 15);
            this.cbHyd.Name = "cbHyd";
            this.cbHyd.Size = new System.Drawing.Size(134, 29);
            this.cbHyd.TabIndex = 0;
            this.cbHyd.Text = "Hyderabad";
            this.cbHyd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnSubmit";
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(742, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorPhonenum
            // 
            this.errorPhonenum.ContainerControl = this;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1500, 793);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtHomeTown);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhonenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel gender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbChennai;
        private System.Windows.Forms.CheckBox cbBang;
        private System.Windows.Forms.CheckBox cbHyd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbDelhi;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorPhonenum;
    }
}