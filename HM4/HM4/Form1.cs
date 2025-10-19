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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open an Image File";
            dialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }

            Form2 frm2 = new Form2(
                maskedTextBox1.Text, 
                textBox1.Text, 
                textBox2.Text, 
                gender, 
                comboBox1.Text, 
                dateTimePicker1.Text, 
                textBox3.Text, 
                pictureBox1.Image);
            frm2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
