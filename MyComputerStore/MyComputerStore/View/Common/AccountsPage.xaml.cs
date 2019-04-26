using MyComputerStore.LogicApp;
using MyComputerStore.View.Admin;
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

namespace MyComputerStore.View.Common
{
    /// <summary>
    /// Логика взаимодействия для AccountsPage.xaml
    /// </summary>
    public partial class AccountsPage : Page
    {
        public AccountsPage()
        {
            InitializeComponent();
            LoadAccounts(); // Загружаем аккаунты
        }

        // Метод загрузки аккаунтов
        private void LoadAccounts()
        {
            dgr.ItemsSource = AdminLogic.GetAccounts().ToList();
        }

        // Событие на клик кнопки создания аккаунта, которое открое новое окно
        private void CreateAccount_click(object sender, RoutedEventArgs e)
        {
            if (new CreateAccountWindow().ShowDialog() == true)
            {
                MessageBox.Show("Аккаунт успешно создан!");
                LoadAccounts(); // Прогружаем по новой список аккаунтов
            }
        }
    }
}
