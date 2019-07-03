using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Chinook.Forms
{
    public partial class AlbumListForm : Form
    {
        public AlbumListForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) // 폼이 로드될 때 동작 / **********폼에 내장되어있는 가상함수.
        {
            base.OnLoad(e);

            //bdsArtist.DataSource = DataRepository.Artist.GetAllOrderByName();
            //List<Artist> artists = DataRepository.Artist.GetAll().OrderBy(x => x.Name).ToList();
            List<Artist> artists = DataRepository.Artist.GetAllOrderByName();
            uscAlbumSearch.SetArtistDataSource(artists);

            //uscAlbumSearch.SearchButtonClicked += BtnSearch_Click;
        }

        //private void BtnSearch_Click(object sender, EventArgs e)
        //{
        //    //int artistId = uscAlbumSearch.SelectedArtistId;

        //    //int artistId = (int)cbbArtist.SelectedValue;
        //    //List<Album> albums = DataRepository.Album.Search(e.AlbumTitle, e.ArtistId);

        //    //bdsAlbum.DataSource = albums;
        //    //uscAlbumList.SetDataSource(albums);
        //}

        private void UscAlbumSearch_SearchButtonClicked(object sender, Controls.AlbumSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Album> albums = DataRepository.Album.Search(e.AlbumTitle, e.ArtistId);
            uscAlbumList.SetDataSource(albums);
        }

        //private void TxtTitle_Leave(object sender, EventArgs e)
        //{
        //    if (txtTitle.Text.StartsWith("a"))
        //        txtTitle.BackColor = Color.Red;

        //    else txtTitle.BackColor = Color.White;
        //}

        //private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    //if (e.ColumnIndex != 1)    //'값이 바뀐 셀(e)의 컬럼 인덱스가 1이 아니다.' -> 좋은 코드 아님. datagridview에서 사용자가 열을 이동할 수 있게 하는 옵션 체크해놓으면 열이 고정된 것이 아님.
        //    if (dgvAlbum.Columns[e.ColumnIndex] != colTitle) //이것도 바뀌면 문제지만 윈폼엔 더 이상의 기능이 없음.
        //        return;                                     //[e.ColumnIndex] : 인덱서?

        //    if (e.RowIndex < 0)
        //        return;

        //    //string value = (string)dgvAlbum[e.ColumnIndex, e.RowIndex].Value; //큰 범주를 부분 집합으로 캐스팅하는 건 문제 없음.

        //    //DataGridViewCell cell = dgvAlbum[e.ColumnIndex, e.RowIndex];

        //    var cell = dgvAlbum[e.ColumnIndex, e.RowIndex];
        //    string value = (string)cell.Value;

        //    if (value.StartsWith("a"))
        //        cell.Style.BackColor = Color.IndianRed;
        //    else
        //        cell.Style.BackColor = Color.White;
        //}
    }
}