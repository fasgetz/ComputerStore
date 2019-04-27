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
        }


        // Событие на текстовые поля, которые позволяют вводить только цифры
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true; // отклоняем ввод
            }
        }


        // Событие на клик кнопки добавить характеристики
        private void AddProperties_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
