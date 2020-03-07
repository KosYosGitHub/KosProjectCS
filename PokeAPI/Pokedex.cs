using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑クラス
	/// </summary>
	public class Pokedex : PokeAPIBase
	{
		// public 定数

		#region 全国図鑑
		/// <summary>全国図鑑</summary>
		public const string NameNational = "NATIONAL";
		#endregion

		#region カントー図鑑
		/// <summary>カントー図鑑</summary>
		public const string NameKanto = "KANTO";
		#endregion

		#region ジョウト図鑑
		/// <summary>ジョウト図鑑</summary>
		public const string NameJohto = "ORIGINAL-JOHTO";
		#endregion

		#region ホウエン図鑑
		/// <summary>ホウエン図鑑</summary>
		public const string NameHoenn = "HOENN";
		#endregion

		#region シンオウ図鑑
		/// <summary>シンオウ図鑑</summary>
		public const string NameShinnoh = "ORIGINAL-SHINNOH";
		#endregion

		#region シンオウ図鑑(拡張版)
		/// <summary>シンオウ図鑑(拡張版)</summary>
		public const string NameShinnohExtended = "EXTENDED-SINNOH";
		#endregion

		#region ジョウト図鑑(更新版)
		/// <summary>ジョウト図鑑(更新版)</summary>
		public const string NameJohtoUpdated = "UPDATED-JOHTO";
		#endregion

		#region イッシュ図鑑
		/// <summary>イッシュ図鑑</summary>
		public const string NameUnova = "ORIGINAL-UNOVA";
		#endregion

		#region イッシュ図鑑(更新版)
		/// <summary>イッシュ図鑑(更新版)</summary>
		public const string NameUnovaUpdated = "UPDATED-UNOVA";
		#endregion

		#region conquest-gallery
		/// <summary>conquest-gallery</summary>
		public const string NameConquestGallery = "CONQUEST-GALLERY";
		#endregion

		#region セントラルカロス図鑑
		/// <summary>セントラルカロス図鑑</summary>
		public const string NameKalosCentral = "KALOS-CENTRAL";
		#endregion

		#region コーストカロス図鑑
		/// <summary>コーストカロス図鑑</summary>
		public const string NameKalosCoastal = "KALOS-COASTAL";
		#endregion

		#region マウンテンカロス図鑑
		/// <summary>マウンテンカロス図鑑</summary>
		public const string NameKalosMountain = "KALOS-MOUNTAIN";
		#endregion

		#region ホウエン図鑑(更新版)
		/// <summary>ホウエン図鑑(更新版)</summary>
		public const string NameHoennUpdated = "UPDATED-HOENN";
		#endregion

		#region アローラ図鑑
		/// <summary>アローラ図鑑</summary>
		public const string NameAlola = "ORIGINAL-ALOLA";
		#endregion

		#region メレメレ図鑑
		/// <summary>メレメレ図鑑</summary>
		public const string NameMelemele = "ORIGINAL-MELEMELE";
		#endregion

		#region アーカラ図鑑
		/// <summary>アーカラ図鑑</summary>
		public const string NameAkala = "ORIGINAL-AKALA";
		#endregion

		#region ウラウラ図鑑
		/// <summary>ウラウラ図鑑</summary>
		public const string NameUlaula = "ORIGINAL-ULAULA";
		#endregion

		#region ポニ図鑑
		/// <summary>ポニ図鑑</summary>
		public const string NamePoni = "ORIGINAL-PONI";
		#endregion

		#region アローラ図鑑(更新版)
		/// <summary>アローラ図鑑(更新版)</summary>
		public const string NameAlolaUpdated = "UPDATED-ALOLA";
		#endregion

		#region メレメレ図鑑(更新版)
		/// <summary>メレメレ図鑑(更新版)</summary>
		public const string NameMelemeleUpdated = "UPDATED-MELEMELE";
		#endregion

		#region アーカラ図鑑(更新版)
		/// <summary>アーカラ図鑑(更新版)</summary>
		public const string NameAkalaUpdated = "UPDATED-AKALA";
		#endregion

		#region ウラウラ図鑑(更新版)
		/// <summary>ウラウラ図鑑(更新版)</summary>
		public const string NameUlaulaUpdated = "UPDATED-ULAULA";
		#endregion

		#region ポニ図鑑(更新版)
		/// <summary>ポニ図鑑(更新版)</summary>
		public const string NamePoniUpdated = "UPDATED-PONI";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Pokedex() : base("pokedex")
		{
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			pokedexDataIDKey.Clear();
			pokedexDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region ポケモン図鑑情報取得
		/// <summary>
		/// ポケモン図鑑情報取得
		/// </summary>
		/// <param name="name">ポケモン図鑑名</param>
		public void GetPokedex(string name)
		{
			// ポケモン図鑑リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(pokedexDataNameKey.ContainsKey(name)) {
				return;
			}

			// ポケモン図鑑APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// ポケモン図鑑JSON文字列取得
			string json = RunPokeAPI(url);

			// ポケモン図鑑JSON文字列解析
			ParsePokedexJson(json);
		}
		#endregion

		// private メンバ変数

		#region ポケモン図鑑ディクショナリ(IDキー)
		/// <summary>ポケモン図鑑ディクショナリ(IDキー)</summary>
		private Dictionary<int, PokedexData> pokedexDataIDKey = new Dictionary<int, PokedexData>();
		#endregion

		#region ポケモン図鑑ディクショナリ(Nameキー)
		/// <summary>ポケモン図鑑ディクショナリ(Nameキー)</summary>
		private Dictionary<string, PokedexData> pokedexDataNameKey = new Dictionary<string, PokedexData>();
		#endregion

		// private メソッド

		#region ポケモン図鑑 JSON解析
		/// <summary>
		/// ポケモン図鑑 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParsePokedexJson(string json)
		{
			JObject obj = JObject.Parse(json);
			PokedexData data = new PokedexData();

			data.ID = (int)obj["id"];                               // ID
			data.Name = (obj["name"] as JValue).ToString();         // 名称
			data.IsMainSeries = (bool)obj["is_main_series"];        // メインのポケモン図鑑か
			data.Region = ParseNamedAPIResource(obj["region"]);     // 地方

			// 言語ごとの説明
			data.Descriptions = new List<DescriptionData>();
			ParseDescriptionList(obj, "descriptions", data.Descriptions);

			// 言語ごとの名称
			data.Names = new List<NameData>();
			ParseNameList(obj, "names", data.Names);

			// ポケモン登録情報
			data.PokemonEntries = new List<PokemonEntryData>();
			ParsePokemonEntryDataList(obj, "pokemon_entries", data.PokemonEntries);

			// バージョングループ
			data.VersionGroups = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "version_groups", data.VersionGroups);

			// ディクショナリに追加
			pokedexDataIDKey.Add(data.ID, data);
			pokedexDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion

		#region PokemonEntryData用フィールド解析
		/// <summary>
		/// PokemonEntryData用フィールド解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <returns>解析データ</returns>
		private PokemonEntryData ParsePokemonEntry(JToken token)
		{
			PokemonEntryData data = new PokemonEntryData();

			data.EntryNumber = (int)token["entry_number"];							// ポケモン図鑑番号
			data.PokemonSpecies = ParseNamedAPIResource(token["pokemon_species"]);	// ポケモン

			return data;
		}
		#endregion

		#region PokemonEntryDataのリスト要素を解析
		/// <summary>
		/// PokemonEntryDataのリスト要素を解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="datas">解析したデータの格納先</param>
		protected void ParsePokemonEntryDataList(JToken token, string name, List<PokemonEntryData> datas)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new Exception($"{name}要素が見つかりません。");
			}

			foreach(JObject field in fields) {
				datas.Add(ParsePokemonEntry(field));
			}
		}
		#endregion
	}
}
