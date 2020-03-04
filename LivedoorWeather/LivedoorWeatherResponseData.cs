using System;
using System.Collections.Generic;

namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather WebServiceのレスポンスフィールドクラス
	/// </summary>
	public class LivedoorWeatherResponseData
	{
		/// <summary>天気予報発表日時</summary>
		public DateTime PublicTime { get; internal set; } = new DateTime();

		/// <summary>タイトル・見出し</summary>
		public string Title { get; internal set; } = string.Empty;

		/// <summary>リクエストされたデータの地域に該当するlivedoor 天気情報のURL</summary>
		public string Link { get; internal set; } = string.Empty;

		/// <summary>予報を発表した地域</summary>
		public LivedoorWeatherResponseLocationData Location { get; internal set; } = null;

		/// <summary>天気概況</summary>
		public LivedoorWeatherResponseDescriptionData Description { get; internal set; } = null;

		/// <summary>府県天気予報の予報日毎の情報</summary>
		public List<LivedoorWeatherResponseForecastData> Forecasts { get; } = new List<LivedoorWeatherResponseForecastData>();

		/// <summary>ピンポイkンと予報の発表地点</summary>
		public List<LivedoorWeatherResponsePinpointLocationData> PinpointLocation { get; } = new List<LivedoorWeatherResponsePinpointLocationData>();

		/// <summary>著作権情報</summary>
		public LivedoorWeatherResponseCopryrightData Copyright { get; internal set; } = null;
	}

}
