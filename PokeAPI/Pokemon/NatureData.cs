using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 性格データ
	/// </summary>
	public class NatureData
	{
		// プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; internal set; } = string.Empty;
		#endregion

		#region 10%減少するステータス
		/// <summary>10%減少するステータス</summary>
		public NamedAPIResourceData DecreasedStat { get; internal set; } = null;
		#endregion

		#region 10%増加するステータス
		/// <summary>10%増加するステータス</summary>
		public NamedAPIResourceData IncreasedStat { get; internal set; } = null;
		#endregion

		#region 嫌いな味
		/// <summary>嫌いな味</summary>
		public NamedAPIResourceData HatesFlavor { get; internal set; } = null;
		#endregion

		#region 好きな味
		/// <summary>好きな味</summary>
		public NamedAPIResourceData LikesFlavor { get; internal set; } = null;
		#endregion

		#region 影響を受けるステータス
		/// <summary>影響を受けるステータス</summary>
		public List<NatureStatChangeData> PokeathlonStateChanges { get; internal set; } = null;
		#endregion

		#region 技スタイル
		/// <summary>技スタイル</summary>
		public List<MoveBattleStylePreferenceData> MoveBattleStylePerferences { get; internal set; } = null;
		#endregion

		#region 言語ごとの名称
		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public NatureData(JToken token)
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
			ID = (int)token["id"];												// ID
			Name = (token["name"] as JValue).ToString();						// 名称
			DecreasedStat = new NamedAPIResourceData(token["decreased_stat"]);	// 10%減少するステータス
			IncreasedStat = new NamedAPIResourceData(token["increased_stat"]);	// 10%増加するステータス
			HatesFlavor = new NamedAPIResourceData(token["hates_flavor"]);		// 嫌いな味
			LikesFlavor = new NamedAPIResourceData(token["likes_flavor"]);		// 好きな味

			// 影響を受けるステータス
			PokeathlonStateChanges = new List<NatureStatChangeData>();
			NatureStatChangeData.ParseList(token, "pokeathlon_stat_changes", PokeathlonStateChanges);

			// 技スタイル
			MoveBattleStylePerferences = new List<MoveBattleStylePreferenceData>();
			MoveBattleStylePreferenceData.ParseList(token, "move_battle_style_preferences", MoveBattleStylePerferences);
		}
		#endregion
	}
}
