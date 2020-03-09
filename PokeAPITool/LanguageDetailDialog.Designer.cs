namespace PokeAPITool
{
	partial class LanguageDetailDialog
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
			System.Windows.Forms.Label idCaption;
			System.Windows.Forms.Label nameCaption;
			System.Windows.Forms.Label officialCaption;
			System.Windows.Forms.Label iso639Caption;
			System.Windows.Forms.Label iso3166Caption;
			System.Windows.Forms.Label namesCaption;
			this.idData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			this.officialData = new System.Windows.Forms.Label();
			this.iso639Data = new System.Windows.Forms.Label();
			this.iso3166Data = new System.Windows.Forms.Label();
			this.languageNameView = new System.Windows.Forms.DataGridView();
			this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LanguageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.languageDetailButton = new System.Windows.Forms.Button();
			idCaption = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			officialCaption = new System.Windows.Forms.Label();
			iso639Caption = new System.Windows.Forms.Label();
			iso3166Caption = new System.Windows.Forms.Label();
			namesCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).BeginInit();
			this.SuspendLayout();
			// 
			// idCaption
			// 
			idCaption.AutoSize = true;
			idCaption.Location = new System.Drawing.Point(13, 13);
			idCaption.Name = "idCaption";
			idCaption.Size = new System.Drawing.Size(16, 12);
			idCaption.TabIndex = 0;
			idCaption.Text = "ID";
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(13, 31);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(29, 12);
			nameCaption.TabIndex = 2;
			nameCaption.Text = "名称";
			// 
			// officialCaption
			// 
			officialCaption.AutoSize = true;
			officialCaption.Location = new System.Drawing.Point(13, 49);
			officialCaption.Name = "officialCaption";
			officialCaption.Size = new System.Drawing.Size(53, 12);
			officialCaption.TabIndex = 4;
			officialCaption.Text = "公式言語";
			// 
			// iso639Caption
			// 
			iso639Caption.AutoSize = true;
			iso639Caption.Location = new System.Drawing.Point(13, 67);
			iso639Caption.Name = "iso639Caption";
			iso639Caption.Size = new System.Drawing.Size(41, 12);
			iso639Caption.TabIndex = 6;
			iso639Caption.Text = "ISO639";
			// 
			// iso3166Caption
			// 
			iso3166Caption.AutoSize = true;
			iso3166Caption.Location = new System.Drawing.Point(13, 85);
			iso3166Caption.Name = "iso3166Caption";
			iso3166Caption.Size = new System.Drawing.Size(47, 12);
			iso3166Caption.TabIndex = 8;
			iso3166Caption.Text = "ISO3166";
			// 
			// namesCaption
			// 
			namesCaption.AutoSize = true;
			namesCaption.Location = new System.Drawing.Point(197, 12);
			namesCaption.Name = "namesCaption";
			namesCaption.Size = new System.Drawing.Size(75, 12);
			namesCaption.TabIndex = 10;
			namesCaption.Text = "言語毎の名称";
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(70, 12);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(70, 30);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(100, 15);
			this.nameData.TabIndex = 3;
			// 
			// officialData
			// 
			this.officialData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.officialData.Location = new System.Drawing.Point(70, 48);
			this.officialData.Name = "officialData";
			this.officialData.Size = new System.Drawing.Size(40, 15);
			this.officialData.TabIndex = 5;
			// 
			// iso639Data
			// 
			this.iso639Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iso639Data.Location = new System.Drawing.Point(70, 66);
			this.iso639Data.Name = "iso639Data";
			this.iso639Data.Size = new System.Drawing.Size(30, 15);
			this.iso639Data.TabIndex = 7;
			// 
			// iso3166Data
			// 
			this.iso3166Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.iso3166Data.Location = new System.Drawing.Point(70, 84);
			this.iso3166Data.Name = "iso3166Data";
			this.iso3166Data.Size = new System.Drawing.Size(30, 15);
			this.iso3166Data.TabIndex = 9;
			// 
			// languageNameView
			// 
			this.languageNameView.AllowUserToAddRows = false;
			this.languageNameView.AllowUserToDeleteRows = false;
			this.languageNameView.AllowUserToResizeColumns = false;
			this.languageNameView.AllowUserToResizeRows = false;
			this.languageNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.languageNameView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanguageColumn,
            this.LanguageNameColumn});
			this.languageNameView.Location = new System.Drawing.Point(199, 27);
			this.languageNameView.MultiSelect = false;
			this.languageNameView.Name = "languageNameView";
			this.languageNameView.ReadOnly = true;
			this.languageNameView.RowHeadersVisible = false;
			this.languageNameView.RowTemplate.Height = 21;
			this.languageNameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.languageNameView.Size = new System.Drawing.Size(198, 138);
			this.languageNameView.TabIndex = 11;
			// 
			// LanguageColumn
			// 
			this.LanguageColumn.HeaderText = "言語";
			this.LanguageColumn.Name = "LanguageColumn";
			this.LanguageColumn.ReadOnly = true;
			this.LanguageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LanguageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.LanguageColumn.Width = 80;
			// 
			// LanguageNameColumn
			// 
			this.LanguageNameColumn.HeaderText = "名称";
			this.LanguageNameColumn.Name = "LanguageNameColumn";
			this.LanguageNameColumn.ReadOnly = true;
			this.LanguageNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LanguageNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// languageDetailButton
			// 
			this.languageDetailButton.Location = new System.Drawing.Point(197, 171);
			this.languageDetailButton.Name = "languageDetailButton";
			this.languageDetailButton.Size = new System.Drawing.Size(75, 23);
			this.languageDetailButton.TabIndex = 12;
			this.languageDetailButton.Text = "言語詳細";
			this.languageDetailButton.UseVisualStyleBackColor = true;
			this.languageDetailButton.Click += new System.EventHandler(this.languageDetailButton_Click);
			// 
			// LanguageDetailDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.languageDetailButton);
			this.Controls.Add(this.languageNameView);
			this.Controls.Add(namesCaption);
			this.Controls.Add(this.iso3166Data);
			this.Controls.Add(this.iso639Data);
			this.Controls.Add(this.officialData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(iso3166Caption);
			this.Controls.Add(iso639Caption);
			this.Controls.Add(officialCaption);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "LanguageDetailDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "言語(Language)";
			this.Load += new System.EventHandler(this.LanguageDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label officialData;
		private System.Windows.Forms.Label iso639Data;
		private System.Windows.Forms.Label iso3166Data;
		private System.Windows.Forms.DataGridView languageNameView;
		private System.Windows.Forms.Button languageDetailButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageNameColumn;
	}
}