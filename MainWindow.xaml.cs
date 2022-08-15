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

namespace HelloWorldGUI
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
            int t1 = int.Parse(txtIncome.Text);
            int t2 = int.Parse(txtExpeneses.Text);
            int sumt = t1 - t2;

            int t3 = int.Parse(txtPrice.Text);


            if (sumt <= 0)
            {
                txtDay.Text = "คุณไม่มีทางซื้อมันได้";
            }
            else
            {
                int sumall = t3 / sumt;
                txtDay.Text = sumall.ToString();
            }
        }
    }
}
