namespace C12VeriTabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxSum.Clear();
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
             
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int sum = a + b;
            textBoxSum.Text = sum.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}