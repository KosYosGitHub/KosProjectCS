using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class GenerationDetailDialog : Form
	{
		// public プロパティ

		#region 世代名
		/// <summary>世代名</summary>
		public string GenerationName { set { generationName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GenerationDetailDialog()
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
		private void GenerationDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 主な地方ボタン クリック
		/// <summary>
		/// 主な地方ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMainRegionCaption_Click(object sender, EventArgs e)
		{
			RegionDetailDialog dialog = new RegionDetailDialog();
			dialog.RegionName = mainRegionData.Text;
			dialog.Show(this);
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
			// 対象行確認
			if(versionGroupDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionGroupDataView.SelectedRows[0];

			// 選択言語の情報表示
			VersionGroupDetailDialog dialog = new VersionGroupDetailDialog();
			dialog.VersionGroupName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		#region 言語詳細 クリック
		/// <summary>
		/// 言語詳細 クリック
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

		// private メンバ変数

		#region 世代名
		/// <summary>世代名</summary>
		private string generationName = string.Empty;
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		private void ShowData()
		{
			GenerationData data = Singleton<PokeAPIToolModel>.Instance.GenerationDetailList.GetGeneration(generationName);

			idData.Text = $"{data.ID}";					// ID
			nameData.Text = data.Name;					// 名称
			mainRegionData.Text = data.MainRegion.Name; // 主な地方

			// ポケモン
			pokemonDataView.Rows.Clear();
			foreach(NamedAPIResourceData pokemon in data.PokemonSpecies) {
				pokemonDataView.Rows.Add(pokemon.Name);
			}

			// 技
			moveDataView.Rows.Clear();
			foreach(NamedAPIResourceData move in data.Moves) {
				moveDataView.Rows.Add(move.Name);
			}

			// 特性
			abilityDataView.Rows.Clear();
			foreach(NamedAPIResourceData ability in data.Abilities) {
				abilityDataView.Rows.Add(ability.Name);
			}

			// バージョングループ
			versionGroupDataView.Rows.Clear();
			foreach(NamedAPIResourceData versionGroup in data.VersionGroups) {
				versionGroupDataView.Rows.Add(versionGroup.Name);
			}

			// タイプ
			typeDataView.Rows.Clear();
			foreach(NamedAPIResourceData type in data.Types) {
				typeDataView.Rows.Add(type.Name);
			}

			// 言語ごとの名称
			languageNameView.Rows.Clear();
			foreach(NameData language in data.Names) {
				languageNameView.Rows.Add(language.Language.Name, language.Name);
			}
		}
		#endregion
	}
}
