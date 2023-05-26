using MySqlConnector;
using System;
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
    public partial class login_form : Form
    {


        private MySqlConnection Connection { get; set; }

        private connect_class connect_class = new connect_class();

        public static string img_rute = "";

        public login_form()
        {
            InitializeComponent();
            this.Connection = new MySqlConnection(connect_class.connection_string);
        }
        public static string user_email_global = "";
        public static string user_password_global = "";
        public static string pic_rute = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (email_input.Text != "" && password_input.Text != "")
            {
                string user_email = email_input.Text;
                string password = password_input.Text;
                // WE GET EMAIL AND PASSWORD FROM TEXTBOXES
                user user_login = new user(user_email, password);

                if (connect_class.Login_User(user_login)) 
                {
<<<<<<< Updated upstream
=======
                    user_login.login_log();
>>>>>>> Stashed changes
                    main_pagecs frm = new main_pagecs();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password. \nPlease Try Again.");
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Fill in all the boxes");
            }
        }

        private void login_form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
