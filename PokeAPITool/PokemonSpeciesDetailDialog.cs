using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class PokemonSpeciesDetailDialog : Form
	{
		// public プロパティ

		#region ポケモン種名
		/// <summary>ポケモン種名</summary>
		public string PokemonSpeciesName { set { pokemonSpeciesName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpeciesDetailDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private メンバ変数

		#region ポケモン種名
		/// <summary>ポケモン種名</summary>
		private string pokemonSpeciesName = string.Empty;
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PokemonSpeciesDetailDialog_Load(object sender, EventArgs e)
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
			PokemonSpeciesData data = Singleton<PokeAPIToolModel>.Instance.PokemonSpeciesDetailList.GetPokemonSpecies(pokemonSpeciesName);

			idData.Text = $"{data.ID}";                                     // ID
			nameData.Text = data.Name;                                      // 名称
			orderData.Text = $"{data.Order}";                               // ソート順番
			generationData.Text = data.Generation.Name;                     // 世代
			genderRateData.Text = $"{data.GenderRate}";                     // 性別レート
			captureRateData.Text = $"{data.CaptureRate}";                   // ゲットしやすさ
			baseHappinessData.Text = $"{data.BaseHappiness}";               // 基本幸福度
			isBabyData.Text = $"{data.IsBaby}";                             // 赤ちゃんポケモン
			hatchCounterData.Text = $"{255 * (data.HatchCounter + 1)}";         // 孵化歩数
			hasGenderDeferencesData.Text = $"{data.HasGenderDifferences}";  // 視覚的性別差
			formsSwitableData.Text = $"{data.FormsSwitchable}";             // フォルム変更がありえるか
			growthRateData.Text = data.GrowthRate.Name;                     // 成長率
			colorData.Text = data.Color.Name;                               // 色
			shapeData.Text = data.Shape.Name;                               // 形
			evolvesFromSpeciesData.Text = data.EvolvesFromSpecies.Name;     // 進化元
			habitatData.Text = data.Habitat.Name;                           // 生息地

			// 言語ごとの名称
			languageNameView.Rows.Clear();
			foreach(NameData language in data.Names) {
				languageNameView.Rows.Add(language.Language.Name, language.Name);
			}

			// 言語ごとの種族
			generaDataView.Rows.Clear();
			foreach(GenusData genera in data.Genera) {
				generaDataView.Rows.Add(genera.Language.Name, genera.Genus);
			}

			// ポケモン図鑑番号
			pokedexNumbersDataView.Rows.Clear();
			foreach(PokemonSpeciesDexEntryData pokedexNo in data.PokedexNumbers) {
				pokedexNumbersDataView.Rows.Add(pokedexNo.Pokedex.Name, $"{pokedexNo.EntryNumber}");
			}

			// 卵グループ
			eggGroupDataView.Rows.Clear();
			foreach(NamedAPIResourceData eggGroup in data.EggGroups) {
				eggGroupDataView.Rows.Add($"{eggGroup.Name}");
			}

			// パルパークのエンカウントエリア
			palParkEncountersDataView.Rows.Clear();
			foreach(PalParkEncounterAreaData area in data.PalParkEncounters) {
				palParkEncountersDataView.Rows.Add(area.Area.Name, $"{area.BaseScore}", $"{area.Rate}");
			}

			// フレーバーテキスト
			flavorTextDataView.Rows.Clear();
			foreach(FlavorTextData text in data.FlavorTextEntries) {
				flavorTextDataView.Rows.Add(text.FlavorText, text.Language.Name, text.Version.Name);
			}

			// フォルム説明
			formDescriptionsDataView.Rows.Clear();
			foreach(DescriptionData desc in data.FormDescriptions) {
				formDescriptionsDataView.Rows.Add(desc.Language.Name, desc.Description);
			}

			// バリエーション
			varietyDataView.Rows.Clear();
			foreach(PokemonSpeciesVariety variety in data.Varieties) {
				varietyDataView.Rows.Add(variety.Pokemon.Name, $"{variety.IsDefault}");
			}
		}
		#endregion
	}
}
