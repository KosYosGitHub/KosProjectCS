using System;
using System.Windows.Forms;
using Generic;

namespace PokeAPITool
{
	/// <summary>
	/// バージョングループリスト画面
	/// </summary>
	public partial class VersionGroupListDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroupListDialog()
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
		private void VersionGroupListDialog_Load(object sender, EventArgs e)
		{
			ShowVersionGroupListData();
		}
		#endregion

		#region バージョングループリスト 選択変更
		/// <summary>
		/// バージョングループリスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void versionGroupDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(versionGroupDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionGroupDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.VersionGroupList.GetURL(nameData.Text);
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
			VersionGroupDetailDialog dialog = new VersionGroupDetailDialog();
			dialog.VersionGroupName = nameData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region バージョングループデータの表示
		/// <summary>
		/// バージョングループデータの表示
		/// </summary>
		private void ShowVersionGroupListData()
		{
			// 一度クリア
			versionGroupDataView.Rows.Clear();

			foreach(string name in Singleton<PokeAPIToolModel>.Instance.VersionGroupList.Names) {
				versionGroupDataView.Rows.Add(name);
			}
		}
		#endregion
	}
}
