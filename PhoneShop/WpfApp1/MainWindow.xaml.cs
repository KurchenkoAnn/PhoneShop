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
            InitializeComponent();
            u = new List<UserUI>() { new UserUI { Name = "Vasyan", Email = "vasyanVas" } };
            o = new List<OrderUI>() { new OrderUI {} };
            p = new List<PhoneUI>() { new PhoneUI { Model="Samsung J3 2016",Producer="Samsung",Price=2700} };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
