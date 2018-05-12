namespace CourseProjectForms
{
    partial class CaseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseInfo));
            this.CaseInfoLbl = new System.Windows.Forms.Label();
            this.LawyersList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.CaseTitle = new System.Windows.Forms.Label();
            this.CaseTitleLbl = new System.Windows.Forms.Label();
            this.CaseDescTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LawyerEmpty = new System.Windows.Forms.Label();
            this.LawyerId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoEvidence = new System.Windows.Forms.Label();
            this.DocumentGrid = new System.Windows.Forms.DataGridView();
            this.CaseId = new System.Windows.Forms.TextBox();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.LeaveComment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CaseInfoLbl
            // 
            this.CaseInfoLbl.AutoSize = true;
            this.CaseInfoLbl.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseInfoLbl.Location = new System.Drawing.Point(12, 9);
            this.CaseInfoLbl.Name = "CaseInfoLbl";
            this.CaseInfoLbl.Size = new System.Drawing.Size(261, 42);
            this.CaseInfoLbl.TabIndex = 0;
            this.CaseInfoLbl.Text = "Case Information";
            // 
            // LawyersList
            // 
            this.LawyersList.BackColor = System.Drawing.Color.SeaShell;
            this.LawyersList.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyersList.Location = new System.Drawing.Point(159, 104);
            this.LawyersList.Name = "LawyersList";
            this.LawyersList.Size = new System.Drawing.Size(71, 23);
            this.LawyersList.TabIndex = 1;
            this.LawyersList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lawyer list -";
            // 
            // CaseTitle
            // 
            this.CaseTitle.AutoSize = true;
            this.CaseTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseTitle.Location = new System.Drawing.Point(40, 65);
            this.CaseTitle.Name = "CaseTitle";
            this.CaseTitle.Size = new System.Drawing.Size(56, 23);
            this.CaseTitle.TabIndex = 3;
            this.CaseTitle.Text = "Title - ";
            // 
            // CaseTitleLbl
            // 
            this.CaseTitleLbl.AutoSize = true;
            this.CaseTitleLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseTitleLbl.Location = new System.Drawing.Point(155, 65);
            this.CaseTitleLbl.Name = "CaseTitleLbl";
            this.CaseTitleLbl.Size = new System.Drawing.Size(42, 23);
            this.CaseTitleLbl.TabIndex = 4;
            this.CaseTitleLbl.Text = "Title";
            // 
            // CaseDescTxt
            // 
            this.CaseDescTxt.BackColor = System.Drawing.Color.SeaShell;
            this.CaseDescTxt.Location = new System.Drawing.Point(159, 133);
            this.CaseDescTxt.Multiline = true;
            this.CaseDescTxt.Name = "CaseDescTxt";
            this.CaseDescTxt.ReadOnly = true;
            this.CaseDescTxt.Size = new System.Drawing.Size(71, 97);
            this.CaseDescTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description - ";
            // 
            // LawyerEmpty
            // 
            this.LawyerEmpty.AutoSize = true;
            this.LawyerEmpty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerEmpty.Location = new System.Drawing.Point(155, 104);
            this.LawyerEmpty.Name = "LawyerEmpty";
            this.LawyerEmpty.Size = new System.Drawing.Size(59, 23);
            this.LawyerEmpty.TabIndex = 7;
            this.LawyerEmpty.Text = "Empty";
            this.LawyerEmpty.Visible = false;
            // 
            // LawyerId
            // 
            this.LawyerId.Location = new System.Drawing.Point(279, 12);
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.Size = new System.Drawing.Size(10, 20);
            this.LawyerId.TabIndex = 8;
            this.LawyerId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoEvidence);
            this.groupBox1.Controls.Add(this.DocumentGrid);
            this.groupBox1.Controls.Add(this.CaseId);
            this.groupBox1.Location = new System.Drawing.Point(317, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 394);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // NoEvidence
            // 
            this.NoEvidence.AutoSize = true;
            this.NoEvidence.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoEvidence.Location = new System.Drawing.Point(166, 139);
            this.NoEvidence.Name = "NoEvidence";
            this.NoEvidence.Size = new System.Drawing.Size(193, 42);
            this.NoEvidence.TabIndex = 12;
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
            this.Image,
            this.LeaveComment,
            this.Info});
            this.DocumentGrid.Location = new System.Drawing.Point(6, 41);
            this.DocumentGrid.Name = "DocumentGrid";
            this.DocumentGrid.Size = new System.Drawing.Size(571, 336);
            this.DocumentGrid.TabIndex = 11;
            this.DocumentGrid.Visible = false;
            this.DocumentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentGrid_CellContentClick);
            // 
            // CaseId
            // 
            this.CaseId.Location = new System.Drawing.Point(256, 15);
            this.CaseId.Name = "CaseId";
            this.CaseId.Size = new System.Drawing.Size(10, 20);
            this.CaseId.TabIndex = 10;
            this.CaseId.Visible = false;
            // 
            // DocumentId
            // 
            this.DocumentId.HeaderText = "Id";
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.Visible = false;
            this.DocumentId.Width = 150;
            // 
            // Image
            // 
            this.Image.HeaderText = "Evidence";
            this.Image.Name = "Image";
            this.Image.Width = 300;
            // 
            // LeaveComment
            // 
            this.LeaveComment.HeaderText = "Leave Comment";
            this.LeaveComment.Name = "LeaveComment";
            this.LeaveComment.Text = "Leave Comment";
            this.LeaveComment.ToolTipText = "Leave Comment";
            this.LeaveComment.UseColumnTextForButtonValue = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "CaseInfoBtn";
            this.Info.Name = "Info";
            this.Info.Text = "Info";
            this.Info.ToolTipText = "Info";
            this.Info.UseColumnTextForButtonValue = true;
            // 
            // CaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(917, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LawyerId);
            this.Controls.Add(this.LawyerEmpty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaseDescTxt);
            this.Controls.Add(this.CaseTitleLbl);
            this.Controls.Add(this.CaseTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LawyersList);
            this.Controls.Add(this.CaseInfoLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(933, 422);
            this.MinimumSize = new System.Drawing.Size(933, 422);
            this.Name = "CaseInfo";
            this.Text = "Case Information";
            this.Load += new System.EventHandler(this.CaseInfo_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaseInfoLbl;
        private System.Windows.Forms.ListView LawyersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CaseTitle;
        private System.Windows.Forms.Label CaseTitleLbl;
        private System.Windows.Forms.TextBox CaseDescTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LawyerEmpty;
        private System.Windows.Forms.TextBox LawyerId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DocumentGrid;
        private System.Windows.Forms.TextBox CaseId;
        private System.Windows.Forms.Label NoEvidence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewButtonColumn LeaveComment;
        private System.Windows.Forms.DataGridViewButtonColumn Info;
    }
}