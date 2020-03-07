using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>性別データクラス</summary>
	public class GenderData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>ポケモンごとの詳細</summary>
		public List<PokemonSpeciesGenderData> PokemonSpeciesDetails { get; internal set; } = null;

		/// <summary>進化するためにこの性別が条件になっているポケモン</summary>
		public List<NamedAPIResourceData> RequiredForEvolution { get; internal set; } = null;
	}
}
