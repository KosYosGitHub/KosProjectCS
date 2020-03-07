namespace PokeAPI
{
	/// <summary>
	/// ポケモンの性別データクラス
	/// </summary>
	public class PokemonSpeciesGenderData
	{
		/// <summary>1/8でメスになる確率(性別がない場合は-1)</summary>
		public int Rate { get; internal set; } = -1;

		/// <summary>ポケモン</summary>
		public NamedAPIResourceData PokemonSpecies { get; internal set; } = null;
	}
}
