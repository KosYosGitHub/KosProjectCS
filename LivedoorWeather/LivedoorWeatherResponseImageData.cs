namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド アイコン情報クラス
	/// </summary>
	public class LivedoorWeatherResponseImageData
	{
		/// <summary>天気</summary>
		public string Title { get; internal set; } = string.Empty;

		/// <summary>天気アイコンのURL</summary>
		public string Url { get; internal set; } = string.Empty;

		/// <summary>天気アイコンの幅</summary>
		public int Width { get; internal set; } = 0;

		/// <summary>天気アイコンの高さ</summary>
		public int Height { get; internal set; } = 0;
	}
}
