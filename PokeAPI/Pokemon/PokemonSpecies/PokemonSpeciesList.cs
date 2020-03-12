namespace PokeAPI
{
	/// <summary>
	/// ポケモン種リスト
	/// </summary>
	public class PokemonSpeciesList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpeciesList() : base("pokemon-species")
		{
		}
		#endregion
	}
}
