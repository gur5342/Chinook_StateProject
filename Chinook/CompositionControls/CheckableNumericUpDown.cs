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
    public partial class CheckableNumericUpDown : UserControl
    {
        public CheckableNumericUpDown()
        {
            InitializeComponent();
        }

        private void ChbCheck_CheckedChanged(object sender, EventArgs e)
        {
            nupValue.Enabled = chbCheck.Checked;
        }
        public decimal? Value
        {
            get
            {
                if (chbCheck.Checked)
                    return nupValue.Value; //Value 자체가 decimal 타입
                else
                    return null;
            }
        }
    }
}
