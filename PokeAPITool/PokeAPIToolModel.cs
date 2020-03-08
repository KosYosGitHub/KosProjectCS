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

		#region バージョングループ詳細リスト
		/// <summary>バージョングループ詳細リスト</summary>
		public PokeAPI.VersionGroup VersionGroupDetailList => Singleton<PokeAPI.VersionGroup>.Instance;
		#endregion

		#region バージョン詳細リスト
		/// <summary>バージョン詳細リスト</summary>
		public PokeAPI.Version VersionDetailList => Singleton<PokeAPI.Version>.Instance;
		#endregion

		#region 世代詳細リスト
		/// <summary>世代詳細リスト</summary>
		public PokeAPI.Generation GenerationDetailList => Singleton<PokeAPI.Generation>.Instance;
		#endregion

		#region 地方詳細リスト
		/// <summary>地方詳細リスト</summary>
		public PokeAPI.Region RegionDetailList => Singleton<PokeAPI.Region>.Instance;
		#endregion
	}
}
