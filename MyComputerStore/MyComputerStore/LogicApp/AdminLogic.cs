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
    /// Логика работы администратора
    /// </summary>


    class AdminLogic
    {
        // Метод, который получает список пользователей системы
        public static List<Accounts> GetAccounts()
        {
            return new DbAcc().Accounts.ToList();
        }

        // Метод, который создает аккаунт
        public static bool CreateAccount(Accounts acc)
        {
            try
            {
                // подключение к БД
                using (DbAcc db = new DbAcc())
                {
                    db.Accounts.Add(acc);
                    db.SaveChanges();

                    return true; // т.к. аккаунт создан
                }
            }
            // В случае ошибки возвращаем false
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return false;
            }
        }

        // Метод, который получает список статусов аккаунтов
        public static List<UserStatuses> GetUserStatuses()
        {
            try
            {
                return new DbAcc().UserStatuses.ToList();
            }
            catch (Exception)
            {
                return null; // В случае ошибки пустой список
            }
        }
    }
}
