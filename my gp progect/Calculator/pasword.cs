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
    public partial class pasword : Form
    {
        public pasword()
        {
            InitializeComponent();
            this.ActiveControl = tetboxpasword;
        }
        public static string Show()
        {
            using (pasword inputDLg = new pasword ())
            {
                inputDLg.ShowDialog();
                return inputDLg.tetboxpasword.Text;
            }
        }

        private void pasword_Load(object sender, EventArgs e)
        {

        }
    }
        
}
