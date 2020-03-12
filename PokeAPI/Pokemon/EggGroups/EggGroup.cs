using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 卵グループ
	/// </summary>
	public class EggGroup : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public EggGroup() : base(Singleton<EggGroupList>.Instance)
		{
		}
		#endregion

		#region 卵グループの取得
		/// <summary>
		/// 卵グループの取得
		/// </summary>
		/// <param name="name">名称</param>
		public EggGroupData GetEggGroup(string name)
		{
			return GetResource(name) as EggGroupData;
		}
		#endregion

		// protected メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new EggGroupData(JObject.Parse(json));
		}
		#endregion
	}
}
