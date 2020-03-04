using System.Runtime.Serialization;

namespace LivedoorWeather
{
	/// <summary>
	/// Livedoor Weather WebServiceのレスポンスフィールド 著作権情報 気象データ配信元クラス
	/// </summary>
	public class LivedoorWeatherResponseCopyrightProviderData
	{
		/// <summary>気象データ配信元 名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>気象データ配信元 URL</summary>
		public string Link { get; internal set; } = string.Empty;
	}
}
