namespace CourseProjectForms
{
    partial class LawyerCaseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerCaseInfo));
            this.LawyerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CaseDescTxt = new System.Windows.Forms.TextBox();
            this.CaseTitleLbl = new System.Windows.Forms.Label();
            this.CaseTitle = new System.Windows.Forms.Label();
            this.CaseInfoLbl = new System.Windows.Forms.Label();
            this.CaseFinish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaseId = new System.Windows.Forms.TextBox();
            this.CommentAdd = new System.Windows.Forms.Button();
            this.evidenceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NoEvidence = new System.Windows.Forms.Label();
            this.DocumentGrid = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LawyerId
            // 
            this.LawyerId.Location = new System.Drawing.Point(271, 23);
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.Size = new System.Drawing.Size(10, 20);
            this.LawyerId.TabIndex = 17;
            this.LawyerId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description - ";
            // 
            // CaseDescTxt
            // 
            this.CaseDescTxt.BackColor = System.Drawing.Color.SeaShell;
            this.CaseDescTxt.Location = new System.Drawing.Point(151, 112);
            this.CaseDescTxt.Multiline = true;
            this.CaseDescTxt.Name = "CaseDescTxt";
            this.CaseDescTxt.ReadOnly = true;
            this.CaseDescTxt.Size = new System.Drawing.Size(71, 97);
            this.CaseDescTxt.TabIndex = 14;
            // 
            // CaseTitleLbl
            // 
            this.CaseTitleLbl.AutoSize = true;
            this.CaseTitleLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseTitleLbl.Location = new System.Drawing.Point(147, 76);
            this.CaseTitleLbl.Name = "CaseTitleLbl";
            this.CaseTitleLbl.Size = new System.Drawing.Size(42, 23);
            this.CaseTitleLbl.TabIndex = 13;
            this.CaseTitleLbl.Text = "Title";
            // 
            // CaseTitle
            // 
            this.CaseTitle.AutoSize = true;
            this.CaseTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseTitle.Location = new System.Drawing.Point(32, 76);
            this.CaseTitle.Name = "CaseTitle";
            this.CaseTitle.Size = new System.Drawing.Size(56, 23);
            this.CaseTitle.TabIndex = 12;
            this.CaseTitle.Text = "Title - ";
            // 
            // CaseInfoLbl
            // 
            this.CaseInfoLbl.AutoSize = true;
            this.CaseInfoLbl.BackColor = System.Drawing.Color.SeaShell;
            this.CaseInfoLbl.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseInfoLbl.Location = new System.Drawing.Point(4, 20);
            this.CaseInfoLbl.Name = "CaseInfoLbl";
            this.CaseInfoLbl.Size = new System.Drawing.Size(261, 42);
            this.CaseInfoLbl.TabIndex = 9;
            this.CaseInfoLbl.Text = "Case Information";
            // 
            // CaseFinish
            // 
            this.CaseFinish.Location = new System.Drawing.Point(114, 307);
            this.CaseFinish.Name = "CaseFinish";
            this.CaseFinish.Size = new System.Drawing.Size(75, 35);
            this.CaseFinish.TabIndex = 18;
            this.CaseFinish.Text = "Finish";
            this.CaseFinish.UseVisualStyleBackColor = true;
            this.CaseFinish.Click += new System.EventHandler(this.CaseFinish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoEvidence);
            this.groupBox1.Controls.Add(this.DocumentGrid);
            this.groupBox1.Controls.Add(this.CaseId);
            this.groupBox1.Controls.Add(this.CommentAdd);
            this.groupBox1.Location = new System.Drawing.Point(297, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 398);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // CaseId
            // 
            this.CaseId.Location = new System.Drawing.Point(218, 19);
            this.CaseId.Name = "CaseId";
            this.CaseId.Size = new System.Drawing.Size(10, 20);
            this.CaseId.TabIndex = 10;
            this.CaseId.Visible = false;
            // 
            // CommentAdd
            // 
            this.CommentAdd.Location = new System.Drawing.Point(165, 317);
            this.CommentAdd.Name = "CommentAdd";
            this.CommentAdd.Size = new System.Drawing.Size(75, 35);
            this.CommentAdd.TabIndex = 0;
            this.CommentAdd.Text = "leave a comment";
            this.CommentAdd.UseVisualStyleBackColor = true;
            this.CommentAdd.Click += new System.EventHandler(this.CommentAdd_Click);
            // 
            // evidenceFileDialog
            // 
            this.evidenceFileDialog.FileName = "Select";
            // 
            // NoEvidence
            // 
            this.NoEvidence.AutoSize = true;
            this.NoEvidence.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoEvidence.Location = new System.Drawing.Point(115, 156);
            this.NoEvidence.Name = "NoEvidence";
            this.NoEvidence.Size = new System.Drawing.Size(193, 42);
            this.NoEvidence.TabIndex = 14;
            this.NoEvidence.Text = "No evidence";
            this.NoEvidence.Visible = false;
            // 
            // DocumentGrid
            // 
            this.DocumentGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DocumentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocumentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.Image});
            this.DocumentGrid.Location = new System.Drawing.Point(6, 77);
            this.DocumentGrid.Name = "DocumentGrid";
            this.DocumentGrid.Size = new System.Drawing.Size(360, 214);
            this.DocumentGrid.TabIndex = 13;
            this.DocumentGrid.Visible = false;
            // 
            // Image
            // 
            this.Image.HeaderText = "Evidence";
            this.Image.Name = "Image";
            this.Image.Width = 300;
            // 
            // DocumentId
            // 
            this.DocumentId.HeaderText = "Id";
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.Visible = false;
            this.DocumentId.Width = 150;
            // 
            // LawyerCaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(698, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CaseFinish);
            this.Controls.Add(this.LawyerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaseDescTxt);
            this.Controls.Add(this.CaseTitleLbl);
            this.Controls.Add(this.CaseTitle);
            this.Controls.Add(this.CaseInfoLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(714, 420);
            this.Name = "LawyerCaseInfo";
            this.Text = "LawyerCaseInfo";
            this.Load += new System.EventHandler(this.LawyerCaseInfo_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LawyerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaseDescTxt;
        private System.Windows.Forms.Label CaseTitleLbl;
        private System.Windows.Forms.Label CaseTitle;
        private System.Windows.Forms.Label CaseInfoLbl;
        private System.Windows.Forms.Button CaseFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CaseId;
        private System.Windows.Forms.Button CommentAdd;
        private System.Windows.Forms.OpenFileDialog evidenceFileDialog;
        private System.Windows.Forms.Label NoEvidence;
        private System.Windows.Forms.DataGridView DocumentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}