namespace PokeAPITool
{
	partial class APIResourceListForm
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
			this.listDataView = new System.Windows.Forms.DataGridView();
			this.URLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// listDataView
			// 
			this.listDataView.AllowUserToAddRows = false;
			this.listDataView.AllowUserToDeleteRows = false;
			this.listDataView.AllowUserToResizeColumns = false;
			this.listDataView.AllowUserToResizeRows = false;
			this.listDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URLColumn});
			this.listDataView.Location = new System.Drawing.Point(12, 12);
			this.listDataView.MultiSelect = false;
			this.listDataView.Name = "listDataView";
			this.listDataView.ReadOnly = true;
			this.listDataView.RowHeadersVisible = false;
			this.listDataView.RowTemplate.Height = 21;
			this.listDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listDataView.Size = new System.Drawing.Size(928, 705);
			this.listDataView.TabIndex = 1;
			// 
			// URLColumn
			// 
			this.URLColumn.HeaderText = "URL";
			this.URLColumn.Name = "URLColumn";
			this.URLColumn.ReadOnly = true;
			this.URLColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.URLColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.URLColumn.Width = 900;
			// 
			// detailButton
			// 
			this.detailButton.Location = new System.Drawing.Point(946, 694);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(50, 23);
			this.detailButton.TabIndex = 6;
			this.detailButton.Text = "詳細";
			this.detailButton.UseVisualStyleBackColor = true;
			// 
			// APIResourceListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.listDataView);
			this.Name = "APIResourceListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "APIResourceListForm";
			this.Load += new System.EventHandler(this.APIResourceListForm_Load);
			this.Shown += new System.EventHandler(this.APIResourceListForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.listDataView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView listDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn URLColumn;
		private System.Windows.Forms.Button detailButton;
	}
}