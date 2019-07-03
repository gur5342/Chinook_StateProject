namespace Chinook.Controls
{
    partial class InvoiceListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.bdsInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.billingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billingCountryDataGridViewTextBoxColumn,
            this.billingStateDataGridViewTextBoxColumn,
            this.billingCityDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.CustomerLastName,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.Total});
            this.dgvTrack.DataSource = this.bdsInvoice;
            this.dgvTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrack.Location = new System.Drawing.Point(0, 0);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowHeadersWidth = 51;
            this.dgvTrack.RowTemplate.Height = 27;
            this.dgvTrack.Size = new System.Drawing.Size(801, 339);
            this.dgvTrack.TabIndex = 4;
            // 
            // bdsInvoice
            // 
            this.bdsInvoice.DataSource = typeof(Chinook.Data.Invoice);
            // 
            // billingCountryDataGridViewTextBoxColumn
            // 
            this.billingCountryDataGridViewTextBoxColumn.DataPropertyName = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.HeaderText = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billingCountryDataGridViewTextBoxColumn.Name = "billingCountryDataGridViewTextBoxColumn";
            this.billingCountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // billingStateDataGridViewTextBoxColumn
            // 
            this.billingStateDataGridViewTextBoxColumn.DataPropertyName = "BillingState";
            this.billingStateDataGridViewTextBoxColumn.HeaderText = "BillingState";
            this.billingStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billingStateDataGridViewTextBoxColumn.Name = "billingStateDataGridViewTextBoxColumn";
            this.billingStateDataGridViewTextBoxColumn.Width = 125;
            // 
            // billingCityDataGridViewTextBoxColumn
            // 
            this.billingCityDataGridViewTextBoxColumn.DataPropertyName = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.HeaderText = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billingCityDataGridViewTextBoxColumn.Name = "billingCityDataGridViewTextBoxColumn";
            this.billingCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.DataPropertyName = "CustomerLastName";
            this.CustomerLastName.HeaderText = "LastName";
            this.CustomerLastName.MinimumWidth = 6;
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.ReadOnly = true;
            this.CustomerLastName.Width = 125;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrack);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(801, 339);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.BindingSource bdsInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
