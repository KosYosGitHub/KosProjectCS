using System.Collections.Generic;
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
		// public 定数

		#region 日本語
		/// <summary>日本語 仮名</summary>
		public const string NameJapaneseHrkt = "JA-HRKT";
		/// <summary>日本語</summary>
		public const string NameJapanese = "JA";
		#endregion

		#region ローマ字
		/// <summary>ローマ字</summary>
		public const string NameOfficialRoomaji = "ROOMAJI";
		#endregion

		#region 韓国語
		/// <summary>韓国語</summary>
		public const string NameKorean = "KO";
		#endregion

		#region 中国語
		/// <summary>中国語 繁体字</summary>
		public const string NameChineseHant = "ZH-HANT";
		/// <summary>中国語 簡体字</summary>
		public const string NameChineseHans = "ZH-HANS";
		#endregion

		#region フランス語
		/// <summary>フランス語</summary>
		public const string NameFrench = "FR";
		#endregion

		#region ドイツ語
		/// <summary>ドイツ語</summary>
		public const string NameGerman = "DE";
		#endregion

		#region スペイン語
		/// <summary>スペイン語</summary>
		public const string NameSpanish = "ES";
		#endregion

		#region イタリア語
		/// <summary>イタリア語</summary>
		public const string NameItalian = "IT";
		#endregion

		#region 英語
		/// <summary>英語</summary>
		public const string NameEnglish = "EN";
		#endregion

		#region チェコ語
		/// <summary>チェコ語</summary>
		public const string NameCzech = "CS";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Language() : base("language")
		{
		}
		#endregion

		#region 言語情報取得
		/// <summary>
		/// 言語情報取得
		/// </summary>
		/// <param name="name">言語名</param>
		/// <returns>言語情報</returns>
		public LanguageData GetLanguage(string name)
		{
			// APIリソースの取得
			GetNamedAPIResourceList();

			// 読込済確認
			LanguageData data = null;
			if(languageDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// 言語情報APIリソースURL取得
			string url = Singleton<LanguageList>.Instance.GetURL(name);

			// 言語JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 言語JSON文字列解析
			return ParseLanguageJson(json);
		}
		#endregion

		#region 全言語情報取得
		/// <summary>
		/// 全言語情報取得
		/// </summary>
		public void GetLanguageAll()
		{
			foreach(NamedAPIResourceData data in NamedAPIResourceList.Results) {
				GetLanguage(data.Name);
			}
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			languageDataIDKey.Clear();
			languageDataNameKey.Clear();
		}
		#endregion

		// private メンバ変数

		#region 言語ディクショナリ(IDキー)
		/// <summary>言語ディクショナリ(IDキー)</summary>
		private Dictionary<int, LanguageData> languageDataIDKey = new Dictionary<int, LanguageData>();
		#endregion

		#region 言語ディクショナリ(Nameキー)
		/// <summary>言語ディクショナリ(Nameキー)</summary>
		private Dictionary<string, LanguageData> languageDataNameKey = new Dictionary<string, LanguageData>();
		#endregion

		// private メソッド

		#region 言語 JSON解析
		/// <summary>
		/// 言語 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		private LanguageData ParseLanguageJson(string json)
		{
			JObject obj = JObject.Parse(json);

			LanguageData data = new LanguageData(obj);

			// ディクショナリに追加
			languageDataIDKey.Add(data.ID, data);
			languageDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
