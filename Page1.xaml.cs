﻿using System;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (namebox.Text.Length == 0 || addressbox.Text.Length == 0 || phonebox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание", MessageBoxButton.OK);
            }
            else
            {
                if (innbox.Text.Length < 12)
                {
                    MessageBox.Show("Неполный номер ИНН", "Внимание", MessageBoxButton.OK);
                }
                else
                {
                    try
                    {
                        string name = Convert.ToString(namebox.Text);
                        string phone = Convert.ToString(phonebox.Text);
                        string adres = Convert.ToString(addressbox.Text);
                        string inn = Convert.ToString(innbox.Text);
                        string mail = Convert.ToString(sas1.Text);
                        Dota sl = new Dota();
                        sl.Select($@"INSERT INTO Поставщик ([Юредический_адрес],Телефон,[Почтовый_ящик],[Дата_поставки],ИНН [Название_Компании]) VALUES ('{name}', '{phone}','{adres}','{inn}','{mail}')");
                        MainWindow.GetWindow(openpage.MainFrame).Title = "Оптовый склад->Клиенты";
                        openpage.MainFrame.Navigate(new infoclient());

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ошибка добавления данных", "обратитесь к разработчику", MessageBoxButton.OK);
                    }
                }


            }


        }

        private void innbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= '0' && ch <= '9')
                         )
                         .ToArray()
                    );
                textBox.SelectionStart = e.Changes.First().Offset + 1;
                textBox.SelectionLength = 0;
            }
            innbox.MaxLength = 12;
        }

        private void phonebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            ch == '+' || (ch >= '0' && ch <= '9')
                         )
                         .ToArray()
                    );
            }
            phonebox.MaxLength = 18;
        }
    }
}
