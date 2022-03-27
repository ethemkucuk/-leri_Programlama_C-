namespace week4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += a;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Purple;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }
    }
}