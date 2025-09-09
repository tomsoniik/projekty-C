namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadTweets_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lstTweets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
