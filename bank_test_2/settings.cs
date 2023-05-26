using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_test_2
{
    public partial class settings : Form
    {
        private connect_class connect_class = new connect_class();
        private MySqlConnection Connection { get; set; }
        public settings()
        {
            InitializeComponent();
            this.Connection = new MySqlConnection(connect_class.connection_string);
        }
        public static string img_rute = "";
        public static string pass = "";
        private void settings_Load(object sender, EventArgs e)
        {
            Connection.Open();
            // GETTING NAME TO SHOW

            string query_name = $"SELECT name FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_name = new MySqlCommand(query_name, this.Connection);

            var name_to_text = commandDatabase_name.ExecuteScalar();
            name_label.Text = name_to_text.ToString();

            // GETTING LASTNAME TO SHOW

            string query_lastname = $"SELECT surname FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_lastname = new MySqlCommand(query_lastname, this.Connection);

            var surname_to_text = commandDatabase_lastname.ExecuteScalar();

            lastname_label.Text = surname_to_text.ToString();

            // GETTING DOB

            string query_dob = $"SELECT dob FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_dob = new MySqlCommand(query_dob, this.Connection);

            var dob_to_text = commandDatabase_dob.ExecuteScalar();

            dob_label.Text = dob_to_text.ToString();
            // GETTING IMG

            string query_img = $"SELECT img FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);
            var img_to_text = commandDatabase_img.ExecuteScalar();

            pictureBox1.Image = Image.FromFile($@"{img_to_text}");

            string query_ask = $"SELECT password FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand command_password = new MySqlCommand(query_ask, this.Connection);
            pass = command_password.ExecuteScalar().ToString();
            Connection.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                img_rute = openFileDialog1.FileName;
            }

            string query = $"UPDATE `bank_test`.`test` SET `img` = @img WHERE(`email` = '{login_form.user_email_global}')";
            this.Connection.Open();


            MySqlCommand commandDatabase_query = new MySqlCommand(query, this.Connection);
            commandDatabase_query.Parameters.AddWithValue("@img", img_rute);

            commandDatabase_query.ExecuteNonQuery();
            this.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (pass == current_pass.Text)
            {
                if(new_pass.Text == new_pass2.Text)
                {
                    this.Connection.Open();
                    string query_change = $"UPDATE `bank_test`.`test` SET `password` = '{new_pass.Text}'  WHERE(`email` = '{login_form.user_email_global}' and `password` ='{login_form.user_password_global}');";
                    MySqlCommand command_change = new MySqlCommand(query_change, this.Connection);
                    command_change.ExecuteNonQuery();
                    current_pass.Text = "";
                    new_pass.Text = "";
                    new_pass2.Text = "";
                    MessageBox.Show("Password Changed");
                    this.Connection.Close();
                }
                else
                {
                    MessageBox.Show("Password must be the same");
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            main_pagecs.Main_Page.Show();
            main_pagecs.Main_Page.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete your account?","Confirm", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                string query_delete = @$"Delete from `bank_test`.`test`  WHERE(`email` = '{login_form.user_email_global}' and `password` ='{login_form.user_password_global}');";
                MySqlCommand command_delete = new MySqlCommand(query_delete, this.Connection);
                this.Connection.Open();
                command_delete.ExecuteNonQuery();
                this.Connection.Close();
                this.Close();
                main_pagecs.Main_Page.Hide();
                Form1.MainForm.Show();
            }
            else if (delete == DialogResult.No)
            {
                
            }
                                       
        }
    }
}
