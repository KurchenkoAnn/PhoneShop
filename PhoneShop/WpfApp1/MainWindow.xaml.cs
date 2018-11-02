using MahApps.Metro.Controls;
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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        List<UserUI> u = new List<UserUI>();
        List<OrderUI> o = new List<OrderUI>();
        List<PhoneUI> p = new List<PhoneUI>();



        public MainWindow()
        {

            UserUI user = new UserUI();
            // user.Name = "gfgf";
            // user.Email = "dfjfdf";
            PhoneUI phone = new PhoneUI();
            // phone.Model = "gfgf";
            // phone.Price = 1000;
            // phone.Producer = "Sumsung";

            InitializeComponent();
            //  u = new List<UserUI>() { new UserUI { Name = "Vasyan", Email = "vasyanVas" } };
            o = new List<OrderUI>() { new OrderUI { Customer = user, Item = phone, GetOrder = DateTime.Now } };
            p = new List<PhoneUI>() { new PhoneUI { Model = "Samsung J3 2016", Producer = "Samsung", Price = 2700 } };

            LV.ItemsSource = p.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            u.Add(new UserUI { Name = NameT.Text, Email = EmailT.Text });
            j.Opacity = 100;
            j.IsEnabled = true;
        }


        private void bob_Click(object sender, RoutedEventArgs e)
        {
            
            Window2 main = new Window2(LV.SelectedItem as PhoneUI);
            main.ShowDialog();

            
        }


    }
}
