namespace CourseProjectForms
{
    partial class LawyerCommentsAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerCommentsAll));
            this.CaseTitleLbl = new System.Windows.Forms.Label();
            this.DocumentBox = new System.Windows.Forms.PictureBox();
            this.CommentsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LawyerComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CommentsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CaseTitleLbl
            // 
            this.CaseTitleLbl.AutoSize = true;
            this.CaseTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaseTitleLbl.Location = new System.Drawing.Point(251, 43);
            this.CaseTitleLbl.Name = "CaseTitleLbl";
            this.CaseTitleLbl.Size = new System.Drawing.Size(53, 25);
            this.CaseTitleLbl.TabIndex = 0;
            this.CaseTitleLbl.Text = "Title";
            // 
            // DocumentBox
            // 
            this.DocumentBox.Location = new System.Drawing.Point(12, 43);
            this.DocumentBox.Name = "DocumentBox";
            this.DocumentBox.Size = new System.Drawing.Size(156, 200);
            this.DocumentBox.TabIndex = 1;
            this.DocumentBox.TabStop = false;
            // 
            // CommentsGrid
            // 
            this.CommentsGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.CommentsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LawyerName,
            this.LawyerComment});
            this.CommentsGrid.Location = new System.Drawing.Point(83, 321);
            this.CommentsGrid.Name = "CommentsGrid";
            this.CommentsGrid.Size = new System.Drawing.Size(258, 150);
            this.CommentsGrid.TabIndex = 2;
            this.CommentsGrid.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // LawyerName
            // 
            this.LawyerName.HeaderText = "Lawyer";
            this.LawyerName.Name = "LawyerName";
            // 
            // LawyerComment
            // 
            this.LawyerComment.HeaderText = "Comment";
            this.LawyerComment.Name = "LawyerComment";
            // 
            // CaseDescription
            // 
            this.CaseDescription.BackColor = System.Drawing.Color.SeaShell;
            this.CaseDescription.Location = new System.Drawing.Point(192, 126);
            this.CaseDescription.Multiline = true;
            this.CaseDescription.Name = "CaseDescription";
            this.CaseDescription.ReadOnly = true;
            this.CaseDescription.Size = new System.Drawing.Size(201, 117);
            this.CaseDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(142, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comments:";
            this.label3.Visible = false;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentsLbl.Location = new System.Drawing.Point(142, 332);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(143, 25);
            this.CommentsLbl.TabIndex = 7;
            this.CommentsLbl.Text = "No comments";
            this.CommentsLbl.Visible = false;
            // 
            // LawyerCommentsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(444, 498);
            this.Controls.Add(this.CommentsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaseDescription);
            this.Controls.Add(this.CommentsGrid);
            this.Controls.Add(this.DocumentBox);
            this.Controls.Add(this.CaseTitleLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LawyerCommentsAll";
            this.Text = "Comments";
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaseTitleLbl;
        private System.Windows.Forms.PictureBox DocumentBox;
        private System.Windows.Forms.DataGridView CommentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawyerComment;
        private System.Windows.Forms.TextBox CaseDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CommentsLbl;
    }
}