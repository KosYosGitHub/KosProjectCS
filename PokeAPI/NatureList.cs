namespace PokeAPI
{
	/// <summary>
	/// 性格リスト
	/// </summary>
	public class NatureList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public NatureList() : base("nature")
		{
		}
		#endregion
	}
}
