using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// 性格データ
	/// </summary>
	public class NatureData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>10%減少するステータス</summary>
		public NamedAPIResourceData DecreasedStat { get; internal set; } = null;

		/// <summary>10%増加するステータス</summary>
		public NamedAPIResourceData IncreasedStat { get; internal set; } = null;

		/// <summary>嫌いな味</summary>
		public NamedAPIResourceData HatesFlavor { get; internal set; } = null;

		/// <summary>好きな味</summary>
		public NamedAPIResourceData LikesFlavor { get; internal set; } = null;

		/// <summary>影響を受けるステータス</summary>
		public List<NatureStatChangeData> PokeathlonStateChanges { get; internal set; } = null;

		/// <summary>技スタイル</summary>
		public List<MoveBattleStylePreferenceData> MoveBattleStylePerferences { get; internal set; } = null;

		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
	}
}
