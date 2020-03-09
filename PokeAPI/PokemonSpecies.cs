using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------


namespace PokeAPI
{
	/// <summary>
	/// ポケモン種
	/// </summary>
	public class PokemonSpecies : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpecies() : base("pokemon-species")
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
			pokemonSpeciesDataIDKey.Clear();
			pokemonSpeciesDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region ポケモン種情報取得
		/// <summary>
		/// ポケモン種情報取得
		/// </summary>
		/// <param name="name">ポケモン種名</param>
		/// <returns>取得データ</returns>
		public PokemonSpeciesData GetPokemonSpecies(string name)
		{
			// ポケモン種リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			PokemonSpeciesData data;
			if(pokemonSpeciesDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// ポケモン種APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// ポケモン種JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// ポケモン種JSON文字列解析
			return ParsePokemonSpeciesJson(json);
		}
		#endregion

		// private メンバ変数

		#region ポケモン種ディクショナリ(IDキー)
		/// <summary>ポケモン種ディクショナリ(IDキー)</summary>
		private Dictionary<int, PokemonSpeciesData> pokemonSpeciesDataIDKey = new Dictionary<int, PokemonSpeciesData>();
		#endregion

		#region ポケモン種ディクショナリ(Nameキー)
		/// <summary>ポケモン種ディクショナリ(Nameキー)</summary>
		private Dictionary<string, PokemonSpeciesData> pokemonSpeciesDataNameKey = new Dictionary<string, PokemonSpeciesData>();
		#endregion

		// private メソッド

		#region ポケモン種 JSON解析
		/// <summary>
		/// ポケモン種 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private PokemonSpeciesData ParsePokemonSpeciesJson(string json)
		{
			JObject obj = JObject.Parse(json);

			PokemonSpeciesData data = new PokemonSpeciesData(obj);

			// ディクショナリに追加
			pokemonSpeciesDataIDKey.Add(data.ID, data);
			pokemonSpeciesDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
