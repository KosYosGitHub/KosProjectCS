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
	/// 性格によって影響を受けるステータス
	/// </summary>
	public class NatureStatChangeData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<NatureStatChangeData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new NatureStatChangeData(field));
			}
		}
		#endregion

		// プロパティ

		#region 影響の最大値
		/// <summary>影響の最大値</summary>
		public int MaxChange { get; internal set; } = 0;
		#endregion

		#region ステータス
		/// <summary>ステータス</summary>
		public NamedAPIResourceData PokeathlonState { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public NatureStatChangeData(JToken token)
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
			MaxChange = (int)token["max_change"];									// 影響の最大値
			PokeathlonState = new NamedAPIResourceData(token["pokeathlon_stat"]);	// ステータス
		}
		#endregion
	}
}
