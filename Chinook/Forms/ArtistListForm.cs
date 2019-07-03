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
    public partial class ArtistListForm : Form
    {
        public ArtistListForm()
        {
            InitializeComponent();
        }
        private void TxtName_Leave(object sender, EventArgs e)
        {
            if(txtName.Text.StartsWith("a"))
            {
                txtName.BackColor = Color.Red;
                btnSearch.Enabled = false;
            }
            else
            {
                txtName.BackColor = Color.Blue;
                btnSearch.Enabled = true;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Artist> list = DataRepository.Artist.GetAll(x => x.Name.Contains(txtName.Text));

            bdsArtist.DataSource = list;    //아래 foreach문과 같은 역할이지만 훨씬 빠르고 효율적.

            cbbArtist.SelectedIndex = 1; //선택된 index를 1로 바꿈(2번 째 인덱스)

            //foreach(var artist in list)
            //{
            //    cbbArtist.Items.Add(artist);
            //}
        }

        private void CbbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist artist = (Artist)cbbArtist.SelectedItem; //SelectedItem은 선택된 그 튜플을 반환. 이 property를 만든 사람들은 우리가 어떤 타입의 Item을 만들지 모르기 때문에 object 타입으로 반환시켜서, 캐스팅을 해야함.
            Text = artist.ArtistId.ToString();

            int artistId = (int)cbbArtist.SelectedValue; //그 튜플의 특정 속성값을 반환.
            Text = artistId.ToString();
        }
    }
}
