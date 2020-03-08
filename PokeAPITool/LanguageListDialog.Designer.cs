namespace PokeAPITool
{
	partial class LanguageListDialog
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
			System.Windows.Forms.Label nameCaption;
			System.Windows.Forms.Label urlCaption;
			this.languageDataView = new System.Windows.Forms.DataGridView();
			this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameData = new System.Windows.Forms.Label();
			this.urlData = new System.Windows.Forms.Label();
			this.detailButton = new System.Windows.Forms.Button();
			nameCaption = new System.Windows.Forms.Label();
			urlCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.languageDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(142, 13);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(29, 12);
			nameCaption.TabIndex = 1;
			nameCaption.Text = "名称";
			// 
			// urlCaption
			// 
			urlCaption.AutoSize = true;
			urlCaption.Location = new System.Drawing.Point(142, 60);
			urlCaption.Name = "urlCaption";
			urlCaption.Size = new System.Drawing.Size(27, 12);
			urlCaption.TabIndex = 3;
			urlCaption.Text = "URL";
			// 
			// languageDataView
			// 
			this.languageDataView.AllowUserToAddRows = false;
			this.languageDataView.AllowUserToDeleteRows = false;
			this.languageDataView.AllowUserToResizeColumns = false;
			this.languageDataView.AllowUserToResizeRows = false;
			this.languageDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.languageDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Language});
			this.languageDataView.Location = new System.Drawing.Point(13, 12);
			this.languageDataView.MultiSelect = false;
			this.languageDataView.Name = "languageDataView";
			this.languageDataView.ReadOnly = true;
			this.languageDataView.RowHeadersVisible = false;
			this.languageDataView.RowTemplate.Height = 21;
			this.languageDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.languageDataView.Size = new System.Drawing.Size(122, 358);
			this.languageDataView.TabIndex = 0;
			this.languageDataView.SelectionChanged += new System.EventHandler(this.languageDataView_SelectionChanged);
			// 
			// Language
			// 
			this.Language.HeaderText = "言語";
			this.Language.Name = "Language";
			this.Language.ReadOnly = true;
			this.Language.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(144, 29);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(117, 19);
			this.nameData.TabIndex = 2;
			// 
			// urlData
			// 
			this.urlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.urlData.Location = new System.Drawing.Point(144, 72);
			this.urlData.Name = "urlData";
			this.urlData.Size = new System.Drawing.Size(304, 19);
			this.urlData.TabIndex = 4;
			// 
			// detailButton
			// 
			this.detailButton.Location = new System.Drawing.Point(144, 103);
			this.detailButton.Name = "detailButton";
			this.detailButton.Size = new System.Drawing.Size(50, 23);
			this.detailButton.TabIndex = 5;
			this.detailButton.Text = "詳細";
			this.detailButton.UseVisualStyleBackColor = true;
			this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
			// 
			// LanguageListDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 384);
			this.Controls.Add(this.detailButton);
			this.Controls.Add(this.urlData);
			this.Controls.Add(urlCaption);
			this.Controls.Add(this.nameData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(this.languageDataView);
			this.Name = "LanguageListDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "言語リスト";
			this.Load += new System.EventHandler(this.LanguageList_Load);
			((System.ComponentModel.ISupportInitialize)(this.languageDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView languageDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Language;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label urlData;
		private System.Windows.Forms.Button detailButton;
	}
}