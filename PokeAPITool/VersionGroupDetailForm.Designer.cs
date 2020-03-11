namespace PokeAPITool
{
	partial class VersionGroupDetailForm
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
			System.Windows.Forms.Label orderCaption;
			System.Windows.Forms.Label generationCaption;
			System.Windows.Forms.Label versionsCaption;
			System.Windows.Forms.Label regionsCaption;
			System.Windows.Forms.Label pokedexesCaption;
			System.Windows.Forms.Label moveLearnMethodsCaption;
			this.versionDataView = new System.Windows.Forms.DataGridView();
			this.VersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idData = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.Label();
			this.orderData = new System.Windows.Forms.Label();
			this.generationData = new System.Windows.Forms.Label();
			this.buttonGenerationDetail = new System.Windows.Forms.Button();
			this.regionsDataView = new System.Windows.Forms.DataGridView();
			this.regionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pokedexDataView = new System.Windows.Forms.DataGridView();
			this.pokedexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moveLearnMethodDataView = new System.Windows.Forms.DataGridView();
			this.moveDataMethodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonVersionDetail = new System.Windows.Forms.Button();
			this.buttonRegionDetail = new System.Windows.Forms.Button();
			this.buttonPokedexDetail = new System.Windows.Forms.Button();
			this.buttonMoveLearnMethod = new System.Windows.Forms.Button();
			nameCaption = new System.Windows.Forms.Label();
			idCaption = new System.Windows.Forms.Label();
			orderCaption = new System.Windows.Forms.Label();
			generationCaption = new System.Windows.Forms.Label();
			versionsCaption = new System.Windows.Forms.Label();
			regionsCaption = new System.Windows.Forms.Label();
			pokedexesCaption = new System.Windows.Forms.Label();
			moveLearnMethodsCaption = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.versionDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.regionsDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokedexDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moveLearnMethodDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// nameCaption
			// 
			nameCaption.AutoSize = true;
			nameCaption.Location = new System.Drawing.Point(12, 33);
			nameCaption.Name = "nameCaption";
			nameCaption.Size = new System.Drawing.Size(66, 12);
			nameCaption.TabIndex = 2;
			nameCaption.Text = "名称(Name)";
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
			// orderCaption
			// 
			orderCaption.AutoSize = true;
			orderCaption.Location = new System.Drawing.Point(11, 57);
			orderCaption.Name = "orderCaption";
			orderCaption.Size = new System.Drawing.Size(92, 12);
			orderCaption.TabIndex = 4;
			orderCaption.Text = "ソート順番(Order)";
			// 
			// generationCaption
			// 
			generationCaption.AutoSize = true;
			generationCaption.Location = new System.Drawing.Point(10, 83);
			generationCaption.Name = "generationCaption";
			generationCaption.Size = new System.Drawing.Size(92, 12);
			generationCaption.TabIndex = 6;
			generationCaption.Text = "世代(Generation)";
			// 
			// versionsCaption
			// 
			versionsCaption.AutoSize = true;
			versionsCaption.Location = new System.Drawing.Point(12, 116);
			versionsCaption.Name = "versionsCaption";
			versionsCaption.Size = new System.Drawing.Size(97, 12);
			versionsCaption.TabIndex = 9;
			versionsCaption.Text = "バージョン(Version)";
			// 
			// regionsCaption
			// 
			regionsCaption.AutoSize = true;
			regionsCaption.Location = new System.Drawing.Point(155, 116);
			regionsCaption.Name = "regionsCaption";
			regionsCaption.Size = new System.Drawing.Size(72, 12);
			regionsCaption.TabIndex = 12;
			regionsCaption.Text = "地方(Region)";
			// 
			// pokedexesCaption
			// 
			pokedexesCaption.AutoSize = true;
			pokedexesCaption.Location = new System.Drawing.Point(291, 116);
			pokedexesCaption.Name = "pokedexesCaption";
			pokedexesCaption.Size = new System.Drawing.Size(80, 12);
			pokedexesCaption.TabIndex = 15;
			pokedexesCaption.Text = "図鑑(Pokedex)";
			// 
			// moveLearnMethodsCaption
			// 
			moveLearnMethodsCaption.AutoSize = true;
			moveLearnMethodsCaption.Location = new System.Drawing.Point(428, 116);
			moveLearnMethodsCaption.Name = "moveLearnMethodsCaption";
			moveLearnMethodsCaption.Size = new System.Drawing.Size(175, 12);
			moveLearnMethodsCaption.TabIndex = 18;
			moveLearnMethodsCaption.Text = "技の習得方法(MoveLearnMethod)";
			// 
			// versionDataView
			// 
			this.versionDataView.AllowUserToAddRows = false;
			this.versionDataView.AllowUserToDeleteRows = false;
			this.versionDataView.AllowUserToResizeColumns = false;
			this.versionDataView.AllowUserToResizeRows = false;
			this.versionDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.versionDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersionColumn});
			this.versionDataView.Location = new System.Drawing.Point(14, 131);
			this.versionDataView.MultiSelect = false;
			this.versionDataView.Name = "versionDataView";
			this.versionDataView.ReadOnly = true;
			this.versionDataView.RowHeadersVisible = false;
			this.versionDataView.RowTemplate.Height = 21;
			this.versionDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.versionDataView.Size = new System.Drawing.Size(129, 184);
			this.versionDataView.TabIndex = 10;
			// 
			// VersionColumn
			// 
			this.VersionColumn.HeaderText = "バージョン(Version)";
			this.VersionColumn.Name = "VersionColumn";
			this.VersionColumn.ReadOnly = true;
			this.VersionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.VersionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.VersionColumn.Width = 110;
			// 
			// idData
			// 
			this.idData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.idData.Location = new System.Drawing.Point(113, 8);
			this.idData.Name = "idData";
			this.idData.Size = new System.Drawing.Size(30, 15);
			this.idData.TabIndex = 1;
			// 
			// nameData
			// 
			this.nameData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameData.Location = new System.Drawing.Point(113, 32);
			this.nameData.Name = "nameData";
			this.nameData.Size = new System.Drawing.Size(153, 15);
			this.nameData.TabIndex = 3;
			// 
			// orderData
			// 
			this.orderData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.orderData.Location = new System.Drawing.Point(113, 56);
			this.orderData.Name = "orderData";
			this.orderData.Size = new System.Drawing.Size(30, 15);
			this.orderData.TabIndex = 5;
			// 
			// generationData
			// 
			this.generationData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.generationData.Location = new System.Drawing.Point(113, 80);
			this.generationData.Name = "generationData";
			this.generationData.Size = new System.Drawing.Size(100, 15);
			this.generationData.TabIndex = 7;
			// 
			// buttonGenerationDetail
			// 
			this.buttonGenerationDetail.Location = new System.Drawing.Point(215, 75);
			this.buttonGenerationDetail.Name = "buttonGenerationDetail";
			this.buttonGenerationDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonGenerationDetail.TabIndex = 8;
			this.buttonGenerationDetail.Text = "詳細";
			this.buttonGenerationDetail.UseVisualStyleBackColor = true;
			this.buttonGenerationDetail.Click += new System.EventHandler(this.buttonGenerationDetail_Click);
			// 
			// regionsDataView
			// 
			this.regionsDataView.AllowUserToAddRows = false;
			this.regionsDataView.AllowUserToDeleteRows = false;
			this.regionsDataView.AllowUserToResizeColumns = false;
			this.regionsDataView.AllowUserToResizeRows = false;
			this.regionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.regionsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionColumn});
			this.regionsDataView.Location = new System.Drawing.Point(157, 131);
			this.regionsDataView.MultiSelect = false;
			this.regionsDataView.Name = "regionsDataView";
			this.regionsDataView.ReadOnly = true;
			this.regionsDataView.RowHeadersVisible = false;
			this.regionsDataView.RowTemplate.Height = 21;
			this.regionsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.regionsDataView.Size = new System.Drawing.Size(122, 184);
			this.regionsDataView.TabIndex = 13;
			// 
			// regionColumn
			// 
			this.regionColumn.HeaderText = "地方(Region)";
			this.regionColumn.Name = "regionColumn";
			this.regionColumn.ReadOnly = true;
			this.regionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.regionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
			this.pokedexDataView.Location = new System.Drawing.Point(293, 131);
			this.pokedexDataView.MultiSelect = false;
			this.pokedexDataView.Name = "pokedexDataView";
			this.pokedexDataView.ReadOnly = true;
			this.pokedexDataView.RowHeadersVisible = false;
			this.pokedexDataView.RowTemplate.Height = 21;
			this.pokedexDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.pokedexDataView.Size = new System.Drawing.Size(122, 184);
			this.pokedexDataView.TabIndex = 16;
			// 
			// pokedexColumn
			// 
			this.pokedexColumn.HeaderText = "図鑑(Pokedex)";
			this.pokedexColumn.Name = "pokedexColumn";
			this.pokedexColumn.ReadOnly = true;
			this.pokedexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.pokedexColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// moveLearnMethodDataView
			// 
			this.moveLearnMethodDataView.AllowUserToAddRows = false;
			this.moveLearnMethodDataView.AllowUserToDeleteRows = false;
			this.moveLearnMethodDataView.AllowUserToResizeColumns = false;
			this.moveLearnMethodDataView.AllowUserToResizeRows = false;
			this.moveLearnMethodDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.moveLearnMethodDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moveDataMethodColumn});
			this.moveLearnMethodDataView.Location = new System.Drawing.Point(430, 131);
			this.moveLearnMethodDataView.MultiSelect = false;
			this.moveLearnMethodDataView.Name = "moveLearnMethodDataView";
			this.moveLearnMethodDataView.ReadOnly = true;
			this.moveLearnMethodDataView.RowHeadersVisible = false;
			this.moveLearnMethodDataView.RowTemplate.Height = 21;
			this.moveLearnMethodDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.moveLearnMethodDataView.Size = new System.Drawing.Size(212, 184);
			this.moveLearnMethodDataView.TabIndex = 19;
			// 
			// moveDataMethodColumn
			// 
			this.moveDataMethodColumn.HeaderText = "技の習得方法(MoveLearnMethod)";
			this.moveDataMethodColumn.Name = "moveDataMethodColumn";
			this.moveDataMethodColumn.ReadOnly = true;
			this.moveDataMethodColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.moveDataMethodColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.moveDataMethodColumn.Width = 190;
			// 
			// buttonVersionDetail
			// 
			this.buttonVersionDetail.Location = new System.Drawing.Point(12, 321);
			this.buttonVersionDetail.Name = "buttonVersionDetail";
			this.buttonVersionDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonVersionDetail.TabIndex = 11;
			this.buttonVersionDetail.Text = "詳細";
			this.buttonVersionDetail.UseVisualStyleBackColor = true;
			this.buttonVersionDetail.Click += new System.EventHandler(this.buttonVersionDetail_Click);
			// 
			// buttonRegionDetail
			// 
			this.buttonRegionDetail.Location = new System.Drawing.Point(157, 321);
			this.buttonRegionDetail.Name = "buttonRegionDetail";
			this.buttonRegionDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonRegionDetail.TabIndex = 14;
			this.buttonRegionDetail.Text = "詳細";
			this.buttonRegionDetail.UseVisualStyleBackColor = true;
			this.buttonRegionDetail.Click += new System.EventHandler(this.buttonRegionDetail_Click);
			// 
			// buttonPokedexDetail
			// 
			this.buttonPokedexDetail.Location = new System.Drawing.Point(293, 321);
			this.buttonPokedexDetail.Name = "buttonPokedexDetail";
			this.buttonPokedexDetail.Size = new System.Drawing.Size(39, 24);
			this.buttonPokedexDetail.TabIndex = 17;
			this.buttonPokedexDetail.Text = "詳細";
			this.buttonPokedexDetail.UseVisualStyleBackColor = true;
			this.buttonPokedexDetail.Click += new System.EventHandler(this.buttonPokedexDetail_Click);
			// 
			// buttonMoveLearnMethod
			// 
			this.buttonMoveLearnMethod.Location = new System.Drawing.Point(430, 321);
			this.buttonMoveLearnMethod.Name = "buttonMoveLearnMethod";
			this.buttonMoveLearnMethod.Size = new System.Drawing.Size(39, 24);
			this.buttonMoveLearnMethod.TabIndex = 20;
			this.buttonMoveLearnMethod.Text = "詳細";
			this.buttonMoveLearnMethod.UseVisualStyleBackColor = true;
			// 
			// VersionGroupDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 359);
			this.Controls.Add(this.buttonMoveLearnMethod);
			this.Controls.Add(this.buttonPokedexDetail);
			this.Controls.Add(this.buttonRegionDetail);
			this.Controls.Add(this.buttonVersionDetail);
			this.Controls.Add(this.moveLearnMethodDataView);
			this.Controls.Add(this.pokedexDataView);
			this.Controls.Add(this.regionsDataView);
			this.Controls.Add(this.buttonGenerationDetail);
			this.Controls.Add(this.generationData);
			this.Controls.Add(this.orderData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.idData);
			this.Controls.Add(this.versionDataView);
			this.Controls.Add(moveLearnMethodsCaption);
			this.Controls.Add(pokedexesCaption);
			this.Controls.Add(regionsCaption);
			this.Controls.Add(versionsCaption);
			this.Controls.Add(generationCaption);
			this.Controls.Add(orderCaption);
			this.Controls.Add(nameCaption);
			this.Controls.Add(idCaption);
			this.Name = "VersionGroupDetailForm";
			this.Text = "バージョングループ(VersionGroup)";
			this.Load += new System.EventHandler(this.VersionGroupDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.versionDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.regionsDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokedexDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moveLearnMethodDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView versionDataView;
		private System.Windows.Forms.Label idData;
		private System.Windows.Forms.Label nameData;
		private System.Windows.Forms.Label orderData;
		private System.Windows.Forms.Label generationData;
		private System.Windows.Forms.Button buttonGenerationDetail;
		private System.Windows.Forms.DataGridView regionsDataView;
		private System.Windows.Forms.DataGridView pokedexDataView;
		private System.Windows.Forms.DataGridView moveLearnMethodDataView;
		private System.Windows.Forms.Button buttonVersionDetail;
		private System.Windows.Forms.Button buttonRegionDetail;
		private System.Windows.Forms.Button buttonPokedexDetail;
		private System.Windows.Forms.Button buttonMoveLearnMethod;
		private System.Windows.Forms.DataGridViewTextBoxColumn VersionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn regionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokedexColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn moveDataMethodColumn;
	}
}