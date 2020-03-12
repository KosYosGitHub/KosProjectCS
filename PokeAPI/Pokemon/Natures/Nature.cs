using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 性格
	/// </summary>
	public class Nature : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Nature() : base(Singleton<NatureList>.Instance)
		{
		}
		#endregion

		#region 性格の取得
		/// <summary>
		/// 性格の取得
		/// </summary>
		/// <param name="name">名称</param>
		public NatureData GetNature(string name)
		{
			return GetResource(name) as NatureData;
		}
		#endregion

		// protected メソッド

		#region 性格JSON 解析
		/// <summary>
		/// 性格JSON 解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		protected override APIResource ParseJson(string json)
		{
			return new NatureData(JObject.Parse(json));
		}
		#endregion
	}
}
