namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "tomson_dev" && txtpassword.Text == "dev_#1")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zly Login lub Haslo, sproboj ponownie.");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
