namespace PokeAPITool
{
	partial class VersionGroupListDialog
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
			if(disposing && (components != null)) {
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
			System.Windows.Forms.Label urlCaption;
			System.Windows.Forms.Label nameCaption;
			this.versionGroupDataView = new System.Windows.Forms.DataGridView();
			this.VersionGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailButton = new System.Windows.Forms.Button();
			this.urlData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			urlCaption = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// urlCaption
			// 
			urlCaption.AutoSize = true;
			urlCaption.Location = new System.Drawing.Point(158, 59);
			urlCaption.Name = "urlCaption";
			urlCaption.Size = new System.Drawing.Size(27, 12);
			urlCaption.TabIndex = 3;
			urlCaption.Text = "URL";
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(158, 12);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(29, 12);
			nameCaption.TabIndex = 1;
			nameCaption.Text = "名称";
			// 
			// versionGroupDataView
			// 
			this.versionGroupDataView.AllowUserToAddRows = false;
			this.versionGroupDataView.AllowUserToDeleteRows = false;
			this.versionGroupDataView.AllowUserToResizeColumns = false;
			this.versionGroupDataView.AllowUserToResizeRows = false;
			this.versionGroupDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.versionGroupDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersionGroupColumn});
			this.versionGroupDataView.Location = new System.Drawing.Point(12, 12);
			this.versionGroupDataView.MultiSelect = false;
			this.versionGroupDataView.Name = "versionGroupDataView";
			this.versionGroupDataView.ReadOnly = true;
			this.versionGroupDataView.RowHeadersVisible = false;
			this.versionGroupDataView.RowTemplate.Height = 21;
			this.versionGroupDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.versionGroupDataView.Size = new System.Drawing.Size(140, 358);
			this.versionGroupDataView.TabIndex = 0;
			this.versionGroupDataView.SelectionChanged += new System.EventHandler(this.versionGroupDataView_SelectionChanged);
			// 
			// VersionGroupColumn
			// 
			this.VersionGroupColumn.HeaderText = "バージョングループ";
			this.VersionGroupColumn.Name = "VersionGroupColumn";
			this.VersionGroupColumn.ReadOnly = true;
			this.VersionGroupColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.VersionGroupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.VersionGroupColumn.Width = 120;
			// 
			// detailButton
			// 
			this.detailButton.Location = new System.Drawing.Point(160, 102);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(50, 23);
			this.detailButton.TabIndex = 5;
			this.detailButton.Text = "詳細";
			this.detailButton.UseVisualStyleBackColor = true;
			this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
			// 
			// urlData
			// 
			this.urlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.urlData.Location = new System.Drawing.Point(160, 71);
			this.urlData.Name = "urlData";
			this.urlData.Size = new System.Drawing.Size(304, 19);
			this.urlData.TabIndex = 4;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(160, 28);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(173, 19);
			this.nameData.TabIndex = 2;
			// 
			// VersionGroupListDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 382);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.urlData);
			this.Controls.Add(urlCaption);
			this.Controls.Add(this.nameData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(this.versionGroupDataView);
			this.Name = "VersionGroupListDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "バージョングループ";
			this.Load += new System.EventHandler(this.VersionGroupListDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView versionGroupDataView;
		private System.Windows.Forms.Button detailButton;
		private System.Windows.Forms.Label urlData;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.DataGridViewTextBoxColumn VersionGroupColumn;
	}
}