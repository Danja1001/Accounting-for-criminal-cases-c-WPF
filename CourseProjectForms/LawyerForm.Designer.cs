namespace CourseProjectForms
{
    partial class LawyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerForm));
            this.LawyerBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LawyerCaseBtn = new System.Windows.Forms.Button();
            this.AllCaseBtn = new System.Windows.Forms.Button();
            this.InfoLawyerBtn = new System.Windows.Forms.Button();
            this.LawyerNameLabel = new System.Windows.Forms.Label();
            this.LawyerLastNameLabel = new System.Windows.Forms.Label();
            this.LawyerNameEditBtn = new System.Windows.Forms.Button();
            this.LawyerIdTxt = new System.Windows.Forms.TextBox();
            this.LawyerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LawyerBox
            // 
            this.LawyerBox.Controls.Add(this.pictureBox2);
            this.LawyerBox.Controls.Add(this.pictureBox1);
            this.LawyerBox.Controls.Add(this.LawyerCaseBtn);
            this.LawyerBox.Controls.Add(this.AllCaseBtn);
            this.LawyerBox.Controls.Add(this.InfoLawyerBtn);
            this.LawyerBox.Location = new System.Drawing.Point(0, 0);
            this.LawyerBox.Name = "LawyerBox";
            this.LawyerBox.Size = new System.Drawing.Size(146, 505);
            this.LawyerBox.TabIndex = 0;
            this.LawyerBox.TabStop = false;
            this.LawyerBox.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LawyerCaseBtn
            // 
            this.LawyerCaseBtn.Location = new System.Drawing.Point(29, 87);
            this.LawyerCaseBtn.Name = "LawyerCaseBtn";
            this.LawyerCaseBtn.Size = new System.Drawing.Size(75, 35);
            this.LawyerCaseBtn.TabIndex = 2;
            this.LawyerCaseBtn.Text = "All Cases";
            this.LawyerCaseBtn.UseVisualStyleBackColor = true;
            this.LawyerCaseBtn.Click += new System.EventHandler(this.LawyerCaseBtn_Click);
            // 
            // AllCaseBtn
            // 
            this.AllCaseBtn.Location = new System.Drawing.Point(29, 140);
            this.AllCaseBtn.Name = "AllCaseBtn";
            this.AllCaseBtn.Size = new System.Drawing.Size(75, 35);
            this.AllCaseBtn.TabIndex = 1;
            this.AllCaseBtn.Text = "My Case";
            this.AllCaseBtn.UseVisualStyleBackColor = true;
            this.AllCaseBtn.Click += new System.EventHandler(this.AllCaseBtn_Click);
            // 
            // InfoLawyerBtn
            // 
            this.InfoLawyerBtn.Location = new System.Drawing.Point(29, 37);
            this.InfoLawyerBtn.Name = "InfoLawyerBtn";
            this.InfoLawyerBtn.Size = new System.Drawing.Size(75, 35);
            this.InfoLawyerBtn.TabIndex = 0;
            this.InfoLawyerBtn.Text = "Information";
            this.InfoLawyerBtn.UseVisualStyleBackColor = true;
            // 
            // LawyerNameLabel
            // 
            this.LawyerNameLabel.AutoSize = true;
            this.LawyerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerNameLabel.Location = new System.Drawing.Point(349, 37);
            this.LawyerNameLabel.Name = "LawyerNameLabel";
            this.LawyerNameLabel.Size = new System.Drawing.Size(142, 31);
            this.LawyerNameLabel.TabIndex = 2;
            this.LawyerNameLabel.Text = "First name";
            // 
            // LawyerLastNameLabel
            // 
            this.LawyerLastNameLabel.AutoSize = true;
            this.LawyerLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LawyerLastNameLabel.Location = new System.Drawing.Point(349, 110);
            this.LawyerLastNameLabel.Name = "LawyerLastNameLabel";
            this.LawyerLastNameLabel.Size = new System.Drawing.Size(140, 31);
            this.LawyerLastNameLabel.TabIndex = 3;
            this.LawyerLastNameLabel.Text = "Last name";
            // 
            // LawyerNameEditBtn
            // 
            this.LawyerNameEditBtn.Location = new System.Drawing.Point(355, 166);
            this.LawyerNameEditBtn.Name = "LawyerNameEditBtn";
            this.LawyerNameEditBtn.Size = new System.Drawing.Size(75, 35);
            this.LawyerNameEditBtn.TabIndex = 6;
            this.LawyerNameEditBtn.Text = "Edit";
            this.LawyerNameEditBtn.UseVisualStyleBackColor = true;
            this.LawyerNameEditBtn.Click += new System.EventHandler(this.LawyerNameEditBtn_Click);
            // 
            // LawyerIdTxt
            // 
            this.LawyerIdTxt.Location = new System.Drawing.Point(355, 87);
            this.LawyerIdTxt.Name = "LawyerIdTxt";
            this.LawyerIdTxt.Size = new System.Drawing.Size(100, 20);
            this.LawyerIdTxt.TabIndex = 8;
            this.LawyerIdTxt.Visible = false;
            // 
            // LawyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(529, 421);
            this.Controls.Add(this.LawyerIdTxt);
            this.Controls.Add(this.LawyerNameEditBtn);
            this.Controls.Add(this.LawyerLastNameLabel);
            this.Controls.Add(this.LawyerNameLabel);
            this.Controls.Add(this.LawyerBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(545, 460);
            this.MinimumSize = new System.Drawing.Size(545, 460);
            this.Name = "LawyerForm";
            this.Text = "Lawyer Panel";
            this.LawyerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LawyerBox;
        private System.Windows.Forms.Button AllCaseBtn;
        private System.Windows.Forms.Button InfoLawyerBtn;
        private System.Windows.Forms.Label LawyerNameLabel;
        private System.Windows.Forms.Label LawyerLastNameLabel;
        private System.Windows.Forms.Button LawyerNameEditBtn;
        private System.Windows.Forms.Button LawyerCaseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LawyerIdTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}