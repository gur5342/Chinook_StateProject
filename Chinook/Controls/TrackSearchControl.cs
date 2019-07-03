using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.Controls
{
    public partial class TrackSearchControl : UserControl
    {
        public TrackSearchControl()
        {
            InitializeComponent();
        }

        internal void SetArtistDataSource(List<Artist> artists)
        {
            uscArtist.SetDataSource(artists, nameof(Artist.Name), nameof(Artist.ArtistId));
        }

        internal void SetAlbumDataSource(List<Album> albums)
        {
            uscAlbum.SetDataSource(albums, nameof(Album.Title), nameof(Album.AlbumId));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked(txtName.Text, uscArtist.SelectedValue, uscAlbum.SelectedValue, uscMinUnitPrice.Value, uscMaxUnitPrice.Value);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(trackName, artistId, albumId, minUnitPrice, maxUnitPrice);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string TrackName { get; set; }
            public int? ArtistId { get; set; }
            public int? AlbumId { get; set; }
            public decimal? MinUnitPrice { get; set; }
            public decimal? MaxUnitPrice { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice)
            {
                TrackName = trackName;
                ArtistId = artistId;
                AlbumId = albumId;
                MinUnitPrice = minUnitPrice;
                MaxUnitPrice = maxUnitPrice;
            }
        }
        #endregion
    }
}
