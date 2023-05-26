using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_test_2
{
    internal class user
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }

        public string img { get; set; }

        public user(string name, string lastname, string email, string password, string gender, string date)
        {
            this.Name = name;
            this.Surname = lastname;
            this.Password = password;
            this.email = email;
            this.dob = date;
            this.gender = gender;
            
        }

        public user(string Email, string Password)
        {
            this.email = Email;
            this.Password = Password;
        }


        public string get_password()
        {
            return this.Password;
        }

        public string print_email()
        {
<<<<<<< Updated upstream
            return this.email;
=======
            Connect connect_class = new Connect();
            int id = connect_class.get_id();
            this.Connection = new MySqlConnection(connect_class.connection_string);

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            string pass_pattern = @"^(?=.*[a-zA-Z])(?=.*[!@#$%^&*()])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            Regex regex_pass = new Regex(pass_pattern);

            if (!regex.IsMatch(usuari.email))
            {
                MessageBox.Show("Enter a valid email");
               
            }
            else if (!regex_pass.IsMatch(usuari.Password))
            {
                MessageBox.Show("Password must have: letter, capital letter, number and symbol");
                
            }
            else
            {
                string query = $"INSERT INTO `bank_test`.`users` (`name`, `surname`,`email`,`password`,`gender`,`dob`)" +
                   $" VALUES ('{usuari.Name}','{usuari.Surname}','{usuari.email}','{usuari.Password}','{usuari.gender}','{usuari.dob}')";
                MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
                try
                {
                    this.Connection.Open();
                    int result = commandDatabase.ExecuteNonQuery();
                    
                    this.Connection.Close();
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Form1.MainForm.Show();
            }

           



            return 0;
        }
        public bool Login_User(user usuari)
        {
            Connect connect_class = new Connect();

            this.Connection = new MySqlConnection(connect_class.connection_string);
            string query = $"SELECT count(*) FROM bank_test.users where email = '{usuari.email}' and password = '{usuari.Password}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);

            try
            {
                this.Connection.Open();
                int count = Convert.ToInt32(commandDatabase.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Login Succesful");
                    login_form.user_email_global = usuari.email;
                    login_form.user_password_global = usuari.Password;

                    string query_img = $"SELECT img FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
                    MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);

                    var img_to_text = commandDatabase_img.ExecuteScalar();

                    login_form.pic_rute = img_to_text.ToString();
                    this.Connection.Close();
                    return true;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;


        }
        public string payment()
        {
            return "hello";
>>>>>>> Stashed changes
        }

    
    }
}
