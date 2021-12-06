using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TestWPF
{
    
    public partial class MainWindow : Window
    {

        private double n1 = 0;
        private double n2 = 0;

        bool Plus = false;
        bool Minus = false;
        bool Mnozenie = false;
        bool Dzielenie = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(Tekst.Text);
            Pok_obl.Content = Tekst.Text + "+";
            Tekst.Text = "";

            Plus = true;
            Minus = false;
            Mnozenie = false;
            Dzielenie = false;
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(Tekst.Text);
            Pok_obl.Content = Tekst.Text + "-";
            Tekst.Text = "";

            Plus = false;
            Minus = true;
            Mnozenie = false;
            Dzielenie = false;
        }
        private void mnozenie_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(Tekst.Text);
            Pok_obl.Content = Tekst.Text + "*";
            Tekst.Text = "";

            Plus = false;
            Minus = false;
            Mnozenie = true;
            Dzielenie = false;
        }
        private void dzielenie_Click(object sender, RoutedEventArgs e)
        {
            n1 += double.Parse(Tekst.Text);
            Pok_obl.Content = Tekst.Text + "/";
            Tekst.Text = "";

            Plus = false;
            Minus = false;
            Mnozenie = false;
            Dzielenie = true;
        }
        private void pierwiastek_Click(object sender, RoutedEventArgs e)
        {
            Pok_obl.Content += "√" + Tekst.Text;

            n1 += Math.Sqrt(double.Parse(Tekst.Text));
            Tekst.Text = n1.ToString();

        }

        private void wymaz_Click(object sender, RoutedEventArgs e)
        {
            Tekst.Text = "0";
            Pok_obl.Content = "";
        }
        private void czysc_Click(object sender, RoutedEventArgs e)
        {
            Tekst.Text = "0";
            Pok_obl.Content = "";
        }
        private void plus_minus_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text.StartsWith("-"))
            {
                
                Tekst.Text = Tekst.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(Tekst.Text) && decimal.Parse(Tekst.Text) != 0)
            {
               
                Tekst.Text = "-" + Tekst.Text;
            }
        }

        private void przecinek_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text.Contains(","))
            {

            }
            else
            {
                Tekst.Text += ",";
            }    
        }
        private void cofnij_click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "")
            {

            }
            else
            {
                Tekst.Text = Tekst.Text.Substring(0, Tekst.Text.Length - 1);
            }           
        }

        private void rowna_sie_Click(object sender, RoutedEventArgs e)
        {
            if (Plus == true)
            {
                n2 = n1 + double.Parse(Tekst.Text);
                Pok_obl.Content = n1 + "+" + double.Parse(Tekst.Text);
                Tekst.Text = n2.ToString();
                n1 = 0;
            }
            else if (Minus == true)
            {
                n2 = n1 - double.Parse(Tekst.Text);
                Pok_obl.Content = n1 + "-" + double.Parse(Tekst.Text);
                Tekst.Text = n2.ToString();
                n1 = 0;
            }
            else if (Mnozenie == true)
            {
                n2 = n1 * double.Parse(Tekst.Text);
                Pok_obl.Content = n1 + "*" + double.Parse(Tekst.Text);
                Tekst.Text = n2.ToString();
                n1 = 0;
            }
            else if (Dzielenie == true)
            {
                n2 = n1 / double.Parse(Tekst.Text);
                Pok_obl.Content = n1 + "/" + double.Parse(Tekst.Text);
                Tekst.Text = n2.ToString();
                n1 = 0;
            }
        }
        private void liczba_0_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "0";
            }
            else
            {
                Tekst.Text += "0";
                Pok_obl.Content = Tekst.Text;              
            }
        }
        private void liczba_1_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "1";
            }
            else
            {
                Tekst.Text += "1";
                Pok_obl.Content = Tekst.Text;              
            }
        }
        private void liczba_2_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "2";
            }
            else
            {
                Tekst.Text += "2";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_3_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "3";
            }
            else
            {
                Tekst.Text += "3";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_4_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "4";
            }
            else
            {
                Tekst.Text += "4";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_5_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "5";
            }
            else
            {
                Tekst.Text += "5";
                Pok_obl.Content = Tekst.Text;
            }
            
        }
        private void liczba_6_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "6";
            }
            else
            {
                Tekst.Text += "6";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_7_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "7";
            }
            else
            {
                Tekst.Text += "7";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_8_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "8";
            }
            else
            {
                Tekst.Text += "8";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void liczba_9_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "0")
            {
                Tekst.Text = "9";
            }
            else
            {
                Tekst.Text += "9";
                Pok_obl.Content = Tekst.Text;
            }
        }
        private void Zmieniony_Tekst(object sender, RoutedEventArgs e)
        {

        }

        private void sin(object sender, EventArgs e)
        {
            if (Tekst.Text.Length > 0) 
            {
                Tekst.Text = Math.Sin(double.Parse(Tekst.Text) * Math.PI / 180).ToString();
                
            }
        }


        private void cos(object sender, EventArgs e)
        {
            if (Tekst.Text.Length > 0)
            {
                Tekst.Text = Math.Cos(double.Parse(Tekst.Text) * Math.PI / 180).ToString();
            }
        }

        private void tg(object sender, EventArgs e)
        {
            if (Tekst.Text.Length > 0)
            {
                if ((double.Parse(Tekst.Text)) % 90 != 0) 
                    Tekst.Text = Math.Tan(double.Parse(Tekst.Text) * Math.PI / 180).ToString();
               
            }
        }


      
        
    }
}
