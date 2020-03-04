namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド 府県天気予報の予報日毎の情報 気温クラス
	/// </summary>
	public class LivedoorWeatherResponseForecastTemperatureData
	{
		/// <summary>
		/// 最低気温 摂氏
		/// </summary>
		public int? MinCelsius { get; internal set; } = null;

		/// <summary>
		/// 最高気温 摂氏
		/// </summary>
		public int? MaxCelsius { get; internal set; } = null;

		/// <summary>
		/// 最低気温 華氏
		/// </summary>
		public double? MinFahrenheit { get; internal set; } = null;

		/// <summary>
		/// 最高気温 華氏
		/// </summary>
		public double? MaxFahrenheit { get; internal set; } = null;
	}
}
