namespace week4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yon(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                panel2.Top -= 5;
            if (e.KeyCode == Keys.Down)
                panel2.Top += 5;
            if (e.KeyCode == Keys.Left)
                panel2.Left -= 5;
            if (e.KeyCode == Keys.Right)
                panel2.Left += 5;

          

        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Left < panel2.Left)
                panel1.Left++;
            if (panel1.Left > panel2.Left)
                panel1.Left--;
            if (panel1.Top > panel2.Top)
                panel1.Top--;
            if(panel1.Top < panel2.Top)
                panel1.Top++;
            if(panel2.Location != panel1.Location)
            {
                label2.Text = rnd.Next(1, 10).ToString();
                label3.Text = rnd.Next(1, 10).ToString();
                label4.Text = rnd.Next(1, 10).ToString();

            }
        }
    }
}