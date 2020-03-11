using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	public class RegionData : APIResource
	{
		// プロパティ

		#region 言語ごとの名称
		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region 場所リスト
		/// <summary>場所リスト</summary>
		public List<NamedAPIResourceData> Locations { get; internal set; } = null;
		#endregion

		#region 主な世代
		/// <summary>主な世代</summary>
		public NamedAPIResourceData MainGeneration { get; internal set; } = null;
		#endregion

		#region ポケモン図鑑
		/// <summary>ポケモン図鑑</summary>
		public List<NamedAPIResourceData> Pokedexes { get; internal set; } = null;
		#endregion

		#region バージョングループ
		/// <summary>バージョングループ</summary>
		public List<NamedAPIResourceData> VersionGroups { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public RegionData(JToken token)
		{
			Parse(token);
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		private void Parse(JToken token)
		{
			ID = (int)token["id"];													// ID
			Name = (token["name"] as JValue).ToString();							// 名称
			MainGeneration = new NamedAPIResourceData(token["main_generation"]);    // 主な世代

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);

			// 場所リスト
			Locations = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "locations", Locations);

			// ポケモン図鑑
			Pokedexes = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "pokedexes", Pokedexes);

			// バージョングループ
			VersionGroups = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "version_groups", VersionGroups);
		}
		#endregion
	}
}
