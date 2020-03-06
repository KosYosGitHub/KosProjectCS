namespace PokeAPI
{
	/// <summary>
	/// APIリソースデータ
	/// </summary>
	public class NamedAPIResourceData
	{
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>URL</summary>
		public string URL { get; internal set; } = string.Empty;
	}
}
