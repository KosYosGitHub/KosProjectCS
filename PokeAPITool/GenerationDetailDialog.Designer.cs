namespace PokeAPITool
{
	partial class GenerationDetailDialog
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
			System.Windows.Forms.Label pokemonCaption;
			System.Windows.Forms.Label typeCaption;
			System.Windows.Forms.Label moveCaption;
			System.Windows.Forms.Label abilityCaption;
			System.Windows.Forms.Label namesCaption;
			this.nameData = new System.Windows.Forms.Label();
			this.idData = new System.Windows.Forms.Label();
			this.mainRegionData = new System.Windows.Forms.Label();
			this.buttonMainRegionCaption = new System.Windows.Forms.Button();
			this.versionGroupDataView = new System.Windows.Forms.DataGridView();
			this.VersionGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonVersionGroupDetail = new System.Windows.Forms.Button();
			this.pokemonDataView = new System.Windows.Forms.DataGridView();
			this.pokemonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonPokemonDetail = new System.Windows.Forms.Button();
			this.typeDataView = new System.Windows.Forms.DataGridView();
			this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonTypeDetail = new System.Windows.Forms.Button();
			this.moveDataView = new System.Windows.Forms.DataGridView();
			this.moveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonMoveDetail = new System.Windows.Forms.Button();
			this.abilityDataView = new System.Windows.Forms.DataGridView();
			this.abilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonAbilityDetail = new System.Windows.Forms.Button();
			this.languageNameView = new System.Windows.Forms.DataGridView();
			this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LanguageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonLanguageDetail = new System.Windows.Forms.Button();
			nameCaption = new System.Windows.Forms.Label();
			idCaption = new System.Windows.Forms.Label();
			versionGroupCaption = new System.Windows.Forms.Label();
			pokemonCaption = new System.Windows.Forms.Label();
			typeCaption = new System.Windows.Forms.Label();
			moveCaption = new System.Windows.Forms.Label();
			abilityCaption = new System.Windows.Forms.Label();
			namesCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typeDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moveDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.abilityDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(12, 30);
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
			versionGroupCaption.Location = new System.Drawing.Point(798, 402);
			versionGroupCaption.Name = "versionGroupCaption";
			versionGroupCaption.Size = new System.Drawing.Size(88, 12);
			versionGroupCaption.TabIndex = 21;
			versionGroupCaption.Text = "バージョングループ";
			// 
			// pokemonCaption
			// 
			pokemonCaption.AutoSize = true;
			pokemonCaption.Location = new System.Drawing.Point(12, 83);
			pokemonCaption.Name = "pokemonCaption";
			pokemonCaption.Size = new System.Drawing.Size(42, 12);
			pokemonCaption.TabIndex = 6;
			pokemonCaption.Text = "ポケモン";
			// 
			// typeCaption
			// 
			typeCaption.AutoSize = true;
			typeCaption.Location = new System.Drawing.Point(650, 83);
			typeCaption.Name = "typeCaption";
			typeCaption.Size = new System.Drawing.Size(31, 12);
			typeCaption.TabIndex = 15;
			typeCaption.Text = "タイプ";
			// 
			// moveCaption
			// 
			moveCaption.AutoSize = true;
			moveCaption.Location = new System.Drawing.Point(143, 83);
			moveCaption.Name = "moveCaption";
			moveCaption.Size = new System.Drawing.Size(17, 12);
			moveCaption.TabIndex = 9;
			moveCaption.Text = "技";
			// 
			// abilityCaption
			// 
			abilityCaption.AutoSize = true;
			abilityCaption.Location = new System.Drawing.Point(520, 83);
			abilityCaption.Name = "abilityCaption";
			abilityCaption.Size = new System.Drawing.Size(29, 12);
			abilityCaption.TabIndex = 12;
			abilityCaption.Text = "特性";
			// 
			// namesCaption
			// 
			namesCaption.AutoSize = true;
			namesCaption.Location = new System.Drawing.Point(796, 83);
			namesCaption.Name = "namesCaption";
			namesCaption.Size = new System.Drawing.Size(75, 12);
			namesCaption.TabIndex = 18;
			namesCaption.Text = "言語毎の名称";
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(88, 29);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(153, 15);
			this.nameData.TabIndex = 3;
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(88, 8);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// mainRegionData
			// 
			this.mainRegionData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mainRegionData.Location = new System.Drawing.Point(88, 50);
			this.mainRegionData.Name = "mainRegionData";
			this.mainRegionData.Size = new System.Drawing.Size(55, 15);
			this.mainRegionData.TabIndex = 5;
			// 
			// buttonMainRegionCaption
			// 
			this.buttonMainRegionCaption.Location = new System.Drawing.Point(14, 45);
			this.buttonMainRegionCaption.Name = "buttonMainRegionCaption";
			this.buttonMainRegionCaption.Size = new System.Drawing.Size(64, 24);
			this.buttonMainRegionCaption.TabIndex = 4;
			this.buttonMainRegionCaption.Text = "主な地方";
			this.buttonMainRegionCaption.UseVisualStyleBackColor = true;
			this.buttonMainRegionCaption.Click += new System.EventHandler(this.buttonMainRegionCaption_Click);
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
			this.versionGroupDataView.Location = new System.Drawing.Point(798, 417);
			this.versionGroupDataView.MultiSelect = false;
			this.versionGroupDataView.Name = "versionGroupDataView";
			this.versionGroupDataView.ReadOnly = true;
			this.versionGroupDataView.RowHeadersVisible = false;
			this.versionGroupDataView.RowTemplate.Height = 21;
			this.versionGroupDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.versionGroupDataView.Size = new System.Drawing.Size(198, 270);
			this.versionGroupDataView.TabIndex = 22;
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
			// buttonVersionGroupDetail
			// 
			this.buttonVersionGroupDetail.Location = new System.Drawing.Point(798, 693);
			this.buttonVersionGroupDetail.Name = "buttonVersionGroupDetail";
			this.buttonVersionGroupDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonVersionGroupDetail.TabIndex = 23;
			this.buttonVersionGroupDetail.Text = "詳細";
			this.buttonVersionGroupDetail.UseVisualStyleBackColor = true;
			this.buttonVersionGroupDetail.Click += new System.EventHandler(this.buttonVersionGroupDetail_Click);
			// 
			// pokemonDataView
			// 
			this.pokemonDataView.AllowUserToAddRows = false;
			this.pokemonDataView.AllowUserToDeleteRows = false;
			this.pokemonDataView.AllowUserToResizeColumns = false;
			this.pokemonDataView.AllowUserToResizeRows = false;
			this.pokemonDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pokemonDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokemonColumn});
			this.pokemonDataView.Location = new System.Drawing.Point(14, 100);
			this.pokemonDataView.MultiSelect = false;
			this.pokemonDataView.Name = "pokemonDataView";
			this.pokemonDataView.ReadOnly = true;
			this.pokemonDataView.RowHeadersVisible = false;
			this.pokemonDataView.RowTemplate.Height = 21;
			this.pokemonDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.pokemonDataView.Size = new System.Drawing.Size(125, 587);
			this.pokemonDataView.TabIndex = 7;
			// 
			// pokemonColumn
			// 
			this.pokemonColumn.HeaderText = "ポケモン";
			this.pokemonColumn.Name = "pokemonColumn";
			this.pokemonColumn.ReadOnly = true;
			this.pokemonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.pokemonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonPokemonDetail
			// 
			this.buttonPokemonDetail.Location = new System.Drawing.Point(14, 693);
			this.buttonPokemonDetail.Name = "buttonPokemonDetail";
			this.buttonPokemonDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonPokemonDetail.TabIndex = 8;
			this.buttonPokemonDetail.Text = "詳細";
			this.buttonPokemonDetail.UseVisualStyleBackColor = true;
			// 
			// typeDataView
			// 
			this.typeDataView.AllowUserToAddRows = false;
			this.typeDataView.AllowUserToDeleteRows = false;
			this.typeDataView.AllowUserToResizeColumns = false;
			this.typeDataView.AllowUserToResizeRows = false;
			this.typeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.typeDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeColumn});
			this.typeDataView.Location = new System.Drawing.Point(652, 100);
			this.typeDataView.MultiSelect = false;
			this.typeDataView.Name = "typeDataView";
			this.typeDataView.ReadOnly = true;
			this.typeDataView.RowHeadersVisible = false;
			this.typeDataView.RowTemplate.Height = 21;
			this.typeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.typeDataView.Size = new System.Drawing.Size(140, 587);
			this.typeDataView.TabIndex = 16;
			// 
			// typeColumn
			// 
			this.typeColumn.HeaderText = "タイプ";
			this.typeColumn.Name = "typeColumn";
			this.typeColumn.ReadOnly = true;
			this.typeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.typeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonTypeDetail
			// 
			this.buttonTypeDetail.Location = new System.Drawing.Point(652, 693);
			this.buttonTypeDetail.Name = "buttonTypeDetail";
			this.buttonTypeDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonTypeDetail.TabIndex = 17;
			this.buttonTypeDetail.Text = "詳細";
			this.buttonTypeDetail.UseVisualStyleBackColor = true;
			// 
			// moveDataView
			// 
			this.moveDataView.AllowUserToAddRows = false;
			this.moveDataView.AllowUserToDeleteRows = false;
			this.moveDataView.AllowUserToResizeColumns = false;
			this.moveDataView.AllowUserToResizeRows = false;
			this.moveDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.moveDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moveColumn});
			this.moveDataView.Location = new System.Drawing.Point(145, 100);
			this.moveDataView.MultiSelect = false;
			this.moveDataView.Name = "moveDataView";
			this.moveDataView.ReadOnly = true;
			this.moveDataView.RowHeadersVisible = false;
			this.moveDataView.RowTemplate.Height = 21;
			this.moveDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.moveDataView.Size = new System.Drawing.Size(371, 587);
			this.moveDataView.TabIndex = 10;
			// 
			// moveColumn
			// 
			this.moveColumn.HeaderText = "技";
			this.moveColumn.Name = "moveColumn";
			this.moveColumn.ReadOnly = true;
			this.moveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.moveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.moveColumn.Width = 350;
			// 
			// buttonMoveDetail
			// 
			this.buttonMoveDetail.Location = new System.Drawing.Point(145, 693);
			this.buttonMoveDetail.Name = "buttonMoveDetail";
			this.buttonMoveDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonMoveDetail.TabIndex = 11;
			this.buttonMoveDetail.Text = "詳細";
			this.buttonMoveDetail.UseVisualStyleBackColor = true;
			// 
			// abilityDataView
			// 
			this.abilityDataView.AllowUserToAddRows = false;
			this.abilityDataView.AllowUserToDeleteRows = false;
			this.abilityDataView.AllowUserToResizeColumns = false;
			this.abilityDataView.AllowUserToResizeRows = false;
			this.abilityDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.abilityDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abilityColumn});
			this.abilityDataView.Location = new System.Drawing.Point(522, 100);
			this.abilityDataView.MultiSelect = false;
			this.abilityDataView.Name = "abilityDataView";
			this.abilityDataView.ReadOnly = true;
			this.abilityDataView.RowHeadersVisible = false;
			this.abilityDataView.RowTemplate.Height = 21;
			this.abilityDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.abilityDataView.Size = new System.Drawing.Size(125, 587);
			this.abilityDataView.TabIndex = 13;
			// 
			// abilityColumn
			// 
			this.abilityColumn.HeaderText = "特性";
			this.abilityColumn.Name = "abilityColumn";
			this.abilityColumn.ReadOnly = true;
			this.abilityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.abilityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonAbilityDetail
			// 
			this.buttonAbilityDetail.Location = new System.Drawing.Point(522, 693);
			this.buttonAbilityDetail.Name = "buttonAbilityDetail";
			this.buttonAbilityDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonAbilityDetail.TabIndex = 14;
			this.buttonAbilityDetail.Text = "詳細";
			this.buttonAbilityDetail.UseVisualStyleBackColor = true;
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
			this.languageNameView.Location = new System.Drawing.Point(798, 100);
			this.languageNameView.MultiSelect = false;
			this.languageNameView.Name = "languageNameView";
			this.languageNameView.ReadOnly = true;
			this.languageNameView.RowHeadersVisible = false;
			this.languageNameView.RowTemplate.Height = 21;
			this.languageNameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.languageNameView.Size = new System.Drawing.Size(198, 253);
			this.languageNameView.TabIndex = 19;
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
			// buttonLanguageDetail
			// 
			this.buttonLanguageDetail.Location = new System.Drawing.Point(798, 359);
			this.buttonLanguageDetail.Name = "buttonLanguageDetail";
			this.buttonLanguageDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonLanguageDetail.TabIndex = 20;
			this.buttonLanguageDetail.Text = "詳細";
			this.buttonLanguageDetail.UseVisualStyleBackColor = true;
			this.buttonLanguageDetail.Click += new System.EventHandler(this.buttonLanguageDetail_Click);
			// 
			// GenerationDetailDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.buttonLanguageDetail);
			this.Controls.Add(this.languageNameView);
			this.Controls.Add(namesCaption);
			this.Controls.Add(this.buttonAbilityDetail);
			this.Controls.Add(abilityCaption);
			this.Controls.Add(this.abilityDataView);
			this.Controls.Add(this.buttonMoveDetail);
			this.Controls.Add(moveCaption);
			this.Controls.Add(this.moveDataView);
			this.Controls.Add(this.buttonTypeDetail);
			this.Controls.Add(this.typeDataView);
			this.Controls.Add(typeCaption);
			this.Controls.Add(this.buttonPokemonDetail);
			this.Controls.Add(this.pokemonDataView);
			this.Controls.Add(this.buttonVersionGroupDetail);
			this.Controls.Add(pokemonCaption);
			this.Controls.Add(this.versionGroupDataView);
			this.Controls.Add(versionGroupCaption);
			this.Controls.Add(this.buttonMainRegionCaption);
			this.Controls.Add(this.mainRegionData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "GenerationDetailDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "世代(Generation)";
			this.Load += new System.EventHandler(this.GenerationDetailDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typeDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moveDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.abilityDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.languageNameView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Label mainRegionData;
		private System.Windows.Forms.Button buttonMainRegionCaption;
		private System.Windows.Forms.DataGridView versionGroupDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn VersionGroupColumn;
		private System.Windows.Forms.Button buttonVersionGroupDetail;
		private System.Windows.Forms.DataGridView pokemonDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokemonColumn;
		private System.Windows.Forms.Button buttonPokemonDetail;
		private System.Windows.Forms.DataGridView typeDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
		private System.Windows.Forms.Button buttonTypeDetail;
		private System.Windows.Forms.DataGridView moveDataView;
		private System.Windows.Forms.Button buttonMoveDetail;
		private System.Windows.Forms.DataGridView abilityDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn abilityColumn;
		private System.Windows.Forms.Button buttonAbilityDetail;
		private System.Windows.Forms.DataGridView languageNameView;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageNameColumn;
		private System.Windows.Forms.Button buttonLanguageDetail;
		private System.Windows.Forms.DataGridViewTextBoxColumn moveColumn;
	}
}