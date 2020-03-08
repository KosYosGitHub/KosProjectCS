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
	/// ポケモン図鑑クラス
	/// </summary>
	public class Pokedex : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Pokedex() : base("pokedex")
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
			pokedexDataIDKey.Clear();
			pokedexDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region ポケモン図鑑情報取得
		/// <summary>
		/// ポケモン図鑑情報取得
		/// </summary>
		/// <param name="name">ポケモン図鑑名</param>
		/// <returns>取得データ</returns>
		public PokedexData GetPokedex(string name)
		{
			// ポケモン図鑑リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			PokedexData data;
			if(pokedexDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// ポケモン図鑑APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// ポケモン図鑑JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// ポケモン図鑑JSON文字列解析
			return ParsePokedexJson(json);
		}
		#endregion

		// private メンバ変数

		#region ポケモン図鑑ディクショナリ(IDキー)
		/// <summary>ポケモン図鑑ディクショナリ(IDキー)</summary>
		private Dictionary<int, PokedexData> pokedexDataIDKey = new Dictionary<int, PokedexData>();
		#endregion

		#region ポケモン図鑑ディクショナリ(Nameキー)
		/// <summary>ポケモン図鑑ディクショナリ(Nameキー)</summary>
		private Dictionary<string, PokedexData> pokedexDataNameKey = new Dictionary<string, PokedexData>();
		#endregion

		// private メソッド

		#region ポケモン図鑑 JSON解析
		/// <summary>
		/// ポケモン図鑑 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private PokedexData ParsePokedexJson(string json)
		{
			JObject obj = JObject.Parse(json);

			PokedexData data = new PokedexData(obj);

			// ディクショナリに追加
			pokedexDataIDKey.Add(data.ID, data);
			pokedexDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
