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
            try
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
            catch (FormatException)
            {
                wynikTB.Text = "Błąd";
            }
        }
        public void Zad1()
        {
            wynikTB.Clear();
            double n = double.Parse(yTB.Text);
            Func<double, double> nazwa = x => Math.Pow(x,n);
            wynikTB.Text = nazwa(double.Parse(xTB.Text)).ToString();
        }
        public void Zad2()
        {
            wynikTB.Clear();
            Func<string, string,string> polacz = (a,b) => a+" "+b;
            wynikTB.Text = polacz(xTB.Text,yTB.Text);
        }
        public void Zad3()
        {
            wynikTB.Clear();
            Func<int, string> nazwa = (n) =>
              {
                  Random rand = new Random();
                  char[] a = new char[n];
                  for (int i = 0; i < n; i++)
                  {
                      a[i] = (char)rand.Next(97, 123);
                      
                  }
                  String s = new String(a);
                  return s;
              };
            wynikTB.Text += nazwa(int.Parse(xTB.Text)).ToString();                    
        }     
        public void Zad4()
        {
            wynikTB.Clear();
           double[] tab = new double[10];
           for(int i = 0; i < 10; i++)
            {
                Func<double, double> nazwa = x => Math.Pow(x, i);
                tab[i] = nazwa(double.Parse(xTB.Text));
                wynikTB.Text += (i + 1) + ". " + tab[i] + "\n";
            }
        }
        public delegate int porownaj(int a, int b);
        public void Zad5_sortowanie(int []tablica, porownaj delegat)
        {
            int n = tablica.Length;
            int tmp = 0;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (delegat(tablica[i],tablica[i + 1])<0)
                    {
                        tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            } while (n > 1);
        }
        public void Zad5()
        {
            wynikTB.Clear();
            string s = xTB.Text;
            String[] split;
            split = s.Split(' ');
            int[] liczby = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                liczby[i] = int.Parse(split[i]);
            }
            porownaj nazwa = (a, b) =>
             {
                 if (a > b) return 1;
                 else if (b > a) return -1;
                 else return 0;
             };
            Zad5_sortowanie(liczby, nazwa);
            foreach(int a in liczby)
            {
                wynikTB.Text += a.ToString() + " ";
            }
        }
        public void Zad6()
        {
            wynikTB.Clear();
            string s = xTB.Text;
            String[] split;
            split = s.Split(' ');
            int[] liczby = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                liczby[i] = int.Parse(split[i]);
            }
            Array.Sort(liczby, (a,b) => b - a);
            wynikTB.Text = "Malejąco: ";
            for(int i = 0; i < liczby.Length; i++)
            {
                wynikTB.Text += liczby[i] + " ";
            }
            wynikTB.Text += "\nRosnąco: ";
            Array.Sort(liczby, (a, b) => a - b);
            for (int i = 0; i < liczby.Length; i++)
            {
                wynikTB.Text += liczby[i] + " ";
            }
        }
        public void Zad7()
        {
            wynikTB.Clear();
            string s = xTB.Text;
            String[] split;
            split = s.Split(' ');
            int[] liczby = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                liczby[i] = int.Parse(split[i]);
            }
            Array.Sort(liczby, (a, b) => a % 2 == b % 2 ? a-b : a % 2 == 0 ? - 1 : 1);
            for (int i = 0; i < liczby.Length; i++)
            {
                wynikTB.Text += liczby[i] + " ";
            }
        }
        public void Zad8()
        {
            wynikTB.Clear();
            string s = xTB.Text;
            String[] split;
            split = s.Split(' ');
            Array.Sort(split,(a,b) => a.CompareTo(b));
            for (int i = 0; i < split.Length; i++)
            {
                wynikTB.Text += split[i] + " ";
            }
        }
        public void Zad8_b()
        {
            string s = xTB.Text;
            char[] liczby = s.ToCharArray();
            Array.Sort(liczby, (a, b) => a.CompareTo(b));
            for (int i = 0; i < liczby.Length; i++)
            {
                wynikTB.Text += " " + liczby[i] + " ";
            }
        }
        public double zad9_return(double a)
        {
            Func<double, double> nazwa = x => Math.Pow(x, a);
            return nazwa(double.Parse(xTB.Text));
        }

        Func<double, double, double> nazwa1 = (x, a) =>
         {
             return Math.Pow(x, a);
         };
        public void Zad9()
        {
            wynikTB.Clear();
            wynikTB.Text = nazwa1(double.Parse(xTB.Text),double.Parse(yTB.Text)).ToString();
        }
    }
}
