using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑データ
	/// </summary>
	public class PokedexData
	{
		// プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region メインのポケモン図鑑か
		/// <summary>メインのポケモン図鑑か</summary>
		public bool IsMainSeries { get; internal set; } = false;
		#endregion

		#region 説明リスト
		/// <summary>説明リスト</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;
		#endregion

		#region 各言語での名称
		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region ポケモン図鑑登録情報リスト
		/// <summary>ポケモン図鑑登録情報リスト</summary>
		public List<PokemonEntryData> PokemonEntries { get; internal set; } = null;
		#endregion

		#region 地方
		/// <summary>地方</summary>
		public NamedAPIResourceData Region { get; internal set; } = null;
		#endregion

		#region バージョングループリスト
		/// <summary>バージョングループリスト</summary>
		public List<NamedAPIResourceData> VersionGroups { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public PokedexData(JToken token)
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
			ID = (int)token["id"];                               // ID
			Name = (token["name"] as JValue).ToString();         // 名称
			IsMainSeries = (bool)token["is_main_series"];        // メインのポケモン図鑑か
			Region = new NamedAPIResourceData(token["region"]);  // 地方

			// 言語ごとの説明
			Descriptions = new List<DescriptionData>();
			DescriptionData.ParseList(token, "descriptions", Descriptions);

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);

			// ポケモン登録情報
			PokemonEntries = new List<PokemonEntryData>();
			PokemonEntryData.ParseList(token, "pokemon_entries", PokemonEntries);

			// バージョングループ
			VersionGroups = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "version_groups", VersionGroups);
		}
		#endregion
	}
}
