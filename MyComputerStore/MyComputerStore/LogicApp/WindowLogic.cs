using MyComputerStore.Models.DbAccount;
using MyComputerStore.View.Admin;
using MyComputerStore.View.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyComputerStore.LogicApp
{
    /// <summary>
    /// Класс содержит логику работы окон
    /// </summary>

    class WindowLogic
    {
        // Метод открытия окон, в зависимости от типа аккаунта
        public static bool OpenWindow(Accounts Acc)
        {
            // Если аккаунт не пустой, то открой окно
            if (Acc != null)
            {
                Window wind; // Окно

                // Если аккаунт администратор, то открой окно администратора
                if (Acc.idStatus == 2)
                {
                    wind = new AdminWindow();
                    wind.Show();

                    return true;
                }
                // Если аккаунт рабочего, то открой окно рабочего
                else if (Acc.idStatus == 1)
                {
                    wind = new SellerWindow();
                    wind.Show();

                    return true;
                }
            }

            return false; // В случае, если не удалось открыть окно
        }
    }
}
