using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// 卵グループデータ
	/// </summary>
	public class EggGroupData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;

		/// <summary>ポケモンリスト</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;
	}
}
