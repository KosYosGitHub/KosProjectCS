namespace PokeAPI
{
	/// <summary>
	/// レベルに到達するために必要な経験値データ
	/// </summary>
	public class GrowthRateExperienceLevelData
	{
		/// <summary>レベル</summary>
		public int Level { get; internal set; } = 0;

		/// <summary>到達するのに必要な経験値</summary>
		public long Experience { get; internal set; } = 0;
	}
}
