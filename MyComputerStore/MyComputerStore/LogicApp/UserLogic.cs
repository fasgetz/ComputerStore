using MyComputerStore.Models.DbAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyComputerStore.LogicApp
{
    /// <summary>
    /// Класс содержит логику работы учетных записей
    /// </summary>

    class UserLogic
    {

        // Метод, который проходит процесс авторизации пользователя по учетным данным (Логин и пароль) и возвращает на выходе аккаунт
        public static Accounts Authorization(string login, string password)
        {
            // Проверяем, ввел ли пользователь учетные данные. Если ввел, то выполни процесс авторизации
            if (login != string.Empty && password != string.Empty)
            {
                // Находим аккаунт
                var acc = new DbAcc().Accounts.FirstOrDefault(i => i.login == login && i.password == password);

                if (acc == null)
                    MessageBox.Show("Аккаунт не найден или вы ввели неверные учетные данные!");

                // Возвращаем аккаунт пользователю, который послал запрос
                return acc;
            }
            else
            {
                MessageBox.Show("Вы не ввели учетные данные!");
            }


            return null; // Возвращаем null, в случае, если пользователь не ввел учетных данных
        }

    }
}
