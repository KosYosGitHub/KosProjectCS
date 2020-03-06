namespace PokeAPI
{
	/// <summary>
	/// 名称データクラス
	/// </summary>
	public class NameData
	{
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>言語</summary>
		public NamedAPIResourceData Language { get; internal set; } = null;
	}
}
