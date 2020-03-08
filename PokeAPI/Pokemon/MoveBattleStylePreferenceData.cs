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
	/// 技スタイルの好み
	/// </summary>
	public class MoveBattleStylePreferenceData
	{
		// public static メソッド

		#region リスト解析
		/// <summary>
		/// リスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">名称</param>
		/// <param name="list">格納先リスト</param>
		public static void ParseList(JToken token, string name, List<MoveBattleStylePreferenceData> list)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", nameof(name));
			}

			foreach(JObject field in fields) {
				list.Add(new MoveBattleStylePreferenceData(field));
			}
		}
		#endregion

		// プロパティ

		#region HPが半分以下の時に使用する可能性
		/// <summary>HPが半分以下の時に使用する可能性</summary>
		public int LowHPPreference { get; internal set; } = 0;
		#endregion

		#region HPが半分以上の時に使用する可能性
		/// <summary>HPが半分以上の時に使用する可能性</summary>
		public int HighHPPreference { get; internal set; } = 0;
		#endregion

		#region 技スタイル
		/// <summary>技スタイル</summary>
		public NamedAPIResourceData MoveBattleStyle { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public MoveBattleStylePreferenceData(JToken token)
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
			LowHPPreference = (int)token["low_hp_preference"];						// HPが半分以下の時に使用する可能性
			HighHPPreference = (int)token["high_hp_preference"];					// HPが半分以上の時に使用する可能性
			MoveBattleStyle = new NamedAPIResourceData(token["move_battle_style"]);	// 技スタイル
		}
		#endregion
	}
}
