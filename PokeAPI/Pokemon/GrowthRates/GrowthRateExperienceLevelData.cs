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
	/// レベルに到達するために必要な経験値データ
	/// </summary>
	public class GrowthRateExperienceLevelData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<GrowthRateExperienceLevelData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new GrowthRateExperienceLevelData(field));
			}
		}
		#endregion

		// プロパティ

		#region レベル
		/// <summary>レベル</summary>
		public int Level { get; internal set; } = 0;
		#endregion

		#region 到達するのに必要な経験値
		/// <summary>到達するのに必要な経験値</summary>
		public long Experience { get; internal set; } = 0;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public GrowthRateExperienceLevelData(JToken token)
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
			Level = (int)token["level"];			// レベル
			Experience = (long)token["experience"];	// 必要経験値
		}
		#endregion
	}
}
