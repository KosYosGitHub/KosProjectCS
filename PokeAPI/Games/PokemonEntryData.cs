using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑登録データクラス
	/// </summary>
	public class PokemonEntryData
	{
		/// <summary>ポケモン図鑑番号</summary>
		public int EntryNumber { get; internal set; } = 0;

		/// <summary>
		/// ポケモン
		/// </summary>
		public NamedAPIResourceData PokemonSpecies { get; internal set; } = null;
	}
}
