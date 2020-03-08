using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 世代データクラス
	/// </summary>
	public class GenerationData
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

		#region 特性リスト
		/// <summary>特性リスト</summary>
		public List<NamedAPIResourceData> Abilities { get; internal set; } = null;
		#endregion

		#region 各言語での名称
		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region 主な地方
		/// <summary>主な地方</summary>
		public NamedAPIResourceData MainRegion { get; internal set; } = null;
		#endregion

		#region 技リスト
		/// <summary>技リスト</summary>
		public List<NamedAPIResourceData> Moves { get; internal set; } = null;
		#endregion

		#region ポケモンリスト
		/// <summary>ポケモンリスト</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;
		#endregion

		#region タイプリスト
		/// <summary>タイプリスト</summary>
		public List<NamedAPIResourceData> Types { get; internal set; } = null;
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
		public GenerationData(JToken token)
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
			ID = (int)token["id"];											// ID
			Name = (token["name"] as JValue).ToString();					// 名称
			MainRegion = new NamedAPIResourceData(token["main_region"]);	// 主な地方

			// 特性
			Abilities = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "abilities", Abilities);

			// 技
			Moves = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "moves", Moves);

			// ポケモン
			PokemonSpecies = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "pokemon_species", PokemonSpecies);

			// タイプ
			Types = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "types", Types);

			// バージョングループ
			VersionGroups = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "version_groups", VersionGroups);

			// 各言語での名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);
		}
		#endregion
	}
}
