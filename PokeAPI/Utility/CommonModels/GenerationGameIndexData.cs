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
	/// ゲームごとの世代データクラス
	/// </summary>
	public class GenerationGameIndexData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<GenerationGameIndexData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			foreach(JObject field in fields) {
				list.Add(new GenerationGameIndexData(field));
			}
		}
		#endregion

		// プロパティ

		#region ゲームインデックス
		/// <summary>ゲームインデックス</summary>
		public int GameIndex { get; internal set; } = 0;
		#endregion

		#region 世代
		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public GenerationGameIndexData(JToken token)
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
			GameIndex = (int)token["game_index"];
			Generation = new NamedAPIResourceData(token["generation"]);
		}
		#endregion
	}
}
