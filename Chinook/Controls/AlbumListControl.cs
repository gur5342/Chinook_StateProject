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
    public partial class AlbumListControl : UserControl
    {
        public AlbumListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Album> albums)
        {
            bdsAlbum.DataSource = albums;
        }
        private void DgvAlbum_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvAlbum.Columns[e.ColumnIndex] != colTitle)
                return;                                   

            if (e.RowIndex < 0)
                return;

            var cell = dgvAlbum[e.ColumnIndex, e.RowIndex];
            string value = (string)cell.Value;

            if (value.StartsWith("a"))
                cell.Style.BackColor = Color.IndianRed;
            else
                cell.Style.BackColor = Color.White;
        }

    }
}
