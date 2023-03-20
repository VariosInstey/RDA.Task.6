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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RDA.Task._6.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private bool _stateClosed = true;
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (_stateClosed)
            {
                Storyboard? sb = FindResource("OpenMenu") as Storyboard;
                sb?.Begin();
            }
            else
            {
                Storyboard? sb = FindResource("CloseMenu") as Storyboard;
                sb?.Begin();
            }
            _stateClosed = !_stateClosed;
        }

        private void ButtonMenu_Click_1(object sender, RoutedEventArgs e)
        {
            if (_stateClosed)
            {
                Storyboard? sb = FindResource("OpenMenu") as Storyboard;
                sb?.Begin();
            }
            else
            {
                Storyboard? sb = FindResource("CloseMenu") as Storyboard;
                sb?.Begin();
            }
            _stateClosed = !_stateClosed;
        }
    }
}
