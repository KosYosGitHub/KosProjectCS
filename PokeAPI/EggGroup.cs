using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 卵グループ
	/// </summary>
	public class EggGroup : PokeAPIBase
	{
		// public 定数

		#region 怪獣
		/// <summary>怪獣</summary>
		public const string NameMonster = "MONSTER";
		#endregion

		#region 水中1
		/// <summary>水中1</summary>
		public const string NameWater1 = "WATER1";
		#endregion

		#region 水中2
		/// <summary>水中2</summary>
		public const string NameWater2 = "WATER2";
		#endregion

		#region 水中3
		/// <summary>水中3</summary>
		public const string NameWater3 = "WATER3";
		#endregion

		#region 虫
		/// <summary>虫</summary>
		public const string NameBug = "BUG";
		#endregion

		#region 飛行
		/// <summary>飛行</summary>
		public const string NameFlying = "FLYING";
		#endregion

		#region 陸上
		/// <summary>陸上</summary>
		public const string NameGround = "GROUND";
		#endregion

		#region 妖精
		/// <summary>妖精</summary>
		public const string NameFairy = "FAIRY";
		#endregion

		#region 植物
		/// <summary>植物</summary>
		public const string NamePlant = "PLANT";
		#endregion

		#region 人型
		/// <summary>人型</summary>
		public const string NameHumanShape = "HUMANSHAPE";
		#endregion

		#region 鉱物
		/// <summary>鉱物</summary>
		public const string NameMineral = "MINERAL";
		#endregion

		#region 不定形
		/// <summary>不定形</summary>
		public const string NameIndeterminate = "INDETERMINATE";
		#endregion

		#region メタモン
		/// <summary>メタモン</summary>
		public const string NameDitto = "DITTO";
		#endregion

		#region ドラゴン
		/// <summary>ドラゴン</summary>
		public const string NameDragon = "DRAGON";
		#endregion

		#region 未発見
		/// <summary>未発見</summary>
		public const string NameNoEggs = "NO-EGGS";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public EggGroup() : base("egg-group")
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
			eggGroupDataIDKey.Clear();
			eggGroupDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region 卵グループの取得
		/// <summary>
		/// 卵グループの取得
		/// </summary>
		/// <param name="name">名称</param>
		public void GetEggGroup(string name)
		{
			// 卵グループリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(eggGroupDataNameKey.ContainsKey(name)) {
				return;
			}

			// 卵グループAPIリソースURLの取得
			string url = NamedAPIResourceList.GetURL(name);

			// 卵グループJSON文字列の取得
			string json = RunPokeAPI(url);

			// 卵グループJSON文字列の解析
			ParseEggGroupJson(json);
		}
		#endregion

		// private メンバ変数

		#region 卵グループディクショナリ(IDキー)
		/// <summary>卵グループディクショナリ(IDキー)</summary>
		private Dictionary<int, EggGroupData> eggGroupDataIDKey = new Dictionary<int, EggGroupData>();
		#endregion

		#region 卵グループディクショナリ(Nameキー)
		/// <summary>卵グループディクショナリ(Nameキー)</summary>
		private Dictionary<string, EggGroupData> eggGroupDataNameKey = new Dictionary<string, EggGroupData>();
		#endregion

		// private メソッド

		#region 卵グループ JSON解析
		/// <summary>
		/// 卵グループ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseEggGroupJson(string json)
		{
			JObject obj = JObject.Parse(json);
			EggGroupData data = new EggGroupData();

			data.ID = (int)obj["id"];							// ID
			data.Name = (obj["name"] as JValue).ToString();     // 名称

			// 言語ごとの名称
			data.Names = new List<NameData>();
			ParseNameList(obj, "names", data.Names);

			// ポケモン
			data.PokemonSpecies = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "pokemon_species", data.PokemonSpecies);

			// ディクショナリに追加
			eggGroupDataIDKey.Add(data.ID, data);
			eggGroupDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
