namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather Web Servie レスポンスフィールド ピンポイント予報の発表地点クラス
	/// </summary>
	public class LivedoorWeatherResponsePinpointLocationData
	{
		/// <summary>市区町村名</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>対応するlivedoor 天気情報のURL</summary>
		public string Link { get; internal set; } = string.Empty;
	}
}
