using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 言語クラス
	/// </summary>
	public class Language : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Language() : base(Singleton<LanguageList>.Instance)
		{
		}
		#endregion

		#region 言語取得
		/// <summary>
		/// 言語取得
		/// </summary>
		/// <param name="name">言語名</param>
		/// <returns>言語</returns>
		public LanguageData GetLanguage(string name)
		{
			return GetResource(name) as LanguageData;
		}
		#endregion

		// protected メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new LanguageData(JObject.Parse(json));
		}
		#endregion
	}
}
