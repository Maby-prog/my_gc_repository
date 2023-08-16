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
    public partial class Menu : Form
    {
        const string OurPassword = "1";
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        enterPasword:
            string password = pasword.Show();
            if(password =="")
            {
                this.Close();
            }
            if(password != OurPassword && password != "" )
            {
                MessageBox.Show("Попробуйте в следующий раз!","Пароль неверный!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goto enterPasword; 
            }
        }

        private void lblLinkCalculator_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr();
            frm.Show();
        }
    }
}
