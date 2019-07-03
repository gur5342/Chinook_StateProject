namespace Chinook.Forms
{
    partial class TrackListForm
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
            this.uscTrackList = new Chinook.Controls.TrackListControl();
            this.uscTrackSearch = new Chinook.Controls.TrackSearchControl();
            this.SuspendLayout();
            // 
            // uscTrackList
            // 
            this.uscTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTrackList.Location = new System.Drawing.Point(5, 128);
            this.uscTrackList.Name = "uscTrackList";
            this.uscTrackList.Size = new System.Drawing.Size(928, 380);
            this.uscTrackList.TabIndex = 1;
            // 
            // uscTrackSearch
            // 
            this.uscTrackSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscTrackSearch.Location = new System.Drawing.Point(5, 5);
            this.uscTrackSearch.Name = "uscTrackSearch";
            this.uscTrackSearch.Size = new System.Drawing.Size(928, 123);
            this.uscTrackSearch.TabIndex = 0;
            this.uscTrackSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.TrackSearchControl.SearchButtonClickedEventArgs>(this.UscTrackSearch_SearchButtonClicked);
            // 
            // TrackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.uscTrackList);
            this.Controls.Add(this.uscTrackSearch);
            this.Name = "TrackListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "TrackListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TrackSearchControl uscTrackSearch;
        private Controls.TrackListControl uscTrackList;
    }
}