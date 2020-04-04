using Generic;

namespace PokeAPITool
{
	public class PokeAPIToolModel
	{
		// public 定数

		#region 言語タイトル
		/// <summary>言語タイトル</summary>
		public const string TitleLanguage = "言語(Language)";
		#endregion

		#region バージョングループタイトル
		/// <summary>バージョングループタイトル</summary>
		public const string TitleVersionGroup = "バージョングループ(VersionGroup)";
		#endregion

		#region バージョンタイトル
		/// <summary>バージョンタイトル</summary>
		public const string TitleVersion = "バージョン(Version)";
		#endregion

		#region 世代タイトル
		/// <summary>世代タイトル</summary>
		public const string TitleGeneration = "世代(Generation)";
		#endregion

		#region 地方タイトル
		/// <summary>地方タイトル</summary>
		public const string TitleRegion = "地方(Region)";
		#endregion

		#region 場所タイトル
		/// <summary>場所</summary>
		public const string TitleLocation = "場所(Location)";
		#endregion

		#region 場所エリアタイトル
		/// <summary>場所エリアタイトル</summary>
		public const string TitleLocationArea = "場所エリア(LocationArea)";
		#endregion

		#region パルパークエリアタイトル
		/// <summary>パルパークエリアタイトル</summary>
		public const string TitlePalParkArea = "パルパークエリア(PalParkArea)";
		#endregion

		#region ポケモン図鑑タイトル
		/// <summary>ポケモン図鑑タイトル</summary>
		public const string TitlePokedex = "ポケモン図鑑(Pokedex)";
		#endregion

		#region ポケモン種タイトル
		/// <summary>ポケモン種タイトル</summary>
		public const string TitlePokemonSpecies = "ポケモン種(PokemonSpecies)";
		#endregion

		#region ポケモンタイトル
		/// <summary>ポケモンタイトル</summary>
		public const string TitlePokemon = "ポケモン(Pokemon)";
		#endregion

		#region アイテムタイトル
		/// <summary>アイテムタイトル</summary>
		public const string TitleItem = "アイテム(Item)";
		#endregion

		#region アイテム属性タイトル
		/// <summary>アイテム属性タイトル</summary>
		public const string TitleItemAttribute = "アイテム属性(ItemAttribute)";
		#endregion

		#region アイテムカテゴリタイトル
		/// <summary>アイテムカテゴリタイトル</summary>
		public const string TitleItemCategory = "アイテムカテゴリ(ItemCategory)";
		#endregion

		#region アイテムポケットタイトル
		/// <summary>アイテムポケットタイトル</summary>
		public const string TitleItemPocket = "アイテムポケット(ItemPocket)";
		#endregion

		#region 技マシンタイトル
		/// <summary>技マシンタイトル</summary>
		public const string TitleMachine = "技マシン(Machine)";
		#endregion

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

		#region 場所リスト
		/// <summary>場所リスト</summary>
		public PokeAPI.LocationList LocationList => Singleton<PokeAPI.LocationList>.Instance;
		#endregion

		#region 場所エリアリスト
		/// <summary>場所エリアリスト</summary>
		public PokeAPI.LocationAreaList LocationAreaList => Singleton<PokeAPI.LocationAreaList>.Instance;
		#endregion

		#region パルパークエリアタイトル
		/// <summary>パルパークエリアタイトル</summary>
		public PokeAPI.PalParkAreaList PalParkAreaList => Singleton<PokeAPI.PalParkAreaList>.Instance;
		#endregion

		#region 図鑑リスト
		/// <summary>図鑑リスト</summary>
		public PokeAPI.PokedexList PokedexList => Singleton<PokeAPI.PokedexList>.Instance;
		#endregion

		#region 図鑑詳細リスト
		/// <summary>図鑑詳細リスト</summary>
		public PokeAPI.Pokedex PokedexDetailList => Singleton<PokeAPI.Pokedex>.Instance;
		#endregion

		#region ポケモン種リスト
		/// <summary>種リスト</summary>
		public PokeAPI.PokemonSpeciesList PokemonSpeciesList => Singleton<PokeAPI.PokemonSpeciesList>.Instance;
		#endregion

		#region ポケモン種詳細リスト
		/// <summary>ポケモン種詳細リスト</summary>
		public PokeAPI.PokemonSpecies PokemonSpeciesDetailList = Singleton<PokeAPI.PokemonSpecies>.Instance;
		#endregion

		#region ポケモンリスト
		/// <summary>ポケモンリスト</summary>
		public PokeAPI.PokemonList PokemonList => Singleton<PokeAPI.PokemonList>.Instance;
		#endregion

		#region アイテムリスト
		/// <summary>アイテムリスト</summary>
		public PokeAPI.ItemList ItemList => Singleton<PokeAPI.ItemList>.Instance;
		#endregion

		#region アイテム属性リスト
		/// <summary>アイテム属性リスト</summary>
		public PokeAPI.ItemAttributeList ItemAttributeList => Singleton<PokeAPI.ItemAttributeList>.Instance;
		#endregion

		#region アイテムカテゴリリスト
		/// <summary>アイテムカテゴリリスト</summary>
		public PokeAPI.ItemCategoryList ItemCategoryList => Singleton<PokeAPI.ItemCategoryList>.Instance;
		#endregion

		#region アイテムポケットリスト
		/// <summary>アイテムポケットリスト</summary>
		public PokeAPI.ItemPocketList ItemPocketList => Singleton<PokeAPI.ItemPocketList>.Instance;
		#endregion

		#region 技マシンリスト
		/// <summary>技マシンリスト</summary>
		public PokeAPI.MachineList MachineList => Singleton<PokeAPI.MachineList>.Instance;
		#endregion
	}
}
