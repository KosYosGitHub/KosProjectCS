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
	/// バージョングループクラス
	/// </summary>
	public class VersionGroup : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroup() : base("version-group")
		{
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			versionGroupDataIDKey.Clear();
			versionGroupDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region バージョングループ情報取得
		/// <summary>
		/// バージョングループ情報取得
		/// </summary>
		/// <param name="name">バージョングループ名</param>
		/// <returns>データ</returns>
		public VersionGroupData GetVersionGroup(string name)
		{
			// バージョングループリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			VersionGroupData data = null;
			if(versionGroupDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// バージョングループAPIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// バージョングループJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// バージョングループJSON文字列解析
			return ParseVersionGroupJson(json);
		}
		#endregion

		// private メンバ変数

		#region バージョングループディクショナリ(IDキー)
		/// <summary>バージョングループディクショナリ(IDキー)</summary>
		private Dictionary<int, VersionGroupData> versionGroupDataIDKey = new Dictionary<int, VersionGroupData>();
		#endregion

		#region バージョングループディクショナリ(Nameキー)
		/// <summary>バージョングループディクショナリ(Nameキー)</summary>
		private Dictionary<string, VersionGroupData> versionGroupDataNameKey = new Dictionary<string, VersionGroupData>();
		#endregion

		// private メソッド

		#region バージョングループ JSON解析
		/// <summary>
		/// バージョングループ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		private VersionGroupData ParseVersionGroupJson(string json)
		{
			JObject obj = JObject.Parse(json);

			VersionGroupData data = new VersionGroupData(obj);

			// ディクショナリに追加
			versionGroupDataIDKey.Add(data.ID, data);
			versionGroupDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
