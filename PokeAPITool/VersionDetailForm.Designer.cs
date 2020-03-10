namespace PokeAPITool
{
	partial class VersionDetailForm
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
			System.Windows.Forms.Label idCaption;
			System.Windows.Forms.Label versionGroupCaption;
			System.Windows.Forms.Label namesCaption;
			this.nameData = new System.Windows.Forms.Label();
			this.idData = new System.Windows.Forms.Label();
			this.versionGroupData = new System.Windows.Forms.Label();
			this.buttonVersionGroupDetail = new System.Windows.Forms.Button();
			this.buttonLanguageDetail = new System.Windows.Forms.Button();
			this.languageNameView = new System.Windows.Forms.DataGridView();
			this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LanguageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			nameCaption = new System.Windows.Forms.Label();
			idCaption = new System.Windows.Forms.Label();
			versionGroupCaption = new System.Windows.Forms.Label();
			namesCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(12, 33);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(29, 12);
			nameCaption.TabIndex = 2;
			nameCaption.Text = "名称";
			// 
			// idCaption
			// 
			idCaption.AutoSize = true;
			idCaption.Location = new System.Drawing.Point(12, 9);
			idCaption.Name = "idCaption";
			idCaption.Size = new System.Drawing.Size(16, 12);
			idCaption.TabIndex = 0;
			idCaption.Text = "ID";
			// 
			// versionGroupCaption
			// 
			versionGroupCaption.AutoSize = true;
			versionGroupCaption.Location = new System.Drawing.Point(12, 57);
			versionGroupCaption.Name = "versionGroupCaption";
			versionGroupCaption.Size = new System.Drawing.Size(88, 12);
			versionGroupCaption.TabIndex = 4;
			versionGroupCaption.Text = "バージョングループ";
			// 
			// namesCaption
			// 
			namesCaption.AutoSize = true;
			namesCaption.Location = new System.Drawing.Point(333, 9);
			namesCaption.Name = "namesCaption";
			namesCaption.Size = new System.Drawing.Size(75, 12);
			namesCaption.TabIndex = 7;
			namesCaption.Text = "言語毎の名称";
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(106, 32);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(153, 15);
			this.nameData.TabIndex = 3;
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(106, 8);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// versionGroupData
			// 
			this.versionGroupData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.versionGroupData.Location = new System.Drawing.Point(106, 56);
			this.versionGroupData.Name = "versionGroupData";
			this.versionGroupData.Size = new System.Drawing.Size(153, 15);
			this.versionGroupData.TabIndex = 5;
			// 
			// buttonVersionGroupDetail
			// 
			this.buttonVersionGroupDetail.Location = new System.Drawing.Point(262, 51);
			this.buttonVersionGroupDetail.Name = "buttonVersionGroupDetail";
			this.buttonVersionGroupDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonVersionGroupDetail.TabIndex = 6;
			this.buttonVersionGroupDetail.Text = "詳細";
			this.buttonVersionGroupDetail.UseVisualStyleBackColor = true;
			this.buttonVersionGroupDetail.Click += new System.EventHandler(this.buttonVersionGroupDetail_Click);
			// 
			// buttonLanguageDetail
			// 
			this.buttonLanguageDetail.Location = new System.Drawing.Point(335, 178);
			this.buttonLanguageDetail.Name = "buttonLanguageDetail";
			this.buttonLanguageDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonLanguageDetail.TabIndex = 9;
			this.buttonLanguageDetail.Text = "詳細";
			this.buttonLanguageDetail.UseVisualStyleBackColor = true;
			this.buttonLanguageDetail.Click += new System.EventHandler(this.buttonLanguageDetail_Click);
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
			this.languageNameView.Location = new System.Drawing.Point(335, 24);
			this.languageNameView.MultiSelect = false;
			this.languageNameView.Name = "languageNameView";
			this.languageNameView.ReadOnly = true;
			this.languageNameView.RowHeadersVisible = false;
			this.languageNameView.RowTemplate.Height = 21;
			this.languageNameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.languageNameView.Size = new System.Drawing.Size(198, 153);
			this.languageNameView.TabIndex = 8;
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
			// VersionDetailDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.buttonLanguageDetail);
			this.Controls.Add(this.languageNameView);
			this.Controls.Add(namesCaption);
			this.Controls.Add(this.buttonVersionGroupDetail);
			this.Controls.Add(this.versionGroupData);
			this.Controls.Add(versionGroupCaption);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "VersionDetailDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "バージョン(Version)";
			this.Load += new System.EventHandler(this.VersionDetailDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Label versionGroupData;
		private System.Windows.Forms.Button buttonVersionGroupDetail;
		private System.Windows.Forms.Button buttonLanguageDetail;
		private System.Windows.Forms.DataGridView languageNameView;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageNameColumn;
	}
}