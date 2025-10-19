using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM4
{
    public partial class Form2 : Form
    {

        public Form2(string i1, string i2, string i3, string i4, string i5, string i6, string i7, Image i8 )
        {
            InitializeComponent();
            textBox1.Text = i1;
            textBox2.Text = $"{i3}, {i2}";
            textBox3.Text = i4;
            textBox4.Text = i5;
            textBox5.Text = i6;
            textBox6.Text = i7;
            pictureBox1.Image = i8;
            
            
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
