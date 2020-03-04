using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Service クラス
	/// </summary>
	public class LivedoorWeatherService
	{
		// private 定数

		#region Livedoor Weather Web Service リクエストURL
		/// <summary>
		/// Livedoor Weather Web Service リクエストURL
		/// </summary>
		private const string LWWS_REQUEST_URL = "http://weather.livedoor.com/forecast/webservice/json/v1?city={0}";
		#endregion

		// public プロパティ

		#region livedoor Weather Web Serviceから取得したデータ
		/// <summary>livedoor Weather Web Serviceから取得したデータ</summary>
		public LivedoorWeatherResponseData LivedoorWeatherData { get; private set; } = null;
		#endregion

		// private プロパティ

		#region LWWSサービスから取得したJson文字列
		/// <summary>
		/// LWWSサービスから取得したJson文字列
		/// </summary>
		public string LwwsJsonText { get; set; } = string.Empty;
		// ToDo: 動作確認のため、一時的にpublicにしている。
		#endregion


		// コンストラクタ

		#region デフォルトコンストラクタ
		/// <summary>
		/// デフォルトコンストラクタ
		/// </summary>
		public LivedoorWeatherService()
		{
		}
		#endregion

		// public メソッド

		#region 天気予報情報の読込
		/// <summary>
		/// 天気予報情報の読込
		/// </summary>
		/// <returns></returns>
		public bool LoadWeatherInfo()
		{
			string json;

			json = ConnectLWWS("230010");

			ReadLWWSResponseData(json);

			return true;		// ToDo:とりあえず(例外処理にするなら戻り値voidになるかも？)
		}
		#endregion

		// private メソッド

		#region LWWSサービスへ接続
		/// <summary>
		/// LWWSサービスへ接続
		/// </summary>
		/// <param name="cityCode">全国の地点定義表 1次細分区</param>
		/// <returns>レスポンスフィールド情報(Json)</returns>
		private string ConnectLWWS(string cityCode)
		{
			// LWWSサービスURLに1次細分区を埋め込み
			string lwwsUrl = string.Format(LWWS_REQUEST_URL, cityCode);

			// LWWSにGET要求を送信して、Jsonデータを取得
			return Singleton<HttpClient>.Instance.GetStringAsync(lwwsUrl).Result;
		}
		#endregion

		/// <summary>
		/// LWWSから取得したレスポンスフィールドデータを読込
		/// </summary>
		/// <param name="responseData">レスポンスフィールドデータ</param>
		private void ReadLWWSResponseData(string responseData)
		{
			//---
			// 気が向いたらDataContractJsonSerializerを使った形で書き換える！！！
			//---

			// レスポンスフィールドデータを解析
			JObject obj = JObject.Parse(responseData);

			this.LivedoorWeatherData = new LivedoorWeatherResponseData();

			this.LivedoorWeatherData.Title = (obj["title"] as JValue).ToString();
			this.LivedoorWeatherData.Link = (obj["link"] as JValue).ToString();
			this.LivedoorWeatherData.PublicTime = DateTime.Parse((obj["publicTime"] as JValue).ToString());

			// 地域情報
			JToken location = obj["location"];
			this.LivedoorWeatherData.Location = new LivedoorWeatherResponseLocationData();

			this.LivedoorWeatherData.Location.Area = (location["area"] as JValue).ToString();
			this.LivedoorWeatherData.Location.Prefecture = (location["prefecture"] as JValue).ToString();
			this.LivedoorWeatherData.Location.City = (location["city"] as JValue).ToString();

			// 天気概状文
			JToken desc = obj["description"];
			this.LivedoorWeatherData.Description = new LivedoorWeatherResponseDescriptionData();
			this.LivedoorWeatherData.Description.Text = (desc["text"] as JValue).ToString();
			this.LivedoorWeatherData.Description.PublicTime = DateTime.Parse((desc["publicTime"] as JValue).ToString());

			// 日ごとの情報
			for(int i = 0; i < 3; i++) {
				this.LivedoorWeatherData.Forecasts.Add(ReadForecastData(obj, i));
			}

			// ToDo: PinpointLocationとCopyrightがまだ
		}

		private LivedoorWeatherResponseForecastData ReadForecastData(JObject obj, int index)
		{
			LivedoorWeatherResponseForecastData data = new LivedoorWeatherResponseForecastData();
			JToken today = obj["forecasts"][index];

			data.Date = DateTime.Parse((today["date"] as JValue).ToString());
			data.DateLabel = (today["dateLabel"] as JValue).ToString();
			data.Telop = (today["telop"] as JValue).ToString();
			data.Image = new LivedoorWeatherResponseImageData();
			data.Image.Title = (today["image"]["title"] as JValue).ToString();
			data.Image.Url = (today["image"]["url"] as JValue).ToString();
			data.Image.Width = (int)today["image"]["width"];
			data.Image.Height = (int)today["image"]["height"];
			data.Temperature = new LivedoorWeatherResponseForecastTemperatureData();

			JToken max = today["temperature"]["max"];
			if(!(max is JValue)) {
				data.Temperature.MaxCelsius = (int)max["celsius"];
				data.Temperature.MaxFahrenheit = (double)max["fahrenheit"];
			}
			JToken min = today["temperature"]["min"];
			if(!(min is JValue)) {
				data.Temperature.MinCelsius = (int)max["celsius"];
				data.Temperature.MinFahrenheit = (double)max["fahrenheit"];
			}

			return data;
		}

	}
}
