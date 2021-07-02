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
using System.Data;
using System.Data.SqlClient;

namespace Sklad
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        public auth()
        {
            InitializeComponent();
            try
            {
                DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                                // подключаемся к базе данных
                SqlConnection sqlConnection = new SqlConnection("data source = homeserver27rus.ddns.net; initial catalog = Stas_bd; user id = stas_kursach; password = ytujhg664hg2; MultipleActiveResultSets = True; App = EntityFramework");
                sqlConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету, либо обратитесь к разработчику", "Ошибка", MessageBoxButton.OK);

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dota sl = new Dota();
            DataTable dt_user = sl.Select("SELECT log,pass FROM [Менеджер]");
            MainWindow main = new MainWindow();
            infoclient cl = new infoclient();
            for (int i = 0; i < dt_user.Rows.Count; i++)
            {
                if (AuthLogin.Text == Convert.ToString(dt_user.Rows[i][0]) && AuthPass.Text == Convert.ToString(dt_user.Rows[i][1]))
                {
                    Hide();
                    main.Show();

                }
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            exit_window exit_win = new exit_window();
            exit_win.Show();

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Hide();
            exit_window exit_win = new exit_window();
            exit_win.Show();
        }

    }

}
