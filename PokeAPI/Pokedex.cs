using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑クラス
	/// </summary>
	public class Pokedex : NamedAPIResourceListItem
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Pokedex() : base("pokedex", Singleton<PokedexList>.Instance)
		{
		}
		#endregion

		#region ポケモン図鑑情報取得
		/// <summary>
		/// ポケモン図鑑情報取得
		/// </summary>
		/// <param name="name">ポケモン図鑑名</param>
		/// <returns>取得データ</returns>
		public PokedexData GetPokedex(string name)
		{
			return GetResource(name) as PokedexData;
		}
		#endregion

		// protected メソッド

		#region ポケモン図鑑 JSON解析
		/// <summary>
		/// ポケモン図鑑 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>ポケモン図鑑</returns>
		protected override APIResource ParseJson(string json)
		{
			return new PokedexData(JObject.Parse(json));
		}
		#endregion
	}
}
