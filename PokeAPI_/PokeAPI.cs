using System;

namespace PokeAPI
{
	/// <summary>
	/// PokeAPI 接続用クラス
	/// </summary>
	public class PokeAPIConnection
	{
		// private 定数

		#region PokeAPI リクエストURL
		/// <summary>
		/// PokeAPI リクエストURL
		/// </summary>
		private const string POKE_API_REQUEST_URL = "https://pokeapi.co/api/v2/{0}";
		#endregion

		// public 関数

		public string Connect(string command)
		{
			// GET要求用URL作成
			string url = string.Format(POKE_API_REQUEST_URL, command);

			// LWWSにGET要求を送信して、Jsonデータを取得
			return Singleton<HttpClient>.Instance.GetStringAsync(url).Result;
		}

	}
}
