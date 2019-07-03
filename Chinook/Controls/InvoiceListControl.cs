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
    public partial class InvoiceListControl : UserControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Invoice> invoice)
        {
            bdsInvoice.DataSource = invoice;
        }
    }
}
