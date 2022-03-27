using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array1 = new int[10] { 23, 12, 45, 32, 78, 4, 1, 98, 56, 8 };
        private void button1_Click(object sender, EventArgs e)
        {
           Array.Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            
                listBox1.Items.Add(array1[i]);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Reverse(array1);
            for (int i = 0; i < array1.Length; i++)

                listBox3.Items.Add(array1[i]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Clear(array1,2,4);
            for (int i = 0; i < array1.Length; i++)

                listBox2.Items.Add(array1[i]);
        }
    }
}
