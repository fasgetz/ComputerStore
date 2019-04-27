using MyComputerStore.LogicApp;
using MyComputerStore.Models.DbAccount;
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
    /// Логика взаимодействия для CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();

            Initizalization(); // Инициализируем компоненты (Комбо бокс)
        }

        // Метод инициализации. Он прогружает список статусов аккаунтов
        private void Initizalization()
        {
            StatusCB.ItemsSource = AdminLogic.GetUserStatuses().ToList();
        }

        // Событие на клик кнопки Создать
        private void Create_click(object sender, RoutedEventArgs e)
        {
            // Получаем значение с комбобокса статуса аккаунта
            var status = (UserStatuses)StatusCB.SelectedItem;

            // Если заполнили входные данные, то создай аккаунт, иначе выдай ошибку, что необходимо заполнить данные
            if (login.Text != string.Empty && password.Text != string.Empty && status != null)
            {
                var created = AdminLogic.CreateAccount(new Accounts(login.Text, password.Text, status.idStatus));

                // Если аккаунт создан успешно, то верни true
                if (created == true)
                    this.DialogResult = true;
            }
            else
                MessageBox.Show("Заполните данные!");
        }
    }
}
