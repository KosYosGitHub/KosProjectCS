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
	/// ポケモンの性別データクラス
	/// </summary>
	public class PokemonSpeciesGenderData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PokemonSpeciesGenderData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new Exception($"{name}要素が見つかりません。");
			}

			foreach(JObject field in fields) {
				list.Add(new PokemonSpeciesGenderData(field));
			}
		}
		#endregion

		// プロパティ

		#region 1/8でメスになる確率(性別がない場合は-1)
		/// <summary>1/8でメスになる確率(性別がない場合は-1)</summary>
		public int Rate { get; internal set; } = -1;
		#endregion

		#region ポケモン
		/// <summary>ポケモン</summary>
		public NamedAPIResourceData PokemonSpecies { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PokemonSpeciesGenderData(JToken token)
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
			Rate = (int)token["rate"];												// 1/8でメスになる確率
			PokemonSpecies = new NamedAPIResourceData(token["pokemon_species"]);	// ポケモン
		}
		#endregion
	}
}
