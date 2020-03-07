using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// バージョングループデータクラス
	/// </summary>
	public class VersionGroupData
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

		#region ソート順番
		/// <summary>ソート順番</summary>
		public int Order { get; internal set; } = 0;
		#endregion

		#region 世代
		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;
		#endregion

		#region 技の習得方法リスト
		/// <summary>技の習得方法リスト</summary>
		public List<NamedAPIResourceData> MoveLearnMethods { get; internal set; } = null;
		#endregion

		#region ポケモン図鑑リスト
		/// <summary>ポケモン図鑑リスト</summary>
		public List<NamedAPIResourceData> Pokedexes { get; internal set; } = null;
		#endregion

		#region 地方リスト
		/// <summary>地方リスト</summary>
		public List<NamedAPIResourceData> Regions { get; internal set; } = null;
		#endregion

		#region バージョンリスト
		/// <summary>バージョンリスト</summary>
		public List<NamedAPIResourceData> Versions { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public VersionGroupData(JToken token)
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
		private void Parse(JToken token)
		{
			ID = (int)token["id"];							// ID
			Name = (token["name"] as JValue).ToString();	// 名称
			Order = (int)token["order"];					// ソート順番
			Generation = new NamedAPIResourceData(token);	// 世代

			// 技の習得方法
			MoveLearnMethods = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "move_learn_methods", MoveLearnMethods);

			// ポケモン図鑑
			Pokedexes = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "pokedexes", Pokedexes);

			// 地方
			Regions = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "regions", Regions);

			// バージョン
			Versions = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "versions", Versions);
		}
		#endregion
	}
}
