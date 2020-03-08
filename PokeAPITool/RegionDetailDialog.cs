using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// 地方詳細ダイアログ
	/// </summary>
	public partial class RegionDetailDialog : Form
	{
		// public プロパティ

		#region 地方名
		/// <summary>地方名</summary>
		public string RegionName { set { regionName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RegionDetailDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private メンバ変数

		#region 地方名
		/// <summary>地方名</summary>
		private string regionName = string.Empty;
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RegionDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		private void ShowData()
		{
			RegionData data = Singleton<PokeAPIToolModel>.Instance.RegionDetailList.GetRegion(regionName);

			idData.Text = $"{data.ID}";							// ID
			nameData.Text = data.Name;							// 名称
			mainGenerationData.Text = data.MainGeneration.Name;	// 主な世代

			// 言語ごとの名称
			namesDataView.Rows.Clear();
			foreach(NameData language in data.Names) {
				namesDataView.Rows.Add(language.Language.Name, language.Name);
			}

			// 場所
			locationDataView.Rows.Clear();
			foreach(NamedAPIResourceData location in data.Locations) {
				locationDataView.Rows.Add(location.Name);
			}

			// 図鑑
			pokedexDataView.Rows.Clear();
			foreach(NamedAPIResourceData pokedex in data.Pokedexes) {
				pokedexDataView.Rows.Add(pokedex.Name);
			}

			// バージョングループ
			versionGroupDataView.Rows.Clear();
			foreach(NamedAPIResourceData versionGroup in data.VersionGroups) {
				versionGroupDataView.Rows.Add(versionGroup.Name);
			}
		}
		#endregion

		#region 主な世代詳細ボタン クリック
		/// <summary>
		/// 主な世代詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGenerationDetail_Click(object sender, EventArgs e)
		{
			GenerationDetailDialog dialog = new GenerationDetailDialog();
			dialog.GenerationName = mainGenerationData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		#region 地方詳細ボタン クリック
		/// <summary>
		/// 地方詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroupDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(versionGroupDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionGroupDataView.SelectedRows[0];

			// 選択情報表示
			VersionGroupDetailDialog dialog = new VersionGroupDetailDialog();
			dialog.VersionGroupName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		#region 言語詳細ボタン クリック
		/// <summary>
		/// 言語詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonNamesDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(namesDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = namesDataView.SelectedRows[0];

			// 選択言語の情報表示
			LanguageDetailDialog dialog = new LanguageDetailDialog();
			dialog.LanguageName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion
	}
}
