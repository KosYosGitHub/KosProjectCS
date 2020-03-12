using System;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// APIリソースリストアイテムクラス
	/// </summary>
	public class APIResourceItesmBase
	{
		// protected 自動プロパティ

		#region リソース数
		/// <summary>リソース数</summary>
		protected int Count { get; set; } = 0;
		#endregion

		// protected メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="json">JSON文字列</param>
		protected APIResourceItesmBase(string json)
		{
			ParseList(json);
		}
		#endregion

		#region JSONリストの解析
		/// <summary>
		/// JSONリストの解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <param name="firstCall">初回呼出</param>
		protected void ParseList(string json, bool firstCall = true)
		{
			// JSONの解析
			JObject obj = JObject.Parse(json);

			// 初回呼出時
			if(firstCall) {
				// リソース件数
				Count = (int)obj["count"];
			}

			// 次ページのURL取得
			string next = (obj["next"] as JValue).ToString();

			// 結果リストを解析
			Parse(obj, "results");

			// 次のページがあれば呼出
			if(!string.IsNullOrEmpty(next)) {
				string nextJson = Singleton<PokeAPIClient>.Instance.GetJson(next);

				ParseList(nextJson, false);
			}
		}
		#endregion

		#region JSON文字列の解析
		/// <summary>
		/// JSON文字列の解析
		/// </summary>
		/// <param name="obj">JSONオブジェクト</param>
		/// <param name="name">名称</param>
		protected virtual void Parse(JObject obj, string name)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
