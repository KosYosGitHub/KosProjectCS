using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// ポケモン(大分類)データクラス
	/// </summary>
	public class PokemonSpeciesData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PokemonSpeciesData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new PokemonSpeciesData(field));
			}
		}
		#endregion

		// public プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region ソート順番
		/// <summary>ソート順番</summary>
		public int Order { get; internal set; } = 0;
		#endregion

		#region 1/8でメスになる確率(-1は性別なし)
		/// <summary>1/8でメスになる確率(-1は性別なし)</summary>
		public int GenderRate { get; internal set; } = -1;
		#endregion

		#region ゲットしやすさ
		/// <summary>ゲットしやすさ</summary>
		public int CaptureRate { get; internal set; } = 0;
		#endregion

		#region 基本幸福度
		/// <summary>基本幸福度</summary>
		public int BaseHappiness { get; internal set; } = 0;
		#endregion

		#region 赤ちゃんポケモンか
		/// <summary>赤ちゃんポケモンか</summary>
		public bool IsBaby { get; internal set; } = false;
		#endregion

		#region 孵化歩数
		/// <summary>孵化歩数</summary>
		public int HatchCounter { get; internal set; } = 0;
		#endregion

		#region 性別で視覚的な差があるか
		/// <summary>性別で視覚的な差があるか</summary>
		public bool HasGenderDifferences { get; internal set; } = false;
		#endregion

		#region フォルムの変更がありえるか
		/// <summary>フォルムの変更がありえるか</summary>
		public bool FormsSwitchable { get; internal set; } = false;
		#endregion

		#region 成長率
		/// <summary>成長率</summary>
		public NamedAPIResourceData GrowthRate { get; internal set; } = null;
		#endregion

		#region ポケモン図鑑番号
		/// <summary>ポケモン図鑑番号</summary>
		public List<PokemonSpeciesDexEntryData> PokedexNumbers { get; internal set; } = null;
		#endregion

		#region 卵グループ
		/// <summary>卵グループ</summary>
		public List<NamedAPIResourceData> EggGroups { get; internal set; } = null;
		#endregion

		#region 色
		/// <summary>色</summary>
		public NamedAPIResourceData Color { get; internal set; } = null;
		#endregion

		#region ポケモンの形
		/// <summary>ポケモンの形</summary>
		public NamedAPIResourceData Shape { get; internal set; } = null;
		#endregion

		#region 進化元ポケモン
		/// <summary>進化元ポケモン</summary>
		public NamedAPIResourceData EvolvesFromSpecies { get; internal set; } = null;
		#endregion

		#region 進化ルート
		/// <summary>進化ルート</summary>
		public APIResourceData EvolutionChain { get; internal set; } = null;
		#endregion

		#region 生息地
		/// <summary>生息地</summary>
		public NamedAPIResourceData Habitat { get; internal set; } = null;
		#endregion

		#region 世代
		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;
		#endregion

		#region 言語ごとの名称
		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region パルパークのエンカウントエリア
		/// <summary>パルパークのエンカウントエリア</summary>
		public List<PalParkEncounterAreaData> PalParkEncounters { get; internal set; } = null;
		#endregion

		#region フレーバーテキスト
		/// <summary>フレーバーテキスト</summary>
		public List<FlavorTextData> FlavorTextEntries { get; internal set; } = null;
		#endregion

		#region フォルム説明
		/// <summary>フォルム説明</summary>
		public List<DescriptionData> FormDescriptions { get; internal set; } = null;
		#endregion

		#region 種族
		/// <summary>種族</summary>
		public List<GenusData> Genera { get; internal set; } = null;
		#endregion

		#region バリエーション
		/// <summary>バリエーション</summary>
		public List<PokemonSpeciesVariety> Varieties { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PokemonSpeciesData(JToken token)
		{
			Parse(token);
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public void Parse(JToken token)
		{
			ID = (int)token["id"];																// ID
			Name = (token["name"] as JValue).ToString();										// 名称
			Order = (int)token["order"];														// ソート順番
			GenderRate = (int)token["gender_rate"];												// 1/8でメスになる確率
			CaptureRate = (int)token["capture_rate"];											// ゲットしやすさ
			BaseHappiness = (int)token["base_happiness"];										// 基本幸福度
			IsBaby = (bool)token["is_baby"];													// 赤ちゃんポケモンか
			HatchCounter = (int)token["hatch_counter"];											// 孵化歩数
			HasGenderDifferences = (bool)token["has_gender_differences"];						// 性別で視覚的な差があるか
			FormsSwitchable = (bool)token["forms_switchable"];									// フォルムの変更がありえるか
			GrowthRate = new NamedAPIResourceData(token["growth_rate"]);						// 成長率
			Color = new NamedAPIResourceData(token["color"]);									// ポケモンの色
			Shape = new NamedAPIResourceData(token["shape"]);									// ポケモンの形
			EvolvesFromSpecies = new NamedAPIResourceData(token["evolves_from_species"]);		// 進化元ポケモン
			EvolutionChain = new APIResourceData(token["evolution_chain"]);						// 進化ルート
			Habitat = new NamedAPIResourceData(token["habitat"]);								// 生息地
			Generation = new NamedAPIResourceData(token["generation"]);							// 世代

			// ポケモン図鑑番号
			PokedexNumbers = new List<PokemonSpeciesDexEntryData>();
			PokemonSpeciesDexEntryData.ParseList(token, "pokedex_numbers", PokedexNumbers);

			// 卵グループ
			EggGroups = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "egg_groups", EggGroups);

			// 言語との名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);

			// パルパークのエンカウントエリア
			PalParkEncounters = new List<PalParkEncounterAreaData>();
			PalParkEncounterAreaData.ParseList(token, "pal_park_encounters", PalParkEncounters);

			// フレーバーテキスト
			FlavorTextEntries = new List<FlavorTextData>();
			FlavorTextData.ParseList(token, "flavor_text_entries", FlavorTextEntries);

			// フォルムの説明
			FormDescriptions = new List<DescriptionData>();
			DescriptionData.ParseList(token, "form_descriptions", FormDescriptions);

			// 種族
			Genera = new List<GenusData>();
			GenusData.ParseList(token, "genera", Genera);

			// バリエーション
			Varieties = new List<PokemonSpeciesVariety>();
			PokemonSpeciesVariety.ParseList(token, "varieties", Varieties);
		}
		#endregion
	}
}
