﻿namespace PokeAPITool
{
	partial class PokedexDetailForm
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
			System.Windows.Forms.Label isMainSeriesCaption;
			System.Windows.Forms.Label namesCaption;
			System.Windows.Forms.Label descriptionCaption;
			System.Windows.Forms.Label versionGroupCaption;
			System.Windows.Forms.Label pokemonSpeciesCaption;
			this.buttonNameLanguageDetail = new System.Windows.Forms.Button();
			this.namesDataView = new System.Windows.Forms.DataGridView();
			this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LanguageNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameData = new System.Windows.Forms.Label();
			this.idData = new System.Windows.Forms.Label();
			this.isMainSeriesData = new System.Windows.Forms.Label();
			this.regionData = new System.Windows.Forms.Label();
			this.buttonDescriptionLanguageDetail = new System.Windows.Forms.Button();
			this.descriptionsDataView = new System.Windows.Forms.DataGridView();
			this.buttonVersionGroupDetail = new System.Windows.Forms.Button();
			this.versionGroupDataView = new System.Windows.Forms.DataGridView();
			this.VersionGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pokemonDataView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonRegion = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			nameCaption = new System.Windows.Forms.Label();
			idCaption = new System.Windows.Forms.Label();
			isMainSeriesCaption = new System.Windows.Forms.Label();
			namesCaption = new System.Windows.Forms.Label();
			descriptionCaption = new System.Windows.Forms.Label();
			versionGroupCaption = new System.Windows.Forms.Label();
			pokemonSpeciesCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.namesDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.descriptionsDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(10, 33);
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
			// isMainSeriesCaption
			// 
			isMainSeriesCaption.AutoSize = true;
			isMainSeriesCaption.Location = new System.Drawing.Point(10, 57);
			isMainSeriesCaption.Name = "isMainSeriesCaption";
			isMainSeriesCaption.Size = new System.Drawing.Size(75, 12);
			isMainSeriesCaption.TabIndex = 4;
			isMainSeriesCaption.Text = "メインの図鑑か";
			// 
			// namesCaption
			// 
			namesCaption.AutoSize = true;
			namesCaption.Location = new System.Drawing.Point(250, 112);
			namesCaption.Name = "namesCaption";
			namesCaption.Size = new System.Drawing.Size(75, 12);
			namesCaption.TabIndex = 11;
			namesCaption.Text = "言語毎の名称";
			// 
			// descriptionCaption
			// 
			descriptionCaption.AutoSize = true;
			descriptionCaption.Location = new System.Drawing.Point(250, 316);
			descriptionCaption.Name = "descriptionCaption";
			descriptionCaption.Size = new System.Drawing.Size(75, 12);
			descriptionCaption.TabIndex = 17;
			descriptionCaption.Text = "言語毎の説明";
			// 
			// versionGroupCaption
			// 
			versionGroupCaption.AutoSize = true;
			versionGroupCaption.Location = new System.Drawing.Point(454, 112);
			versionGroupCaption.Name = "versionGroupCaption";
			versionGroupCaption.Size = new System.Drawing.Size(88, 12);
			versionGroupCaption.TabIndex = 14;
			versionGroupCaption.Text = "バージョングループ";
			// 
			// pokemonSpeciesCaption
			// 
			pokemonSpeciesCaption.AutoSize = true;
			pokemonSpeciesCaption.Location = new System.Drawing.Point(10, 112);
			pokemonSpeciesCaption.Name = "pokemonSpeciesCaption";
			pokemonSpeciesCaption.Size = new System.Drawing.Size(54, 12);
			pokemonSpeciesCaption.TabIndex = 8;
			pokemonSpeciesCaption.Text = "ポケモン種";
			// 
			// buttonNameLanguageDetail
			// 
			this.buttonNameLanguageDetail.Location = new System.Drawing.Point(252, 283);
			this.buttonNameLanguageDetail.Name = "buttonNameLanguageDetail";
			this.buttonNameLanguageDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonNameLanguageDetail.TabIndex = 13;
			this.buttonNameLanguageDetail.Text = "詳細";
			this.buttonNameLanguageDetail.UseVisualStyleBackColor = true;
			this.buttonNameLanguageDetail.Click += new System.EventHandler(this.buttonNameLanguageDetail_Click);
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
			this.namesDataView.Location = new System.Drawing.Point(252, 127);
			this.namesDataView.MultiSelect = false;
			this.namesDataView.Name = "namesDataView";
			this.namesDataView.ReadOnly = true;
			this.namesDataView.RowHeadersVisible = false;
			this.namesDataView.RowTemplate.Height = 21;
			this.namesDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.namesDataView.Size = new System.Drawing.Size(198, 153);
			this.namesDataView.TabIndex = 12;
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
			this.nameData.Location = new System.Drawing.Point(93, 32);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(153, 15);
			this.nameData.TabIndex = 3;
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(93, 8);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// isMainSeriesData
			// 
			this.isMainSeriesData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.isMainSeriesData.Location = new System.Drawing.Point(93, 56);
			this.isMainSeriesData.Name = "isMainSeriesData";
			this.isMainSeriesData.Size = new System.Drawing.Size(40, 15);
			this.isMainSeriesData.TabIndex = 5;
			// 
			// regionData
			// 
			this.regionData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.regionData.Location = new System.Drawing.Point(93, 80);
			this.regionData.Name = "regionData";
			this.regionData.Size = new System.Drawing.Size(55, 15);
			this.regionData.TabIndex = 7;
			// 
			// buttonDescriptionLanguageDetail
			// 
			this.buttonDescriptionLanguageDetail.Location = new System.Drawing.Point(252, 487);
			this.buttonDescriptionLanguageDetail.Name = "buttonDescriptionLanguageDetail";
			this.buttonDescriptionLanguageDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonDescriptionLanguageDetail.TabIndex = 19;
			this.buttonDescriptionLanguageDetail.Text = "詳細";
			this.buttonDescriptionLanguageDetail.UseVisualStyleBackColor = true;
			this.buttonDescriptionLanguageDetail.Click += new System.EventHandler(this.buttonDescriptionLanguageDetail_Click);
			// 
			// descriptionsDataView
			// 
			this.descriptionsDataView.AllowUserToAddRows = false;
			this.descriptionsDataView.AllowUserToDeleteRows = false;
			this.descriptionsDataView.AllowUserToResizeColumns = false;
			this.descriptionsDataView.AllowUserToResizeRows = false;
			this.descriptionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.descriptionsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.descriptionsDataView.Location = new System.Drawing.Point(252, 331);
			this.descriptionsDataView.MultiSelect = false;
			this.descriptionsDataView.Name = "descriptionsDataView";
			this.descriptionsDataView.ReadOnly = true;
			this.descriptionsDataView.RowHeadersVisible = false;
			this.descriptionsDataView.RowTemplate.Height = 21;
			this.descriptionsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.descriptionsDataView.Size = new System.Drawing.Size(744, 153);
			this.descriptionsDataView.TabIndex = 18;
			// 
			// buttonVersionGroupDetail
			// 
			this.buttonVersionGroupDetail.Location = new System.Drawing.Point(458, 283);
			this.buttonVersionGroupDetail.Name = "buttonVersionGroupDetail";
			this.buttonVersionGroupDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonVersionGroupDetail.TabIndex = 16;
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
			this.versionGroupDataView.Location = new System.Drawing.Point(458, 127);
			this.versionGroupDataView.MultiSelect = false;
			this.versionGroupDataView.Name = "versionGroupDataView";
			this.versionGroupDataView.ReadOnly = true;
			this.versionGroupDataView.RowHeadersVisible = false;
			this.versionGroupDataView.RowTemplate.Height = 21;
			this.versionGroupDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.versionGroupDataView.Size = new System.Drawing.Size(198, 153);
			this.versionGroupDataView.TabIndex = 15;
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
			// pokemonDataView
			// 
			this.pokemonDataView.AllowUserToAddRows = false;
			this.pokemonDataView.AllowUserToDeleteRows = false;
			this.pokemonDataView.AllowUserToResizeColumns = false;
			this.pokemonDataView.AllowUserToResizeRows = false;
			this.pokemonDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pokemonDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.pokemonDataView.Location = new System.Drawing.Point(12, 127);
			this.pokemonDataView.MultiSelect = false;
			this.pokemonDataView.Name = "pokemonDataView";
			this.pokemonDataView.ReadOnly = true;
			this.pokemonDataView.RowHeadersVisible = false;
			this.pokemonDataView.RowTemplate.Height = 21;
			this.pokemonDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.pokemonDataView.Size = new System.Drawing.Size(234, 560);
			this.pokemonDataView.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 693);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(39, 24);
			this.button1.TabIndex = 10;
			this.button1.Text = "詳細";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// buttonRegion
			// 
			this.buttonRegion.Location = new System.Drawing.Point(10, 76);
			this.buttonRegion.Name = "buttonRegion";
			this.buttonRegion.Size = new System.Drawing.Size(75, 23);
			this.buttonRegion.TabIndex = 6;
			this.buttonRegion.Text = "地方";
			this.buttonRegion.UseVisualStyleBackColor = true;
			this.buttonRegion.Click += new System.EventHandler(this.buttonRegion_Click);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "No.";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn3.Width = 40;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "ポケモン種";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "言語";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn1.Width = 80;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "説明";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn2.Width = 620;
			// 
			// PokedexDetailDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.buttonRegion);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pokemonDataView);
			this.Controls.Add(pokemonSpeciesCaption);
			this.Controls.Add(this.buttonVersionGroupDetail);
			this.Controls.Add(this.versionGroupDataView);
			this.Controls.Add(versionGroupCaption);
			this.Controls.Add(this.buttonDescriptionLanguageDetail);
			this.Controls.Add(this.descriptionsDataView);
			this.Controls.Add(descriptionCaption);
			this.Controls.Add(this.regionData);
			this.Controls.Add(this.isMainSeriesData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(this.buttonNameLanguageDetail);
			this.Controls.Add(this.namesDataView);
			this.Controls.Add(namesCaption);
			this.Controls.Add(isMainSeriesCaption);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "PokedexDetailDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ポケモン図鑑(Pokedex)";
			this.Load += new System.EventHandler(this.PokedexDetailDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.namesDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.descriptionsDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.versionGroupDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokemonDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNameLanguageDetail;
		private System.Windows.Forms.DataGridView namesDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LanguageNameColumn;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Label isMainSeriesData;
		private System.Windows.Forms.Label regionData;
		private System.Windows.Forms.Button buttonDescriptionLanguageDetail;
		private System.Windows.Forms.DataGridView descriptionsDataView;
		private System.Windows.Forms.Button buttonVersionGroupDetail;
		private System.Windows.Forms.DataGridView versionGroupDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn VersionGroupColumn;
		private System.Windows.Forms.DataGridView pokemonDataView;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonRegion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}