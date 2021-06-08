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

namespace WpfApp35
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Product
    {
        public int[] id = new int[100];
        public string[] S_product = new string[100];

        public string[] S_Data = new string[100];
        public string[] S_manufact = new string[100];
        public string[] S_sostav = new string[100];
        public string[] S_typeProd = { "Молочные продукты", "Мясные продукты ", "Овощи фрукты", "Пищевой продукт" };
        public int[] S_typeProdid = new int[100];
        public string[] S_Price = new string[100];
        public int[] S_proc = new int[100];

    }
    public partial class MainWindow : Window
    {
        Product cd = new Product();
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < cd.id.Length; i++)
            {
                IdProductBox.Items.Add(i);
            }

            for (int i = 0; i < cd.id.Length; i++)
            {
                IdProductBox2.Items.Add(i);
            }
            for (int i = 0; i < cd.S_typeProd.Length; i++)
            {
                TypeCombobox.Items.Add(cd.S_typeProd[i]);
            }
            for (int i = 0; i < cd.id.Length; i++)
            {
                ProverkaID.Items.Add(i);
            }

        }
        string mainproduct = "";
        string maindata = "";
        string mainmanu = "";
        string mainsostav = "";
        string mianprice = "";
        int maintypeid = 0;
        string TimeNow = "04.06.2021";


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                for (int i = 0; i < cd.id.Length; i++)
                {
                    if (IdProductBox.SelectedIndex == i)
                    {
                        ProductBlock.Text = cd.S_product[i].ToString();
                        DataBlock.Text = cd.S_Data[i].ToString();
                        ManuBlock.Text = cd.S_manufact[i].ToString();
                        SostavBlock.Text = cd.S_sostav[i].ToString();
                        TypeBlock.Text = cd.S_typeProd[i].ToString();
                        PriceBlock.Text = cd.S_Price[i].ToString();
                    }
                }
            }
            catch
            {
                ProductBlock.Text = "Пусто";
                DataBlock.Text = "Пусто";
                ManuBlock.Text = "Пусто";
                SostavBlock.Text = "Пусто";
                TypeBlock.Text = "Пусто";
                PriceBlock.Text = "Пусто";
            }
        }

        private void deletebutton(object sender, RoutedEventArgs e)
        {



            for (int i = 0; i < cd.id.Length; i++)
            {
                if (IdProductBox.SelectedIndex == i)
                {
                    cd.S_product[i] = "Пусто";
                    cd.S_Data[i] = "Пусто";
                    cd.S_manufact[i] = "Пусто";
                    cd.S_sostav[i] = "Пусто";
                    cd.S_typeProd[i] = "Пусто";
                    cd.S_Price[i] = "Пусто";
                    ProductBlock.Text = cd.S_product[i].ToString();
                    DataBlock.Text = cd.S_Data[i].ToString();
                    ManuBlock.Text = cd.S_manufact[i].ToString();
                    SostavBlock.Text = cd.S_sostav[i].ToString();
                    TypeBlock.Text = cd.S_typeProd[i].ToString();
                    PriceBlock.Text = cd.S_Price[i].ToString();
                }
            }
        }




        private void addbutton1(object sender, RoutedEventArgs e)
        {

            mainproduct = ProductText.Text.ToString();
            maindata = DataText.Text.ToString();
            mainsostav = SostavText.Text.ToString();
            mainmanu = ManuText.Text.ToString();
            mianprice = PriceText.Text.ToString();
            maintypeid = TypeCombobox.SelectedIndex;
            for (int i = 0; i < cd.id.Length; i++)
            {
                if (IdProductBox2.SelectedIndex == i)
                {


                    cd.S_product[i] = mainproduct;
                    cd.S_Data[i] = maindata;
                    cd.S_manufact[i] = mainmanu;
                    cd.S_sostav[i] = mainsostav;
                    cd.S_Price[i] = mianprice;
                }
                for (int j = 0; j < cd.S_typeProdid.Length; j++)
                {
                    if (TypeCombobox.SelectedIndex == j)
                    {
                        cd.S_typeProdid[i] = maintypeid;
                    }
                }
            }
            MessageBox.Show("Продукт успешно добавлен!", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void SalesClick(object sender, RoutedEventArgs e)
        {
            try
            {   for (int i = 0; i < cd.id.Length; i++)
                {
                    if (ProverkaID.SelectedIndex == i)
                    {
                        string[] a;
                        string[] b;
                        int a1mouth;
                        int b1mouth;
                        int a1day;
                        int b1day;
                        int srok = 0;
                        if (cd.S_typeProdid[i] == 0)
                        {
                            srok += 6;
                        }
                        else if (cd.S_typeProdid[i] == 1)
                        {
                            srok += 3;
                        }
                        else if (cd.S_typeProdid[i] == 2)
                        {
                            srok += 15;
                        }
                        else if (cd.S_typeProdid[i] == 3)
                        {
                            srok += 9;
                        }
                        a = cd.S_Data[i].Split('.');
                        b = TimeNow.Split('.');
                        a1mouth = Convert.ToInt32(a[1]);
                        b1mouth = Convert.ToInt32(b[1]);
                        a1day = Convert.ToInt32(a[0]);
                        b1day = Convert.ToInt32(b[0]);
                        //проверка месяца
                        if (a1mouth > b1mouth)
                        {
                            a1day += 30;
                        }
                        else if (b1mouth > a1mouth)
                        {
                            b1day += 30;
                        }
                        if (b1day - a1day == 1)
                        {
                            MessageBox.Show($"Вы получили скидку на товар ({cd.S_product[i]}) - 5%! ", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else if (b1day - a1day > 1 && b1day - a1day <= 5)
                        {
                            MessageBox.Show($"Вы получили скидку на товар ({cd.S_product[i]}) - 10%! ", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else if (b1day - a1day > 5 && b1day - a1day >= 15)
                        {
                            MessageBox.Show($"Вы получили скидку на товар ({cd.S_product[i]}) - 15%! ", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
            }
            catch { }
        }

        private void ProsrochClick(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < cd.id.Length; i++)
                {
                    if (ProverkaID.SelectedIndex == i)
                    {
                        string[] a;
                        string[] b;
                        int a1mouth;
                        int b1mouth;
                        int a1day;
                        int b1day;
                        int srok = 0;
                        if (cd.S_typeProdid[i] == 0)
                        {
                            srok += 6;
                        }
                        else if (cd.S_typeProdid[i] == 1)
                        {
                            srok += 3;
                        }
                        else if (cd.S_typeProdid[i] == 2)
                        {
                            srok += 15;
                        }
                        else if (cd.S_typeProdid[i] == 3)
                        {
                            srok += 9;
                        }
                        a = cd.S_Data[i].Split('.');
                        b = TimeNow.Split('.');
                        a1mouth = Convert.ToInt32(a[1]);
                        b1mouth = Convert.ToInt32(b[1]);
                        a1day = Convert.ToInt32(a[0]);
                        b1day = Convert.ToInt32(b[0]);
                        //проверка месяца
                        if (a1mouth > b1mouth)
                        {
                            a1day += 30;
                        }
                        else if (b1mouth > a1mouth)
                        {
                            b1day += 30;
                        }
                        //проверка просроченности
                        if ((b1day - a1day) > srok)
                        {
                            MessageBox.Show($"Ваш товар ({cd.S_product[i]}) - Просрочен!", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            cd.S_proc[i] = 1; 
                        }
                        else if ((b1day - a1day) < srok)
                        {
                            MessageBox.Show($"Ваш товар ({cd.S_product[i]}) - Не просрочен!", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Ваш товар недоступен", "ProductInfo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                }
            }
            catch { }
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            try
            {
                for (int i = 0; i < cd.id.Length; i++)
                {
                    if (cd.S_product[i].Contains(SearchText.Text))
                    {
                        list.Items.Add($"Результаты поиска: \n{cd.S_product[i]}");
                    }
                }
            }
            catch
            {
                
            }
        }

        private void IdProductBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AllButton(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();

            for (int i = 0; i < cd.id.Length; i++)
            {   
                    list.Items.Add($"{i}: \n{cd.S_product[i]}\n---------------------------");
            }
        }

        private void Sortclick(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            try
            {
                for (int i = 0; i < cd.id.Length; i++)
                {
                    string[] day;
                    string[] day1;
                    day = cd.S_Data[i].Split('.');
                    day1 = cd.S_Data[i + 1].Split('.');

                    if (Convert.ToInt32(day[1]) > Convert.ToInt32(day1[1]))
                    {
                        list.Items.Add($"{i + 1}: \n{cd.S_product[i + 1]}. Дата:{cd.S_Data[i + 1]}\n---------------------------");
                        list.Items.Add($"{i}: \n{cd.S_product[i]}. Дата:{cd.S_Data[i]}\n---------------------------");
                    }

                }
            }
            catch { }
        }

        private void DueClck(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Перед тем как отсортировать только просроченные продукты, их нужно проверить по кнопке" +
                " (Проверка на просроченность).\n Вы сделали данные действия?", "ProductInfo v1", MessageBoxButton.YesNo, MessageBoxImage.Information);
            
        }

        private void AllDelete(object sender, RoutedEventArgs e)
        {

        }
    }
}
