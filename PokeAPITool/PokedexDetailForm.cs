using System;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// ポケモン図鑑詳細フォーム
	/// </summary>
	public partial class PokedexDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokedexDetailForm(string titleText, string apiName) : base(titleText, apiName)
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
		private void PokedexDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 地方ボタン クリック
		/// <summary>
		/// 地方ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRegion_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region 言語ごとの名称 詳細ボタン クリック
		/// <summary>
		/// 言語ごとの名称 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonNameLanguageDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region 言語ごとの説明 詳細ボタン
		/// <summary>
		/// 言語ごとの説明 詳細ボタン
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDescriptionLanguageDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region バージョングループ 詳細ボタン
		/// <summary>
		/// バージョングループ 詳細ボタン
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroupDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		protected override void ShowData()
		{
			base.ShowData();

			PokedexData data = Singleton<PokeAPIToolModel>.Instance.PokedexDetailList.GetPokedex(apiName);

			idData.Text = $"{data.ID}";
			nameData.Text = data.Name;
			isMainSeriesData.Text = $"{data.IsMainSeries}";
			regionData.Text = data.Region.Name;

			// ポケモン
			pokemonDataView.Rows.Clear();
			foreach(PokemonEntryData entry in data.PokemonEntries) {
				pokemonDataView.Rows.Add($"{entry.EntryNumber}", entry.PokemonSpecies.Name);
			}

			// 言語ごとの名称
			namesDataView.Rows.Clear();
			foreach(NameData language in data.Names) {
				namesDataView.Rows.Add(language.Language.Name, language.Name);
			}

			// 言語ごとの説明
			descriptionsDataView.Rows.Clear();
			foreach(DescriptionData language in data.Descriptions) {
				descriptionsDataView.Rows.Add(language.Language.Name, language.Description);
			}

			// バージョングループ
			versionGroupDataView.Rows.Clear();
			foreach(NamedAPIResourceData versionGroup in data.VersionGroups) {
				versionGroupDataView.Rows.Add(versionGroup.Name);
			}
		}
		#endregion
	}
}
