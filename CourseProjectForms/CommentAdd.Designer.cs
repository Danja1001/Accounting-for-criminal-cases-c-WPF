namespace CourseProjectForms
{
    partial class CommentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentAdd));
            this.CommentDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentIdHid = new System.Windows.Forms.TextBox();
            this.LawyerIdHid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CommentDesc
            // 
            this.CommentDesc.Location = new System.Drawing.Point(21, 142);
            this.CommentDesc.Multiline = true;
            this.CommentDesc.Name = "CommentDesc";
            this.CommentDesc.Size = new System.Drawing.Size(284, 232);
            this.CommentDesc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comment:";
            // 
            // CommentAddBtn
            // 
            this.CommentAddBtn.Location = new System.Drawing.Point(230, 391);
            this.CommentAddBtn.Name = "CommentAddBtn";
            this.CommentAddBtn.Size = new System.Drawing.Size(75, 35);
            this.CommentAddBtn.TabIndex = 3;
            this.CommentAddBtn.Text = "Leave Comment";
            this.CommentAddBtn.UseVisualStyleBackColor = true;
            this.CommentAddBtn.Click += new System.EventHandler(this.CommentAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Your Comment";
            // 
            // DocumentIdHid
            // 
            this.DocumentIdHid.Location = new System.Drawing.Point(12, 399);
            this.DocumentIdHid.Name = "DocumentIdHid";
            this.DocumentIdHid.Size = new System.Drawing.Size(10, 20);
            this.DocumentIdHid.TabIndex = 4;
            this.DocumentIdHid.Visible = false;
            // 
            // LawyerIdHid
            // 
            this.LawyerIdHid.Location = new System.Drawing.Point(30, 399);
            this.LawyerIdHid.Name = "LawyerIdHid";
            this.LawyerIdHid.Size = new System.Drawing.Size(10, 20);
            this.LawyerIdHid.TabIndex = 4;
            this.LawyerIdHid.Visible = false;
            // 
            // CommentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 438);
            this.Controls.Add(this.LawyerIdHid);
            this.Controls.Add(this.DocumentIdHid);
            this.Controls.Add(this.CommentAddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommentDesc);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommentAdd";
            this.Text = "Leave comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CommentDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CommentAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocumentIdHid;
        private System.Windows.Forms.TextBox LawyerIdHid;
    }
}