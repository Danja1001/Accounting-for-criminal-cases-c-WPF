namespace CourseProjectForms
{
    partial class CaseEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseEditor));
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CasesEditorBtn = new System.Windows.Forms.Button();
            this.LawyerEditorBtn = new System.Windows.Forms.Button();
            this.LawyerEditorLabel = new System.Windows.Forms.Label();
            this.AddNewCaseBtn = new System.Windows.Forms.Button();
            this.CasesGridEditor = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CaseComplete = new System.Windows.Forms.Button();
            this.CaseFree = new System.Windows.Forms.Button();
            this.MenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.pictureBox1);
            this.MenuGroupBox.Controls.Add(this.CasesEditorBtn);
            this.MenuGroupBox.Controls.Add(this.LawyerEditorBtn);
            this.MenuGroupBox.Location = new System.Drawing.Point(2, -13);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(94, 369);
            this.MenuGroupBox.TabIndex = 7;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 11;
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
            this.LawyerEditorBtn.Click += new System.EventHandler(this.LawyerEditorBtn_Click);
            // 
            // LawyerEditorLabel
            // 
            this.LawyerEditorLabel.AutoSize = true;
            this.LawyerEditorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerEditorLabel.Location = new System.Drawing.Point(244, 9);
            this.LawyerEditorLabel.Name = "LawyerEditorLabel";
            this.LawyerEditorLabel.Size = new System.Drawing.Size(184, 37);
            this.LawyerEditorLabel.TabIndex = 10;
            this.LawyerEditorLabel.Text = "Case Editor";
            // 
            // AddNewCaseBtn
            // 
            this.AddNewCaseBtn.Location = new System.Drawing.Point(122, 268);
            this.AddNewCaseBtn.Name = "AddNewCaseBtn";
            this.AddNewCaseBtn.Size = new System.Drawing.Size(75, 35);
            this.AddNewCaseBtn.TabIndex = 9;
            this.AddNewCaseBtn.Text = "Add New +";
            this.AddNewCaseBtn.UseVisualStyleBackColor = true;
            this.AddNewCaseBtn.Click += new System.EventHandler(this.AddNewCaseBtn_Click);
            // 
            // CasesGridEditor
            // 
            this.CasesGridEditor.BackgroundColor = System.Drawing.Color.SeaShell;
            this.CasesGridEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CasesGridEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CasesGridEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CaseTitle,
            this.CaseStart,
            this.CaseEnd,
            this.Edit});
            this.CasesGridEditor.Location = new System.Drawing.Point(122, 58);
            this.CasesGridEditor.Name = "CasesGridEditor";
            this.CasesGridEditor.Size = new System.Drawing.Size(446, 204);
            this.CasesGridEditor.TabIndex = 8;
            this.CasesGridEditor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CasesGridEditor_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // CaseTitle
            // 
            this.CaseTitle.HeaderText = "Title";
            this.CaseTitle.Name = "CaseTitle";
            // 
            // CaseStart
            // 
            this.CaseStart.HeaderText = "Start date";
            this.CaseStart.Name = "CaseStart";
            // 
            // CaseEnd
            // 
            this.CaseEnd.HeaderText = "Case end";
            this.CaseEnd.Name = "CaseEnd";
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
            // CaseComplete
            // 
            this.CaseComplete.Location = new System.Drawing.Point(221, 268);
            this.CaseComplete.Name = "CaseComplete";
            this.CaseComplete.Size = new System.Drawing.Size(75, 35);
            this.CaseComplete.TabIndex = 12;
            this.CaseComplete.Text = "Сompleted Сases";
            this.CaseComplete.UseVisualStyleBackColor = true;
            this.CaseComplete.Click += new System.EventHandler(this.CaseComplete_Click);
            // 
            // CaseFree
            // 
            this.CaseFree.Location = new System.Drawing.Point(318, 267);
            this.CaseFree.Name = "CaseFree";
            this.CaseFree.Size = new System.Drawing.Size(75, 35);
            this.CaseFree.TabIndex = 12;
            this.CaseFree.Text = "Free Cases";
            this.CaseFree.UseVisualStyleBackColor = true;
            this.CaseFree.Click += new System.EventHandler(this.CaseFree_Click);
            // 
            // CaseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(645, 351);
            this.Controls.Add(this.CaseFree);
            this.Controls.Add(this.CaseComplete);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.LawyerEditorLabel);
            this.Controls.Add(this.AddNewCaseBtn);
            this.Controls.Add(this.CasesGridEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(661, 390);
            this.MinimumSize = new System.Drawing.Size(610, 390);
            this.Name = "CaseEditor";
            this.Text = "Case Editor";
            this.MenuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.Button CasesEditorBtn;
        private System.Windows.Forms.Button LawyerEditorBtn;
        private System.Windows.Forms.Label LawyerEditorLabel;
        private System.Windows.Forms.Button AddNewCaseBtn;
        private System.Windows.Forms.DataGridView CasesGridEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseEnd;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CaseComplete;
        private System.Windows.Forms.Button CaseFree;
    }
}