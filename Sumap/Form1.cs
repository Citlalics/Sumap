using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            //crear elobjeto  
            Sumap sum = new Sumap();
            sum.num1 = int.Parse(txt1.Text);
            sum.num2 = int.Parse(txt2.Text);

            txt3.Text = sum.suma().ToString();
        }
    }
    }

