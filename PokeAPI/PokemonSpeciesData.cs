using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// ポケモン(大分類)データクラス
	/// </summary>
	public class PokemonSpeciesData
	{
		// public プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region ソート順番
		/// <summary>ソート順番</summary>
		public int Order { get; internal set; } = 0;
		#endregion

		#region 1/8でメスになる確率(-1は性別なし)
		/// <summary>1/8でメスになる確率(-1は性別なし)</summary>
		public int GenderRate { get; internal set; } = -1;
		#endregion

		#region ゲットしやすさ
		/// <summary>ゲットしやすさ</summary>
		public int CaptureRate { get; internal set; } = 0;
		#endregion

		#region 基本幸福度
		/// <summary>基本幸福度</summary>
		public int BaseHappiness { get; internal set; } = 0;
		#endregion

		#region 赤ちゃんポケモンか
		/// <summary>赤ちゃんポケモンか</summary>
		public bool IsBaby { get; internal set; } = false;
		#endregion

		#region 孵化歩数
		/// <summary>孵化歩数</summary>
		public int HatchCounter { get; internal set; } = 0;
		#endregion

		#region 性別で視覚的な差があるか
		/// <summary>性別で視覚的な差があるか</summary>
		public bool HasGenderDifferences { get; internal set; } = false;
		#endregion

		#region フォルムの変更がありえるか
		/// <summary>フォルムの変更がありえるか</summary>
		public bool FormSwitchable { get; internal set; } = false;
		#endregion

		#region 成長率
		/// <summary>成長率</summary>
		public NamedAPIResourceData GrowthRate { get; internal set; } = null;
		#endregion

		#region ポケモン図鑑番号
		/// <summary>ポケモン図鑑番号</summary>
		public List<PokemonSpeciesDexEntryData> PokedexNumbers { get; internal set; } = null;
		#endregion

		#region 卵グループ
		/// <summary>卵グループ</summary>
		public List<NamedAPIResourceData> EggGroups { get; internal set; } = null;
		#endregion

		#region 色
		/// <summary>色</summary>
		public NamedAPIResourceData Color { get; internal set; } = null;
		#endregion

		#region ポケモンの形
		/// <summary>ポケモンの形</summary>
		public NamedAPIResourceData Shape { get; internal set; } = null;
		#endregion

		#region 進化元ポケモン
		/// <summary>進化元ポケモン</summary>
		public NamedAPIResourceData EvolvesFromSpecies { get; internal set; } = null;
		#endregion

		#region 進化ルート
		/// <summary>進化ルート</summary>
		public APIResourceData EvolutionChain { get; internal set; } = null;
		#endregion

		#region 生息地
		/// <summary>生息地</summary>
		public NamedAPIResourceData Habitat { get; internal set; } = null;
		#endregion

		#region 世代
		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;
		#endregion

		#region 言語ごとの名称
		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region パルパークのエンカウントエリア
		/// <summary>パルパークのエンカウントエリア</summary>
		public List<PalParkEncounterArea> PalParkEncounters { get; internal set; } = null;
		#endregion

	}
}
