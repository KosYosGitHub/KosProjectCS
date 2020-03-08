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
			// MenuDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonGeneration);
			this.Controls.Add(this.buttonVersion);
			this.Controls.Add(this.buttonVersionGroup);
			this.Controls.Add(this.buttonLanguage);
			this.Name = "MenuDialog";
			this.Text = "PokeAPI ツール";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLanguage;
		private System.Windows.Forms.Button buttonVersionGroup;
		private System.Windows.Forms.Button buttonVersion;
		private System.Windows.Forms.Button buttonGeneration;
	}
}

