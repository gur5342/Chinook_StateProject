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
    public partial class InvoiceSearchControl : UserControl
    {
        public InvoiceSearchControl()
        {
            InitializeComponent();
        }
        internal void SetCountryDataSource(List<Invoice> invoice)
        {

            uscCountry.SetDataSource(invoice, nameof(Invoice.BillingCountry));
        }

        internal void SetStateDataSource(List<Invoice> invoice)
        {
            uscState.SetDataSource(invoice, nameof(Invoice.BillingState));
        }

        internal void SetCityDataSource(List<Invoice> invoice)
        {
            uscCity.SetDataSource(invoice, nameof(Invoice.BillingCity));
        }
        private void BtnInvoiceSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked(uscCountry.SelectedValue, uscState.Enabled ? uscState.SelectedValue : null, uscCity.Enabled ? uscCity.SelectedValue : null);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string billingCountry, string billingState, string billingCity)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(billingCountry, billingState, billingCity);
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
            public string BillingCountry { get; set; }
            public string BillingState { get; set; }
            public string BillingCity { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string billingCountry, string billingState, string billingCity)
            {
                BillingCountry = billingCountry;
                BillingState = billingState;
                BillingCity = billingCity;
            }
        }
        #endregion

        private void UscCountry_CheckedChanged(object sender, CompositionControls.NullableComboBox.CheckedChangedEventArgs e)
        {
            uscState.Enabled = !uscState.Enabled;
            uscCity.Enabled = !uscCity.Enabled;
        }

        private void UscState_CheckedChanged(object sender, CompositionControls.NullableComboBox.CheckedChangedEventArgs e)
        {
            uscCity.Enabled = !uscCity.Enabled;
        }
    }
}
