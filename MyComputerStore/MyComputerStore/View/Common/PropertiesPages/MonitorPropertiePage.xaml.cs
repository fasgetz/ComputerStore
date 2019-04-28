using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyComputerStore.Models.DbProduct.Properties;

namespace MyComputerStore.View.Common.PropertiesPages
{
    /// <summary>
    /// Логика взаимодействия для MonitorPropertiePage.xaml
    /// </summary>
    public partial class MonitorPropertiePage : Page
    {

        public MonitorPropertiePage()
        {
            InitializeComponent();

            Initialization(); // Инициализируем значения с ComboBoxes
        }


        // Метод для инициализации значений ComboBoxe's
        private void Initialization()
        {
            diagonal.ItemsSource = new List<string>() { "17", "18", "19", "21", "22", "23", "24", "27" }; // Диагонали мониторов
            resolution.ItemsSource = new List<string>() { "800x600", "1024x768", "1280x1024","1920x1080" }; // Разрешения экранов
            connector.ItemsSource = new List<string>() { "VGA", "DVI-I" }; // Типы подключений
            color.ItemsSource = new List<string>() { "Черный", "Белый", "Серый" }; // Цвета
        }


        // Событие на клик кнопки сохранить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Записываем в словарь по ключу "json", в котором будет Json сериализованный объект
            Application.Current.Properties["json"] = JsonConvert.SerializeObject(new Monitor(
                Convert.ToInt16(diagonal.SelectedItem?.ToString()),
                color.SelectedItem?.ToString(),
                connector.SelectedItem?.ToString(),
                resolution.SelectedItem?.ToString())); ; // Сохраняем в словарь json сериализованное значение            
            
            this.Visibility = Visibility.Collapsed; // Скрываем текущую страницу после того как нажали сохранить
        }
    }
}
