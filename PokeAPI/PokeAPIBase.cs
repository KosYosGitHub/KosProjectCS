using System;
using System.Collections.Generic;
using System.Net.Http;
using Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// PokeAPI 基本用クラス
	/// </summary>
	public abstract class PokeAPIBase
	{
		// protected メンバ変数

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		protected NamedAPIResourceListData namedAPIResourceList = null;
		#endregion

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected APIResourceListData apiResourceList = null;
		#endregion

		// protected プロパティ

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		protected NamedAPIResourceListData NamedAPIResourceList => namedAPIResourceList;
		#endregion

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected APIResourceListData APIResourceList => apiResourceList;
		#endregion

		// protected メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="apiEndPoint">APIエンドポイント</param>
		protected PokeAPIBase(string apiEndPoint)
		{
			this.apiEndPoint = apiEndPoint;
		}
		#endregion

		#region 名前付きAPIリソースの取得
		/// <summary>
		/// 名前付きAPIリソースの取得
		/// </summary>
		protected void GetNamedAPIResourceList()
		{
			// 取得済確認
			if(namedAPIResourceList != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = RunAPICommand(apiEndPoint);

			// 取得したJSON文字列を解析
			ParseNamedAPIResourceListJson(json, ref namedAPIResourceList);
		}
		#endregion

		#region APIリソースの取得
		/// <summary>
		/// APIリソースの取得
		/// </summary>
		protected void GetAPIResourceList()
		{
			// 取得済確認
			if(apiResourceList != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = RunAPICommand(apiEndPoint);

			// 取得したJSON文字列を解析
			ParseAPIResourceListJson(json, ref apiResourceList);
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		protected void Clear()
		{
			namedAPIResourceList = null;
			apiResourceList = null;
		}
		#endregion

		#region PokeAPIサーバーに接続し、Jsonリソース取得
		/// <summary>
		/// PokeAPIサーバーに接続し、Jsonリソース取得
		/// </summary>
		/// <param name="apiCommand">APIコマンド</param>
		/// <returns></returns>
		protected string RunAPICommand(string apiCommand)
		{
			// GET要求を送信して、Jsonデータを取得
			return RunPokeAPI($"https://pokeapi.co/api/v2/{apiCommand}");
		}
		#endregion

		#region PokeAPIにGET要求を送信しJSON文字列を取得
		/// <summary>
		/// PokeAPIにGET要求を送信しJSON文字列を取得
		/// </summary>
		/// <param name="url">GET要求を送信するURL</param>
		/// <returns>取得したJSON文字列</returns>
		protected string RunPokeAPI(string url)
		{
			return Singleton<HttpClient>.Instance.GetStringAsync(url).Result;
		}
		#endregion

		#region NamedAPIResourceListモデルのJSONを解析
		/// <summary>
		/// NamedAPIResourceListモデルのJSONを解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <param name="listData">解析データ</param>
		protected void ParseNamedAPIResourceListJson(string json, ref NamedAPIResourceListData listData)
		{
			// JSON文字列を解析
			JObject obj = JObject.Parse(json);

			// リストが存在しない(初回呼出時)はインスタンス化
			if(listData == null) {
				listData = new NamedAPIResourceListData();
				listData.Count = (int)obj["count"];
			}

			// 次ページのURLを取得
			string next = (obj["next"] as JValue)?.ToString();

			// 結果リストを解析
			listData.Results = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(obj, "results", listData.Results);

			// 次ページがあれば再起呼出
			if(next != null) {
				ParseNamedAPIResourceListJson(RunPokeAPI(next), ref listData);
			}
		}
		#endregion

		#region APIResourceListモデルのJSONを解析
		/// <summary>
		/// APIResourceListモデルのJSONを解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <param name="listData">解析データ</param>
		protected void ParseAPIResourceListJson(string json, ref APIResourceListData listData)
		{
			// JSON文字列を解析
			JObject obj = JObject.Parse(json);

			// リストが存在しない(初回呼出時)はインスタンス化
			if(listData == null) {
				listData = new APIResourceListData();
				listData.Count = (int)obj["count"];
			}

			// 次ページのURLを取得
			string next = (obj["next"] as JValue)?.ToString();

			// 結果リストを解析
			listData.Results = new List<APIResourceData>();
			APIResourceData.ParseList(obj, "results", listData.Results);

			// 次ページがあれば再起呼出
			if(next != null) {
				ParseAPIResourceListJson(RunPokeAPI(next), ref listData);
			}
		}
		#endregion

		// private メンバ変数

		#region APIエンドポイント
		/// <summary>APIエンドポイント</summary>
		string apiEndPoint = null;
		#endregion
	}
}
