using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>フレーバーテキストデータクラス</summary>
	public class FlavorTextData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<FlavorTextData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			foreach(JObject field in fields) {
				list.Add(new FlavorTextData(field));
			}
		}
		#endregion

		// public プロパティ

		#region フレーバーテキスト
		/// <summary>フレーバーテキスト</summary>
		public string FlavorText { get; internal set; } = string.Empty;
		#endregion

		#region　言語
		/// <summary>言語</summary>
		public NamedAPIResourceData Language { get; internal set; } = null;
		#endregion

		#region バージョン
		/// <summary>バージョン</summary>
		public NamedAPIResourceData Version { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public FlavorTextData(JToken token)
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
			FlavorText = (token["flavor_text"] as JValue).ToString();
			Language = new NamedAPIResourceData(token["language"]);
			Version = new NamedAPIResourceData(token["version"]);
		}
		#endregion
	}
}
