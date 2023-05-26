using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySqlConnector;

namespace bank_test_2
{
    
    internal class connect_class
    {
        public string connection_string { get; set; }
        private MySqlConnection Connection { get; set; }

        public connect_class()
        {
            this.connection_string = "datasource=127.0.0.1;" +
          "port= 3306;" +
          " username=root;"
          + "password= Jupo2011!;" +
          "database = bank_test";
        }

        public int Insert_User(user usuari)
        {
            this.Connection = new MySqlConnection(this.connection_string);

            string query = $"INSERT INTO `bank_test`.`test` (`name`, `surname`,`email`,`password`,`gender`,`dob`)" +
                    $" VALUES ('{usuari.Name}','{usuari.Surname}','{usuari.email}','{usuari.Password}','{usuari.gender}','{usuari.dob}')";

            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            try
            {
                 this.Connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                this.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Form1.MainForm.Show();
            
            

            return -1;
        }

        public bool Login_User (user usuari)
        {
            this.Connection = new MySqlConnection(this.connection_string);
            string query = $"SELECT count(*) FROM bank_test.test where email = '{usuari.email}' and password = '{usuari.Password}'";

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

                    string query_img = $"SELECT img FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
                    MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);

                    var img_to_text = commandDatabase_img.ExecuteScalar();

                    login_form.pic_rute = img_to_text.ToString();                   
                }
                this.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return true;
        }

        public List<object> show_user_info()
        {
            this.Connection = new MySqlConnection(this.connection_string);
            Connection.Open();
            List<object> list = new List<object>();

            
            string query_img = $"SELECT img FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);
            var img_to_text = commandDatabase_img.ExecuteScalar();

            string query_name = $"SELECT name FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_name = new MySqlCommand(query_name, this.Connection);
            var name_to_text = commandDatabase_name.ExecuteScalar();
            list.Add(img_to_text);
            list.Add(name_to_text);



            this.Connection.Close();

            return list;
        }

        public string get_balance()
        {
            this.Connection = new MySqlConnection(this.connection_string);
            Connection.Open();
            string balance = "";
            try
            {
                string query = $"SELECT id FROM bank_test.test where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";

                MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
                int id = Convert.ToInt32(commandDatabase.ExecuteScalar());

                string query_count = $"SELECT count(*) from bank_test.userbalance where userID = '{id.ToString()}'";

                MySqlCommand id_cmd = new MySqlCommand(query_count, this.Connection);
                int count = Convert.ToInt32(id_cmd.ExecuteScalar());
                if(count > 0)
                {
                    string query_balance = $"SELECT balance from bank_test.userbalance where userID = '{id.ToString()}'";
                    MySqlCommand balance_cmd = new MySqlCommand(query_balance, this.Connection);
                    var balance_text = balance_cmd.ExecuteScalar();
                    balance = balance_text.ToString() + " €";

                }
                else
                {

                    string query_insert = $"INSERT INTO `bank_test`.`userbalance` (`userID`, `balance`) VALUES ('{id.ToString()}', '1000');";
                    MySqlCommand insert_cmd = new MySqlCommand(query_insert, this.Connection);
                    insert_cmd.ExecuteNonQuery();

                    string query_balance = $"SELECT balance from bank_test.userbalance where userID = '{id.ToString()}'";
                    MySqlCommand balance_cmd = new MySqlCommand(query_balance, this.Connection);
                    var balance_text = balance_cmd.ExecuteScalar();
                    balance = balance_text.ToString() + " €";

                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return balance;
        }
    }
}
