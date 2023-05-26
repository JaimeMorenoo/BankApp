using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace bank_test_2
{
    internal class admin
    {
        public string name { get; set; }
        public string password { get; set; }

        private MySqlConnection Connection { get; set; }

        private Connect _connect_class = new Connect();

        public admin(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public admin()
        {
            Connection = new MySqlConnection();
        }

        public bool admin_login(admin admin)
        {
            Connect connect_class = new Connect();

            this.Connection = new MySqlConnection(connect_class.connection_string);
            string query = $"SELECT count(*) FROM bank_test.admin where admin_username = '{admin.name}' and admin_password = '{admin.password}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            try
            {
                this.Connection.Open();
                int count = Convert.ToInt32(commandDatabase.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Login Succesful");
                    login_form.admin_username = admin.name;
                    login_form.admin_password = admin.password;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;


        }
        public DataTable get_info()
        {
            int id = _connect_class.get_id();
            Connect connect_class = new Connect();

            this.Connection = new MySqlConnection(connect_class.connection_string);
            Connection.Open();
            string query_balance = $"SELECT * FROM bank_test.users";
            MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Connection.Close();


            return dt;

        }

        public DataTable get_balances()
        {
            int id = _connect_class.get_id();
            Connect connect_class = new Connect();

            this.Connection = new MySqlConnection(connect_class.connection_string);
            Connection.Open();
            string query_balance = $"select users.name as 'username',users.id, userbalance.balance, userbalance.name from userbalance inner join users on userbalance.userID = users.id";
            MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            Connection.Close();


            return dt;

        }
        public int get_id()
        {
            Connect connect_class = new Connect();
            this.Connection = new MySqlConnection(connect_class.connection_string);
            Connection.Open();
            string query = $"SELECT id FROM bank_test.admin where admin_username = '{login_form.admin_username}' and admin_password = '{login_form.admin_password}'";
            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);
            int id = Convert.ToInt32(commandDatabase.ExecuteScalar());
            return id;
            Connection.Close();
        }

        public string admin_log()
        {

            Connect connect_class = new Connect();
            this.Connection = new MySqlConnection(connect_class.connection_string);
            this.Connection.Open();
            int id = get_id();
            string query_log = $"INSERT INTO `bank_test`.`admin_logs` (`admin_id`, `action`,`date`) VALUES ('{id}','Logged','{DateTime.Now}')";
            MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
            cmd_logs.ExecuteNonQuery();
            this.Connection.Close();

            return "done";
        }

        public int admin_edit(string table, int id,string new_value)
        {
            Connect connect_class = new Connect();
            this.Connection = new MySqlConnection(connect_class.connection_string);

            string query = $"UPDATE `bank_test`.`users` SET `{table}` = '{new_value}'  WHERE(`id` = '{id}')";
            MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);

            
            try
            {
                this.Connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                int admin_id = get_id();
                string query_log = $"INSERT INTO `bank_test`.`admin_logs` (`admin_id`, `action`,`user_id`,`date`) VALUES ('{admin_id}','{table} changed to {new_value}','{id}','{DateTime.Now}')";
                MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
                cmd_logs.ExecuteNonQuery();

                this.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
      
            return -1;
        }

        public DataTable filter_balances(string id)
        {
            Connect connect_class = new Connect();

            this.Connection = new MySqlConnection(connect_class.connection_string);
            Connection.Open();
            DataTable dt = new DataTable();
            if (id != "all")
            {
                string query_balance = $"select users.name as 'username',users.id, userbalance.balance, userbalance.name from userbalance inner join users on userbalance.userID = users.id " +
                $"where users.id = {id}";
                MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

               

                da.Fill(dt);

                Connection.Close();

            }
            else
            {
                string query_balance = $"select users.name as 'username',users.id, userbalance.balance, userbalance.name from userbalance inner join users on userbalance.userID = users.id ";
               
                MySqlCommand cmd = new MySqlCommand(query_balance, this.Connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                da.Fill(dt);

                Connection.Close();

            }



            return dt;

        }

        public string del_account(string id)
        {
            this.Connection.Open();
            int id_log = get_id();

            string query_log = $"INSERT INTO `bank_test`.`admin_logs` (`admin_id`, `action`,`user_id`,`date`) VALUES ('{id_log}','Account Deleted','{id}','{DateTime.Now}')";
            MySqlCommand cmd_logs = new MySqlCommand(query_log, this.Connection);
            cmd_logs.ExecuteNonQuery();

            string query_balance_delete = @$"Delete from `bank_test`.`userbalance`  WHERE `userID` = {id}";
            MySqlCommand command_delete_b = new MySqlCommand(query_balance_delete, this.Connection);
            command_delete_b.ExecuteNonQuery();

            string query_delete = @$"Delete from `bank_test`.`test`  WHERE(`id` = '{id}');";
            MySqlCommand command_delete = new MySqlCommand(query_delete, this.Connection);

            command_delete.ExecuteNonQuery();
            this.Connection.Close();
            MessageBox.Show("Account Deleted");
            return "deleted";
        }

    }
}
