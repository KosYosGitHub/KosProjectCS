using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// バージョンデータクラス
	/// </summary>
	public class VersionData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;

		/// <summary>バージョングループ</summary>
		public NamedAPIResourceData VersionGroup { get; internal set; } = null;
	}
}
