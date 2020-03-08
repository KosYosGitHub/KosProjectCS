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
	/// ポケモン バリエーションデータクラス
	/// </summary>
	public class PokemonSpeciesVariety
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PokemonSpeciesVariety> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new PokemonSpeciesVariety(field));
			}
		}
		#endregion

		// public プロパティ

		#region デフォルト
		/// <summary>デフォルトか</summary>
		public bool IsDefault { get; internal set; } = false;
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
		public PokemonSpeciesVariety(JToken token)
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
			IsDefault = (bool)token["is_default"];
			Pokemon = new NamedAPIResourceData(token["pokemon"]);
		}
		#endregion
	}
}
