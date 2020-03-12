using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	public class VersionGameIndexData
	{
		/// <summary>ゲームデータ内のAPIリソース内部ID</summary>
		public int GameIndex { get; internal set; } = 0;

		/// <summary>バージョン</summary>
		public NamedAPIResourceData Version { get; internal set; } = null;
	}
}
