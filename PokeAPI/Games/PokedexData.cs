using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑データ
	/// </summary>
	public class PokedexData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>メインのポケモン図鑑か</summary>
		public bool IsMainSeries { get; internal set; } = false;

		/// <summary>説明リスト</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;

		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;

		/// <summary>ポケモン図鑑登録情報リスト</summary>
		public List<PokemonEntryData> PokemonEntries { get; internal set; } = null;

		/// <summary>地方</summary>
		public NamedAPIResourceData Region { get; internal set; } = null;

		/// <summary>バージョングループリスト</summary>
		public List<NamedAPIResourceData> VersionGroups { get; internal set; } = null;
	}
}
