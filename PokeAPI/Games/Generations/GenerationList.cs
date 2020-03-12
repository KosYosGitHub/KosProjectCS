namespace PokeAPI
{
	/// <summary>
	/// 世代リスト
	/// </summary>
	public class GenerationList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GenerationList() : base("generation")
		{
		}
		#endregion
	}
}
