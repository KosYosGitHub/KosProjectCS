using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// バージョングループデータクラス
	/// </summary>
	public class VersionGroupData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>ソート順番</summary>
		public int Order { get; internal set; } = 0;

		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;

		/// <summary>技の習得方法リスト</summary>
		public List<NamedAPIResourceData> MoveLearnMethods { get; internal set; } = null;

		/// <summary>ポケモン図鑑リスト</summary>
		public List<NamedAPIResourceData> Pokedexes { get; internal set; } = null;

		/// <summary>地方リスト</summary>
		public List<NamedAPIResourceData> Regions { get; internal set; } = null;

		/// <summary>バージョンリスト</summary>
		public List<NamedAPIResourceData> Versions { get; internal set; } = null;
	}
}
