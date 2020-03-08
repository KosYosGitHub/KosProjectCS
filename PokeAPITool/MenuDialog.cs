﻿using System;
using System.Windows.Forms;

namespace PokeAPITool
{
	public partial class MenuDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MenuDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private イベント

		#region 言語ボタン クリック
		/// <summary>
		/// 言語ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLanguage_Click(object sender, EventArgs e)
		{
			LanguageListDialog dialog = new LanguageListDialog();

			dialog.ShowDialog(this);
		}
		#endregion

		#region バージョングループボタン クリック
		/// <summary>
		/// バージョングループボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroup_Click(object sender, EventArgs e)
		{
			VersionGroupListDialog dialog = new VersionGroupListDialog();

			dialog.ShowDialog(this);
		}
		#endregion
	}
}
