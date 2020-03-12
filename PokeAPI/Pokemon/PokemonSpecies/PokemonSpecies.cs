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
		public PokemonSpecies() : base(Singleton<PokemonSpeciesList>.Instance)
		{
		}
		#endregion

		#region ポケモン種情報取得
		/// <summary>
		/// ポケモン種情報取得
		/// </summary>
		/// <param name="name">ポケモン種名</param>
		/// <returns>取得データ</returns>
		public PokemonSpeciesData GetPokemonSpecies(string name)
		{
			return GetResource(name) as PokemonSpeciesData;
		}
		#endregion

		// protected メソッド

		#region ポケモン種 JSON解析
		/// <summary>
		/// ポケモン種 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		protected override APIResource ParseJson(string json)
		{
			return new PokemonSpeciesData(JObject.Parse(json));
		}
		#endregion
	}
}
