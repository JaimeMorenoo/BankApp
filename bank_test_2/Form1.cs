namespace bank_test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 MainForm { get; private set; } // ESTA CLASE PARA PODER HIDE EL FORM EN OTROS FORMS
        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser_Form frm = new CreateUser_Form();
            this.Hide();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainForm = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_form frm = new login_form();
            frm.Show();
        }
    }
}