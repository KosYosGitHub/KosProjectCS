﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 卵グループデータ
	/// </summary>
	public class EggGroupData : APIResource
	{
		// プロパティ

		#region 各言語での名称
		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region ポケモンリスト
		/// <summary>ポケモンリスト</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public EggGroupData(JToken token)
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
			ID = (int)token["id"];							// ID
			Name = (token["name"] as JValue).ToString();	// 名称

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);

			// ポケモン
			PokemonSpecies = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "pokemon_species", PokemonSpecies);
		}
		#endregion
	}
}
