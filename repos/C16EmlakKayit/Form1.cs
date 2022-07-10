namespace C16EmlakKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == "admin" && textBoxPW.Text == "anan")
            {
                Estate estate = new Estate();
                estate.Show();
                this.Hide();
            }
        }
    }
}