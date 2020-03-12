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
		public Version() : base(Singleton<VersionList>.Instance)
		{
		}
		#endregion

		#region バージョン情報取得
		/// <summary>
		/// バージョン情報取得
		/// </summary>
		/// <param name="name">バージョン名</param>
		public VersionData GetVersion(string name)
		{
			return GetResource(name) as VersionData;
		}
		#endregion

		// protected メソッド

		#region バージョン JSON解析
		/// <summary>
		/// バージョン JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new VersionData(JObject.Parse(json));
		}
		#endregion
	}
}
