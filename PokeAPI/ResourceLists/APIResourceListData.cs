using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// APIリソースリスト
	/// </summary>
	public class APIResourceListData
	{
		// プロパティ

		#region 利用可能なリソース数
		/// <summary>利用可能なリソース数</summary>
		public int Count { get; internal set; } = 0;
		#endregion

		#region リソースリスト
		/// <summary>リソースリスト</summary>
		public List<APIResourceData> Results { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="json">JSON文字列</param>
		public APIResourceListData(string json)
		{
			ParseList(json);
		}
		#endregion

		// private メソッド

		#region APIリソースリストの解析
		/// <summary>
		/// APIリソースリストの解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <param name="firstCall">初回呼出時true</param>
		private void ParseList(string json, bool firstCall = true)
		{
			// JSON文字列を解析
			JObject obj = JObject.Parse(json);

			// 初回呼出時
			if(firstCall) {
				Count = (int)obj["count"];
			}

			// 次ページのURLを取得
			string next = (obj["next"] as JValue)?.ToString();

			// 結果リストを解析
			Results = new List<APIResourceData>();
			APIResourceData.ParseList(obj, "results", Results);

			// 次ページがあれば再起呼出
			if(!string.IsNullOrEmpty(next)) {
				string nextJson = Singleton<PokeAPIClient>.Instance.GetJson(next);
				ParseList(nextJson, false);
			}
		}
		#endregion
	}
}
