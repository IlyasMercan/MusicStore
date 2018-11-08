using MusicStoreZelf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreZelf.Business
{
    public class AlbumSummaryService
    {
        public static List<AlbumSummary> GetAlbumSummariesByGenre(Genre genre)
        {
            List<AlbumSummary> albumData = new List<AlbumSummary>();

            var albumList = AlbumRepository.GetAlbumByGenre(genre.GenreId);

            for(int i = 0; i < albumList.Count; i++)
            {
                String artist = ArtistRepository.GetArtistNameById(albumList[i].ArtistId);
                AlbumSummary album = new AlbumSummary();
                album.Title = albumList[i].Title;
                album.Artist = artist;
                album.Price = albumList[i].Price;

                albumData.Add(album);
            }

            return albumData;

            
        }
    }
}
