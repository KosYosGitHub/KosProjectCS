using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Generic;

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
			generationDataNameKey.Clear();
		}
		#endregion

		#region 世代情報取得
		/// <summary>
		/// 世代情報取得
		/// </summary>
		/// <param name="name">世代</param>
		public GenerationData GetGeneration(string name)
		{
			// 世代リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			GenerationData data = null;
			if(generationDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// 世代APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// 世代JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 世代JSON文字列解析
			return ParseGenerationJson(name, json);
		}
		#endregion

		// private メンバ

		#region 世代ディクショナリ(Nameキー)
		/// <summary>世代ディクショナリ(Nameキー)</summary>
		private Dictionary<string, GenerationData> generationDataNameKey = new Dictionary<string, GenerationData>();
		#endregion

		// private メソッド

		#region 世代 JSON解析
		/// <summary>
		/// 世代 JSON解析
		/// </summary>
		/// <param name="name">世代</param>
		/// <param name="json">JSON文字列</param>
		private GenerationData ParseGenerationJson(string name, string json)
		{
			JObject obj = JObject.Parse(json);

			GenerationData data = new GenerationData(obj);

			generationDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
