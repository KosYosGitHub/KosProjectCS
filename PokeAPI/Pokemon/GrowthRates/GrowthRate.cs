using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 経験値タイプクラス
	/// </summary>
	internal class GrowthRate : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GrowthRate() : base(Singleton<GrowthRateList>.Instance)
		{
		}
		#endregion

		#region 経験値タイプの取得
		/// <summary>
		/// 経験値タイプの取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>データ</returns>
		public GrowthRateData GetGrowthRate(string name)
		{
			return GetResource(name) as GrowthRateData;
		}
		#endregion

		// protected メソッド

		#region 経験値タイプ 解析
		/// <summary>
		/// 経験値タイプ 解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		protected override APIResource ParseJson(string json)
		{
			return new GrowthRateData(JObject.Parse(json));
		}
		#endregion
	}
}
