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
    public partial class InvoiceListForm : Form
    {
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Invoice> invoice = DataRepository.Invoice.GetAllOrderByCountry();
            uscInvoiceSearch.SetCountryDataSource(invoice);

            invoice = DataRepository.Invoice.GetAllOrderByState();
            invoice = invoice.Distinct().ToList();
            uscInvoiceSearch.SetStateDataSource(invoice);

            invoice = DataRepository.Invoice.GetAllOrderByCity();
            invoice = invoice.Distinct().ToList();
            uscInvoiceSearch.SetCityDataSource(invoice);
        }

        private void UscInvoiceSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Invoice> invoice = DataRepository.Invoice.Search(e.BillingCountry,e.BillingState,e.BillingCity);

            uscInvoiceList.SetDataSource(invoice);
        }
    }
}
