using MyComputerStore.Models.DbProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComputerStore.LogicApp
{

    /// <summary>
    /// Общая логика Администратора и Работника
    /// </summary>

    class CommonLogic
    {
        // Метод, который получает список заказов по дате. Если дата пустая, то выведет весь список
        public static List<Orders> GetOrders(System.DateTime? date = null)
        {
            return null;
        }

        // Метод, который получает список комплектующих по типу. Если тип не указан, то выведет весь список
        public static List<Components> GetComponents(int idType = 0)
        {
            // Если параметры не передали, то верни весь список
            if (idType == 0)
                return new DbProd().Components.ToList();
            else
                // если параметры передали
                return new DbProd().Components.Where(i => i.IdType == idType).ToList();
            
        }

        // Метод, который получает список производителей.
        public static List<Manufacturers> GetManufacturers()
        {
            return new DbProd().Manufacturers.ToList();
        }

        // Метод, который получает список типов компонентов.
        public static List<TypesOfComponents> GetComponentsTypes()
        {
            return new DbProd().TypesOfComponents.ToList();
        }

        // Метод, который добавляет компонент в базу данных и возвращает true, в случае успеха
        public static bool AddComponent(string Name, int IdType, int IdManufacturer, decimal Price, int AvailabilityCount, string Properties)
        {
            try
            {
                DbProd db = new DbProd(); // Создаем контекст БД
                db.Components.Add(new Components(Name, IdType, IdManufacturer, Price, AvailabilityCount, Properties)); // Добавляем компонент в БД
                db.SaveChanges(); // Сохраняем БД

                return true;
            }
            catch (Exception)
            {
                return false; // В случае ошибки возвращаем false
            }
            
        }
    }
}
