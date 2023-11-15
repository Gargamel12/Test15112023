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

namespace Test15112023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVyp_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int.TryParse(textBoxa.Text, out a);
           

            if(cmb.SelectedIndex == 0)
            {
                int polomer = (a * a * a);
                double odpoved = ((4.0 / 3) * Math.PI * polomer); 
                textBlockodp.Text = "Odpověď je: " + odpoved.ToString();
            }
            else 
            {
                double odpoved = (a*a*a);
                textBlockodp.Text = "Odpověď je: " + odpoved.ToString();
            }

        }



        public void  Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(cmb.SelectedIndex == 0)
            {
                textBlocka.Text = "a:";
                selected = true;
                
            }
            else
            {
                textBlocka.Text = "polomer:";
            }
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
