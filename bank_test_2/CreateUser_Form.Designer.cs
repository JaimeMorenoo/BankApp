namespace bank_test_2
{
    partial class CreateUser_Form
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.female_gender = new System.Windows.Forms.RadioButton();
            this.male_gender = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_textbox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(303, 93);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(134, 27);
            this.name_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(303, 141);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(134, 27);
            this.surname_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(303, 186);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(134, 27);
            this.email_textbox.TabIndex = 5;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(227, 228);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(70, 20);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(303, 225);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(134, 27);
            this.password_textbox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.female_gender);
            this.groupBox1.Controls.Add(this.male_gender);
            this.groupBox1.Location = new System.Drawing.Point(303, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // female_gender
            // 
            this.female_gender.AutoSize = true;
            this.female_gender.Location = new System.Drawing.Point(116, 26);
            this.female_gender.Name = "female_gender";
            this.female_gender.Size = new System.Drawing.Size(78, 24);
            this.female_gender.TabIndex = 9;
            this.female_gender.TabStop = true;
            this.female_gender.Text = "Female";
            this.female_gender.UseVisualStyleBackColor = true;
            // 
            // male_gender
            // 
            this.male_gender.AutoSize = true;
            this.male_gender.Location = new System.Drawing.Point(6, 26);
            this.male_gender.Name = "male_gender";
            this.male_gender.Size = new System.Drawing.Size(63, 24);
            this.male_gender.TabIndex = 9;
            this.male_gender.TabStop = true;
            this.male_gender.Text = "Male";
            this.male_gender.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "DOB";
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(303, 330);
            this.date_textbox.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.date_textbox.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(267, 27);
            this.date_textbox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUser_Form";
            this.Text = "CreateUser_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUser_Form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox name_textbox;
        private Label label2;
        private TextBox surname_textbox;
        private Label label3;
        private TextBox email_textbox;
        private Label password_label;
        private TextBox password_textbox;
        private GroupBox groupBox1;
        private RadioButton female_gender;
        private RadioButton male_gender;
        private Label label4;
        private Label label5;
        private DateTimePicker date_textbox;
        private Button button1;
    }
}