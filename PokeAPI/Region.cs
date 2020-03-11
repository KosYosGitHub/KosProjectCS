using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	public class Region : NamedAPIResourceListItem
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Region() : base("region", Singleton<RegionList>.Instance)
		{
		}
		#endregion

		#region データ取得
		/// <summary>
		/// データ取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>データ</returns>
		public RegionData GetRegion(string name)
		{
			return GetResource(name) as RegionData;
		}
		#endregion

		// protected メソッド

		#region 地方 JSON解析
		/// <summary>
		/// 地方 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new RegionData(JObject.Parse(json));
		}
		#endregion
	}
}
