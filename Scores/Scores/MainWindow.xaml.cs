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

namespace Scores
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

    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);
            double num3 = double.Parse(txtNumber3.Text);

            double mark = num1 + num2 + num3;
            double courseAvg = mark / 3;

            if (courseAvg > 90 && courseAvg < 100)
            {
                lblShow.Content = "A";
            }
            else if (courseAvg >= 80 && courseAvg <= 89)
            {
                lblShow.Content = "B";
            }
            else if (courseAvg >= 70 && courseAvg <= 79)
            {
                lblShow.Content = "C";
            }
            else if (courseAvg >= 60 && courseAvg <= 69)
            {
                lblShow.Content = "D";
            }
            else
            {
                lblShow.Content = "!!!";
            }
        }
    }
}
