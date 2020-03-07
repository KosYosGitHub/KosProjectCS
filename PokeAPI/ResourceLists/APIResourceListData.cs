using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// APIリソースリスト
	/// </summary>
	public class APIResourceListData
	{
		// プロパティ

		#region 利用可能なリソース数
		/// <summary>利用可能なリソース数</summary>
		public int Count { get; internal set; } = 0;
		#endregion

		#region リソースリスト
		/// <summary>リソースリスト</summary>
		public List<APIResourceData> Results { get; internal set; } = null;
		#endregion

	}
}
