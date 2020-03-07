using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// 経験値タイプデータクラス
	/// </summary>
	public class GrowthRateData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>レベルアップ割合を計算する式</summary>
		public string Formula { get; internal set; } = string.Empty;

		/// <summary>各言語ごとの説明</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;

		/// <summary>各レベルに到達するための経験値</summary>
		public List<GrowthRateExperienceLevelData> Levels { get; internal set; } = null;

		/// <summary>成長率を持つポケモン</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;
	}
}
