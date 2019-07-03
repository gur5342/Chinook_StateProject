using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.CompositionControls
{
    public partial class CheckableComboBox : UserControl
    {
        public CheckableComboBox()
        {
            InitializeComponent();
        }

        public void SetDataSource(object dataSource, string displayMember, string valueMember)
        {
            cbbList.DataSource = dataSource;
            cbbList.DisplayMember = displayMember;
            cbbList.ValueMember = valueMember;
        }
        private void ChbCheck_CheckedChanged(object sender, EventArgs e)
        {
            cbbList.Enabled = chbCheck.Checked; // 체크박스 체크(true) 체크 해제(falses)
        }

        public int? GetSelectedValue()
        {
            if (chbCheck.Checked)
                return (int)cbbList.SelectedValue; //SelectedValue는 object 타입으로 들어오므로 int로 캐스팅이 필요.
            else
                return null; 
        }
        public int? SelectedValue    // 한 줄 정도의 그냥 값을 반환하는 역할은 메서드보다 property를 쓰는 것을 더 추천.
        {
            get
            {
                if (chbCheck.Checked)
                    return (int)cbbList.SelectedValue;
                else
                    return null;
            }
        }
        public object SelectedItem
        {
            get
            {
                return cbbList.SelectedItem;
            }
        }
    }
}
