using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// タイプデータクラス
	/// </summary>
	public class TypeData : APIResource
	{
		// プロパティ

		#region タイプ相性
		/// <summary>タイプ相性</summary>
		public TypeRelationsData DamageRelations { get; internal set; } = null;
		#endregion

		#region 世代ごとのゲームインデックス
		/// <summary>世代ごとのゲームインデックス</summary>
		public List<GenerationGameIndexData> GameIndices { get; internal set; } = null;
		#endregion

		#region 世代
		/// <summary>世代</summary>
		public NamedAPIResourceData Generation { get; internal set; } = null;
		#endregion

		#region 技ダメージタイプ
		/// <summary>技ダメージタイプ</summary>
		public NamedAPIResourceData MoveDamageClass { get; internal set; } = null;
		#endregion

		#region 言語ごとの名称
		/// <summary>言語ごとの名称</summary>
		public List<NameData> Names { get; internal set; } = null;
		#endregion

		#region タイプを持つポケモン
		/// <summary>タイプを持つポケモン</summary>
		public List<TypePokemonData> Pokemon { get; internal set; } = null;
		#endregion

		#region タイプを持つ技
		/// <summary>タイプを持つ技</summary>
		public List<NamedAPIResourceData> Moves { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="token">JSONトークン</param>
		public TypeData(JToken token)
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
			ID = (int)token["id"];													// ID
			Name = (token["name"] as JValue).ToString();							// 名称
			DamageRelations = new TypeRelationsData(token["damage_relations"]);		// タイプ相性
			Generation = new NamedAPIResourceData(token["generation"]);				// 世代
			MoveDamageClass = new NamedAPIResourceData(token["move_damage_class"]);	// 技ダメージタイプ

			// 世代ごとのゲームインデックス
			GameIndices = new List<GenerationGameIndexData>();
			GenerationGameIndexData.ParseList(token, "game_indices", GameIndices);

			// 言語ごとの名称
			Names = new List<NameData>();
			NameData.ParseList(token, "names", Names);

			// タイプを持つポケモン
			Pokemon = new List<TypePokemonData>();
			TypePokemonData.ParseList(token, "pokemon", Pokemon);

			// タイプを持つ技
			Moves = new List<NamedAPIResourceData>();
			NamedAPIResourceData.ParseList(token, "moves", Moves);
		}
		#endregion
	}
}
