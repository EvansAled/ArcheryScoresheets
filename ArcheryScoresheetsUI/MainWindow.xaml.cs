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

    public partial class MainWindow : Window
    {
        private ScoresSession _scoresSession;

        public MainWindow()
        {
            InitializeComponent();
            _scoresSession = new ScoresSession();
            DataContext = _scoresSession;
        }
        private void On_DistanceBoxLostFocus(object sender, RoutedEventArgs e)
        {
            int distance;
            bool isInt = int.TryParse(DistanceBox.Text, out distance);

            if (isInt)
            {
                _scoresSession.ChangeDistance(distance);
            }
        }

        private void On_ArrowsPerEndBoxLostFocus(object sender, RoutedEventArgs e)
        {
            int arrowsPerEnd;
            bool isInt = int.TryParse(DistanceBox.Text, out arrowsPerEnd);

            if (isInt)
            {
                _scoresSession.ChangeArrowsPerEnd(arrowsPerEnd);
            }
        }

        private void On_NumberOfEndsBoxLostFocus(object sender, RoutedEventArgs e)
        {
            int numberOfEnds;
            bool isInt = int.TryParse(NumberOfEndsBox.Text, out numberOfEnds);

            if (isInt)
            {
                _scoresSession.ChangeNumberOfEnds(numberOfEnds);
            }
        }

        private void On_ScoringSystemChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();

            _scoresSession.ChangeScoringSystem(selectedItem);
        }

        private void On_FaceSizeChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();

            _scoresSession.ChangeFaceSize(selectedItem);
        }

        private void On_PlaceChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();

            _scoresSession.ChangePlace(selectedItem);
        }

    }
}
