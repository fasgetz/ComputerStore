using MyComputerStore.LogicApp;
using MyComputerStore.Models.DbProduct;
using MyComputerStore.View.Common.PropertiesPages;
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
    /// Логика взаимодействия для AddComponentsPage.xaml
    /// </summary>
    public partial class AddComponentsPage : Window
    {
        public AddComponentsPage()
        {
            InitializeComponent();

            initialization(); // Инициализируем данные компонентов
        }


        // Метод, который инициализирует стартовые значения
        private void initialization()
        {
            cb_manufact.ItemsSource = CommonLogic.GetManufacturers();
            cb_type.ItemsSource = CommonLogic.GetComponentsTypes();
        }


        #region События

        // Событие на текстовые поля, которые позволяют вводить только цифры
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        // Событие на свойство выбранного итема в Типе компонента ComboBoxe's
        private void Type_SelectionCB(object sender, SelectionChangedEventArgs e)
        {
            var item = (TypesOfComponents)cb_type.SelectedItem; // Получаем значение выбранного типа компонента с ComboBoxe's


            if (item != null) // Если значение не пустое, то открой соответствущую страницу
            {
                switch (item.IdType)
                {
                    case (1):
                        Application.Current.Properties["json"] = null;
                        break;
                    case (2):
                        frame.Content = null;
                        MessageBox.Show(Application.Current.Properties["json"]?.ToString());
                        break;
                    case (11): // Монитор
                        frame.Content = new MonitorPropertiePage();
                        break;
                }
            }
        }

        // Событие на клик кнопки добавить продукт
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            var type = (TypesOfComponents)cb_type.SelectedItem;
            var manufact = (Manufacturers)cb_manufact.SelectedItem;

            // Если ввели не пустые данные, то добавь в базу данных
            if (name.Text != string.Empty && type != null && manufact != null && price.Text != string.Empty && count.Text != string.Empty && Application.Current.Properties["json"]?.ToString() != null)
            {
                MessageBox.Show("Добавляем в БД");

                // Добавляем продукт в БД
                var added = CommonLogic.AddComponent(
                    name.Text, 
                    type.IdType, 
                    manufact.IdManufacturer,
                    Convert.ToInt16(price.Text),
                    Convert.ToInt16(count.Text),
                    Application.Current.Properties["json"].ToString()
                    );


                // Если товар добавлен успешно, то обнули значение в словаре и закрой текущее окно
                if (added == true)
                {
                    Application.Current.Properties["json"] = null; // Обнуляем значение в словаре                    

                    this.DialogResult = true; // Возвращаем true, т.к. добавлено успешно
                }
                
            }
            else
            {
                MessageBox.Show("Не можем добавить в БД");
            }
        }
        #endregion

    }
}
