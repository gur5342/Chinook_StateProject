namespace Chinook.Forms
{
    partial class ArtistListForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbArtist = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.bdsArtist = new System.Windows.Forms.BindingSource(this.components);
            this.colArtistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbArtist);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // cbbArtist
            // 
            this.cbbArtist.DataSource = this.bdsArtist;
            this.cbbArtist.DisplayMember = "Name";
            this.cbbArtist.FormattingEnabled = true;
            this.cbbArtist.Location = new System.Drawing.Point(195, 26);
            this.cbbArtist.Name = "cbbArtist";
            this.cbbArtist.Size = new System.Drawing.Size(121, 23);
            this.cbbArtist.TabIndex = 2;
            this.cbbArtist.ValueMember = "ArtistId";
            this.cbbArtist.SelectedIndexChanged += new System.EventHandler(this.CbbArtist_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(113, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 0;
            this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // dgvArtist
            // 
            this.dgvArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtist.AutoGenerateColumns = false;
            this.dgvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtistId,
            this.nameDataGridViewTextBoxColumn});
            this.dgvArtist.DataSource = this.bdsArtist;
            this.dgvArtist.Location = new System.Drawing.Point(13, 86);
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.RowHeadersWidth = 51;
            this.dgvArtist.RowTemplate.Height = 27;
            this.dgvArtist.Size = new System.Drawing.Size(775, 352);
            this.dgvArtist.TabIndex = 2;
            // 
            // bdsArtist
            // 
            this.bdsArtist.DataSource = typeof(Chinook.Data.Artist);
            // 
            // colArtistId
            // 
            this.colArtistId.DataPropertyName = "ArtistId";
            this.colArtistId.HeaderText = "아티스트 아이디";
            this.colArtistId.MinimumWidth = 6;
            this.colArtistId.Name = "colArtistId";
            this.colArtistId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colArtistId.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ArtistListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArtist);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArtistListForm";
            this.Text = "ArtistListForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.ComboBox cbbArtist;
        private System.Windows.Forms.BindingSource bdsArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtistId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}