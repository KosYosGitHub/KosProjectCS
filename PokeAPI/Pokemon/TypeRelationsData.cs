using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// タイプ相性データクラス
	/// </summary>
	public class TypeRelationsData
	{
		// プロパティ

		#region 攻撃側 無効
		/// <summary>攻撃側 無効</summary>
		public List<NamedAPIResourceData> NoDamageTo { get; internal set; } = null;
		#endregion

		#region 攻撃側 いまひとつ
		/// <summary>攻撃側 いまひとつ</summary>
		public List<NamedAPIResourceData> HalfDamageTo { get; internal set; } = null;
		#endregion

		#region 攻撃側 抜群
		/// <summary>攻撃側 抜群</summary>
		public List<NamedAPIResourceData> DoubleDamageTo { get; internal set; } = null;
		#endregion

		#region 防御側 無効
		/// <summary>防御側 無効</summary>
		public List<NamedAPIResourceData> NoDamageFrom { get; internal set; } = null;
		#endregion

		#region 防御側 いまひとつ
		/// <summary> 防御側 いまひとつ</summary>
		public List<NamedAPIResourceData> HalfDamageFrom { get; internal set; } = null;
		#endregion

		#region 防御側 抜群
		/// <summary>防御側 抜群</summary>
		public List<NamedAPIResourceData> DoubleDamageFrom { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public TypeRelationsData(JToken token)
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
			// 攻撃側 無効
			NoDamageTo = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "no_damage_to", NoDamageTo);

			// 攻撃側 いまひとつ
			HalfDamageTo = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "half_damage_to", HalfDamageTo);

			// 攻撃側 抜群
			DoubleDamageTo = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "double_damage_to", DoubleDamageTo);

			// 防御側 無効
			NoDamageFrom = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "no_damage_from", NoDamageFrom);

			// 防御側 いまひとつ
			HalfDamageFrom = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "half_damage_from", HalfDamageFrom);

			// 防御側 抜群
			DoubleDamageFrom = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "double_damage_from", DoubleDamageFrom);
		}
		#endregion
	}
}
