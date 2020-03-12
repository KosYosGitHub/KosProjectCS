using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 言語情報クラス
	/// </summary>
	public class LanguageData : APIResource
	{
		// プロパティ

		#region ゲーム上で公開されている言語か
		/// <summary>ゲーム上で公開されている言語か</summary>
		public bool Official { get; internal set; } = false;
		#endregion

		#region 言語が使用されている国の2文字コード
		/// <summary>言語が使用されている国の2文字コード</summary>
		public string ISO639 { get; internal set; } = string.Empty;
		#endregion

		#region 言語の2文字コード
		/// <summary>言語の2文字コード</summary>
		public string ISO3166 { get; internal set; } = string.Empty;
		#endregion

		#region 各言語での名称
		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public LanguageData(JToken token)
		{
			Parse(token);
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public void Parse(JToken token)
		{
			ID = (int)token["id"];								// ID
			Name = (token["name"] as JValue).ToString();		// 名称
			Official = (bool)token["official"];					// 公式対応の言語か
			ISO639 = (token["iso639"] as JValue).ToString();	// 言語の使用国2文字コード
			ISO3166 = (token["iso3166"] as JValue).ToString();	// 言語の2文字コード

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);
		}
		#endregion
	}
}
