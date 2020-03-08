using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------


namespace PokeAPI
{
	internal class Type : PokeAPIBase
	{
		// public 定数

		#region ノーマル
		/// <summary>ノーマル</summary>
		public const string NameNormal = "NORMAL";
		#endregion

		#region 格闘
		/// <summary>格闘</summary>
		public const string NameFighting = "FIGHTING";
		#endregion

		#region 飛行
		/// <summary>飛行</summary>
		public const string NameFlying = "FLYING";
		#endregion

		#region 毒
		/// <summary>毒</summary>
		public const string NamePoison = "POISON";
		#endregion

		#region 地面
		/// <summary>地面</summary>
		public const string NameGround = "GROUND";
		#endregion

		#region 岩
		/// <summary>岩</summary>
		public const string NameRock = "ROCK";
		#endregion

		#region 虫
		/// <summary>虫</summary>
		public const string NameBug = "BUG";
		#endregion

		#region ゴースト
		/// <summary>ゴースト</summary>
		public const string NameGhost = "GHOST";
		#endregion

		#region 鋼
		/// <summary>鋼</summary>
		public const string NameSteel = "STEEL";
		#endregion

		#region 炎
		/// <summary>炎</summary>
		public const string NameFire = "FIRE";
		#endregion

		#region 水
		/// <summary>水</summary>
		public const string NameWater = "WATER";
		#endregion

		#region 草
		/// <summary>草</summary>
		public const string NameGrass = "GRASS";
		#endregion

		#region 電気
		/// <summary>電気</summary>
		public const string NameElectric = "ELECTRIC";
		#endregion

		#region エスパー
		/// <summary>エスパー</summary>
		public const string NamePsychic = "PSYCHIC";
		#endregion

		#region 氷
		/// <summary>氷</summary>
		public const string NameIce = "ICE";
		#endregion

		#region ドラゴン
		/// <summary>ドラゴン</summary>
		public const string NameDragon = "DRAGON";
		#endregion

		#region 悪
		/// <summary>悪</summary>
		public const string NameDark = "DARK";
		#endregion

		#region フェアリー
		/// <summary>フェアリー</summary>
		public const string NameFairy = "FAIRY";
		#endregion

		#region ダーク
		/// <summary>ダーク</summary>
		public const string NameShadow = "SHADOW";
		#endregion

		#region 不明
		/// <summary>不明</summary>
		public const string NameUnknown = "UNKNOWN";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Type() : base("type")
		{
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// /// </summary>
		public new void Clear()
		{
			base.Clear();
			typeDataIDKey.Clear();
			typeDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region タイプ情報取得
		/// <summary>
		/// タイプ情報取得
		/// </summary>
		/// <param name="name">タイプ名</param>
		public void GetType(string name)
		{
			// タイプリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(typeDataNameKey.ContainsKey(name)) {
				return;
			}

			// タイプAPIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// タイプJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// バージョンJSON文字列解析
			ParseTypeJson(json);
		}
		#endregion

		// private メンバ変数

		#region タイプデータ(IDキー)
		/// <summary>タイプデータ(IDキー)</summary>
		private Dictionary<int, TypeData> typeDataIDKey = new Dictionary<int, TypeData>();
		#endregion

		#region タイプデータ(Nameキー)
		/// <summary>タイプデータ(Nameキー)</summary>
		private Dictionary<string, TypeData> typeDataNameKey = new Dictionary<string, TypeData>();
		#endregion

		// private メソッド

		#region タイプ JSON解析
		/// <summary>
		/// タイプ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseTypeJson(string json)
		{
			JObject obj = JObject.Parse(json);

			TypeData data = new TypeData(obj);

			// ディクショナリに追加
			typeDataIDKey.Add(data.ID, data);
			typeDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
