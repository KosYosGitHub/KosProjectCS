namespace PokeAPI
{
	/// <summary>
	/// 性格によって影響を受けるステータス
	/// </summary>
	public class NatureStatChangeData
	{
		/// <summary>影響の最大値</summary>
		public int MaxChange { get; internal set; } = 0;

		/// <summary>ステータス</summary>
		public NamedAPIResourceData PokeathlonState { get; internal set; } = null;
	}
}
