using MusicStoreZelf.Business;
using MusicStoreZelf.Data;
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

namespace MusicStoreZelf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Genre> alleGenresGlobaal = new List<Genre>();
        public MainWindow()
        {
            InitializeComponent();


            var alleGenres = GenreRepository.GetGenres();
            alleGenresGlobaal = alleGenres;

            DataContext = alleGenres;
            
        }

        private void genreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            albumDataGrid.DataContext = null;
            int index = 0;
            List<AlbumSummary> albumsInAanmerking = new List<AlbumSummary>();
            for (int i = 0; i < alleGenresGlobaal.Count; i++)
            {
                if((int)genreComboBox.SelectedValue - 1 == i)
                {
                    index = i;
                    i = alleGenresGlobaal.Count;
                }
            }

            albumsInAanmerking = AlbumSummaryService.GetAlbumSummariesByGenre(alleGenresGlobaal[index]);

            albumDataGrid.DataContext = albumsInAanmerking;


        }
    }
}
