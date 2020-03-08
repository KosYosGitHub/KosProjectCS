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
	/// ポケモン図鑑登録データクラス
	/// </summary>
	public class PokemonEntryData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PokemonEntryData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new PokemonEntryData(field));
			}
		}
		#endregion

		// プロパティ

		#region ポケモン図鑑番号
		/// <summary>ポケモン図鑑番号</summary>
		public int EntryNumber { get; internal set; } = 0;
		#endregion

		#region ポケモン
		/// <summary>
		/// ポケモン
		/// </summary>
		public NamedAPIResourceData PokemonSpecies { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PokemonEntryData(JToken token)
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
			EntryNumber = (int)token["entry_number"];
			PokemonSpecies = new NamedAPIResourceData(token["pokemon_species"]);
		}
		#endregion
	}
}
