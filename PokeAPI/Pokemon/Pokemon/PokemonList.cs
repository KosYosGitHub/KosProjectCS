namespace PokeAPI
{
	/// <summary>
	/// ポケモンリスト
	/// </summary>
	public class PokemonList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonList() : base("pokemon")
		{
		}
		#endregion
	}
}
