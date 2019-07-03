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
    public partial class NullableComboBox : UserControl
    {
        public NullableComboBox()
        {
            InitializeComponent();
        }

        #region CheckedChanged event things for C# 3.0
        public event EventHandler<CheckedChangedEventArgs> CheckedChanged;

        protected virtual void OnCheckedChanged(CheckedChangedEventArgs e)
        {
            if (CheckedChanged != null)
                CheckedChanged(this, e);
        }

        private CheckedChangedEventArgs OnCheckedChanged()
        {
            CheckedChangedEventArgs args = new CheckedChangedEventArgs();
            OnCheckedChanged(args);

            return args;
        }

        /*private CheckedChangedEventArgs OnCheckedChangedForOut()
        {
            CheckedChangedEventArgs args = new CheckedChangedEventArgs();
            OnCheckedChanged(args);

            return args;
        }*/

        public class CheckedChangedEventArgs : EventArgs
        {


            /*public CheckedChangedEventArgs()
            {
            }

            public CheckedChangedEventArgs()
            {

            }*/
        }
        #endregion
        public void SetDataSource(object dataSource, string Member)
        {
            cbbList.DataSource = dataSource;
            cbbList.DisplayMember = Member;
            cbbList.ValueMember = Member;
        }

        private void ChbCheck_CheckedChanged(object sender, EventArgs e)
        {
            cbbList.Enabled = chbCheck.Checked;
            OnCheckedChanged();
        }

        public string SelectedValue
        {
            get
            {
                if (chbCheck.Checked)
                    return (string)cbbList.SelectedValue;
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
