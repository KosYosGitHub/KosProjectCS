using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// 世代データクラス
	/// </summary>
	public class GenerationData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>特性リスト</summary>
		public List<NamedAPIResourceData> Abilities { get; internal set; } = null;

		/// <summary>各言語での名称</summary>
		public List<NamedAPIResourceData> Names { get; internal set; } = null;

		/// <summary>主な地方</summary>
		public NamedAPIResourceData MainRegion { get; internal set; } = null;

		/// <summary>技リスト</summary>
		public List<NamedAPIResourceData> Moves { get; internal set; } = null;

		/// <summary>ポケモンリスト</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;

		/// <summary>タイプリスト</summary>
		public List<NamedAPIResourceData> Types { get; internal set; } = null;

		/// <summary>バージョングループリスト</summary>
		public List<NamedAPIResourceData> VersionGroups { get; internal set; } = null;
	}
}
