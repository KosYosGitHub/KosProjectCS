using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;

namespace PokeAPITool
{
	public class PokeAPIToolModel
	{
		// public プロパティ

		#region 言語リスト
		/// <summary>言語リスト</summary>
		public PokeAPI.LanguageList LanguageList => Singleton<PokeAPI.LanguageList>.Instance;
		#endregion

		#region 言語詳細リスト
		/// <summary>言語詳細リスト</summary>
		public PokeAPI.Language LanguageDetailList => Singleton<PokeAPI.Language>.Instance;
		#endregion

		#region バージョングループリスト
		/// <summary>バージョングループリスト</summary>
		public PokeAPI.VersionGroupList VersionGroupList => Singleton<PokeAPI.VersionGroupList>.Instance;
		#endregion
	}
}
