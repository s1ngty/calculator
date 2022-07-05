using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double plus, min, umn, del, b, percnt,pom,quadro,xvk,oox;
        public Form1()
        {
            InitializeComponent();
            top_label.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button9.Text;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            plus = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button5.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button6.Text;
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            min = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button2.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button3.Text;
        }

        private void button_umn_Click(object sender, EventArgs e)
        {
            umn = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button10.Text;
        }

        private void top_label_Click(object sender, EventArgs e)
        {

        }
 

        private void oneDELonX_Click(object sender, EventArgs e)
        {
            //1 делим на х
            oox = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }


        private void squart_Click(object sender, EventArgs e)
        {
            //корень
            xvk = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //возведение в квадрат
            quadro = Convert.ToDouble(top_label.Text);
            top_label.Text = "";

        }


        private void plusORminus_Click(object sender, EventArgs e)
        {//смена знака
              pom = Convert.ToDouble(top_label.Text);
              top_label.Text = "";
        }


        private void percent_Click(object sender, EventArgs e)
        {//процент
             percnt = Convert.ToDouble(top_label.Text);
             top_label.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            top_label.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            top_label.Text += this.button0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {//деление
            del = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }

        private void button_rav_Click(object sender, EventArgs e)
        {
            if (plus != 0)
            {
                b = Convert.ToDouble(top_label.Text);
                top_label.Text = Convert.ToString(plus + b);
                b = 0;
                plus = 0;
            }
            else if (min != 0)
            {
                b = Convert.ToDouble(top_label.Text);
                top_label.Text = Convert.ToString(min - b);
                b = 0;
                min = 0;
            }
            else if (umn != 0)
            {
                b = Convert.ToDouble(top_label.Text);
                top_label.Text = Convert.ToString(umn * b);
                b = 0;
                umn = 0;
            }
            else if (del != 0)
            {
                b = Convert.ToDouble(top_label.Text);
                top_label.Text = Convert.ToString(del / b);
                b = 0;
                del = 0;
            }
            else if (percnt != 0)
            {
                b = Convert.ToDouble(top_label.Text);
                top_label.Text = Convert.ToString(percnt / 100 * b);
                b = 0;
                percnt = 0;
            }
            else if (pom != 0)
            {
                top_label.Text = Convert.ToString(pom * (-1));
                pom = 0;
            }
            else if (quadro != 0)
            {
                top_label.Text = Convert.ToString(quadro * quadro);
                quadro = 0;
            }
            else if (xvk != 0)
            {
                top_label.Text = Convert.ToString(Math.Sqrt(xvk));
                xvk = 0;
            }
            else if (oox != 0) 
            {
                top_label.Text = Convert.ToString(1 / oox);
                oox = 0; 
            }
            
        }


        //Тут работа с памятью MS,MR,MC,M+,M-
        double Ms = 0;
        private void MC_Click(object sender, EventArgs e)
         {
            Ms = 0;
            top_label.Text = "";
        }
        private void MS_Click(object sender, EventArgs e)
        {
            Ms = Convert.ToDouble(top_label.Text);
            top_label.Text = "";
        }
        private void MR_Click(object sender, EventArgs e)
        {
            top_label.Text = Convert.ToString(Ms);
        }
        private void Mplus_Click(object sender, EventArgs e)
        {
            Ms = Ms + Convert.ToDouble(top_label.Text);
        }
        private void Mminus_Click(object sender, EventArgs e)
        {
            Ms = Ms - Convert.ToDouble(top_label.Text);
        }

    }
}

