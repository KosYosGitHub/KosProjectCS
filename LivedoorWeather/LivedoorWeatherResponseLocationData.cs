namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド 地域クラス
	/// </summary>
	public class LivedoorWeatherResponseLocationData
	{
		/// <summary>地方名</summary>
		public string Area { get; internal set; } = string.Empty;

		/// <summary>都道府県名</summary>
		public string Prefecture { get; internal set; } = string.Empty;

		/// <summary>１次細分区名</summary>
		public string City { get; internal set; } = string.Empty;
	}
}
