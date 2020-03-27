using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ObliczbBTN_Click(object sender, EventArgs e)
        {
            if (Zad1RB.Checked) Zad1();
            else if (Zad2RB.Checked) Zad2();
            else if (Zad3RB.Checked) Zad3();
            else if (Zad4RB.Checked) Zad4();
            else if (Zad5RB.Checked) Zad5();
            else if (Zad6RB.Checked) Zad6();
            else if (Zad7RB.Checked) Zad7();
            else if (Zad8RB.Checked) Zad8();
            else if (Zad9RB.Checked) Zad9();

            
        }
        public void Zad1()
        {
            wynikTB.Clear();
            double n = double.Parse(xTB.Text);
            Func<double, double> nazwa = x => n;
            wynikTB.Text = nazwa(double.Parse(xTB.Text)).ToString();
        }
        public void Zad2()
        {
            wynikTB.Clear();
            string napis2 = yTB.Text;
            Func<string, string> polacz = napis => napis+" "+napis2;
            wynikTB.Text = polacz(xTB.Text);
        }
        public void Zad3()
        {
            wynikTB.Clear();
            char a;
            int n = int.Parse(xTB.Text);
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a = (char)rand.Next(97, 123);
                Func<char, char> nazwa = x => a;
                char b= nazwa(char.Parse(xTB.Text));
                wynikTB.Text += b.ToString();               
            }
        }

        public void Zad4()
        {
            wynikTB.Clear();
            int n = 10;
           double[] tab = new double[10];
           for(int i = 0; i < n; i++)
            {
                Func<double, double> nazwa = x => Math.Pow(x, i);
                tab[i] = nazwa(double.Parse(xTB.Text));
                wynikTB.Text += (i + 1) + ". " + tab[i] + "\n";
            }
        }
        public void Zad5()
        {

        }
        public void Zad6()
        {

        }
        public void Zad7()
        {

        }
        public void Zad8()
        {

        }
        public void Zad9()
        {

        }


    }
}
