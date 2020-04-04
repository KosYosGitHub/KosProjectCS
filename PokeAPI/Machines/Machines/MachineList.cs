namespace PokeAPI
{
	/// <summary>
	/// 技マシンリストクラス
	/// </summary>
	public class MachineList : APIResourceList
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MachineList() : base("machine")
		{
		}
		#endregion
	}
}
