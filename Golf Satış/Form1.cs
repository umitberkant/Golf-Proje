using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int otv = 0;
            int kdv = 0;
            int t = 0;

            int m10 = 105000;
            int c10 = 125000;
            int h10 = 180000;

            int m16 = 125000;
            int c16 = 145000;
            int h16 = 200000;

            if (mtr1.Checked && d1.Checked)
            {
                t = m10;           
            if (ek1.Checked)
            {
                t = t + 2500;
            }
            if (ek2.Checked)
            {
                t = t + 4000;
            }
            if (ek3.Checked)
            {
                t = t + 3500;
            }
            if (ek4.Checked)
            {
                otv = t * 145 / 100;
                kdv = t * 18 / 100;
                t = t + otv + kdv;
            }
            if (san1.Checked)
            {
                t = t + 20000;
            }
            if (san2.Checked)
            {
                t = t + 10000;
            }
            fiyatlabel.Text = Convert.ToString(t);
            }
            if (mtr1.Checked && d2.Checked)
            {
                t = c10;
                if (ek1.Checked)
                {
                    t = t + 2500;
                }
                if (ek2.Checked)
                {
                    t = t + 4000;
                }
                if (ek3.Checked)
                {
                    t = t + 3500;
                }
                if (ek4.Checked)
                {
                    otv = t * 145 / 100;
                    kdv = t * 18 / 100;
                    t = t + otv + kdv;
                }
                if (san1.Checked)
                {
                    t = t + 20000;
                }
                if (san2.Checked)
                {
                    t = t + 10000;
                }
                fiyatlabel.Text = Convert.ToString(t);
            }
            if (mtr1.Checked && d3.Checked)
            {
                t = h10;
                if (ek1.Checked)
                {
                    t = t + 2500;
                }
                if (ek2.Checked)
                {
                    t = t + 4000;
                }
                if (ek3.Checked)
                {
                    t = t + 3500;
                }
                if (ek4.Checked)
                {
                    otv = t * 145 / 100;
                    kdv = t * 18 / 100;
                    t = t + otv + kdv;
                }
                if (san1.Checked)
                {
                    t = t + 20000;
                }
                if (san2.Checked)
                {
                    t = t + 10000;
                }
                fiyatlabel.Text = Convert.ToString(t);
            }
            if (mtr2.Checked && d1.Checked)
            {
                t = m16;
                if (ek1.Checked)
                {
                    t = t + 2500;
                }
                if (ek2.Checked)
                {
                    t = t + 4000;
                }
                if (ek3.Checked)
                {
                    t = t + 3500;
                }
                if (ek4.Checked)
                {
                    otv = t * 145 / 100;
                    kdv = t * 18 / 100;
                    t = t + otv + kdv;
                }
                if (san1.Checked)
                {
                    t = t + 20000;
                }
                if (san2.Checked)
                {
                    t = t + 10000;
                }
                fiyatlabel.Text = Convert.ToString(t);
            }
            if (mtr2.Checked && d2.Checked)
            {
                t = c16;
                if (ek1.Checked)
                {
                    t = t + 2500;
                }
                if (ek2.Checked)
                {
                    t = t + 4000;
                }
                if (ek3.Checked)
                {
                    t = t + 3500;
                }
                if (ek4.Checked)
                {
                    otv = t * 145 / 100;
                    kdv = t * 18 / 100;
                    t = t + otv + kdv;
                }
                if (san1.Checked)
                {
                    t = t + 20000;
                }
                if (san2.Checked)
                {
                    t = t + 10000;
                }
                fiyatlabel.Text = Convert.ToString(t);
            }
            if (mtr2.Checked && d3.Checked)
            {
                t = h16;
                if (ek1.Checked)
                {
                    t = t + 2500;
                }
                if (ek2.Checked)
                {
                    t = t + 4000;
                }
                if (ek3.Checked)
                {
                    t = t + 3500;
                }
                if (ek4.Checked)
                {
                    otv = t * 145 / 100;
                    kdv = t * 18 / 100;
                    t = t + otv + kdv;
                }
                if (san1.Checked)
                {
                    t = t + 20000;
                }
                if (san2.Checked)
                {
                    t = t + 10000;
                }
                fiyatlabel.Text = Convert.ToString(t);
            }
        }      
    }
}
