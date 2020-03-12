using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 世代クラス
	/// </summary>
	public class Generation : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Generation() : base(Singleton<GenerationList>.Instance)
		{
		}
		#endregion

		#region 世代取得
		/// <summary>
		/// 世代情報取得
		/// </summary>
		/// <param name="name">世代</param>
		/// <returns>データ</returns>
		public GenerationData GetGeneration(string name)
		{
			return GetResource(name) as GenerationData;
		}
		#endregion

		// private メソッド

		#region 世代 JSON解析
		/// <summary>
		/// 世代 JSON解析
		/// </summary>
		/// <param name="name">世代</param>
		/// <param name="json">JSON文字列</param>
		protected override APIResource ParseJson(string json)
		{
			return new GenerationData(JObject.Parse(json));
		}
		#endregion
	}
}
