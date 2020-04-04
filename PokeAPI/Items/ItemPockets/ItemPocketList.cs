namespace PokeAPI
{
	/// <summary>
	/// アイテムポケットリスト
	/// </summary>
	public class ItemPocketList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ItemPocketList() : base("item-pocket")
		{
		}
		#endregion
	}
}
