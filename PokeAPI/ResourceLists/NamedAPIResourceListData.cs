using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	public class NamedAPIResourceListData
	{
		/// <summary>利用可能なリソース数</summary>
		public int Count { get; internal set; } = 0;

		/// <summary>リソースリスト</summary>
		public List<NamedAPIResourceData> Results { get; internal set; } = null;
	}
}
