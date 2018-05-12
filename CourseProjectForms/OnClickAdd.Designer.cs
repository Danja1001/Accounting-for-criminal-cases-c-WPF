namespace CourseProjectForms
{
    partial class OnClickAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnClickAdd));
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.AddLawyerBtn = new System.Windows.Forms.Button();
            this.LawyerAddLabel = new System.Windows.Forms.Label();
            this.LawyerPasswordLbl = new System.Windows.Forms.Label();
            this.LawyerEmaillbl = new System.Windows.Forms.Label();
            this.LawyerEmailTxt = new System.Windows.Forms.TextBox();
            this.LawyerPasswordTxt = new System.Windows.Forms.TextBox();
            this.BackAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(137, 110);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 20);
            this.FirstNameText.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(137, 157);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 20);
            this.LastNameText.TabIndex = 1;
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CustomFormat = "dd-MM-yyyy";
            this.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthPicker.Location = new System.Drawing.Point(137, 272);
            this.DateOfBirthPicker.MaximumSize = new System.Drawing.Size(100, 20);
            this.DateOfBirthPicker.MinimumSize = new System.Drawing.Size(100, 20);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirthPicker.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(60, 110);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(64, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First name - ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(60, 157);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(65, 13);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last name - ";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(60, 272);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(74, 13);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of birth - ";
            // 
            // AddLawyerBtn
            // 
            this.AddLawyerBtn.Location = new System.Drawing.Point(162, 319);
            this.AddLawyerBtn.Name = "AddLawyerBtn";
            this.AddLawyerBtn.Size = new System.Drawing.Size(75, 35);
            this.AddLawyerBtn.TabIndex = 8;
            this.AddLawyerBtn.Text = "+Add New Lawyer";
            this.AddLawyerBtn.UseVisualStyleBackColor = true;
            this.AddLawyerBtn.Click += new System.EventHandler(this.AddLawyerBtn_Click);
            // 
            // LawyerAddLabel
            // 
            this.LawyerAddLabel.AutoSize = true;
            this.LawyerAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerAddLabel.Location = new System.Drawing.Point(51, 36);
            this.LawyerAddLabel.MaximumSize = new System.Drawing.Size(186, 37);
            this.LawyerAddLabel.MinimumSize = new System.Drawing.Size(186, 37);
            this.LawyerAddLabel.Name = "LawyerAddLabel";
            this.LawyerAddLabel.Size = new System.Drawing.Size(186, 37);
            this.LawyerAddLabel.TabIndex = 9;
            this.LawyerAddLabel.Text = "Add Lawyer";
            // 
            // LawyerPasswordLbl
            // 
            this.LawyerPasswordLbl.AutoSize = true;
            this.LawyerPasswordLbl.Location = new System.Drawing.Point(60, 239);
            this.LawyerPasswordLbl.Name = "LawyerPasswordLbl";
            this.LawyerPasswordLbl.Size = new System.Drawing.Size(59, 13);
            this.LawyerPasswordLbl.TabIndex = 13;
            this.LawyerPasswordLbl.Text = "Password -";
            // 
            // LawyerEmaillbl
            // 
            this.LawyerEmaillbl.AutoSize = true;
            this.LawyerEmaillbl.Location = new System.Drawing.Point(60, 202);
            this.LawyerEmaillbl.Name = "LawyerEmaillbl";
            this.LawyerEmaillbl.Size = new System.Drawing.Size(38, 13);
            this.LawyerEmaillbl.TabIndex = 12;
            this.LawyerEmaillbl.Text = "Email -";
            // 
            // LawyerEmailTxt
            // 
            this.LawyerEmailTxt.Location = new System.Drawing.Point(137, 199);
            this.LawyerEmailTxt.Name = "LawyerEmailTxt";
            this.LawyerEmailTxt.Size = new System.Drawing.Size(100, 20);
            this.LawyerEmailTxt.TabIndex = 10;
            // 
            // LawyerPasswordTxt
            // 
            this.LawyerPasswordTxt.Location = new System.Drawing.Point(137, 236);
            this.LawyerPasswordTxt.Name = "LawyerPasswordTxt";
            this.LawyerPasswordTxt.PasswordChar = '*';
            this.LawyerPasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.LawyerPasswordTxt.TabIndex = 14;
            // 
            // BackAdmin
            // 
            this.BackAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.BackAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackAdmin.ForeColor = System.Drawing.Color.SeaShell;
            this.BackAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BackAdmin.Image")));
            this.BackAdmin.Location = new System.Drawing.Point(2, 0);
            this.BackAdmin.Name = "BackAdmin";
            this.BackAdmin.Size = new System.Drawing.Size(36, 23);
            this.BackAdmin.TabIndex = 15;
            this.BackAdmin.UseVisualStyleBackColor = false;
            this.BackAdmin.Click += new System.EventHandler(this.BackAdmin_Click);
            // 
            // OnClickAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(301, 397);
            this.Controls.Add(this.BackAdmin);
            this.Controls.Add(this.LawyerPasswordTxt);
            this.Controls.Add(this.LawyerPasswordLbl);
            this.Controls.Add(this.LawyerEmaillbl);
            this.Controls.Add(this.LawyerEmailTxt);
            this.Controls.Add(this.LawyerAddLabel);
            this.Controls.Add(this.AddLawyerBtn);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstNameText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(317, 436);
            this.MinimumSize = new System.Drawing.Size(317, 436);
            this.Name = "OnClickAdd";
            this.Text = "Add Lawyer";
            this.Load += new System.EventHandler(this.OnClickAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Button AddLawyerBtn;
        private System.Windows.Forms.Label LawyerAddLabel;
        private System.Windows.Forms.Label LawyerPasswordLbl;
        private System.Windows.Forms.Label LawyerEmaillbl;
        private System.Windows.Forms.TextBox LawyerEmailTxt;
        private System.Windows.Forms.TextBox LawyerPasswordTxt;
        private System.Windows.Forms.Button BackAdmin;
    }
}