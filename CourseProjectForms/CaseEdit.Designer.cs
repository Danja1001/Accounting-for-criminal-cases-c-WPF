namespace CourseProjectForms
{
    partial class CaseEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseEdit));
            this.CaseDescriptionTxt = new System.Windows.Forms.TextBox();
            this.CaseStartPicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.CaseAddLbl = new System.Windows.Forms.Label();
            this.CaseEditBtn = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.CaseTitleLbl = new System.Windows.Forms.Label();
            this.CaseTitleTxt = new System.Windows.Forms.TextBox();
            this.caseIdTxt = new System.Windows.Forms.TextBox();
            this.BackCase = new System.Windows.Forms.Button();
            this.CaseDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaseDescriptionTxt
            // 
            this.CaseDescriptionTxt.Location = new System.Drawing.Point(139, 157);
            this.CaseDescriptionTxt.Multiline = true;
            this.CaseDescriptionTxt.Name = "CaseDescriptionTxt";
            this.CaseDescriptionTxt.Size = new System.Drawing.Size(100, 92);
            this.CaseDescriptionTxt.TabIndex = 37;
            // 
            // CaseStartPicker
            // 
            this.CaseStartPicker.CustomFormat = "dd-MM-yyyy";
            this.CaseStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseStartPicker.Location = new System.Drawing.Point(139, 269);
            this.CaseStartPicker.MaximumSize = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.MinimumSize = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.Name = "CaseStartPicker";
            this.CaseStartPicker.Size = new System.Drawing.Size(100, 20);
            this.CaseStartPicker.TabIndex = 36;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(62, 269);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(59, 13);
            this.StartDateLbl.TabIndex = 35;
            this.StartDateLbl.Text = "Start date -";
            // 
            // CaseAddLbl
            // 
            this.CaseAddLbl.AutoSize = true;
            this.CaseAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseAddLbl.Location = new System.Drawing.Point(69, 30);
            this.CaseAddLbl.MaximumSize = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.MinimumSize = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.Name = "CaseAddLbl";
            this.CaseAddLbl.Size = new System.Drawing.Size(186, 37);
            this.CaseAddLbl.TabIndex = 34;
            this.CaseAddLbl.Text = "Edit Case";
            // 
            // CaseEditBtn
            // 
            this.CaseEditBtn.Location = new System.Drawing.Point(164, 311);
            this.CaseEditBtn.Name = "CaseEditBtn";
            this.CaseEditBtn.Size = new System.Drawing.Size(75, 35);
            this.CaseEditBtn.TabIndex = 33;
            this.CaseEditBtn.Text = "Edit Case";
            this.CaseEditBtn.UseVisualStyleBackColor = true;
            this.CaseEditBtn.Click += new System.EventHandler(this.CaseEditBtn_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(57, 184);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(69, 13);
            this.Description.TabIndex = 31;
            this.Description.Text = "Description - ";
            // 
            // CaseTitleLbl
            // 
            this.CaseTitleLbl.AutoSize = true;
            this.CaseTitleLbl.Location = new System.Drawing.Point(57, 121);
            this.CaseTitleLbl.Name = "CaseTitleLbl";
            this.CaseTitleLbl.Size = new System.Drawing.Size(36, 13);
            this.CaseTitleLbl.TabIndex = 30;
            this.CaseTitleLbl.Text = "Title - ";
            // 
            // CaseTitleTxt
            // 
            this.CaseTitleTxt.Location = new System.Drawing.Point(139, 118);
            this.CaseTitleTxt.Name = "CaseTitleTxt";
            this.CaseTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.CaseTitleTxt.TabIndex = 28;
            // 
            // caseIdTxt
            // 
            this.caseIdTxt.Location = new System.Drawing.Point(139, 69);
            this.caseIdTxt.Name = "caseIdTxt";
            this.caseIdTxt.Size = new System.Drawing.Size(10, 20);
            this.caseIdTxt.TabIndex = 38;
            this.caseIdTxt.Visible = false;
            // 
            // BackCase
            // 
            this.BackCase.BackColor = System.Drawing.Color.SeaShell;
            this.BackCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackCase.ForeColor = System.Drawing.Color.SeaShell;
            this.BackCase.Image = ((System.Drawing.Image)(resources.GetObject("BackCase.Image")));
            this.BackCase.Location = new System.Drawing.Point(2, 2);
            this.BackCase.Name = "BackCase";
            this.BackCase.Size = new System.Drawing.Size(36, 23);
            this.BackCase.TabIndex = 39;
            this.BackCase.UseVisualStyleBackColor = false;
            this.BackCase.Click += new System.EventHandler(this.BackCase_Click);
            // 
            // CaseDelete
            // 
            this.CaseDelete.Location = new System.Drawing.Point(74, 311);
            this.CaseDelete.Name = "CaseDelete";
            this.CaseDelete.Size = new System.Drawing.Size(75, 35);
            this.CaseDelete.TabIndex = 40;
            this.CaseDelete.Text = "Delete";
            this.CaseDelete.UseVisualStyleBackColor = true;
            this.CaseDelete.Click += new System.EventHandler(this.CaseDelete_Click);
            // 
            // CaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(301, 390);
            this.Controls.Add(this.CaseDelete);
            this.Controls.Add(this.BackCase);
            this.Controls.Add(this.caseIdTxt);
            this.Controls.Add(this.CaseDescriptionTxt);
            this.Controls.Add(this.CaseStartPicker);
            this.Controls.Add(this.StartDateLbl);
            this.Controls.Add(this.CaseAddLbl);
            this.Controls.Add(this.CaseEditBtn);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.CaseTitleLbl);
            this.Controls.Add(this.CaseTitleTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(317, 429);
            this.MinimumSize = new System.Drawing.Size(317, 429);
            this.Name = "CaseEdit";
            this.Text = "Case Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaseDescriptionTxt;
        private System.Windows.Forms.DateTimePicker CaseStartPicker;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label CaseAddLbl;
        private System.Windows.Forms.Button CaseEditBtn;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label CaseTitleLbl;
        private System.Windows.Forms.TextBox CaseTitleTxt;
        private System.Windows.Forms.TextBox caseIdTxt;
        private System.Windows.Forms.Button BackCase;
        private System.Windows.Forms.Button CaseDelete;
    }
}