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
	/// バージョンリスト画面
	/// </summary>
	public partial class VersionListDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionListDialog()
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
		private void VersionListDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region バージョンリスト 選択変更
		/// <summary>
		/// バージョンリスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void versionDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(versionDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.VersionList.GetURL(nameData.Text);
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
			VersionDetailDialog dialog = new VersionDetailDialog();
			dialog.VersionName = nameData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region バージョンデータの表示
		/// <summary>
		/// バージョンデータの表示
		/// </summary>
		private void ShowData()
		{
			// 一度クリア
			versionDataView.Rows.Clear();

			foreach(string name in Singleton<PokeAPIToolModel>.Instance.VersionList.Names) {
				versionDataView.Rows.Add(name);
			}
		}
		#endregion
	}
}
