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
	/// パルパーク エンカウントエリアデータクラス
	/// </summary>
	public class PalParkEncounterAreaData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<PalParkEncounterAreaData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			foreach(JObject field in fields) {
				list.Add(new PalParkEncounterAreaData(field));
			}
		}
		#endregion

		// プロパティ

		#region 基本スコア
		/// <summary>基本スコア</summary>
		public int BaseScore { get; internal set; } = 0;
		#endregion

		#region レート
		/// <summary>レート</summary>
		public int Rate { get; internal set; } = 0;
		#endregion

		#region エリア
		/// <summary>エリア</summary>
		public NamedAPIResourceData Area { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PalParkEncounterAreaData(JToken token)
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
			BaseScore = (int)token["base_score"];
			Rate = (int)token["rate"];
			Area = new NamedAPIResourceData(token["area"]);
		}
		#endregion
	}
}
