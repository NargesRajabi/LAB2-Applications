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

namespace MyWPF
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
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            int months = 0;
            int all = 0;
            int year = Convert.ToInt32(txtYears.Text);
            if (year < 1)
            {
                lblAverageRainfall.Content = "Error = Year should not be less than 1";
            }
            else
            {
                for (int i = 0; i < year; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {

                        if (Convert.ToInt32(txtMonth.Text) < 0)
                        {
                            lblAverageRainfall.Content = ("Error = inches should not be negative. Enter Again:");
                            j--;
                        }
                        else
                        {
                            all += Convert.ToInt32(txtMonth.Text);
                        }

                    }
                    months += 12;
                }
                lblYear.Content = "Year : " + year;
                lblTotalinches.Content = "Total Inches : " + all;
                lblTotalMonths.Content = "Total Months : " + months;
                lblAverageRainfall.Content = "Average Rainfall : " + (double)months / all;

            }
        }
    }
}
