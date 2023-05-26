namespace bank_test_2
{
    partial class login_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(323, 169);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(146, 27);
            this.email_input.TabIndex = 1;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(247, 232);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(70, 20);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(323, 225);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(146, 27);
            this.password_input.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.label1);
            this.Name = "login_form";
            this.Text = "login_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox email_input;
        private Label Password_label;
        private TextBox password_input;
        private Button button1;
    }
}