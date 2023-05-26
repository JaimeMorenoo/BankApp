namespace bank_test_2
{
    partial class main_pagecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_pagecs));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.balance_title = new System.Windows.Forms.Label();
            this.main_balance_text = new System.Windows.Forms.Label();
<<<<<<< Updated upstream
=======
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionA = new System.Windows.Forms.ComboBox();
            this.transactionB = new System.Windows.Forms.ComboBox();
            this.transaction_text = new System.Windows.Forms.TextBox();
            this.transaction_button = new System.Windows.Forms.Button();
            this.payment_textbox = new System.Windows.Forms.TextBox();
            this.payment_acc = new System.Windows.Forms.ComboBox();
            this.payment_amount = new System.Windows.Forms.TextBox();
            this.payment_send = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datetime_transfer = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // balance_title
            // 
            this.balance_title.AutoSize = true;
            this.balance_title.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.balance_title.Location = new System.Drawing.Point(12, 64);
            this.balance_title.Name = "balance_title";
            this.balance_title.Size = new System.Drawing.Size(354, 32);
            this.balance_title.TabIndex = 5;
            this.balance_title.Text = "Main Account Balance";
            // 
            // main_balance_text
            // 
            this.main_balance_text.AutoSize = true;
<<<<<<< Updated upstream
            this.main_balance_text.Location = new System.Drawing.Point(145, 99);
=======
            this.main_balance_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_balance_text.Location = new System.Drawing.Point(164, 99);
>>>>>>> Stashed changes
            this.main_balance_text.Name = "main_balance_text";
            this.main_balance_text.Size = new System.Drawing.Size(72, 20);
            this.main_balance_text.TabIndex = 6;
            this.main_balance_text.Text = "1000.00 €";
            // 
<<<<<<< Updated upstream
=======
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(135, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(309, 139);
            this.dataGridView1.TabIndex = 8;
            // 
            // transactionA
            // 
            this.transactionA.FormattingEnabled = true;
            this.transactionA.Location = new System.Drawing.Point(67, 314);
            this.transactionA.Name = "transactionA";
            this.transactionA.Size = new System.Drawing.Size(151, 28);
            this.transactionA.TabIndex = 9;
            this.transactionA.Text = "Account A";
            this.transactionA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transactionA_MouseClick);
            // 
            // transactionB
            // 
            this.transactionB.FormattingEnabled = true;
            this.transactionB.Location = new System.Drawing.Point(240, 314);
            this.transactionB.Name = "transactionB";
            this.transactionB.Size = new System.Drawing.Size(151, 28);
            this.transactionB.TabIndex = 10;
            this.transactionB.Text = "Account B";
            this.transactionB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transactionB_MouseClick);
            // 
            // transaction_text
            // 
            this.transaction_text.Location = new System.Drawing.Point(150, 348);
            this.transaction_text.Name = "transaction_text";
            this.transaction_text.PlaceholderText = "Amount";
            this.transaction_text.Size = new System.Drawing.Size(151, 27);
            this.transaction_text.TabIndex = 11;
            this.transaction_text.Tag = "";
            this.transaction_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transaction_button
            // 
            this.transaction_button.Location = new System.Drawing.Point(178, 414);
            this.transaction_button.Name = "transaction_button";
            this.transaction_button.Size = new System.Drawing.Size(94, 29);
            this.transaction_button.TabIndex = 12;
            this.transaction_button.Text = "Transfer";
            this.transaction_button.UseVisualStyleBackColor = true;
            this.transaction_button.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // payment_textbox
            // 
            this.payment_textbox.Location = new System.Drawing.Point(575, 159);
            this.payment_textbox.Name = "payment_textbox";
            this.payment_textbox.PlaceholderText = "IBAN (userID)";
            this.payment_textbox.Size = new System.Drawing.Size(125, 27);
            this.payment_textbox.TabIndex = 13;
            // 
            // payment_acc
            // 
            this.payment_acc.FormattingEnabled = true;
            this.payment_acc.Location = new System.Drawing.Point(575, 248);
            this.payment_acc.Name = "payment_acc";
            this.payment_acc.Size = new System.Drawing.Size(125, 28);
            this.payment_acc.TabIndex = 14;
            this.payment_acc.Text = "Account";
            this.payment_acc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.payment_acc_MouseClick);
            // 
            // payment_amount
            // 
            this.payment_amount.Location = new System.Drawing.Point(575, 206);
            this.payment_amount.Name = "payment_amount";
            this.payment_amount.PlaceholderText = "Amount";
            this.payment_amount.Size = new System.Drawing.Size(125, 27);
            this.payment_amount.TabIndex = 15;
            // 
            // payment_send
            // 
            this.payment_send.Location = new System.Drawing.Point(589, 282);
            this.payment_send.Name = "payment_send";
            this.payment_send.Size = new System.Drawing.Size(94, 29);
            this.payment_send.TabIndex = 16;
            this.payment_send.Text = "Pay";
            this.payment_send.UseVisualStyleBackColor = true;
            this.payment_send.Click += new System.EventHandler(this.payment_send_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(565, 317);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 27);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // datetime_transfer
            // 
            this.datetime_transfer.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datetime_transfer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_transfer.Location = new System.Drawing.Point(135, 381);
            this.datetime_transfer.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datetime_transfer.Name = "datetime_transfer";
            this.datetime_transfer.Size = new System.Drawing.Size(169, 27);
            this.datetime_transfer.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Download Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
>>>>>>> Stashed changes
            // main_pagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< Updated upstream
=======
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datetime_transfer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.payment_send);
            this.Controls.Add(this.payment_amount);
            this.Controls.Add(this.payment_acc);
            this.Controls.Add(this.payment_textbox);
            this.Controls.Add(this.transaction_button);
            this.Controls.Add(this.transaction_text);
            this.Controls.Add(this.transactionB);
            this.Controls.Add(this.transactionA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
>>>>>>> Stashed changes
            this.Controls.Add(this.main_balance_text);
            this.Controls.Add(this.balance_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_pagecs";
            this.Text = "main_pagecs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_pagecs_FormClosing);
            this.Load += new System.EventHandler(this.main_pagecs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label balance_title;
        private Label main_balance_text;
<<<<<<< Updated upstream
=======
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private ComboBox transactionA;
        private ComboBox transactionB;
        private TextBox transaction_text;
        private Button transaction_button;
        private TextBox payment_textbox;
        private ComboBox payment_acc;
        private TextBox payment_amount;
        private Button payment_send;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker datetime_transfer;
        private Button button2;
>>>>>>> Stashed changes
    }
}