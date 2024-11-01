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
using FaeLibrary;

namespace FaeUI
{
    /// <summary>
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen : Window
    {
        private GameSession _gameSession;
        public GameScreen()
        {
            InitializeComponent();
            _gameSession = new GameSession();
            //DataContext is a WPF thing.
            //DataContext means "the object that will be used in the UI
            DataContext = _gameSession;
        }
    }
}