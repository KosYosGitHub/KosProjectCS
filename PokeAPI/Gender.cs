using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 性別
	/// </summary>
	public class Gender : NamedAPIResourceListItem
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Gender() : base("gender", Singleton<GenderList>.Instance)
		{
		}
		#endregion

		#region 性別の取得
		/// <summary>
		/// 性別の取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>データ</returns>
		public GenderData GetGender(string name)
		{
			return GetResource(name) as GenderData;
		}
		#endregion

		// protected メソッド

		#region GenderDataの解析
		/// <summary>
		/// GenderDataの解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new GenderData(JObject.Parse(json));
		}
		#endregion
	}
}
