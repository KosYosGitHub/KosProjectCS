using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 性別
	/// </summary>
	public class Gender : PokeAPIBase
	{
		// public 定数

		#region メス
		/// <summary>メス</summary>
		public const string NameFemale = "FEMALE";
		#endregion

		#region オス
		/// <summary>オス</summary>
		public const string NameMale = "MALE";
		#endregion

		#region 性別なし
		/// <summary>性別なし</summary>
		public const string NameGenderless = "GENDERLESS";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Gender() : base("gender")
		{
		}
		#endregion

		#region クリア
		/// <summary>クリア</summary>
		public new void Clear()
		{
			base.Clear();

		}
		#endregion

		// internal メソッド

		#region 性別の取得
		/// <summary>
		/// 性別の取得
		/// </summary>
		/// <param name="name">名称</param>
		public void GetGender(string name)
		{
			// 性別リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(genderDataNameKey.ContainsKey(name)) {
				return;
			}

			// 性別APIリソースURLの取得
			string url = NamedAPIResourceList.GetURL(name);

			// 性別JSON文字列の取得
			string json = RunPokeAPI(url);

			// 性別JSON文字列の解析
			ParseGenderJson(json);
		}
		#endregion

		// private メンバ変数

		#region 性別データ(IDキー)
		/// <summary>性別データ(IDキー)</summary>
		private Dictionary<int, GenderData> genderDataIDKey = new Dictionary<int, GenderData>();
		#endregion

		#region 性別データ(Nameキー)
		/// <summary>性別データ(Nameキー)</summary>
		private Dictionary<string, GenderData> genderDataNameKey = new Dictionary<string, GenderData>();
		#endregion

		// private メソッド

		#region GenderDataの解析
		/// <summary>
		/// GenderDataの解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseGenderJson(string json)
		{
			JObject obj = JObject.Parse(json);

			GenderData data = new GenderData(obj);

			// ディクショナリに追加
			genderDataIDKey.Add(data.ID, data);
			genderDataNameKey.Add(data.Name, data);
		}
		#endregion
	}
}
