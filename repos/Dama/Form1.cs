namespace Dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8, 8];
            int Top = 0;
            
            for (int i = 0; i <= button.GetUpperBound(0); i++) 
            {

                int Left = 0;

                for (int j = 0; j <= button.GetUpperBound(1); j++)
                {
                    
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                   
                    button[i, j].Left = Left;
                    button[i, j].Top = Top;
                    Left += 50;
                    this.Controls.Add(button[i, j]);
                    if((i + j) % 2 == 0)
                    {
                        button[i,j].BackColor = Color.White;
                    }
                    else
                    {
                        button[i,j].BackColor= Color.Black;
                    }
                }
                
                Top += 50;

            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}