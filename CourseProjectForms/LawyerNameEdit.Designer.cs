namespace CourseProjectForms
{
    partial class LawyerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerEdit));
            this.FirstNameEditLbl = new System.Windows.Forms.Label();
            this.FirstNameEditTxt = new System.Windows.Forms.TextBox();
            this.LawyerSaveData = new System.Windows.Forms.Button();
            this.LastNameEditTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LawyerId = new System.Windows.Forms.TextBox();
            this.BackAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameEditLbl
            // 
            this.FirstNameEditLbl.AutoSize = true;
            this.FirstNameEditLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameEditLbl.Location = new System.Drawing.Point(12, 25);
            this.FirstNameEditLbl.Name = "FirstNameEditLbl";
            this.FirstNameEditLbl.Size = new System.Drawing.Size(108, 26);
            this.FirstNameEditLbl.TabIndex = 0;
            this.FirstNameEditLbl.Text = "First name:";
            // 
            // FirstNameEditTxt
            // 
            this.FirstNameEditTxt.Location = new System.Drawing.Point(126, 31);
            this.FirstNameEditTxt.Name = "FirstNameEditTxt";
            this.FirstNameEditTxt.Size = new System.Drawing.Size(100, 20);
            this.FirstNameEditTxt.TabIndex = 1;
            // 
            // LawyerSaveData
            // 
            this.LawyerSaveData.Location = new System.Drawing.Point(151, 112);
            this.LawyerSaveData.Name = "LawyerSaveData";
            this.LawyerSaveData.Size = new System.Drawing.Size(75, 35);
            this.LawyerSaveData.TabIndex = 2;
            this.LawyerSaveData.Text = "Save";
            this.LawyerSaveData.UseVisualStyleBackColor = true;
            this.LawyerSaveData.Click += new System.EventHandler(this.LawyerSaveData_Click);
            // 
            // LastNameEditTxt
            // 
            this.LastNameEditTxt.Location = new System.Drawing.Point(126, 75);
            this.LastNameEditTxt.Name = "LastNameEditTxt";
            this.LastNameEditTxt.Size = new System.Drawing.Size(100, 20);
            this.LastNameEditTxt.TabIndex = 4;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLbl.Location = new System.Drawing.Point(12, 69);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(105, 26);
            this.LastNameLbl.TabIndex = 3;
            this.LastNameLbl.Text = "Last name:";
            // 
            // LawyerId
            // 
            this.LawyerId.Location = new System.Drawing.Point(232, 31);
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.Size = new System.Drawing.Size(10, 20);
            this.LawyerId.TabIndex = 5;
            this.LawyerId.Visible = false;
            // 
            // BackAdmin
            // 
            this.BackAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.BackAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackAdmin.ForeColor = System.Drawing.Color.SeaShell;
            this.BackAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BackAdmin.Image")));
            this.BackAdmin.Location = new System.Drawing.Point(1, -1);
            this.BackAdmin.Name = "BackAdmin";
            this.BackAdmin.Size = new System.Drawing.Size(36, 23);
            this.BackAdmin.TabIndex = 16;
            this.BackAdmin.UseVisualStyleBackColor = false;
            this.BackAdmin.Click += new System.EventHandler(this.BackAdmin_Click);
            // 
            // LawyerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(269, 159);
            this.Controls.Add(this.BackAdmin);
            this.Controls.Add(this.LawyerId);
            this.Controls.Add(this.LastNameEditTxt);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LawyerSaveData);
            this.Controls.Add(this.FirstNameEditTxt);
            this.Controls.Add(this.FirstNameEditLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LawyerEdit";
            this.Text = "Lawyer Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameEditLbl;
        private System.Windows.Forms.TextBox FirstNameEditTxt;
        private System.Windows.Forms.Button LawyerSaveData;
        private System.Windows.Forms.TextBox LastNameEditTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LawyerId;
        private System.Windows.Forms.Button BackAdmin;
    }
}