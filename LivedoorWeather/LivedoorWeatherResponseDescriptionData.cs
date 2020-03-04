using System;

namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド 天気概況文クラス
	/// </summary>
	public class LivedoorWeatherResponseDescriptionData
	{
		/// <summary>天気概況文</summary>
		public string Text { get; internal set; } = string.Empty;

		/// <summary>天気概況文の発表時刻</summary>
		public DateTime PublicTime { get; internal set; } = DateTime.Now;
	}
}
