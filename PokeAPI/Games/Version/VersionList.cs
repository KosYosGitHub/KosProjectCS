namespace PokeAPI
{
	/// <summary>
	/// バージョンリスト
	/// </summary>
	public class VersionList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionList() : base("version")
		{
		}
		#endregion
	}
}
