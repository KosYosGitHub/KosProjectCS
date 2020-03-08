using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>性別データクラス</summary>
	public class GenderData
	{
		// プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region ポケモンごとの詳細
		/// <summary>ポケモンごとの詳細</summary>
		public List<PokemonSpeciesGenderData> PokemonSpeciesDetails { get; internal set; } = null;
		#endregion

		#region 進化するためにこの性別が条件になっているポケモン
		/// <summary>進化するためにこの性別が条件になっているポケモン</summary>
		public List<NamedAPIResourceData> RequiredForEvolution { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public GenderData(JToken token)
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
		private void Parse(JToken token)
		{
			ID = (int)token["id"];
			Name = (token["name"] as JValue).ToString();

			// ポケモン詳細
			PokemonSpeciesDetails = new List<PokemonSpeciesGenderData>();
			PokemonSpeciesGenderData.ParseList(token, "pokemon_species_details", PokemonSpeciesDetails);

			// 進化するために性別が条件になっているポケモン
			RequiredForEvolution = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "required_for_evolution", RequiredForEvolution);
		}
		#endregion
	}
}
