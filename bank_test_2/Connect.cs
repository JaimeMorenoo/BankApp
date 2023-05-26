using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySqlConnector;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Logging;

namespace bank_test_2
{
    
    internal class Connect
    {
        public string connection_string { get; set; }
        private MySqlConnection Connection { get; set; }

        public Connect()
        {
            this.connection_string = "datasource=127.0.0.1;" +
          "port= 3306;" +
          " username=root;"
          + "password= Jupo2011!;" +
          "database = bank_test";
        }

        public int get_id()
        {
            this.Connection = new MySqlConnection(this.connection_string);
            Connection.Open();
            string query = $"SELECT id FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            int id = Convert.ToInt32(commandDatabase.ExecuteScalar());
            return id;
        }



        public List<object> show_user_info()
        {
            this.Connection = new MySqlConnection(this.connection_string);
            Connection.Open();
            List<object> list = new List<object>();

            
            string query_img = $"SELECT img FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);
            var img_to_text = commandDatabase_img.ExecuteScalar();

            string query_name = $"SELECT name FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
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
                string query = $"SELECT id FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";

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

                    string query_insert = $"INSERT INTO `bank_test`.`userbalance` (`userID`, `balance`,`name`) VALUES ('{id.ToString()}', '1000','main');";
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

        public string new_bank_acc(string name)
        {
            this.Connection = new MySqlConnection(this.connection_string);
            Connection.Open();

            string query = $"SELECT id FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            int id = Convert.ToInt32(commandDatabase.ExecuteScalar());

            string query_insert = $"INSERT INTO `bank_test`.`userbalance` (`userID`, `balance`,`name`) VALUES ('{id.ToString()}', 1000,'{name}');";
            MySqlCommand insert_cmd = new MySqlCommand(query_insert, this.Connection);
            insert_cmd.ExecuteNonQuery();

            string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`date`) VALUES ('{id}','New Account Created','{DateTime.Now}')";

            MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
            cmd_logs.ExecuteNonQuery();

            Connection.Close();
            MessageBox.Show("New Account Created.");


            return "h";
        }

        public DataTable total_balances()
        {
            int id = get_id();


            string query_balance = $"SELECT name, balance FROM bank_test.userbalance where userid = '{id}'";
            MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Connection.Close();


            return dt;
        }

        public List<string> box_balances()
        {
            int id = get_id();

            string query_balance = $"SELECT name, balance FROM bank_test.userbalance where userid = '{id}'";
            MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);

            MySqlDataReader reader = cmd.ExecuteReader();
           

            List<string> list = new List<string>();
            while (reader.Read())
            {
                string names = reader["name"].ToString();
                string value = reader["balance"].ToString();
                string balances = names + " " + value.ToString()+ "€";
                list.Add(balances);
            }
            this.Connection.Close();
            return list;
        }

        public string personal_transaction(string a,string b,float amount)
        {
            int id = get_id();

            string query_balance = $"SELECT balance from bank_test.userbalance WHERE (`name` = '{a}'and `userID`= {id});";
            MySqlCommand cmd_balance = new MySqlCommand(query_balance,this.Connection);
            int balance_test = Convert.ToInt32(cmd_balance.ExecuteScalar());

            if(balance_test > 0 && amount < balance_test)
            {
                string query_a = $"UPDATE `bank_test`.`userbalance` SET `balance` = `balance` - @amount WHERE (`name` = '{a}'and `userID`= {id});";
                MySqlCommand cmd_a = new MySqlCommand(@query_a, this.Connection);
                cmd_a.Parameters.AddWithValue("@amount", amount);
                cmd_a.ExecuteNonQuery();

                string query_b = $"UPDATE `bank_test`.`userbalance` SET `balance` = `balance` + @amount WHERE (`name` = '{b}'and `userID`= {id});";
                MySqlCommand cmd_b = new MySqlCommand(query_b, this.Connection);
                cmd_b.Parameters.AddWithValue("@amount", amount);
                cmd_b.ExecuteNonQuery();

                string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`balance`, `date`) VALUES ('{id}','Transaction to {b} from {a}','{amount.ToString()}€','{DateTime.Now}')";

                MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
                cmd_logs.ExecuteNonQuery();
                MessageBox.Show("Transaction Done");
                this.Connection.Close();

            }

            else
            {
                MessageBox.Show("-Select Right Account\n-Account must be positive\n-Need enough money to transfer");
            }
           

            return "a";
        }

        public string payment(int a,string b, float c)
        {
            int id = get_id();
            string query_balance = $"SELECT balance from bank_test.userbalance WHERE (`name` = '{b}'and `userID`= {id});";
            MySqlCommand cmd_balance = new MySqlCommand(query_balance, this.Connection);
            int balance_test = Convert.ToInt32(cmd_balance.ExecuteScalar());

            if (balance_test > 0 && c < balance_test)
            {
                string query_a = $"UPDATE `bank_test`.`userbalance` SET `balance` = `balance` - @amount WHERE (`name` = '{b}'and `userID`= {id});";
                MySqlCommand cmd_a = new MySqlCommand(@query_a, this.Connection);
                cmd_a.Parameters.AddWithValue("@amount", c);
                cmd_a.ExecuteNonQuery();

                string query_b = $"UPDATE `bank_test`.`userbalance` SET `balance` = `balance` + @amount WHERE (`name` = 'main'and `userID`= {a});";
                MySqlCommand cmd_b = new MySqlCommand(query_b, this.Connection);
                cmd_b.Parameters.AddWithValue("@amount", c);
                cmd_b.ExecuteNonQuery();

                string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`balance`,`user_receiver`, `date`) VALUES ('{id}','Payment from {b}','{c.ToString()}€','{a}','{DateTime.Now}')";

                MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
                cmd_logs.ExecuteNonQuery();

                MessageBox.Show("Transaction Done");
                this.Connection.Close();
            }

            else
            {
                MessageBox.Show("Requirements:\n-Account must be positive\n-Not enough money to transfer");
            }




            return "a";

        }

        public List<string> settings_load_info()
        {
            this.Connection = new MySqlConnection(this.connection_string);

            this.Connection.Open();
            // GETTING NAME TO SHOW
            List<string> list = new List<string>();
            string query_name = $"SELECT name FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_name = new MySqlCommand(query_name, this.Connection);

            var name_to_text = commandDatabase_name.ExecuteScalar();
            list.Add(name_to_text.ToString());

            string query_lastname = $"SELECT surname FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_lastname = new MySqlCommand(query_lastname, this.Connection);

            var surname_to_text = commandDatabase_lastname.ExecuteScalar();
            list.Add(surname_to_text.ToString());

            string query_dob = $"SELECT dob FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_dob = new MySqlCommand(query_dob, this.Connection);

            var dob_to_text = commandDatabase_dob.ExecuteScalar();

            list.Add(dob_to_text.ToString());

            string query_img = $"SELECT img FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand commandDatabase_img = new MySqlCommand(query_img, this.Connection);
            var img_to_text = commandDatabase_img.ExecuteScalar();

            list.Add(img_to_text.ToString());

            string query_ask = $"SELECT password FROM bank_test.users where email = '{login_form.user_email_global}' and password = '{login_form.user_password_global}'";
            MySqlCommand command_password = new MySqlCommand(query_ask, this.Connection);
            string pass = command_password.ExecuteScalar().ToString();
            list.Add(pass);
            this.Connection.Close();
            return list;
        }


        public string change_pic(string img_rute)
        {
            string query = $"UPDATE `bank_test`.`users` SET `img` = @img WHERE(`email` = '{login_form.user_email_global}')";
            this.Connection.Open();
            int id = get_id();

            MySqlCommand commandDatabase_query = new MySqlCommand(query, this.Connection);
            commandDatabase_query.Parameters.AddWithValue("@img", img_rute);

            commandDatabase_query.ExecuteNonQuery();
            string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`date`) VALUES ('{id}','Profile picture changed','{DateTime.Now}')";

            MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
            cmd_logs.ExecuteNonQuery();
            this.Connection.Close();
            return "a";
        }

        public string change_pass(string pass)
        {
            this.Connection.Open();
            string pass_pattern = @"^(?=.*[a-zA-Z])(?=.*[!@#$%^&*()])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            Regex regex_pass = new Regex(pass_pattern);
            if (regex_pass.IsMatch(pass))
            {
                string query_change = $"UPDATE `bank_test`.`users` SET `password` = '{pass}'  WHERE(`email` = '{login_form.user_email_global}' and `password` ='{login_form.user_password_global}');";
                MySqlCommand command_change = new MySqlCommand(query_change, this.Connection);
                command_change.ExecuteNonQuery();
                login_form.user_password_global = pass;
                int id = get_id();
                string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`date`) VALUES ('{id}','Password changed','{DateTime.Now}')";

                MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
                cmd_logs.ExecuteNonQuery();
                this.Connection.Close();
                MessageBox.Show("Password Changed");
                return pass;
            }
            else
            {
                MessageBox.Show("Password must contain letter, capital letter, symbol, number");
            }
            this.Connection.Open();
            return pass;
        }

        public string delete_acc()
        {
            this.Connection.Open();
            string id = Convert.ToString(get_id());
            int id_log = get_id();

            string query_log = $"INSERT INTO `bank_test`.`logs` (`user_id`, `action`,`date`) VALUES ('{id_log}','Account Deleted','{DateTime.Now}')";
            MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
            cmd_logs.ExecuteNonQuery();

            string query_balance_delete = @$"Delete from `bank_test`.`userbalance`  WHERE `userID` = {id}";
            MySqlCommand command_delete_b = new MySqlCommand(query_balance_delete, this.Connection);
            command_delete_b.ExecuteNonQuery();

            string query_delete = @$"Delete from `bank_test`.`users`  WHERE(`email` = '{login_form.user_email_global}' and `password` ='{login_form.user_password_global}');";
            MySqlCommand command_delete = new MySqlCommand(query_delete, this.Connection);
            
            command_delete.ExecuteNonQuery();
            this.Connection.Close();
            return "a";
        }


        public List<string> get_logs()
        {
           
            this.Connection.Open();
            int id = get_id();
            string query = $"SELECT * FROM bank_test.logs where user_id = '{id}'";
            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            List<string> logs = new List<string>();
            while (reader.Read())
            {
                string result = $"Your ID: {reader["user_id"]}, Action: {reader["action"]}, User Receiver: {reader["user_receiver"]},Date: {reader["date"]}";
                logs.Add(result);
            }
           
            this.Connection.Close();



            string ruta = $"E:\\logs\\log_id{get_id().ToString()}.txt";
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                foreach(string log in logs)
                {
                    writer.WriteLine(log);
                }
            }

            MessageBox.Show($"File created in: {ruta}");

            return logs;
        }
    }
}
