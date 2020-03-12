namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑リスト
	/// </summary>
	public class PokedexList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokedexList() : base("pokedex")
		{
		}
		#endregion
	}
}
