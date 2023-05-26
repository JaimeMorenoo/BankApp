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
    public partial class main_pagecs : Form
    {
        private connect_class connect_class = new connect_class();
        private MySqlConnection Connection { get; set; }
        public static main_pagecs Main_Page { get; private set; }

        
        public main_pagecs()
        {
            InitializeComponent();
            this.Connection = new MySqlConnection(connect_class.connection_string);
            Main_Page = this;
            
        }


        private void main_pagecs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            frm.Show();
            pictureBox1.Hide();
            label1.Hide();
            button1.Show();
            main_balance_text.Hide();
            balance_title.Hide();
            this.Hide();
        }

        private void main_pagecs_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Hide();
            main_balance_text.Hide();
            balance_title.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> list = connect_class.show_user_info();

            pictureBox1.Image = Image.FromFile($@"{list[0].ToString()}");
            pictureBox1.Show();
            label1.Text = "Logged as " + list[1].ToString();
            label1.Show();

            main_balance_text.Text = connect_class.get_balance();
            main_balance_text.Show();
            balance_title.Show();
            button1.Hide();
        }

        private void main_pagecs_Activated(object sender, EventArgs e)
        {
            
<<<<<<< Updated upstream
=======
                
        }

        private void payment_send_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(payment_textbox.Text);
                float value = float.Parse(payment_amount.Text, CultureInfo.InvariantCulture);
                string account_select = payment_acc.Text;
                List<string> tr_a = account_select.Split(" ").ToList();



                if (dateTimePicker1.Value == DateTime.Today)
                {
                    Data.payment(id, tr_a[0], value);

                    dataGridView1.DataSource = Data.total_balances();
                    main_balance_text.Text = Data.get_balance();

                    payment_textbox.Clear();
                    payment_amount.Clear();
                    payment_acc.Text = "Account";
                }
                else
                {
                    DateTime selectedDate = dateTimePicker1.Value;
                    // haces la funcion con date
                    MessageBox.Show($"Payment will be done the : {dateTimePicker1.Value.ToString()}");
                    payment_textbox.Clear();
                    payment_amount.Clear();
                    Observable.Timer(selectedDate).Subscribe(time =>
                    {

                        Data.payment(id, tr_a[0], value);
                        if (dataGridView1.InvokeRequired)
                        {
                            dataGridView1.Invoke(new Action(() => {
                                dataGridView1.DataSource = Data.total_balances();
                                main_balance_text.Text = Data.get_balance();
                                payment_textbox.Clear();
                                payment_amount.Clear();
                                payment_acc.Text = "Account";
                            }));
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select right IBAN (user ID)\nSelect right number format\nSelect account with enough money");
            }

        }

        private void payment_acc_MouseClick(object sender, MouseEventArgs e)
        {

            List<string> transactions = Data.box_balances();
            payment_acc.Items.Clear();
            for (int i = 0; i < transactions.Count; i++)
            {
                payment_acc.Items.Add(transactions[i].ToString());

            }
>>>>>>> Stashed changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List <string> logs = Data.get_logs();

        }
    }
}
