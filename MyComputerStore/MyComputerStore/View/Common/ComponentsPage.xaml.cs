using MyComputerStore.LogicApp;
using MyComputerStore.Models.DbProduct;
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
    /// Логика взаимодействия для ComponentsPage.xaml
    /// </summary>
    public partial class ComponentsPage : Page
    {
        int SelectedType = 0; // Выбранный тип компонента

        public ComponentsPage()
        {
            InitializeComponent();

            CompTypesCB.ItemsSource = CommonLogic.GetComponentsTypes();
            //Load();
        }

        // Событие на клик кнопки загрузить
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            var CompType = (TypesOfComponents)CompTypesCB.SelectedValue;
            
            // Если выбрали тип комплектующего, то загрузи комплектующие
            if (CompType != null)
                SelectedType = CompType.IdType;

            dgr.ItemsSource = CommonLogic.GetComponents(SelectedType);


            //if (CompType != null)
            //    dgr.ItemsSource = CommonLogic.GetComponents(CompType.IdType);
            //else
            //    dgr.ItemsSource = CommonLogic.GetComponents();
        }

        // Событие на клик кнопки добавить
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Если компонент добавлен успешно, то загрузи список комплектующих по новой
            if (new AddComponentsPage().ShowDialog() == true)
            {
                dgr.ItemsSource = CommonLogic.GetComponents(SelectedType);
            }
        }
    }
}
