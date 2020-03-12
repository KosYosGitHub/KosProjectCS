namespace PokeAPI
{
	/// <summary>
	/// 卵グループリストクラス
	/// </summary>
	public class EggGroupList : NamedAPIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public EggGroupList() : base("egg-group")
		{
		}
		#endregion
	}
}
