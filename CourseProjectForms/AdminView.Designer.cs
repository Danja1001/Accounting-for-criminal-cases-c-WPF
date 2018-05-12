namespace CourseProjectForms
{
    partial class AdminViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewForm));
            this.LawyersGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNewLawyerBtn = new System.Windows.Forms.Button();
            this.LawyerEditorLabel = new System.Windows.Forms.Label();
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CasesEditorBtn = new System.Windows.Forms.Button();
            this.LawyerEditorBtn = new System.Windows.Forms.Button();
            this.LawyerBusy = new System.Windows.Forms.Button();
            this.LawyerFree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LawyersGrid)).BeginInit();
            this.MenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LawyersGrid
            // 
            this.LawyersGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.LawyersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LawyersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LawyersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.LawyerEmail,
            this.DateOfBirth,
            this.Edit});
            this.LawyersGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.LawyersGrid.Location = new System.Drawing.Point(139, 56);
            this.LawyersGrid.Name = "LawyersGrid";
            this.LawyersGrid.Size = new System.Drawing.Size(545, 204);
            this.LawyersGrid.TabIndex = 2;
            this.LawyersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name - ";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name - ";
            this.LastName.Name = "LastName";
            // 
            // LawyerEmail
            // 
            this.LawyerEmail.HeaderText = "Lawyer Email";
            this.LawyerEmail.Name = "LawyerEmail";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date of birth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit lawyer";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // AddNewLawyerBtn
            // 
            this.AddNewLawyerBtn.Location = new System.Drawing.Point(139, 283);
            this.AddNewLawyerBtn.Name = "AddNewLawyerBtn";
            this.AddNewLawyerBtn.Size = new System.Drawing.Size(75, 35);
            this.AddNewLawyerBtn.TabIndex = 5;
            this.AddNewLawyerBtn.Text = "Add New +";
            this.AddNewLawyerBtn.UseVisualStyleBackColor = true;
            this.AddNewLawyerBtn.Click += new System.EventHandler(this.AddNewLawyerBtn_Click);
            // 
            // LawyerEditorLabel
            // 
            this.LawyerEditorLabel.AutoSize = true;
            this.LawyerEditorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerEditorLabel.Location = new System.Drawing.Point(292, 5);
            this.LawyerEditorLabel.Name = "LawyerEditorLabel";
            this.LawyerEditorLabel.Size = new System.Drawing.Size(212, 37);
            this.LawyerEditorLabel.TabIndex = 6;
            this.LawyerEditorLabel.Text = "Lawyer Editor";
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.pictureBox1);
            this.MenuGroupBox.Controls.Add(this.CasesEditorBtn);
            this.MenuGroupBox.Controls.Add(this.LawyerEditorBtn);
            this.MenuGroupBox.Location = new System.Drawing.Point(0, -15);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(94, 368);
            this.MenuGroupBox.TabIndex = 8;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CasesEditorBtn
            // 
            this.CasesEditorBtn.Location = new System.Drawing.Point(10, 71);
            this.CasesEditorBtn.Name = "CasesEditorBtn";
            this.CasesEditorBtn.Size = new System.Drawing.Size(75, 35);
            this.CasesEditorBtn.TabIndex = 1;
            this.CasesEditorBtn.Text = "Cases";
            this.CasesEditorBtn.UseVisualStyleBackColor = true;
            this.CasesEditorBtn.Click += new System.EventHandler(this.CasesEditorBtn_Click);
            // 
            // LawyerEditorBtn
            // 
            this.LawyerEditorBtn.Location = new System.Drawing.Point(10, 22);
            this.LawyerEditorBtn.Name = "LawyerEditorBtn";
            this.LawyerEditorBtn.Size = new System.Drawing.Size(75, 35);
            this.LawyerEditorBtn.TabIndex = 0;
            this.LawyerEditorBtn.Text = "Lawyers";
            this.LawyerEditorBtn.UseVisualStyleBackColor = true;
            // 
            // LawyerBusy
            // 
            this.LawyerBusy.Location = new System.Drawing.Point(232, 283);
            this.LawyerBusy.Name = "LawyerBusy";
            this.LawyerBusy.Size = new System.Drawing.Size(75, 35);
            this.LawyerBusy.TabIndex = 9;
            this.LawyerBusy.Text = "Busy Lawyers";
            this.LawyerBusy.UseVisualStyleBackColor = true;
            this.LawyerBusy.Click += new System.EventHandler(this.LawyerBusy_Click);
            // 
            // LawyerFree
            // 
            this.LawyerFree.Location = new System.Drawing.Point(328, 283);
            this.LawyerFree.Name = "LawyerFree";
            this.LawyerFree.Size = new System.Drawing.Size(75, 35);
            this.LawyerFree.TabIndex = 10;
            this.LawyerFree.Text = "Free Lawyers";
            this.LawyerFree.UseVisualStyleBackColor = true;
            this.LawyerFree.Click += new System.EventHandler(this.LawyerFree_Click);
            // 
            // AdminViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(721, 351);
            this.Controls.Add(this.LawyerFree);
            this.Controls.Add(this.LawyerBusy);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.LawyerEditorLabel);
            this.Controls.Add(this.AddNewLawyerBtn);
            this.Controls.Add(this.LawyersGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(737, 390);
            this.MinimumSize = new System.Drawing.Size(737, 390);
            this.Name = "AdminViewForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.LawyersGrid)).EndInit();
            this.MenuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LawyersGrid;
        private System.Windows.Forms.Button AddNewLawyerBtn;
        private System.Windows.Forms.Label LawyerEditorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.Button CasesEditorBtn;
        private System.Windows.Forms.Button LawyerEditorBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LawyerBusy;
        private System.Windows.Forms.Button LawyerFree;
    }
}