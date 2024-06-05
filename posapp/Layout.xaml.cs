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

namespace posapp
{
    /// <summary>
    /// Interaction logic for Layout.xaml
    /// </summary>
    public partial class Layout : Window
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem)NavigationListBox.SelectedItem;

            if (selectedItem != null)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Dashboard":
                        //LoadFragment(new HomeFragment());
                        break;
                    case "Stock":
                        LoadFragment(new Stock());
                        break;
                    case "About":
                        //LoadFragment(new AboutFragment());
                        break;
                }
            }
        }


        private void LoadFragment(Page fragment)
        {
            // Load the specified fragment into the main content frame
            MainContentFrame.Content = fragment;
        }


    }
}
