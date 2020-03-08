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
	public partial class GenerationListDialog : Form
	{
		public GenerationListDialog()
		{
			InitializeComponent();
		}

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GenerationListDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 世代リスト 選択変更
		/// <summary>
		/// 世代リスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void generationDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(generationDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = generationDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.GenerationList.GetURL(nameData.Text);
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
			GenerationDetailDialog dialog = new GenerationDetailDialog();
			dialog.GenerationName = nameData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region データの表示
		/// <summary>
		/// データの表示
		/// </summary>
		private void ShowData()
		{
			// 一度クリア
			generationDataView.Rows.Clear();

			foreach(string name in Singleton<PokeAPIToolModel>.Instance.GenerationList.Names) {
				generationDataView.Rows.Add(name);
			}
		}
		#endregion

	}
}
