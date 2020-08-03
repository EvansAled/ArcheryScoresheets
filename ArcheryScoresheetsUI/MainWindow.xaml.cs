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

        #region Config

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

        #endregion

        #region Entries

        private void On_EntryChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEntry = (sender as DataGrid).SelectedItem;

            _scoresSession.ChangeCurrentEntry(selectedEntry);
        }

        #endregion

        #region Options

        private void OnClick_AddEntry(object sender, RoutedEventArgs e)
        {
            _scoresSession.NewEntry("NewEntry");
        }

        private void OnClick_EditEntry(object sender, RoutedEventArgs e)
        {
            if (_scoresSession.CurrentEntry != null)
            {
                //TODO: Pop-up winodw to edit CurrentEntry
            }
        }

        private void OnClick_DeleteEntry(object sender, RoutedEventArgs e)
        {
            if(_scoresSession.CurrentEntry != null)
            {
                // Have a confirmation window
                _scoresSession.RemoveEntry(_scoresSession.CurrentEntry);
            }
        }

        #endregion
    }
}
