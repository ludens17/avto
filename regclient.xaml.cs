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
    /// Логика взаимодействия для regclient.xaml
    /// </summary>
    public partial class regclient : Page
    {
        public regclient()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (namebox.Text.Length == 0 || addressbox.Text.Length == 0 || phonebox.Text.Length==0)
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание", MessageBoxButton.OK);
            }
          


                //try
              //  {
                    string name = Convert.ToString(namebox.Text);
                    string phone = Convert.ToString(phonebox.Text);
                    string adres = Convert.ToString(addressbox.Text);
                    string inn = Convert.ToString(innbox.Text);
                    string mail = Convert.ToString(sas.Text);
                    int govna = Convert.ToInt32(ton.Text);
                    string dura = Convert.ToString(tan.Text);
                    Dota sl = new Dota();
                    sl.Select($@"INSERT INTO Клиент (Фамилия,Имя,Отчество,[Номер паспорта],[Серия паспорта],Телефон,Адрес) VALUES ('{name}', '{phone}','{adres}','{inn}','{mail}','{govna}','{dura}')");
                    MainWindow.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Клиенты";
                    openpage.MainFrame.Navigate(new infoclient());

               // }
             //   catch (Exception)
               // {

                   // MessageBox.Show("Ошибка добавления данных", "обратитесь к разработчику", MessageBoxButton.OK);
               // }



            }
        }
    }

