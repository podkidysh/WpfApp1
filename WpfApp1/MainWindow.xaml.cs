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
using WpfApp1.DB;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            MySQLContext context = new MySQLContext();

            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Введите все даныне");
            }
            else
            {
                try
                {
                    var newAcaunt = new User();
                    newAcaunt.Name = tbName.Text;
                    newAcaunt.Pass = tbPass.Text;

                    context.Users.Add(newAcaunt);
                    btReg.IsEnabled = false;
                    context.SaveChanges();
                    btReg.IsEnabled = true;
                    MessageBox.Show("Вы прошли регистрацию");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
