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
using static System.Math;


namespace practic11
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
            // MainFrame.Navigate(new DopZadaniyaPage());
        }





        //Задание 1
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double d = int.Parse(textBox.Text); ;
            double L = 3.14 * d;
            ObiemTextBox.Text = L.ToString();
            
        }


        


        //Задание 2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                double.TryParse(textBoxC.Text, out double c))
            {
                double AC = Math.Abs(a - c);
                double BC = Math.Abs(b - c);
                double sum = AC + BC;


                ACTextBox.Text = AC.ToString();
                BCTextBox.Text = BC.ToString();
                ACBCTextBox.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Некорректные значения координат точек.");
            }
        }
        //Задание 3
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(VtextBox.Text, out double v1) && double.TryParse(VrtextBox.Text, out double v2) && double.TryParse(t1textBox.Text, out double t1) && double.TryParse(t2textBox.Text, out double s))
            {
                double S2 = s + t1 * (v1 + v2); ;

                // Вывод результата
                OtverTextBox.Text = "Результат: " + S2.ToString();
            }
            else
            {
                MessageBox.Show("Введите числовые значения для V лодки, V реки, T1 и T2.");
            }
        }

        //Задание 4

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(xTextBox.Text, out double x) &&
                double.TryParse(aTextBox.Text, out double aa) &&
                 double.TryParse(aTextBox.Text, out double y))
            {
                double a = x + y;
                double b = x * x + y * y;
                double p = (a + b) * (a + b) + a * Math.Cos(a + b) + a * Math.Sqrt(b) / (a + b);

                alfaTextBox.Text = $"Ответ:{p:N2}";
            }
            else
            {
                MessageBox.Show("Некорректные значения координат точек.");
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
