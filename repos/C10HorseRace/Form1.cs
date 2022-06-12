namespace C10HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int firstHorse, secondHorse, thirdHorse;
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int firstHorseWidth = pictureBox1.Width;
            int secondHorseWidth = pictureBox2.Width;
            int thirdHorseWidth = pictureBox3.Width;
            int finish = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rand.Next(1, 101);
            pictureBox2.Left = pictureBox2.Left + rand.Next(1, 101);
            pictureBox3.Left = pictureBox3.Left + rand.Next(1, 101);
            if (pictureBox1.Left >= finish && pictureBox2.Left >= finish && pictureBox3.Left >= finish)
            {
                
                timer1.Enabled = false;
                MessageBox.Show("KAZANDI");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstHorse = pictureBox1.Left;
            secondHorse = pictureBox2.Left;
            thirdHorse = pictureBox3.Left;
           
        }
    }
}