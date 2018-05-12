namespace CourseProjectForms
{
    partial class AddNewCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCase));
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.CaseAddLbl = new System.Windows.Forms.Label();
            this.CaseAddBtn = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.CaseTitleLbl = new System.Windows.Forms.Label();
            this.CaseTitleTxt = new System.Windows.Forms.TextBox();
            this.CaseStartPicker = new System.Windows.Forms.DateTimePicker();
            this.CaseDescriptionTxt = new System.Windows.Forms.TextBox();
            this.BackCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(71, 256);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(59, 13);
            this.StartDateLbl.TabIndex = 25;
            this.StartDateLbl.Text = "Start date -";
            // 
            // CaseAddLbl
            // 
            this.CaseAddLbl.AutoSize = true;
            this.CaseAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseAddLbl.Location = new System.Drawing.Point(67, 40);
            this.CaseAddLbl.MaximumSize = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.MinimumSize = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.Name = "CaseAddLbl";
            this.CaseAddLbl.Size = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.TabIndex = 22;
            this.CaseAddLbl.Text = "Add Case";
            // 
            // CaseAddBtn
            // 
            this.CaseAddBtn.Location = new System.Drawing.Point(173, 308);
            this.CaseAddBtn.Name = "CaseAddBtn";
            this.CaseAddBtn.Size = new System.Drawing.Size(75, 35);
            this.CaseAddBtn.TabIndex = 21;
            this.CaseAddBtn.Text = "+Add New Case";
            this.CaseAddBtn.UseVisualStyleBackColor = true;
            this.CaseAddBtn.Click += new System.EventHandler(this.CaseAddBtn_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(66, 171);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(69, 13);
            this.Description.TabIndex = 19;
            this.Description.Text = "Description - ";
            // 
            // CaseTitleLbl
            // 
            this.CaseTitleLbl.AutoSize = true;
            this.CaseTitleLbl.Location = new System.Drawing.Point(66, 108);
            this.CaseTitleLbl.Name = "CaseTitleLbl";
            this.CaseTitleLbl.Size = new System.Drawing.Size(36, 13);
            this.CaseTitleLbl.TabIndex = 18;
            this.CaseTitleLbl.Text = "Title - ";
            // 
            // CaseTitleTxt
            // 
            this.CaseTitleTxt.Location = new System.Drawing.Point(148, 105);
            this.CaseTitleTxt.Name = "CaseTitleTxt";
            this.CaseTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.CaseTitleTxt.TabIndex = 15;
            // 
            // CaseStartPicker
            // 
            this.CaseStartPicker.CustomFormat = "dd-MM-yyyy";
            this.CaseStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartPicker.Location = new System.Drawing.Point(148, 256);
            this.CaseStartPicker.MaximumSize = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.MinimumSize = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.Name = "CaseStartPicker";
            this.CaseStartPicker.Size = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.TabIndex = 26;
            // 
            // CaseDescriptionTxt
            // 
            this.CaseDescriptionTxt.Location = new System.Drawing.Point(148, 144);
            this.CaseDescriptionTxt.Multiline = true;
            this.CaseDescriptionTxt.Name = "CaseDescriptionTxt";
            this.CaseDescriptionTxt.Size = new System.Drawing.Size(100, 92);
            this.CaseDescriptionTxt.TabIndex = 27;
            // 
            // BackCase
            // 
            this.BackCase.BackColor = System.Drawing.Color.SeaShell;
            this.BackCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackCase.ForeColor = System.Drawing.Color.SeaShell;
            this.BackCase.Image = ((System.Drawing.Image)(resources.GetObject("BackCase.Image")));
            this.BackCase.Location = new System.Drawing.Point(0, 1);
            this.BackCase.Name = "BackCase";
            this.BackCase.Size = new System.Drawing.Size(36, 23);
            this.BackCase.TabIndex = 28;
            this.BackCase.UseVisualStyleBackColor = false;
            this.BackCase.Click += new System.EventHandler(this.BackCase_Click);
            // 
            // AddNewCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(301, 390);
            this.Controls.Add(this.BackCase);
            this.Controls.Add(this.CaseDescriptionTxt);
            this.Controls.Add(this.CaseStartPicker);
            this.Controls.Add(this.StartDateLbl);
            this.Controls.Add(this.CaseAddLbl);
            this.Controls.Add(this.CaseAddBtn);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.CaseTitleLbl);
            this.Controls.Add(this.CaseTitleTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(317, 429);
            this.MinimumSize = new System.Drawing.Size(317, 429);
            this.Name = "AddNewCase";
            this.Text = "AddNewCase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label CaseAddLbl;
        private System.Windows.Forms.Button CaseAddBtn;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label CaseTitleLbl;
        private System.Windows.Forms.TextBox CaseTitleTxt;
        private System.Windows.Forms.DateTimePicker CaseStartPicker;
        private System.Windows.Forms.TextBox CaseDescriptionTxt;
        private System.Windows.Forms.Button BackCase;
    }
}