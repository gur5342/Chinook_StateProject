using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class TrackListForm : Form
    {
        public TrackListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) // 폼이 로드될 때 동작 / **********폼에 내장되어있는 가상함수. 이벤트에 같은 역할을 하는 이벤트도 있음.
        {
            base.OnLoad(e);

            List<Artist> artists = DataRepository.Artist.GetAllOrderByName();
            uscTrackSearch.SetArtistDataSource(artists);

            List<Album> albums = DataRepository.Album.GetAllOrderByName();
            uscTrackSearch.SetAlbumDataSource(albums);
        }

        private void UscTrackSearch_SearchButtonClicked(object sender, Controls.TrackSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Track> tracks = DataRepository.Track.Search(e.TrackName, e.ArtistId, e.AlbumId, e.MinUnitPrice, e.MaxUnitPrice);

            uscTrackList.SetDataSource(tracks);
        }
    }
}
