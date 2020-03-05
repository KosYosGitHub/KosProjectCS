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
		// protected メソッド

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

		// private メソッド

		#region NameAPIResourceData用フィールドの解析
		/// <summary>
		/// NameAPIResourceData用フィールドの解析
		/// </summary>
		/// <param name="token">Jsonトークン</param>
		/// <returns>解析データ</returns>
		private NamedAPIResourceData ParseNamedAPIResource(JToken token)
		{
			NamedAPIResourceData data = new NamedAPIResourceData();

			data.Name = (token["name"] as JValue).ToString();
			data.URL = (token["url"] as JValue).ToString();

			return data;
		}
		#endregion
	}
}
