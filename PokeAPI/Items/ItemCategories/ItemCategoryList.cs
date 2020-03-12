namespace PokeAPI
{
	/// <summary>
	/// アイテムカテゴリリストクラス
	/// </summary>
	public class ItemCategoryList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ItemCategoryList() : base("item-category")
		{
		}
		#endregion
	}
}
