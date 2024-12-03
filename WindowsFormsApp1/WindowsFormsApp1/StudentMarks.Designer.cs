namespace WindowsFormsApp1
{
    partial class StudentMarks
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
            this.RESULTS = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.lblResultH = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPerResult = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblgr = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Button();
            this.lblmark = new System.Windows.Forms.Label();
            this.lbltotalMarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RESULTS
            // 
            this.RESULTS.AutoSize = true;
            this.RESULTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTS.Location = new System.Drawing.Point(519, 27);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.Size = new System.Drawing.Size(212, 46);
            this.RESULTS.TabIndex = 0;
            this.RESULTS.Text = "RESULTS";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(83, 102);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(339, 37);
            this.details.TabIndex = 1;
            this.details.Text = "Enter Student Details";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(85, 221);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(131, 29);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Student Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(85, 334);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(793, 102);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(200, 37);
            this.lblMarks.TabIndex = 4;
            this.lblMarks.Text = "Enter Marks";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaths.Location = new System.Drawing.Point(795, 198);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(82, 29);
            this.lblMaths.TabIndex = 5;
            this.lblMaths.Text = "Maths";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.Location = new System.Drawing.Point(795, 270);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(107, 29);
            this.lblScience.TabIndex = 6;
            this.lblScience.Text = "Science";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocial.Location = new System.Drawing.Point(795, 346);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(86, 29);
            this.lblSocial.TabIndex = 7;
            this.lblSocial.Text = "Social";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(320, 220);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(172, 30);
            this.txtId.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(320, 334);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 30);
            this.txtName.TabIndex = 9;
            // 
            // txtMaths
            // 
            this.txtMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaths.Location = new System.Drawing.Point(1011, 197);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 30);
            this.txtMaths.TabIndex = 10;
            // 
            // txtScience
            // 
            this.txtScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScience.Location = new System.Drawing.Point(1011, 269);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 30);
            this.txtScience.TabIndex = 11;
            // 
            // txtSocial
            // 
            this.txtSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocial.Location = new System.Drawing.Point(1011, 345);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 30);
            this.txtSocial.TabIndex = 12;
            // 
            // lblResultH
            // 
            this.lblResultH.AutoSize = true;
            this.lblResultH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultH.Location = new System.Drawing.Point(793, 597);
            this.lblResultH.Name = "lblResultH";
            this.lblResultH.Size = new System.Drawing.Size(148, 37);
            this.lblResultH.TabIndex = 13;
            this.lblResultH.Text = "RESULT";
            this.lblResultH.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(1088, 585);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(107, 49);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result";
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(479, 453);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 49);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(189, 614);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(147, 29);
            this.lblPercentage.TabIndex = 16;
            this.lblPercentage.Text = "Percentage";
            this.lblPercentage.Visible = false;
            // 
            // lblPerResult
            // 
            this.lblPerResult.AutoSize = true;
            this.lblPerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerResult.Location = new System.Drawing.Point(383, 614);
            this.lblPerResult.Name = "lblPerResult";
            this.lblPerResult.Size = new System.Drawing.Size(27, 29);
            this.lblPerResult.TabIndex = 17;
            this.lblPerResult.Text = "0";
            this.lblPerResult.Visible = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(189, 656);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(85, 29);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Visible = false;
            // 
            // lblgr
            // 
            this.lblgr.AutoSize = true;
            this.lblgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgr.Location = new System.Drawing.Point(383, 656);
            this.lblgr.Name = "lblgr";
            this.lblgr.Size = new System.Drawing.Size(29, 29);
            this.lblgr.TabIndex = 19;
            this.lblgr.Text = "F";
            this.lblgr.Visible = false;
            this.lblgr.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(703, 454);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(178, 49);
            this.lblReset.TabIndex = 20;
            this.lblReset.Text = "Reset";
            this.lblReset.UseVisualStyleBackColor = true;
            this.lblReset.Visible = false;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // lblmark
            // 
            this.lblmark.AutoSize = true;
            this.lblmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmark.Location = new System.Drawing.Point(186, 571);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(150, 29);
            this.lblmark.TabIndex = 21;
            this.lblmark.Text = "Total Marks";
            this.lblmark.Visible = false;
            // 
            // lbltotalMarks
            // 
            this.lbltotalMarks.AutoSize = true;
            this.lbltotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalMarks.Location = new System.Drawing.Point(383, 571);
            this.lbltotalMarks.Name = "lbltotalMarks";
            this.lbltotalMarks.Size = new System.Drawing.Size(27, 29);
            this.lbltotalMarks.TabIndex = 22;
            this.lbltotalMarks.Text = "0";
            this.lbltotalMarks.Visible = false;
            // 
            // StudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1716, 794);
            this.Controls.Add(this.lbltotalMarks);
            this.Controls.Add(this.lblmark);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblgr);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblPerResult);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultH);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.lblMaths);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.details);
            this.Controls.Add(this.RESULTS);
            this.Name = "StudentMarks";
            this.Text = "StudentMarks";
            this.Load += new System.EventHandler(this.StudentMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RESULTS;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.Label lblResultH;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPerResult;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblgr;
        private System.Windows.Forms.Button lblReset;
        private System.Windows.Forms.Label lblmark;
        private System.Windows.Forms.Label lbltotalMarks;
    }
}