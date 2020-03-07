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
	/// 世代クラス
	/// </summary>
	public class Generation : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Generation() : base("generation")
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
			generationDataGenerationKey.Clear();
		}
		#endregion

		// internal メソッド

		#region 世代情報取得
		/// <summary>
		/// 世代情報取得
		/// </summary>
		/// <param name="generation">世代</param>
		internal void GetGeneration(int generation)
		{
			// 世代リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(generationDataGenerationKey.ContainsKey(generation)) {
				return;
			}

			// 名称存在確認
			if(!GenerationName.ContainsKey(generation)) {
				throw new Exception($"{generation}世代は対応していません。");
			}

			// 世代APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(GenerationName[generation]);

			// 世代JSON文字列取得
			string json = RunPokeAPI(url);

			// 世代JSON文字列解析
			ParseGenerationJson(generation, json);
		}
		#endregion

		// private 定数

		#region 世代
		/// <summary>
		/// 世代
		/// </summary>
		private readonly Dictionary<int, string> GenerationName = new Dictionary<int, string> {
				{1, "GENERATION-I" }, {2, "GENERATION-II" }, {3, "GENERATION-III" }, {4, "GENERATION-IV" },
				{5, "GENERATION-V" }, {6, "GENERATION-VI" }, {7, "GENERATION-VII" }
			};
		#endregion

		// private メンバ

		#region 世代ディクショナリ(世代キー)
		/// <summary>世代ディクショナリ(世代キー)</summary>
		private Dictionary<int, GenerationData> generationDataGenerationKey = new Dictionary<int, GenerationData>();
		#endregion

		// private メソッド

		#region 世代 JSON解析
		/// <summary>
		/// 世代 JSON解析
		/// </summary>
		/// <param name="generation">世代</param>
		/// <param name="json">JSON文字列</param>
		private void ParseGenerationJson(int generation, string json)
		{
			JObject obj = JObject.Parse(json);

			GenerationData data = new GenerationData(obj);

			generationDataGenerationKey.Add(generation, data);
		}
		#endregion
	}
}
