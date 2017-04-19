using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Brandon Yates
//Natalie Monson
//Payton Hall
//Shawn Jones
//Team Project
//A4
//Test
namespace Fortress__Team_Project_
{
    public partial class Form1 : Form
    {
        numbers num;
        
        
        public Form1()
        {
            InitializeComponent();
            num = new numbers();
            int base1HP = num.Base1Health();
            int base2HP = num.Base2Health();
            Base1.Text = $"{base1HP}";
            Base2.Text = $"{base2HP}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Base1_TextChanged(object sender, EventArgs e)
        {
            int base1HP = num.Base1Health();
            Base1.Text = $"{base1HP}";
            
        }

        private void Base2_TextChanged(object sender, EventArgs e)
        {
            int base2HP = num.Base2Health();
            Base2.Text = $"{base2HP}";
        }
    }
}
