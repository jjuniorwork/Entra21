using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{numero1 - numero2}");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            MessageBox.Show($"{numero1 + numero2}");

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisãoClick(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

        }
    }
}

