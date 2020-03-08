namespace PokeAPITool
{
	partial class RegionDetailDialog
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
			System.Windows.Forms.Label mainGenerationCaption;
			System.Windows.Forms.Label locationCaption;
			System.Windows.Forms.Label pokedexesCaption;
			System.Windows.Forms.Label versionGroupCaption;
			System.Windows.Forms.Label namesCaption;
			this.buttonLocationDetail = new System.Windows.Forms.Button();
			this.locationDataView = new System.Windows.Forms.DataGridView();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonPokedexDetail = new System.Windows.Forms.Button();
			this.pokedexDataView = new System.Windows.Forms.DataGridView();
			this.pokedexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonVersionGroupDetail = new System.Windows.Forms.Button();
			this.versionGroupDataView = new System.Windows.Forms.DataGridView();
			this.VersionGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonNamesDetail = new System.Windows.Forms.Button();
			this.namesDataView = new System.Windows.Forms.DataGridView();
			this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LanguageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameData = new System.Windows.Forms.Label();
			this.idData = new System.Windows.Forms.Label();
			this.buttonGenerationDetail = new System.Windows.Forms.Button();
			this.mainGenerationData = new System.Windows.Forms.Label();
			nameCaption = new System.Windows.Forms.Label();
			idCaption = new System.Windows.Forms.Label();
			mainGenerationCaption = new System.Windows.Forms.Label();
			locationCaption = new System.Windows.Forms.Label();
			pokedexesCaption = new System.Windows.Forms.Label();
			versionGroupCaption = new System.Windows.Forms.Label();
			namesCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.locationDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokedexDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.namesDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(12, 27);
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
			// mainGenerationCaption
			// 
			mainGenerationCaption.AutoSize = true;
			mainGenerationCaption.Location = new System.Drawing.Point(12, 45);
			mainGenerationCaption.Name = "mainGenerationCaption";
			mainGenerationCaption.Size = new System.Drawing.Size(51, 12);
			mainGenerationCaption.TabIndex = 4;
			mainGenerationCaption.Text = "主な世代";
			// 
			// locationCaption
			// 
			locationCaption.AutoSize = true;
			locationCaption.Location = new System.Drawing.Point(12, 67);
			locationCaption.Name = "locationCaption";
			locationCaption.Size = new System.Drawing.Size(29, 12);
			locationCaption.TabIndex = 7;
			locationCaption.Text = "場所";
			// 
			// pokedexesCaption
			// 
			pokedexesCaption.AutoSize = true;
			pokedexesCaption.Location = new System.Drawing.Point(143, 67);
			pokedexesCaption.Name = "pokedexesCaption";
			pokedexesCaption.Size = new System.Drawing.Size(29, 12);
			pokedexesCaption.TabIndex = 10;
			pokedexesCaption.Text = "図鑑";
			// 
			// versionGroupCaption
			// 
			versionGroupCaption.AutoSize = true;
			versionGroupCaption.Location = new System.Drawing.Point(143, 253);
			versionGroupCaption.Name = "versionGroupCaption";
			versionGroupCaption.Size = new System.Drawing.Size(88, 12);
			versionGroupCaption.TabIndex = 13;
			versionGroupCaption.Text = "バージョングループ";
			// 
			// namesCaption
			// 
			namesCaption.AutoSize = true;
			namesCaption.Location = new System.Drawing.Point(290, 67);
			namesCaption.Name = "namesCaption";
			namesCaption.Size = new System.Drawing.Size(75, 12);
			namesCaption.TabIndex = 16;
			namesCaption.Text = "言語毎の名称";
			// 
			// buttonLocationDetail
			// 
			this.buttonLocationDetail.Location = new System.Drawing.Point(14, 422);
			this.buttonLocationDetail.Name = "buttonLocationDetail";
			this.buttonLocationDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonLocationDetail.TabIndex = 9;
			this.buttonLocationDetail.Text = "詳細";
			this.buttonLocationDetail.UseVisualStyleBackColor = true;
			// 
			// locationDataView
			// 
			this.locationDataView.AllowUserToAddRows = false;
			this.locationDataView.AllowUserToDeleteRows = false;
			this.locationDataView.AllowUserToResizeColumns = false;
			this.locationDataView.AllowUserToResizeRows = false;
			this.locationDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.locationDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationColumn});
			this.locationDataView.Location = new System.Drawing.Point(14, 82);
			this.locationDataView.MultiSelect = false;
			this.locationDataView.Name = "locationDataView";
			this.locationDataView.ReadOnly = true;
			this.locationDataView.RowHeadersVisible = false;
			this.locationDataView.RowTemplate.Height = 21;
			this.locationDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.locationDataView.Size = new System.Drawing.Size(117, 339);
			this.locationDataView.TabIndex = 8;
			// 
			// locationColumn
			// 
			this.locationColumn.HeaderText = "場所";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			this.locationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.locationColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonPokedexDetail
			// 
			this.buttonPokedexDetail.Location = new System.Drawing.Point(145, 226);
			this.buttonPokedexDetail.Name = "buttonPokedexDetail";
			this.buttonPokedexDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonPokedexDetail.TabIndex = 12;
			this.buttonPokedexDetail.Text = "詳細";
			this.buttonPokedexDetail.UseVisualStyleBackColor = true;
			this.buttonPokedexDetail.Click += new System.EventHandler(this.buttonPokedexDetail_Click);
			// 
			// pokedexDataView
			// 
			this.pokedexDataView.AllowUserToAddRows = false;
			this.pokedexDataView.AllowUserToDeleteRows = false;
			this.pokedexDataView.AllowUserToResizeColumns = false;
			this.pokedexDataView.AllowUserToResizeRows = false;
			this.pokedexDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pokedexDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokedexColumn});
			this.pokedexDataView.Location = new System.Drawing.Point(144, 82);
			this.pokedexDataView.MultiSelect = false;
			this.pokedexDataView.Name = "pokedexDataView";
			this.pokedexDataView.ReadOnly = true;
			this.pokedexDataView.RowHeadersVisible = false;
			this.pokedexDataView.RowTemplate.Height = 21;
			this.pokedexDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.pokedexDataView.Size = new System.Drawing.Size(141, 143);
			this.pokedexDataView.TabIndex = 11;
			// 
			// pokedexColumn
			// 
			this.pokedexColumn.HeaderText = "図鑑";
			this.pokedexColumn.Name = "pokedexColumn";
			this.pokedexColumn.ReadOnly = true;
			this.pokedexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.pokedexColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonVersionGroupDetail
			// 
			this.buttonVersionGroupDetail.Location = new System.Drawing.Point(143, 422);
			this.buttonVersionGroupDetail.Name = "buttonVersionGroupDetail";
			this.buttonVersionGroupDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonVersionGroupDetail.TabIndex = 15;
			this.buttonVersionGroupDetail.Text = "詳細";
			this.buttonVersionGroupDetail.UseVisualStyleBackColor = true;
			this.buttonVersionGroupDetail.Click += new System.EventHandler(this.buttonVersionGroupDetail_Click);
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
			this.versionGroupDataView.Location = new System.Drawing.Point(145, 268);
			this.versionGroupDataView.MultiSelect = false;
			this.versionGroupDataView.Name = "versionGroupDataView";
			this.versionGroupDataView.ReadOnly = true;
			this.versionGroupDataView.RowHeadersVisible = false;
			this.versionGroupDataView.RowTemplate.Height = 21;
			this.versionGroupDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.versionGroupDataView.Size = new System.Drawing.Size(140, 153);
			this.versionGroupDataView.TabIndex = 14;
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
			// buttonNamesDetail
			// 
			this.buttonNamesDetail.Location = new System.Drawing.Point(292, 226);
			this.buttonNamesDetail.Name = "buttonNamesDetail";
			this.buttonNamesDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonNamesDetail.TabIndex = 18;
			this.buttonNamesDetail.Text = "詳細";
			this.buttonNamesDetail.UseVisualStyleBackColor = true;
			this.buttonNamesDetail.Click += new System.EventHandler(this.buttonNamesDetail_Click);
			// 
			// namesDataView
			// 
			this.namesDataView.AllowUserToAddRows = false;
			this.namesDataView.AllowUserToDeleteRows = false;
			this.namesDataView.AllowUserToResizeColumns = false;
			this.namesDataView.AllowUserToResizeRows = false;
			this.namesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.namesDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LanguageColumn,
            this.LanguageNameColumn});
			this.namesDataView.Location = new System.Drawing.Point(292, 82);
			this.namesDataView.MultiSelect = false;
			this.namesDataView.Name = "namesDataView";
			this.namesDataView.ReadOnly = true;
			this.namesDataView.RowHeadersVisible = false;
			this.namesDataView.RowTemplate.Height = 21;
			this.namesDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.namesDataView.Size = new System.Drawing.Size(198, 143);
			this.namesDataView.TabIndex = 17;
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
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(66, 24);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(153, 15);
			this.nameData.TabIndex = 3;
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(66, 8);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// buttonGenerationDetail
			// 
			this.buttonGenerationDetail.Location = new System.Drawing.Point(167, 36);
			this.buttonGenerationDetail.Name = "buttonGenerationDetail";
			this.buttonGenerationDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonGenerationDetail.TabIndex = 6;
			this.buttonGenerationDetail.Text = "詳細";
			this.buttonGenerationDetail.UseVisualStyleBackColor = true;
			this.buttonGenerationDetail.Click += new System.EventHandler(this.buttonGenerationDetail_Click);
			// 
			// mainGenerationData
			// 
			this.mainGenerationData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mainGenerationData.Location = new System.Drawing.Point(66, 40);
			this.mainGenerationData.Name = "mainGenerationData";
			this.mainGenerationData.Size = new System.Drawing.Size(100, 15);
			this.mainGenerationData.TabIndex = 5;
			// 
			// RegionDetailDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 457);
			this.Controls.Add(this.buttonGenerationDetail);
			this.Controls.Add(this.mainGenerationData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(this.buttonNamesDetail);
			this.Controls.Add(this.namesDataView);
			this.Controls.Add(namesCaption);
			this.Controls.Add(this.buttonVersionGroupDetail);
			this.Controls.Add(this.versionGroupDataView);
			this.Controls.Add(versionGroupCaption);
			this.Controls.Add(this.buttonPokedexDetail);
			this.Controls.Add(this.pokedexDataView);
			this.Controls.Add(pokedexesCaption);
			this.Controls.Add(this.buttonLocationDetail);
			this.Controls.Add(this.locationDataView);
			this.Controls.Add(locationCaption);
			this.Controls.Add(mainGenerationCaption);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "RegionDetailDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "地方";
			this.Load += new System.EventHandler(this.RegionDetailDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.locationDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokedexDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.namesDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLocationDetail;
		private System.Windows.Forms.DataGridView locationDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.Button buttonPokedexDetail;
		private System.Windows.Forms.DataGridView pokedexDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokedexColumn;
		private System.Windows.Forms.Button buttonVersionGroupDetail;
		private System.Windows.Forms.DataGridView versionGroupDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn VersionGroupColumn;
		private System.Windows.Forms.Button buttonNamesDetail;
		private System.Windows.Forms.DataGridView namesDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageNameColumn;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Button buttonGenerationDetail;
		private System.Windows.Forms.Label mainGenerationData;
	}
}