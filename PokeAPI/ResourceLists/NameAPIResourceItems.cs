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
	/// 名前付きAPIリソースリスト
	/// </summary>
	public class NamedAPIResourceItems : APIResourceItesmBase
	{
		// プロパティ
		#region リソースリスト
		/// <summary>リソースリスト</summary>
		public List<NamedAPIResourceData> Results { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="json">JSON文字列</param>
		public NamedAPIResourceItems(string json) : base(json)
		{
		}
		#endregion

		#region APIリソースのURLを取得
		/// <summary>
		/// APIリソースのURLを取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>URL</returns>
		public string GetURL(string name)
		{
			string url = Results.FirstOrDefault(x => x.Name == name)?.URL;
			if(string.IsNullOrEmpty(url)) {
				throw new ArgumentException("APIリソースが見つかりません。", name);
			}

			return url;
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="obj">JSONオブジェクト</param>
		/// <param name="name">名称</param>
		protected override void Parse(JObject obj, string name)
		{
			if(Results == null) {
				Results = new List<NamedAPIResourceData>();
			}

			NamedAPIResourceData.ParseList(obj, "results", Results);
		}
		#endregion
	}
}
