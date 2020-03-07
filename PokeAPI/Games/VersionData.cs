using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// バージョンデータクラス
	/// </summary>
	public class VersionData
	{
		// プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region 各言語の名称
		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region バージョングループ
		/// <summary>バージョングループ</summary>
		public NamedAPIResourceData VersionGroup { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public VersionData(JToken token)
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
			ID = (int)token["id"];							// ID
			Name = (token["name"] as JValue).ToString();	// 名称
			VersionGroup = new NamedAPIResourceData(token);	// バージョングループ

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);
		}
		#endregion
	}
}
