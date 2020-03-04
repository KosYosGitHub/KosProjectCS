using System;

namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド 府県天気予報の予報日毎の情報クラス
	/// </summary>
	public class LivedoorWeatherResponseForecastData
	{
		// public プロパティ

		/// <summary>予報日</summary>
		public DateTime Date { get; internal set; } = DateTime.Today;

		/// <summary>予報日(今日/明日/明後日)</summary>
		public string DateLabel { get; internal set; } = string.Empty;

		/// <summary>天気</summary>
		public string Telop { get; internal set; } = string.Empty;

		/// <summary>天気アイコン</summary>
		public LivedoorWeatherResponseImageData Image { get; internal set; } = null;

		/// <summary>気温</summary>
		public LivedoorWeatherResponseForecastTemperatureData Temperature { get; internal set; } = null;
	}
}
