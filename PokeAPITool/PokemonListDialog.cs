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
	public partial class PokemonListDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonListDialog()
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
		private void PokemonListDialog_Load(object sender, EventArgs e)
		{
			ShowData();
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
			urlData.Text = Singleton<PokeAPIToolModel>.Instance.PokemonList.GetURL(nameData.Text);
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

			foreach(string name in Singleton<PokeAPIToolModel>.Instance.PokemonList.Names) {
				listDataView.Rows.Add(name);
			}
		}
		#endregion
	}
}
