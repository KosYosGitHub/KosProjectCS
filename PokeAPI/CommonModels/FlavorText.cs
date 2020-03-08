using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI.CommonModels
{
	/// <summary>味テキストデータクラス</summary>
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
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new FlavorTextData(field));
			}
		}
		#endregion

		// public プロパティ

		#region 味テキスト
		/// <summary>味テキスト</summary>
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
		}
		#endregion
	}
}
