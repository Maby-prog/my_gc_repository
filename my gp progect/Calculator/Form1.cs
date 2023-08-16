using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Калькулятор : Form
    {
        int counter = 0;
        public Калькулятор()
        {
            InitializeComponent();
            LbName3.Text = counter.ToString();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LbName1.Text = "Hello, world!";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            LbName2.Text = "Vika";
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            counter++;
            LbName3.Text = counter.ToString();
        }
    }
}
