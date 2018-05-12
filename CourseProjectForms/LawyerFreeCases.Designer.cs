namespace CourseProjectForms
{
    partial class LawyerFreeCases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerFreeCases));
            this.LawyerId = new System.Windows.Forms.TextBox();
            this.CasesGridEditor = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FreeCasesLbl = new System.Windows.Forms.Label();
            this.FreeCases = new System.Windows.Forms.Button();
            this.CaseAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // LawyerId
            // 
            this.LawyerId.Location = new System.Drawing.Point(74, 12);
            this.LawyerId.Name = "LawyerId";
            this.LawyerId.Size = new System.Drawing.Size(10, 20);
            this.LawyerId.TabIndex = 0;
            this.LawyerId.Visible = false;
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
            this.Edit,
            this.Info});
            this.CasesGridEditor.Location = new System.Drawing.Point(23, 116);
            this.CasesGridEditor.Name = "CasesGridEditor";
            this.CasesGridEditor.Size = new System.Drawing.Size(550, 204);
            this.CasesGridEditor.TabIndex = 9;
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
            this.Edit.HeaderText = "Take";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Take";
            this.Edit.ToolTipText = "TakeCase";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Info.Text = "Info";
            this.Info.ToolTipText = "CaseInfo";
            this.Info.UseColumnTextForButtonValue = true;
            // 
            // FreeCasesLbl
            // 
            this.FreeCasesLbl.AutoSize = true;
            this.FreeCasesLbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeCasesLbl.Location = new System.Drawing.Point(192, 32);
            this.FreeCasesLbl.Name = "FreeCasesLbl";
            this.FreeCasesLbl.Size = new System.Drawing.Size(197, 59);
            this.FreeCasesLbl.TabIndex = 10;
            this.FreeCasesLbl.Text = "All Cases";
            // 
            // FreeCases
            // 
            this.FreeCases.Location = new System.Drawing.Point(23, 326);
            this.FreeCases.Name = "FreeCases";
            this.FreeCases.Size = new System.Drawing.Size(75, 35);
            this.FreeCases.TabIndex = 11;
            this.FreeCases.Text = "Free Cases";
            this.FreeCases.UseVisualStyleBackColor = true;
            this.FreeCases.Click += new System.EventHandler(this.FreeCases_Click);
            // 
            // CaseAll
            // 
            this.CaseAll.Location = new System.Drawing.Point(122, 326);
            this.CaseAll.Name = "CaseAll";
            this.CaseAll.Size = new System.Drawing.Size(75, 35);
            this.CaseAll.TabIndex = 12;
            this.CaseAll.Text = "All Cases";
            this.CaseAll.UseVisualStyleBackColor = true;
            this.CaseAll.Click += new System.EventHandler(this.CaseAll_Click);
            // 
            // LawyerFreeCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(585, 421);
            this.Controls.Add(this.CaseAll);
            this.Controls.Add(this.FreeCases);
            this.Controls.Add(this.FreeCasesLbl);
            this.Controls.Add(this.CasesGridEditor);
            this.Controls.Add(this.LawyerId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(601, 460);
            this.MinimumSize = new System.Drawing.Size(601, 460);
            this.Name = "LawyerFreeCases";
            this.Text = "Lawyer Panel";
            this.Load += new System.EventHandler(this.LawyerFreeCases_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CasesGridEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LawyerId;
        private System.Windows.Forms.DataGridView CasesGridEditor;
        private System.Windows.Forms.Label FreeCasesLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseEnd;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Info;
        private System.Windows.Forms.Button FreeCases;
        private System.Windows.Forms.Button CaseAll;
    }
}