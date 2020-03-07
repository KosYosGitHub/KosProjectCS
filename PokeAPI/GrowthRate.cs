using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 経験値タイプクラス
	/// </summary>
	internal class GrowthRate : PokeAPIBase
	{
		// public 定数

		#region 60万タイプ(初期は成長が非常に遅い（全タイプ中最遅）が、途中から早くなり、高レベルになっても必要な経験値がほとんど増えなくなる)
		/// <summary>60万タイプ(初期は成長が非常に遅い（全タイプ中最遅）が、途中から早くなり、高レベルになっても必要な経験値がほとんど増えなくなる)</summary>
		public const string NameSlowThenVeryFast = "SLOW-THEN-VERY-FAST";
		#endregion

		#region 80万タイプ(最初から最後まで比較的早い)
		/// <summary>80万タイプ(最初から最後まで比較的早い)</summary>
		public const string NameFast = "FAST";
		#endregion

		#region 100万タイプ(標準的に成長する)
		/// <summary>100万タイプ(標準的)</summary>
		public const string NameMedium = "MEDIUM";
		#endregion

		#region 105万タイプ(初期は早いペースで成長し、途中から標準的なペースに移行)
		/// <summary>105万タイプ(初期は早いペースで成長し、途中から標準的なペースに移行)</summary>
		public const string NameMediumSlow = "MEDIUM-SLOW";
		#endregion

		#region 125万タイプ(最初から最後まで比較的遅い)
		/// <summary>125万タイプ(最初から最後まで比較的遅い)</summary>
		public const string NameSlow = "SLOW";
		#endregion

		#region 164万タイプ(初期は成長が非常に早いが、途中から遅くなっていき、高レベルになると1レベル上げるのに必要な経験値が爆発的に増えていく)
		/// <summary>164万タイプ(初期は成長が非常に早いが、途中から遅くなっていき、高レベルになると1レベル上げるのに必要な経験値が爆発的に増えていく)</summary>
		public const string NameFastThenVerySlow = "FAST-THEN-VERY-SLOW";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public GrowthRate() : base("growth-rate")
		{
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			growthRateDataIDKey.Clear();
			growthRateDataNameKey.Clear();
		}
		#endregion

		// interanal メソッド

		#region 経験値タイプの取得
		/// <summary>
		/// 経験値タイプの取得
		/// </summary>
		/// <param name="name">名称</param>
		public void GetGrowthRate(string name)
		{
			// 経験値タイプリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(growthRateDataNameKey.ContainsKey(name)) {
				return;
			}

			// 経験値タイプAPIリソースURLの取得
			string url = NamedAPIResourceList.GetURL(name);

			// 経験値タイプJSON文字列の取得
			string json = RunPokeAPI(url);

			// 経験値タイプJSON文字列の解析
			ParseGrowthRateJson(json);
		}
		#endregion

		// private メンバ変数

		#region 経験値タイプデータ(IDキー)
		/// <summary>経験値タイプデータ(IDキー)</summary>
		private Dictionary<int, GrowthRateData> growthRateDataIDKey = new Dictionary<int, GrowthRateData>();
		#endregion

		#region 経験値タイプデータ(Nameキー)
		/// <summary>経験値タイプデータ(Nameキー)</summary>
		private Dictionary<string, GrowthRateData> growthRateDataNameKey = new Dictionary<string, GrowthRateData>();
		#endregion

		// private メソッド

		#region 経験値タイプ 解析
		/// <summary>
		/// 経験値タイプ 解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseGrowthRateJson(string json)
		{
			JObject obj = JObject.Parse(json);
			GrowthRateData data = new GrowthRateData();

			data.ID = (int)obj["id"];								// ID
			data.Name = (obj["name"] as JValue).ToString();			// 名称
			data.Formula = (obj["formula"] as JValue).ToString();	// 計算式

			// 言語ごとの説明
			data.Descriptions = new List<DescriptionData>();
			DescriptionData.ParseList(obj, "descriptions", data.Descriptions);

			// レベル
			data.Levels = new List<GrowthRateExperienceLevelData>();
			ParseGrowthRateExperienceLevelList(obj, "levels", data.Levels);

			// ポケモン
			data.PokemonSpecies = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(obj, "pokemon_species", data.PokemonSpecies);

			// ディクショナリに追加
			growthRateDataIDKey.Add(data.ID, data);
			growthRateDataNameKey.Add(data.Name, data);
		}
		#endregion

		#region GrowthRateExperienceLevelのリスト要素を解析
		/// <summary>
		/// PokemonSpeciesGenderのリスト要素を解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="datas">解析したデータの格納先</param>
		private void ParseGrowthRateExperienceLevelList(JToken token, string name, List<GrowthRateExperienceLevelData> datas)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new Exception($"{name}要素が見つかりません。");
			}

			foreach(JObject field in fields) {
				datas.Add(ParseGrowthRateExperienceLevel(field));
			}
		}
		#endregion

		#region GrowthRateExperienceLevelData 解析
		/// <summary>
		/// GrowthRateExperienceLevelData 解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <returns>解析データ</returns>
		private GrowthRateExperienceLevelData ParseGrowthRateExperienceLevel(JToken token)
		{
			GrowthRateExperienceLevelData data = new GrowthRateExperienceLevelData();

			data.Level = (int)token["level"];					// レベル
			data.Experience = (long)token["experience"];        // 必要経験値

			return data;
		}
		#endregion
	}
}
