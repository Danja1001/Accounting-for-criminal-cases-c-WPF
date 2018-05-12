namespace CourseProjectForms
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.UsrNameTxt = new System.Windows.Forms.TextBox();
            this.UsrPasswordTxt = new System.Windows.Forms.TextBox();
            this.UsrNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsrNameTxt
            // 
            this.UsrNameTxt.Location = new System.Drawing.Point(108, 9);
            this.UsrNameTxt.Name = "UsrNameTxt";
            this.UsrNameTxt.Size = new System.Drawing.Size(100, 20);
            this.UsrNameTxt.TabIndex = 0;
            this.UsrNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsrPasswordTxt
            // 
            this.UsrPasswordTxt.Location = new System.Drawing.Point(108, 47);
            this.UsrPasswordTxt.Name = "UsrPasswordTxt";
            this.UsrPasswordTxt.PasswordChar = '*';
            this.UsrPasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.UsrPasswordTxt.TabIndex = 1;
            this.UsrPasswordTxt.TextChanged += new System.EventHandler(this.UsrPasswordTxt_TextChanged);
            // 
            // UsrNameLabel
            // 
            this.UsrNameLabel.AutoSize = true;
            this.UsrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrNameLabel.Location = new System.Drawing.Point(38, 10);
            this.UsrNameLabel.Name = "UsrNameLabel";
            this.UsrNameLabel.Size = new System.Drawing.Size(42, 17);
            this.UsrNameLabel.TabIndex = 2;
            this.UsrNameLabel.Text = "User:";
            this.UsrNameLabel.Click += new System.EventHandler(this.UsrNameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(28, 48);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(133, 82);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 35);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(243, 129);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsrNameLabel);
            this.Controls.Add(this.UsrPasswordTxt);
            this.Controls.Add(this.UsrNameTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(259, 168);
            this.MinimumSize = new System.Drawing.Size(259, 168);
            this.Name = "LogInForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsrNameTxt;
        private System.Windows.Forms.TextBox UsrPasswordTxt;
        private System.Windows.Forms.Label UsrNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogInButton;
    }
}

