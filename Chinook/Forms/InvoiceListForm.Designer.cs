namespace Chinook.Forms
{
    partial class InvoiceListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uscInvoiceList = new Chinook.Controls.InvoiceListControl();
            this.uscInvoiceSearch = new Chinook.Controls.InvoiceSearchControl();
            this.SuspendLayout();
            // 
            // uscInvoiceList
            // 
            this.uscInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscInvoiceList.Location = new System.Drawing.Point(0, 34);
            this.uscInvoiceList.Name = "uscInvoiceList";
            this.uscInvoiceList.Size = new System.Drawing.Size(800, 416);
            this.uscInvoiceList.TabIndex = 0;
            // 
            // uscInvoiceSearch
            // 
            this.uscInvoiceSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscInvoiceSearch.Location = new System.Drawing.Point(0, 0);
            this.uscInvoiceSearch.Name = "uscInvoiceSearch";
            this.uscInvoiceSearch.Size = new System.Drawing.Size(800, 34);
            this.uscInvoiceSearch.TabIndex = 1;
            this.uscInvoiceSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.InvoiceSearchControl.SearchButtonClickedEventArgs>(this.UscInvoiceSearch_SearchButtonClicked);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uscInvoiceList);
            this.Controls.Add(this.uscInvoiceSearch);
            this.Name = "InvoiceListForm";
            this.Text = "InvoiceListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InvoiceListControl uscInvoiceList;
        private Controls.InvoiceSearchControl uscInvoiceSearch;
    }
}