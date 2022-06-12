namespace C11ZarVeBilgiYarış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxYou_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
             


            
             
            int a = random.Next(1, 7);
            int b = random.Next(1, 7);
            labelDice1.Text = a.ToString();
            labelDice2.Text = b.ToString();
            int sum = a + b;
            labelDiceSum.Text = sum.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = random.Next(1, 7);
            int b = random.Next(1, 7);
            labelDice3.Text = a.ToString();
            labelDice4.Text = b.ToString();
            int sum = a + b;
            labelDiceSumAI.Text = sum.ToString();
        }
    }
}