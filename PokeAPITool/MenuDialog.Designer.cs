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
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonLanguage);
			this.Name = "Menu";
			this.Text = "PokeAPI ツール";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLanguage;
	}
}

