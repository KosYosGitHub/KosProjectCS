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

namespace PokeAPITool
{
	/// <summary>
	/// 言語リスト画面
	/// </summary>
	public partial class LanguageListDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageListDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LanguageList_Load(object sender, EventArgs e)
		{
			// 言語名称設定
			ShowLanguageListData();
		}
		#endregion

		#region 言語リスト 選択変更
		/// <summary>
		/// 言語リスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void languageDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(languageDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = languageDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.LanguageList.GetURL(nameData.Text);
		}
		#endregion

		#region 詳細ボタン クリック
		/// <summary>
		/// 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void detailButton_Click(object sender, EventArgs e)
		{
			LanguageDetailDialog dialog = new LanguageDetailDialog();

			dialog.LanguageName = nameData.Text;

			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		/// <summary>
		/// 言語リストデータの表示
		/// </summary>
		private void ShowLanguageListData()
		{
			// 一度クリア
			languageDataView.Rows.Clear();

			// 言語名称設定
			foreach(string name in Singleton<PokeAPIToolModel>.Instance.LanguageList.Names) {
				languageDataView.Rows.Add(name);
			}
		}
	}
}
