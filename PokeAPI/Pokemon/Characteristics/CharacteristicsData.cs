using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 個性データクラス
	/// </summary>
	public class CharacteristicData
	{
		// プロパティ

		#region ID
		/// <summary>ID</summary>
		public int ID { get; internal set; } = 0;
		#endregion

		#region 説明リスト
		/// <summary>説明リスト</summary>
		public List<DescriptionData> Descriptions { get; internal set; } = null;
		#endregion

		#region 遺伝子モジュロ
		/// <summary>遺伝子モジュロ</summary>
		public int GeneModulo { get; internal set; } = 0;
		#endregion

		#region あり得る値
		/// <summary>あり得る値</summary>
		public List<int> PossibleValues { get; internal set; } = null;
		#endregion

		#region 最高値のステータス
		/// <summary>最高値のステータス</summary>
		public NamedAPIResourceData HighestState { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public CharacteristicData(JToken token)
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
			ID = (int)token["id"];					// ID
			GeneModulo = (int)token["gene_modulo"];	// 遺伝子モジュロ

			// 説明リスト
			Descriptions = new List<DescriptionData>();
			DescriptionData.ParseList(token, "descriptions", Descriptions);

			// あり得る値
			JArray possibleValues = token["possible_values"] as JArray;
			PossibleValues = new List<int>();
			int no = 0;
			foreach(JObject possibleValue in possibleValues) {
				PossibleValues.Add((int)possibleValue[$"{no}"]);
				no++;
			}
		}
		#endregion
	}
}
