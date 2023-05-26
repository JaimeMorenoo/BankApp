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
    public partial class CreateUser_Form : Form
    {
        

        private MySqlConnection Connection { get; set; }

        private connect_class _connect_class = new connect_class();
        public static CreateUser_Form MainForm { get; private set; }
        public CreateUser_Form()
        {
            InitializeComponent();
            this.Connection = new MySqlConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string lastname = surname_textbox.Text;
            string email = email_textbox.Text;
            string password = password_textbox.Text;
            DateTime date = date_textbox.Value;
            string date_formated = date.ToString("yyyy/MM/dd");
            string gender = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;

            user test_user = new user(name,lastname,email,password,gender,date_formated);

            _connect_class.Insert_User(test_user);
            this.Close();

        }

        private void CreateUser_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.MainForm.Show();
        }
    }
}
