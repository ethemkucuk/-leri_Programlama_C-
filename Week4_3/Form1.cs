using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_Nt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;
        int art = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(a);
                a += art;
                if(i%3 == 0)
                    art++;

            }
        }
    }
}
