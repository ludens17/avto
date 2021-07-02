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
    /// Логика взаимодействия для RegAvto.xaml
    /// </summary>
    public partial class RegAvto : Page
    {
        public RegAvto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            try
            {
                Dota sl = new Dota();
                int stoim = Convert.ToInt32(hueta.Text);
                string name = innbox.Text;
                string ed = phonebox.Text;
                int kol = Convert.ToInt32(kolihestvo.Text);
                string pizda = addressbox.Text;
                string noda = namebox.Text;
                DateTime datakak = Convert.ToDateTime(innbox.Text);
                int es = 1;

                sl.Select($@"INSERT INTO автомобиль(Марка_автомобиля, Модель_автомобиля, Кузов, Дата_выпуска,цена,Количество,Наличие) VALUES('{noda}', '{ed}', '{pizda}', '{name}', '{kol}', '{stoim}', '{es})");
                stoim = 0;
                name = null;
                ed = null;
                kol = 0;

                MessageBox.Show("Товар добавлен в базу", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления данных в базу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
