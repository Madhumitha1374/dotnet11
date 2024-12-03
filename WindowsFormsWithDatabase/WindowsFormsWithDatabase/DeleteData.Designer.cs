namespace WindowsFormsWithDatabase
{
    partial class DeleteData
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(499, 286);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(220, 73);
            this.btnDeleteRecord.TabIndex = 0;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(628, 182);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(133, 26);
            this.textId.TabIndex = 2;
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 777);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRecord);
            this.Name = "DeleteData";
            this.Text = "DeleteData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
    }
}