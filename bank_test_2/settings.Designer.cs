namespace bank_test_2
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.name_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.dob_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.changepass_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.current_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pass2 = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(325, 114);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 20);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(413, 114);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(75, 20);
            this.lastname_label.TabIndex = 1;
            this.lastname_label.Text = "LastName";
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Location = new System.Drawing.Point(325, 156);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(40, 20);
            this.dob_label.TabIndex = 2;
            this.dob_label.Text = "DOB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Profile Picture";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // changepass_button
            // 
            this.changepass_button.Location = new System.Drawing.Point(345, 388);
            this.changepass_button.Name = "changepass_button";
            this.changepass_button.Size = new System.Drawing.Size(198, 44);
            this.changepass_button.TabIndex = 5;
            this.changepass_button.Text = "Change Password";
            this.changepass_button.UseVisualStyleBackColor = true;
            this.changepass_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Password";
            // 
            // current_pass
            // 
            this.current_pass.Location = new System.Drawing.Point(371, 290);
            this.current_pass.Name = "current_pass";
            this.current_pass.PasswordChar = '*';
            this.current_pass.Size = new System.Drawing.Size(151, 27);
            this.current_pass.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password";
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(371, 322);
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '*';
            this.new_pass.Size = new System.Drawing.Size(151, 27);
            this.new_pass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repeat New Password";
            // 
            // new_pass2
            // 
            this.new_pass2.Location = new System.Drawing.Point(371, 355);
            this.new_pass2.Name = "new_pass2";
            this.new_pass2.PasswordChar = '*';
            this.new_pass2.Size = new System.Drawing.Size(151, 27);
            this.new_pass2.TabIndex = 11;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(655, 418);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(143, 29);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete Account";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.new_pass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.current_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changepass_button);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.name_label);
            this.Name = "settings";
            this.Text = "settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name_label;
        private Label lastname_label;
        private Label dob_label;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button changepass_button;
        private Label label1;
        private TextBox current_pass;
        private Label label2;
        private TextBox new_pass;
        private Label label3;
        private TextBox new_pass2;
        private Button delete_button;
    }
}