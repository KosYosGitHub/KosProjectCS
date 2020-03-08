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
	/// バージョンクラス
	/// </summary>
	public class Version : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Version() : base("version")
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
			versionDataIDKey.Clear();
			versionDataNameKey.Clear();
		}
		#endregion

		#region バージョン情報取得
		/// <summary>
		/// バージョン情報取得
		/// </summary>
		/// <param name="name">バージョン名</param>
		public VersionData GetVersion(string name)
		{
			// バージョンリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			VersionData data;
			if(versionDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// バージョンAPIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// バージョンJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// バージョンJSON文字列解析
			return ParseVersionJson(json);
		}
		#endregion

		// private メンバ変数

		#region バージョンディクショナリ(IDキー)
		/// <summary>バージョンディクショナリ(IDキー)</summary>
		private Dictionary<int, VersionData> versionDataIDKey = new Dictionary<int, VersionData>();
		#endregion

		#region バージョンディクショナリ(Nameキー)
		/// <summary>バージョンディクショナリ(Nameキー)</summary>
		private Dictionary<string, VersionData> versionDataNameKey = new Dictionary<string, VersionData>();
		#endregion

		// private メソッド

		#region バージョン JSON解析
		/// <summary>
		/// バージョン JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private VersionData ParseVersionJson(string json)
		{
			JObject obj = JObject.Parse(json);

			VersionData data = new VersionData(obj);

			// ディクショナリに追加
			versionDataIDKey.Add(data.ID, data);
			versionDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
