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

namespace FaeUI
{
    /// <summary>
    /// Interaction logic for TitleScreen.xaml
    /// </summary>
    public partial class TitleScreen : Window
    {
        GameScreen gameScreen = new(); //we are "linking" the game screen form
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void StartNewGame(object sender, RoutedEventArgs e)
        {
            gameScreen.Show();
            /*intriguing lol. this makes the game screen pop up in a new window 
             * and keeps the title screen up in a separate window*/
        }

        private void ContinueLastSave(object sender, RoutedEventArgs e)
        {

        }

        private void QuitGame(object sender, RoutedEventArgs e)
        {

        }

        private void ShowLoadingMenu(object sender, RoutedEventArgs e)
        {

        }

        private void ShowOptions(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCredits(object sender, RoutedEventArgs e)
        {

        }
    }
}
