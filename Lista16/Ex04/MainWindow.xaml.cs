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

namespace Ex04
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

            private void Calc(object sender, RoutedEventArgs e)
            {
                Equa E = new Equa();
                E.SetABC(double.Parse(A.Text), double.Parse(B.Text), double.Parse(C.Text));
                Delta.Text = E.Delta().ToString();
                double r, s;
                if (E.X1(out r))
                {
                    E.X2(out s);
                    X1.Text = r.ToString();
                    X2.Text = s.ToString();

                }
                else
                {
                    X1.Text = "Raiz Complexa";
                    X2.Text = "Raiz Complexa";
                    MessageBox.Show("A equação não é do II grau ou não tem raízes complexas");

                }

            }
        }
        }