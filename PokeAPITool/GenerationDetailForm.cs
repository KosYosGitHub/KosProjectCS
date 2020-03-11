using System;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// 世代詳細画面
	/// </summary>
	public partial class GenerationDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GenerationDetailForm(string titleText, string apiName) : base(titleText, apiName)
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

			GenerationData data = Singleton<PokeAPIToolModel>.Instance.GenerationDetailList.GetGeneration(apiName);

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
