using posapp.Database.Controllers;
using posapp.Database.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace posapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserNameTextBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordBox.Password;

            if(username == null)
            {
                UserNameErrorLabel.Content = "Username can not be empty";
            }
            else if (password == null)
            {
                PasswordErrorLabel.Content = "Password can not be empty";
            }
            else if (username != null &&  password != null)
            {
                (int code, string message, User user) = UserController.GetLoggedIn(username, password);
                Console.WriteLine(message);
            }
        }
    }
}