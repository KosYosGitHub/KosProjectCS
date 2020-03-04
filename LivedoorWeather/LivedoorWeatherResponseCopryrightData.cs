namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather WebServiceのレスポンスフィールド 著作権情報クラス
	/// </summary>
	public class LivedoorWeatherResponseCopryrightData
	{
		/// <summary>コピーライトの文言</summary>
		public string Title { get; internal set; } = string.Empty;

		/// <summary>livedoor 天気情報のURL</summary>
		public string Link { get; internal set; } = string.Empty;

		/// <summary>livedoor 天気情報への　URL、アイコンなど</summary>
		public LivedoorWeatherResponseImageData Image { get; internal set; } = null;
	}
}
