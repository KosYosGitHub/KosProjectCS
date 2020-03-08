using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 経験値タイプデータクラス
	/// </summary>
	public class GrowthRateData
	{
		// コンストラクタ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region レベルアップ割合を計算する式
		/// <summary>レベルアップ割合を計算する式</summary>
		public string Formula { get; internal set; } = string.Empty;
		#endregion

		#region 各言語ごとの説明
		/// <summary>各言語ごとの説明</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;
		#endregion

		#region 各レベルに到達するための経験値
		/// <summary>各レベルに到達するための経験値</summary>
		public List<GrowthRateExperienceLevelData> Levels { get; internal set; } = null;
		#endregion

		#region 成長率を持つポケモン
		/// <summary>成長率を持つポケモン</summary>
		public List<NamedAPIResourceData> PokemonSpecies { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public GrowthRateData(JToken token)
		{
			Parse(token);
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public void Parse(JToken token)
		{
			ID = (int)token["id"];								// ID
			Name = (token["name"] as JValue).ToString();		// 名称
			Formula = (token["formula"] as JValue).ToString();	// 計算式

			// 言語ごとの説明
			Descriptions = new List<DescriptionData>();
			DescriptionData.ParseList(token, "descriptions", Descriptions);

			// レベル
			Levels = new List<GrowthRateExperienceLevelData>();
			GrowthRateExperienceLevelData.ParseList(token, "levels", Levels);

			// ポケモン
			PokemonSpecies = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "pokemon_species", PokemonSpecies);
		}
		#endregion
	}
}
