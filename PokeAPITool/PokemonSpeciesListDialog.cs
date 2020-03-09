using System;
using System.Windows.Forms;
using Generic;

namespace PokeAPITool
{
	/// <summary>
	/// ポケモン種リスト画面
	/// </summary>
	public partial class PokemonSpeciesListDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpeciesListDialog()
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
		private void PokemonSpeciesListDialog_Load(object sender, EventArgs e)
		{
			ShowData();
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
			listDataView.Rows.Clear();

			foreach(string name in Singleton<PokeAPIToolModel>.Instance.PokemonSpeciesList.Names) {
				listDataView.Rows.Add(name);
			}
		}
		#endregion

		#region リスト 選択変更
		/// <summary>
		/// リスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(listDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = listDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.PokemonSpeciesList.GetURL(nameData.Text);
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
			PokemonSpeciesDetailDialog dialog = new PokemonSpeciesDetailDialog();
			dialog.PokemonSpeciesName = nameData.Text;
			dialog.ShowDialog(this);
		}
		#endregion
	}
}
