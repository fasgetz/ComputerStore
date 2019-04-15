using MyComputerStore.LogicApp;
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

namespace MyComputerStore.View.Common
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        // Событие на клик кнопки войти
        private void authorization_click(object sender, RoutedEventArgs e)
        {
            // Открываем окно, в зависимости от типа пользователя, который проходит авторизацию (или не проходит) по логику и паролю
            bool opened = WindowLogic.OpenWindow(UserLogic.Authorization(loginbox.Text, passbox.Password));

            // Если окно открыто, то закрой текущее окно
            if (opened == true)
                this.Close();
        }
    }
}
