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

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected NamedAPIResourceListData apiResourceList = null;
		#endregion

		// protected プロパティ

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected NamedAPIResourceListData APIResourceList => apiResourceList;
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
			ParseNamedAPIResourceListJson(json, ref apiResourceList);
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		protected void Clear()
		{
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
			JArray results = obj["results"] as JArray;
			listData.Results = new List<NamedAPIResourceData>();
			foreach(JObject result in results) {
				listData.Results.Add(ParseNamedAPIResource(result));
			}

			// 次ページがあれば再起呼出
			if(next != null) {
				ParseNamedAPIResourceListJson(RunPokeAPI(next), ref listData);
			}
		}
		#endregion

		#region NameData用フィールドの解析
		/// <summary>
		/// NameData用フィールドの解析
		/// </summary>
		/// <param name="token">Jsonトークンb</param>
		/// <returns>解析データ</returns>
		protected NameData ParseName(JToken token)
		{
			NameData data = new NameData();

			data.Name = (token as JValue).ToString();               // 名称
			data.Language = ParseNamedAPIResource(token["language"]); // 言語ごとの名称

			return data;
		}
		#endregion

		#region NameAPIResourceData用フィールドの解析
		/// <summary>
		/// NameAPIResourceData用フィールドの解析
		/// </summary>
		/// <param name="token">Jsonトークン</param>
		/// <returns>解析データ</returns>
		protected NamedAPIResourceData ParseNamedAPIResource(JToken token)
		{
			NamedAPIResourceData data = new NamedAPIResourceData();

			data.Name = (token["name"] as JValue).ToString();
			data.URL = (token["url"] as JValue).ToString();

			return data;
		}
		#endregion

		#region NamedAPIResourceDataのリスト要素を解析
		/// <summary>
		/// NamedAPIResourceDataのリスト要素を解析
		/// </summary>
		/// <param name="token">Jsonトークン</param>
		/// <param name="name">名称</param>
		/// <param name="datas">解析したデータの格納先</param>
		protected void ParseNamedAPIResourceList(JToken token, string name, List<NamedAPIResourceData> datas)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new Exception($"{name}要素が見つかりません。");
			}

			foreach(JObject field in fields) {
				datas.Add(ParseNamedAPIResource(field));
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
