using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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
		/// <summary>日本語</summary>
		public const string NameJapanese = "JA-HRKT";
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
		/// <summary>中国語</summary>
		public const string NameChinese = "ZH-HANT";
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

		// internal プロパティ

		#region 言語APIリスト
		/// <summary>
		/// 言語APIリスト
		/// </summary>
		internal NamedAPIResourceListData LanguageAPIList {
			get { return languageAPIList; }
		}
		#endregion

		// internal 関数

		#region 言語APIリストを取得
		/// <summary>
		/// 言語リストを取得
		/// </summary>
		internal void GetAPIList()
		{
			// 取得済確認
			if(languageAPIList != null) {
				return;
			}

			// 言語リスト用JSON文字列取得
			string json = RunAPICommand("language");

			// 取得したJSON文字列を解析
			ParseNamedAPIResourceListJson(json, ref languageAPIList);
		}
		#endregion

		#region 言語情報取得
		/// <summary>
		/// 言語情報取得
		/// </summary>
		/// <param name="name">言語名</param>
		public void GetLanguage(string name)
		{
			// 言語リストの取得
			GetAPIList();

			// 読込済確認
			if(languageDataNameKey.ContainsKey(name)) {
				return;
			}

			// 言語情報APIリソースURL取得
			string url = languageAPIList.Results.FirstOrDefault(x => x.Name == name)?.URL;
			if(string.IsNullOrEmpty(url)) {
				throw new Exception($"{name}のAPIリソースが見つかりません。");
			}

			// 言語JSON文字列取得
			string json = RunPokeAPI(url);

			// 言語JSON文字列解析
			ParseLanguageJson(json);
		}
		#endregion

		#region 全言語情報取得
		/// <summary>
		/// 全言語情報取得
		/// </summary>
		public void GetLanguageAll()
		{
			// 言語リストの取得
			GetAPIList();

			// 各言語情報の取得
			foreach(NamedAPIResourceData data in languageAPIList.Results) {
				GetLanguage(data.Name);
			}
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		internal void Clear()
		{
			languageAPIList = null;
			languageDataIDKey.Clear();
			languageDataNameKey.Clear();
		}
		#endregion

		// private メンバ変数

		#region 言語APIリスト
		/// <summary>言語APIリスト</summary>
		private NamedAPIResourceListData languageAPIList = null;
		#endregion

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
		private void ParseLanguageJson(string json)
		{
			JObject obj = JObject.Parse(json);
			LanguageData data = new LanguageData();

			data.ID = (int)obj["id"];								// ID
			data.Name = (obj["name"] as JValue).ToString();			// 名称
			data.Official = (bool)obj["official"];					// 公式対応の言語か
			data.ISO639 = (obj["iso639"] as JValue).ToString();		// 言語の使用国2文字コード
			data.ISO3166 = (obj["iso3166"] as JValue).ToString();   // 言語の2文字コード

			// 言語ごとの名称
			JArray names = obj["names"] as JArray;
			data.Names = new List<NameData>();
			foreach(JObject name in names) {
				data.Names.Add(ParseName(name));
			}

			// ディクショナリに追加
			languageDataIDKey.Add(data.ID, data);
			languageDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
