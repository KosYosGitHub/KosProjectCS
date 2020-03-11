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
	/// 登録されている図鑑データ
	/// </summary>
	public class PokemonSpeciesDexEntryData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PokemonSpeciesDexEntryData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			foreach(JObject field in fields) {
				list.Add(new PokemonSpeciesDexEntryData(field));
			}
		}
		#endregion

		// public プロパティ

		#region 図鑑番号
		/// <summary>図鑑番号</summary>
		public int EntryNumber { get; internal set; } = 0;
		#endregion

		#region ポケモン図鑑
		/// <summary>ポケモン図鑑</summary>
		public NamedAPIResourceData Pokedex { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PokemonSpeciesDexEntryData(JToken token)
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
			Pokedex = new NamedAPIResourceData(token["pokedex"]);
		}
		#endregion
	}
}
