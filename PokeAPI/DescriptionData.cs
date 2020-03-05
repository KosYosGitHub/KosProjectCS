using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// 説明データクラス
	/// </summary>
	public class DescriptionData
	{
		/// <summary>説明</summary>
		public string Description { get; internal set; } = string.Empty;

		/// <summary>言語</summary>
		public NamedAPIResourceData Language { get; internal set; } = null;
	}
}
