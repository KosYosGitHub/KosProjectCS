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
	/// ポケモンタイプデータクラス
	/// </summary>
	public class TypePokemonData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<TypePokemonData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new TypePokemonData(field));
			}
		}
		#endregion

		// プロパティ

		#region タイプのスロット
		/// <summary>タイプのスロット</summary>
		public int Slot { get; internal set; } = 0;
		#endregion

		#region ポケモン
		/// <summary>ポケモン</summary>
		public NamedAPIResourceData Pokemon { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public TypePokemonData(JToken token)
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
			Slot = (int)token["slot"];								// タイプのスロット
			Pokemon = new NamedAPIResourceData(token["pokemon"]);	// ポケモン
		}
		#endregion
	}
}
