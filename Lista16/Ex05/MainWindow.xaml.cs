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

namespace Ex05
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Numeros n = new Numeros();
            n.SetInicio(int.Parse(inicio.Text));
            n.SetFim(int.Parse(fim.Text));

            bool impar, par;
            if (pares.IsChecked.Value == true && impares.IsChecked.Value == false)
            {
                 par = true;
                 impar = false;
                intervalo.Items.Clear();
                 foreach(int c in n.Calcular(par, impar))
                {
                    intervalo.Items.Add(c);
                } 
                 
                 
            }
                else par = false;

            if (impares.IsChecked.Value == true && pares.IsChecked.Value == false)
            {
                impar = true;
                par = false;
                n.Calcular(par, impar);
                intervalo.Items.Clear();
                foreach (int c in n.Calcular(par, impar))
                {
                    intervalo.Items.Add(c);
                }

            }
                else impar = false;

            if (pares.IsChecked.Value == true && impares.IsChecked.Value == true)
            {
                par = true;
                impar = true;
                n.Calcular(par, impar);
                intervalo.Items.Clear();
                foreach (int c in n.Calcular(par, impar))
                {
                    intervalo.Items.Add(c);
                }
            }

        }



        
    }
}
