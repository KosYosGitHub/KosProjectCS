namespace PokeAPITool
{
	partial class GenerationListDialog
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
			this.generationDataView = new System.Windows.Forms.DataGridView();
			this.generationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailButton = new System.Windows.Forms.Button();
			this.urlData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			urlCaption = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.generationDataView)).BeginInit();
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
			// generationDataView
			// 
			this.generationDataView.AllowUserToAddRows = false;
			this.generationDataView.AllowUserToDeleteRows = false;
			this.generationDataView.AllowUserToResizeColumns = false;
			this.generationDataView.AllowUserToResizeRows = false;
			this.generationDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.generationDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.generationColumn});
			this.generationDataView.Location = new System.Drawing.Point(12, 12);
			this.generationDataView.MultiSelect = false;
			this.generationDataView.Name = "generationDataView";
			this.generationDataView.ReadOnly = true;
			this.generationDataView.RowHeadersVisible = false;
			this.generationDataView.RowTemplate.Height = 21;
			this.generationDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.generationDataView.Size = new System.Drawing.Size(140, 705);
			this.generationDataView.TabIndex = 0;
			this.generationDataView.SelectionChanged += new System.EventHandler(this.generationDataView_SelectionChanged);
			// 
			// generationColumn
			// 
			this.generationColumn.HeaderText = "世代";
			this.generationColumn.Name = "generationColumn";
			this.generationColumn.ReadOnly = true;
			this.generationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.generationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.generationColumn.Width = 120;
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
			this.urlData.Size = new System.Drawing.Size(836, 19);
			this.urlData.TabIndex = 4;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(160, 28);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(836, 19);
			this.nameData.TabIndex = 2;
			// 
			// GenerationListDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.urlData);
			this.Controls.Add(urlCaption);
			this.Controls.Add(this.nameData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(this.generationDataView);
			this.Name = "GenerationListDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "世代(Generation)";
			this.Load += new System.EventHandler(this.GenerationListDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.generationDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView generationDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn generationColumn;
		private System.Windows.Forms.Button detailButton;
		private System.Windows.Forms.Label urlData;
		private System.Windows.Forms.Label nameData;
	}
}