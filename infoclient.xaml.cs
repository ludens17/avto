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

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для infoclient.xaml
    /// </summary>
    public partial class infoclient : Page
    {
        public infoclient()
        {
            InitializeComponent();
            Nord.ItemsSource = Stas_bdEntities2.GetContext().Клиент.ToList();
               // sobaka.ItemsSource = Stas_bdEntities1.GetContext().Поставщик.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            openpage.MainFrame.Navigate(new regclient());
        }
    }
}
