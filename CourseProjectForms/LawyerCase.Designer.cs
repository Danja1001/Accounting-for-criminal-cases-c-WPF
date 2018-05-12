namespace CourseProjectForms
{
    partial class LawyerCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerCase));
            this.CasesGridEditor = new System.Windows.Forms.DataGridView();
            this.LawyerId = new System.Windows.Forms.TextBox();
            this.LawyerCaseLbl = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lawId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // CasesGridEditor
            // 
            this.CasesGridEditor.BackgroundColor = System.Drawing.Color.SeaShell;
            this.CasesGridEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CasesGridEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CasesGridEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.lawId,
            this.CaseTitle,
            this.CaseStart,
            this.CaseEnd,
            this.Edit});
            this.CasesGridEditor.Location = new System.Drawing.Point(34, 140);
            this.CasesGridEditor.Name = "CasesGridEditor";
            this.CasesGridEditor.Size = new System.Drawing.Size(446, 204);
            this.CasesGridEditor.TabIndex = 12;
            this.CasesGridEditor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CasesGridEditor_CellContentClick);
            // 
            // LawyerId
            // 
            this.LawyerId.Location = new System.Drawing.Point(71, 35);
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.Size = new System.Drawing.Size(10, 20);
            this.LawyerId.TabIndex = 11;
            this.LawyerId.Visible = false;
            // 
            // LawyerCaseLbl
            // 
            this.LawyerCaseLbl.AutoSize = true;
            this.LawyerCaseLbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerCaseLbl.Location = new System.Drawing.Point(151, 55);
            this.LawyerCaseLbl.Name = "LawyerCaseLbl";
            this.LawyerCaseLbl.Size = new System.Drawing.Size(210, 59);
            this.LawyerCaseLbl.TabIndex = 13;
            this.LawyerCaseLbl.Text = "My Cases";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // lawId
            // 
            this.lawId.HeaderText = "lawId";
            this.lawId.Name = "lawId";
            this.lawId.Visible = false;
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
            this.Edit.HeaderText = "Info";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Info";
            this.Edit.ToolTipText = "Info";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // LawyerCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(529, 421);
            this.Controls.Add(this.CasesGridEditor);
            this.Controls.Add(this.LawyerId);
            this.Controls.Add(this.LawyerCaseLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(545, 460);
            this.MinimumSize = new System.Drawing.Size(545, 460);
            this.Name = "LawyerCase";
            this.Text = "LawyerCase";
            this.Load += new System.EventHandler(this.LawyerCase_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CasesGridEditor;
        private System.Windows.Forms.TextBox LawyerId;
        private System.Windows.Forms.Label LawyerCaseLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lawId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseEnd;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}