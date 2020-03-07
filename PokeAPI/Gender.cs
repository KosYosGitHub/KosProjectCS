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
	/// 性別
	/// </summary>
	public class Gender : PokeAPIBase
	{
		// public 定数

		#region メス
		/// <summary>メス</summary>
		public const string NameFemale = "FEMALE";
		#endregion

		#region オス
		/// <summary>オス</summary>
		public const string NameMale = "MALE";
		#endregion

		#region 性別なし
		/// <summary>性別なし</summary>
		public const string NameGenderless = "GENDERLESS";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Gender() : base("gender")
		{
		}
		#endregion

		#region クリア
		/// <summary>クリア</summary>
		public new void Clear()
		{
			base.Clear();

		}
		#endregion

		// internal メソッド

		#region 性別の取得
		/// <summary>
		/// 性別の取得
		/// </summary>
		/// <param name="name">名称</param>
		public void GetGender(string name)
		{
			// 性別リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(genderDataNameKey.ContainsKey(name)) {
				return;
			}

			// 性別APIリソースURLの取得
			string url = NamedAPIResourceList.GetURL(name);

			// 性別JSON文字列の取得
			string json = RunPokeAPI(url);

			// 性別JSON文字列の解析
			ParseGenderJson(json);
		}
		#endregion

		// private メンバ変数

		#region 性別データ(IDキー)
		/// <summary>性別データ(IDキー)</summary>
		private Dictionary<int, GenderData> genderDataIDKey = new Dictionary<int, GenderData>();
		#endregion

		#region 性別データ(Nameキー)
		/// <summary>性別データ(Nameキー)</summary>
		private Dictionary<string, GenderData> genderDataNameKey = new Dictionary<string, GenderData>();
		#endregion

		// private メソッド

		#region GenderDataの解析
		/// <summary>
		/// GenderDataの解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseGenderJson(string json)
		{
			JObject obj = JObject.Parse(json);
			GenderData data = new GenderData();

			data.ID = (int)obj["id"];
			data.Name = (obj["name"] as JValue).ToString();

			// ポケモン詳細
			data.PokemonSpeciesDetails = new List<PokemonSpeciesGenderData>();
			ParsePokemonSpeciesGenderList(obj, "pokemon_species_details", data.PokemonSpeciesDetails);

			// 進化するために性別が条件になっているポケモン
			data.RequiredForEvolution = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "required_for_evolution", data.RequiredForEvolution);

			// ディクショナリに追加
			genderDataIDKey.Add(data.ID, data);
			genderDataNameKey.Add(data.Name, data);
		}
		#endregion

		#region PokemonSpeciesGenderのリスト要素を解析
		/// <summary>
		/// PokemonSpeciesGenderのリスト要素を解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="datas">解析したデータの格納先</param>
		private void ParsePokemonSpeciesGenderList(JToken token, string name, List<PokemonSpeciesGenderData> datas)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new Exception($"{name}要素が見つかりません。");
			}

			foreach(JObject field in fields) {
				datas.Add(ParsePokemonSpeciesGender(field));
			}
		}
		#endregion

		#region PokemonSpeciesGender 解析
		/// <summary>
		/// PokemonSpeciesGender 解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <returns>解析データ</returns>
		private PokemonSpeciesGenderData ParsePokemonSpeciesGender(JToken token)
		{
			PokemonSpeciesGenderData data = new PokemonSpeciesGenderData();

			data.Rate = (int)token["rate"];											// 1/8でメスになる確率
			data.PokemonSpecies = ParseNamedAPIResource(token["pokemon_species"]);	// ポケモン

			return data;
		}
		#endregion
	}
}
