using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,,] array1 = new int[4,2,2] { { { 1,2},{3,4 } }, { {5,6 }, {7,8 } }, { { 9,10}, { 11,12} }, { { 13,14}, { 15,16} } };// 4 tane elemanı olan her eleman içerisinde 2 eleman olan ve her eleman içerisinde 2 sayısı olan demek

            for(int i=0; i<4;i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (array1[i, j, k] == Convert.ToInt32(textBox4.Text)) ;
                        textBox1.Text = i.ToString() ;
                        textBox2.Text = j.ToString() ;
                        textBox3.Text = k.ToString() ;
                    }
                }
            }

        } 
    }
}
