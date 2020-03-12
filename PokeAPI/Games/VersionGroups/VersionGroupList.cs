namespace PokeAPI
{
	/// <summary>
	/// バージョングループリスト
	/// </summary>
	public class VersionGroupList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroupList() : base("version-group")
		{
		}
		#endregion
	}
}
