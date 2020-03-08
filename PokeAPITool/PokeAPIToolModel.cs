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

		#region バージョンリスト
		/// <summary>バージョンリスト</summary>
		public PokeAPI.VersionList VersionList => Singleton<PokeAPI.VersionList>.Instance;
		#endregion

		#region バージョン詳細リスト
		/// <summary>バージョン詳細リスト</summary>
		public PokeAPI.Version VersionDetailList => Singleton<PokeAPI.Version>.Instance;
		#endregion

		#region 世代リスト
		/// <summary>世代リスト</summary>
		public PokeAPI.GenerationList GenerationList => Singleton<PokeAPI.GenerationList>.Instance;
		#endregion

		#region 世代詳細リスト
		/// <summary>世代詳細リスト</summary>
		public PokeAPI.Generation GenerationDetailList => Singleton<PokeAPI.Generation>.Instance;
		#endregion

		#region 地方リスト
		/// <summary>地方リスト</summary>
		public PokeAPI.RegionList RegionList => Singleton<PokeAPI.RegionList>.Instance;
		#endregion

		#region 地方詳細リスト
		/// <summary>地方詳細リスト</summary>
		public PokeAPI.Region RegionDetailList => Singleton<PokeAPI.Region>.Instance;
		#endregion

		#region 図鑑リスト
		/// <summary>図鑑リスト</summary>
		public PokeAPI.PokedexList PokedexList => Singleton<PokeAPI.PokedexList>.Instance;
		#endregion

		#region 図鑑詳細リスト
		/// <summary>図鑑詳細リスト</summary>
		public PokeAPI.Pokedex PokedexDetailList => Singleton<PokeAPI.Pokedex>.Instance;
		#endregion
	}
}
