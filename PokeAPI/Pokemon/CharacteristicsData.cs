using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// 個性データクラス
	/// </summary>
	public class CharacteristicData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>説明リスト</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;

		/// <summary>遺伝子モジュロ</summary>
		public int GeneModulo { get; internal set; } = 0;

		/// <summary>あり得る値</summary>
		public List<int> PossibleValues { get; internal set; } = null;

		/// <summary>最高値のステータス</summary>
		public NamedAPIResourceData HighestState { get; internal set; } = null;
	}
}
