using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// APIリソースデータ
	/// </summary>
	public class NamedAPIResourceData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<NamedAPIResourceData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			foreach(JObject field in fields) {
				list.Add(new NamedAPIResourceData(field));
			}
		}
		#endregion

		// プロパティ

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region URL
		/// <summary>URL</summary>
		public string URL { get; internal set; } = string.Empty;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public NamedAPIResourceData(JToken token)
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
			if(token.HasValues) {
				Name = (token["name"] as JValue).ToString();
				URL = (token["url"] as JValue).ToString();
			}
		}
		#endregion
	}
}
