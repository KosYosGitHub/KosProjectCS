namespace PokeAPITool
{
	partial class MenuDialog
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonLanguage = new System.Windows.Forms.Button();
			this.buttonVersionGroup = new System.Windows.Forms.Button();
			this.buttonVersion = new System.Windows.Forms.Button();
			this.buttonGeneration = new System.Windows.Forms.Button();
			this.buttonRegion = new System.Windows.Forms.Button();
			this.butonPokedex = new System.Windows.Forms.Button();
			this.buttonPokemonSpecies = new System.Windows.Forms.Button();
			this.buttonItem = new System.Windows.Forms.Button();
			this.buttonPokemon = new System.Windows.Forms.Button();
			this.buttonLocation = new System.Windows.Forms.Button();
			this.buttonLocationArea = new System.Windows.Forms.Button();
			this.buttonPalParkArea = new System.Windows.Forms.Button();
			this.buttonItemAttribute = new System.Windows.Forms.Button();
			this.buttonItemCategory = new System.Windows.Forms.Button();
			this.buttonItemPocket = new System.Windows.Forms.Button();
			this.buttonMachine = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonLanguage
			// 
			this.buttonLanguage.Location = new System.Drawing.Point(13, 13);
			this.buttonLanguage.Name = "buttonLanguage";
			this.buttonLanguage.Size = new System.Drawing.Size(80, 35);
			this.buttonLanguage.TabIndex = 0;
			this.buttonLanguage.Text = "言語";
			this.buttonLanguage.UseVisualStyleBackColor = true;
			this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
			// 
			// buttonVersionGroup
			// 
			this.buttonVersionGroup.Location = new System.Drawing.Point(99, 13);
			this.buttonVersionGroup.Name = "buttonVersionGroup";
			this.buttonVersionGroup.Size = new System.Drawing.Size(80, 35);
			this.buttonVersionGroup.TabIndex = 1;
			this.buttonVersionGroup.Text = "バージョン\r\nグループ";
			this.buttonVersionGroup.UseVisualStyleBackColor = true;
			this.buttonVersionGroup.Click += new System.EventHandler(this.buttonVersionGroup_Click);
			// 
			// buttonVersion
			// 
			this.buttonVersion.Location = new System.Drawing.Point(185, 13);
			this.buttonVersion.Name = "buttonVersion";
			this.buttonVersion.Size = new System.Drawing.Size(80, 35);
			this.buttonVersion.TabIndex = 2;
			this.buttonVersion.Text = "バージョン";
			this.buttonVersion.UseVisualStyleBackColor = true;
			this.buttonVersion.Click += new System.EventHandler(this.buttonVersion_Click);
			// 
			// buttonGeneration
			// 
			this.buttonGeneration.Location = new System.Drawing.Point(13, 54);
			this.buttonGeneration.Name = "buttonGeneration";
			this.buttonGeneration.Size = new System.Drawing.Size(80, 35);
			this.buttonGeneration.TabIndex = 3;
			this.buttonGeneration.Text = "世代";
			this.buttonGeneration.UseVisualStyleBackColor = true;
			this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
			// 
			// buttonRegion
			// 
			this.buttonRegion.Location = new System.Drawing.Point(99, 54);
			this.buttonRegion.Name = "buttonRegion";
			this.buttonRegion.Size = new System.Drawing.Size(80, 35);
			this.buttonRegion.TabIndex = 4;
			this.buttonRegion.Text = "地方";
			this.buttonRegion.UseVisualStyleBackColor = true;
			this.buttonRegion.Click += new System.EventHandler(this.buttonRegion_Click);
			// 
			// butonPokedex
			// 
			this.butonPokedex.Location = new System.Drawing.Point(13, 95);
			this.butonPokedex.Name = "butonPokedex";
			this.butonPokedex.Size = new System.Drawing.Size(80, 35);
			this.butonPokedex.TabIndex = 8;
			this.butonPokedex.Text = "ポケモン図鑑";
			this.butonPokedex.UseVisualStyleBackColor = true;
			this.butonPokedex.Click += new System.EventHandler(this.butonPokedex_Click);
			// 
			// buttonPokemonSpecies
			// 
			this.buttonPokemonSpecies.Location = new System.Drawing.Point(99, 95);
			this.buttonPokemonSpecies.Name = "buttonPokemonSpecies";
			this.buttonPokemonSpecies.Size = new System.Drawing.Size(80, 35);
			this.buttonPokemonSpecies.TabIndex = 9;
			this.buttonPokemonSpecies.Text = "ポケモン種";
			this.buttonPokemonSpecies.UseVisualStyleBackColor = true;
			this.buttonPokemonSpecies.Click += new System.EventHandler(this.buttonPokemonSpecies_Click);
			// 
			// buttonItem
			// 
			this.buttonItem.Location = new System.Drawing.Point(12, 136);
			this.buttonItem.Name = "buttonItem";
			this.buttonItem.Size = new System.Drawing.Size(80, 35);
			this.buttonItem.TabIndex = 11;
			this.buttonItem.Text = "アイテム";
			this.buttonItem.UseVisualStyleBackColor = true;
			this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
			// 
			// buttonPokemon
			// 
			this.buttonPokemon.Location = new System.Drawing.Point(185, 95);
			this.buttonPokemon.Name = "buttonPokemon";
			this.buttonPokemon.Size = new System.Drawing.Size(80, 35);
			this.buttonPokemon.TabIndex = 10;
			this.buttonPokemon.Text = "ポケモン";
			this.buttonPokemon.UseVisualStyleBackColor = true;
			this.buttonPokemon.Click += new System.EventHandler(this.buttonPokemon_Click);
			// 
			// buttonLocation
			// 
			this.buttonLocation.Location = new System.Drawing.Point(185, 54);
			this.buttonLocation.Name = "buttonLocation";
			this.buttonLocation.Size = new System.Drawing.Size(80, 35);
			this.buttonLocation.TabIndex = 5;
			this.buttonLocation.Text = "場所";
			this.buttonLocation.UseVisualStyleBackColor = true;
			this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
			// 
			// buttonLocationArea
			// 
			this.buttonLocationArea.Location = new System.Drawing.Point(271, 54);
			this.buttonLocationArea.Name = "buttonLocationArea";
			this.buttonLocationArea.Size = new System.Drawing.Size(80, 35);
			this.buttonLocationArea.TabIndex = 6;
			this.buttonLocationArea.Text = "場所エリア";
			this.buttonLocationArea.UseVisualStyleBackColor = true;
			this.buttonLocationArea.Click += new System.EventHandler(this.buttonLocationArea_Click);
			// 
			// buttonPalParkArea
			// 
			this.buttonPalParkArea.Location = new System.Drawing.Point(357, 54);
			this.buttonPalParkArea.Name = "buttonPalParkArea";
			this.buttonPalParkArea.Size = new System.Drawing.Size(80, 35);
			this.buttonPalParkArea.TabIndex = 7;
			this.buttonPalParkArea.Text = "パルパーク\r\nエリア";
			this.buttonPalParkArea.UseVisualStyleBackColor = true;
			this.buttonPalParkArea.Click += new System.EventHandler(this.buttonPalParkArea_Click);
			// 
			// buttonItemAttribute
			// 
			this.buttonItemAttribute.Location = new System.Drawing.Point(99, 136);
			this.buttonItemAttribute.Name = "buttonItemAttribute";
			this.buttonItemAttribute.Size = new System.Drawing.Size(80, 35);
			this.buttonItemAttribute.TabIndex = 12;
			this.buttonItemAttribute.Text = "アイテム属性";
			this.buttonItemAttribute.UseVisualStyleBackColor = true;
			this.buttonItemAttribute.Click += new System.EventHandler(this.buttonItemAttribute_Click);
			// 
			// buttonItemCategory
			// 
			this.buttonItemCategory.Location = new System.Drawing.Point(185, 136);
			this.buttonItemCategory.Name = "buttonItemCategory";
			this.buttonItemCategory.Size = new System.Drawing.Size(80, 35);
			this.buttonItemCategory.TabIndex = 13;
			this.buttonItemCategory.Text = "アイテム\r\nカテゴリ";
			this.buttonItemCategory.UseVisualStyleBackColor = true;
			this.buttonItemCategory.Click += new System.EventHandler(this.buttonItemCategory_Click);
			// 
			// buttonItemPocket
			// 
			this.buttonItemPocket.Location = new System.Drawing.Point(271, 136);
			this.buttonItemPocket.Name = "buttonItemPocket";
			this.buttonItemPocket.Size = new System.Drawing.Size(80, 35);
			this.buttonItemPocket.TabIndex = 14;
			this.buttonItemPocket.Text = "アイテム\r\nポケット";
			this.buttonItemPocket.UseVisualStyleBackColor = true;
			this.buttonItemPocket.Click += new System.EventHandler(this.buttonItemPocket_Click);
			// 
			// buttonMachine
			// 
			this.buttonMachine.Location = new System.Drawing.Point(357, 136);
			this.buttonMachine.Name = "buttonMachine";
			this.buttonMachine.Size = new System.Drawing.Size(80, 35);
			this.buttonMachine.TabIndex = 15;
			this.buttonMachine.Text = "技マシン";
			this.buttonMachine.UseVisualStyleBackColor = true;
			this.buttonMachine.Click += new System.EventHandler(this.buttonMachine_Click);
			// 
			// MenuDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.buttonMachine);
			this.Controls.Add(this.buttonItemPocket);
			this.Controls.Add(this.buttonItemCategory);
			this.Controls.Add(this.buttonItemAttribute);
			this.Controls.Add(this.buttonPalParkArea);
			this.Controls.Add(this.buttonLocationArea);
			this.Controls.Add(this.buttonLocation);
			this.Controls.Add(this.buttonPokemon);
			this.Controls.Add(this.buttonItem);
			this.Controls.Add(this.buttonPokemonSpecies);
			this.Controls.Add(this.butonPokedex);
			this.Controls.Add(this.buttonRegion);
			this.Controls.Add(this.buttonGeneration);
			this.Controls.Add(this.buttonVersion);
			this.Controls.Add(this.buttonVersionGroup);
			this.Controls.Add(this.buttonLanguage);
			this.Name = "MenuDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PokeAPI ツール";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLanguage;
		private System.Windows.Forms.Button buttonVersionGroup;
		private System.Windows.Forms.Button buttonVersion;
		private System.Windows.Forms.Button buttonGeneration;
		private System.Windows.Forms.Button buttonRegion;
		private System.Windows.Forms.Button butonPokedex;
		private System.Windows.Forms.Button buttonPokemonSpecies;
		private System.Windows.Forms.Button buttonItem;
		private System.Windows.Forms.Button buttonPokemon;
		private System.Windows.Forms.Button buttonLocation;
		private System.Windows.Forms.Button buttonLocationArea;
		private System.Windows.Forms.Button buttonPalParkArea;
		private System.Windows.Forms.Button buttonItemAttribute;
		private System.Windows.Forms.Button buttonItemCategory;
		private System.Windows.Forms.Button buttonItemPocket;
		private System.Windows.Forms.Button buttonMachine;
	}
}

