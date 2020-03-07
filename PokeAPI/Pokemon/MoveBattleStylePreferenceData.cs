namespace PokeAPI
{
	/// <summary>
	/// 技スタイルの好み
	/// </summary>
	public class MoveBattleStylePreferenceData
	{
		/// <summary>HPが半分以下の時に使用する可能性</summary>
		public int LowHPPreference { get; internal set; } = 0;

		/// <summary>HPが半分以上の時に使用する可能性</summary>
		public int HighHPPreference { get; internal set; } = 0;

		/// <summary>技スタイル</summary>
		public NamedAPIResourceData MoveBattleStyle { get; internal set; } = null;
	}
}
