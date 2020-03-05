using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// 言語情報クラス
	/// </summary>
	public class LanguageData
	{
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;

		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;

		/// <summary>ゲーム上で公開されている言語か</summary>
		public bool Official { get; internal set; } = false;

		/// <summary>言語が使用されている国の2文字コード</summary>
		public string ISO639 { get; internal set; } = string.Empty;

		/// <summary>言語の2文字コード</summary>
		public string ISO3166 { get; internal set; } = string.Empty;

		/// <summary>各言語での名称</summary>
		public List<NameData> Names { get; internal set; } = null;
	}
}
