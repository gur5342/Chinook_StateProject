using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class AlbumSearchControl : UserControl
    {
        //public int SelectedArtistId
        //{
        //    get
        //    {
        //        return ((Artist)cbbArtist.SelectedItem).ArtistId;
        //    }
        //}

        public AlbumSearchControl()
        {
            InitializeComponent();
        }
        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text.StartsWith("a"))
                txtTitle.BackColor = Color.Red;

            else txtTitle.BackColor = Color.White;
        }

        internal void SetArtistDataSource(List<Artist> artists)
        {
            //Artist empty = new Artist();
            //empty.ArtistId = 0;
            //empty.Name = "";

            //Artist empty = new Artist { ArtistId = 0, Name = "" }; // 객체 초기화 식
            //artists.Insert(0, empty);

            //bdsArtist.DataSource = artists; // 그냥 체크박스와 콤보박스를 쓸 때

            uscArtist.SetDataSource(artists, nameof(Artist.Name), nameof(Artist.ArtistId)); //uscArtist를 사용할 때.
        }
        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string albumTitle, int? artistId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(albumTitle, artistId);
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
            public string AlbumTitle { get; set; }
            public int? ArtistId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string albumTitle, int? artistId)
            {
                AlbumTitle = albumTitle;
                ArtistId = artistId;
            }
        }
        #endregion
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //int artistId = ((Artist)cbbArtist.SelectedItem).ArtistId;
            //int artistId = (int)cbbArtist.SelectedValue;// 그냥 체크박스와 콤보박스를 쓸 때
            //int artistId = uscArtist.SelectedValue; // uscArtist를 쓸 때
            //OnSearchButtonClicked(txtTitle.Text, artistId == 0 ? (int?)null:artistId); // cbbArtist의 0번 인덱스에 빈 칸 집어넣을 때.
            //OnSearchButtonClicked(txtTitle.Text, cbbArtist.Enabled ? artistId : (int?)null);   // 체크박스 방법.
            OnSearchButtonClicked(txtTitle.Text, uscArtist.SelectedValue);
        }


        //private void ChbArtist_CheckedChanged(object sender, EventArgs e) //유저 컨트롤로 기능이 옮겨 감.
        //{
        //    cbbArtist.Enabled = chbArtist.Checked;
        //}

    }
}
