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

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Ellipse el = new Ellipse();
        Rectangle il = new Rectangle();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ellipse el = new Ellipse();
            //el.Width = 50;
            //el.Height = 50;
            //el.VerticalAlignment = VerticalAlignment.Top;
            //el.Fill = Brushes.Green;
            //el.Stroke = Brushes.Red;
            //el.StrokeThickness = 3;
            //grid1.Children.Add(el);
            string A1 = a1.Text;
            string A2 = a2.Text;
            if ((A1 == "" || A2 == ""))
            {
                text.Text = "Введите координаты";
            }
            else
            {
                int b1 = Convert.ToInt32(a1);
                int b2 = Convert.ToInt32(a2);
                el.Width = b1;
                el.Height = b2;
                el.HorizontalAlignment = HorizontalAlignment.Center;
                el.Fill = Brushes.MistyRose;
                grid1.Children.Add(el);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string A1 = a1.Text;
            string A2 = a2.Text;
            if ((A1 == "" || A2 == ""))
            {
                text.Text = "Введите координаты";
            }
            else
            {
                int b1 = Convert.ToInt32(a1);
                int b2 = Convert.ToInt32(a2);
                il.Width = b1;
                il.Height = b2;
                il.HorizontalAlignment = HorizontalAlignment.Center;
                il.Fill = Brushes.AliceBlue;
                grid1.Children.Add(il);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grid1.Children.Remove(el);
            grid1.Children.Remove(il);
        }
    }
}
