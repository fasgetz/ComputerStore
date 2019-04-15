using MyComputerStore.View.Common;
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
using System.Windows.Shapes;

namespace MyComputerStore.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            
            // Ссылка на стартовую страницу
            frame.Navigate(new OrdersPage());
        }


        // Событие на клик кнопки компонентов
        private void ComponentsPage(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ComponentsPage());
        }
    }
}
