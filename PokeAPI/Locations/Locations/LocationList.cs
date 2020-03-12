namespace PokeAPI
{
	/// <summary>
	/// 場所リストクラス
	/// </summary>
	public class LocationList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LocationList() : base("location")
		{
		}
		#endregion
	}
}
