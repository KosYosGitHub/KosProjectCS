using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class VersionDetailDialog : Form
	{
		// public プロパティ

		#region バージョン名
		/// <summary>バージョン名</summary>
		public string VersionName { set { versionName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionDetailDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private メンバ変数

		#region バージョン名
		/// <summary>バージョン名</summary>
		private string versionName = string.Empty;
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VersionDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region バージョングループ詳細ボタン クリック
		/// <summary>
		/// バージョングループ詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroupDetail_Click(object sender, EventArgs e)
		{
			VersionGroupDetailDialog dialog = new VersionGroupDetailDialog();
			dialog.VersionGroupName = versionGroupData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		#region 言語詳細ボタン クリック
		/// <summary>
		/// 言語詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLanguageDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(languageNameView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = languageNameView.SelectedRows[0];

			// 選択言語の情報表示
			LanguageDetailDialog dialog = new LanguageDetailDialog();
			dialog.LanguageName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		private void ShowData()
		{
			VersionData data = Singleton<PokeAPIToolModel>.Instance.VersionDetailList.GetVersion(versionName);

			idData.Text = $"{data.ID}";						// ID
			nameData.Text = data.Name;						// 名称
			versionGroupData.Text = data.VersionGroup.Name;	// バージョングループ

			// 言語ごとの名称
			languageNameView.Rows.Clear();
			foreach(NameData language in data.Names) {
				languageNameView.Rows.Add(language.Language.Name, language.Name);
			}
		}
		#endregion
	}
}
