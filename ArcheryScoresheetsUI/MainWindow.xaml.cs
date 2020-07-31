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
using ScoresheetsLibrary.ViewModels;

namespace ArcheryScoresheetsUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ScoresSession _scoresSession;

        public MainWindow()
        {
            InitializeComponent();
            _scoresSession = new ScoresSession();
            DataContext = _scoresSession;
        }

        private void On_ScoringSystemChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }

        private void On_FaceSizeChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }

        private void On_PlaceChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }
    }
}
