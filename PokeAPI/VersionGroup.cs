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
	public class VersionGroup : NamedAPIResourceListItem
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroup() : base("version-group", Singleton<VersionGroupList>.Instance)
		{
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
			return GetResource(name) as VersionGroupData;
		}
		#endregion

		// protected メソッド

		#region バージョングループ JSON解析
		/// <summary>
		/// バージョングループ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new VersionGroupData(JObject.Parse(json));
		}
		#endregion
	}
}
