using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// バージョングループクラス
	/// </summary>
	public class VersionGroup : PokeAPIBase
	{
		// public 定数

		#region 赤・緑
		/// <summary>赤・緑</summary>
		public const string NameRedBlue = "RED-BLUE";
		#endregion

		#region ピカチュウ
		/// <summary>ピカチュウ</summary>
		public const string NameYellow = "YELLOW";
		#endregion

		#region 金・銀
		/// <summary>金・銀</summary>
		public const string NameGoldSilver = "GOLD-SILVER";
		#endregion

		#region クリスタル
		/// <summary>クリスタル</summary>
		public const string NameCrystal = "CRYSTAL";
		#endregion

		#region ルビー・サファイア
		/// <summary>ルビー・サファイア</summary>
		public const string NameRubySapphire = "RUBY-SAPPHIRE";
		#endregion

		#region エメラルド
		/// <summary>エメラルド</summary>
		public const string NameEmerald = "EMERALD";
		#endregion

		#region ファイアレッド・リーフグリーン
		/// <summary>ファイアレッド・リーフグリーン</summary>
		public const string NameFireRedLeafGreen = "FIRERED-LEAFGREEN";
		#endregion

		#region ダイヤモンド・パール
		/// <summary>ダイヤモンド・パール</summary>
		public const string NameDiamondPearl = "DIAMOND-PEARL";
		#endregion

		#region プラチナ
		/// <summary>プラチナ</summary>
		public const string NamePlutinum = "PLUTINUM";
		#endregion

		#region ハートゴールド・ソウルシルバー
		/// <summary>ハートゴールド・ソウルシルバー</summary>
		public const string NameHeartGoldSoulSilver = "HEARTGOLD-SOULSILVER";
		#endregion

		#region ブラック・ホワイト
		/// <summary>ブラック・ホワイト</summary>
		public const string NameBlackWhite = "BLACK-WHITE";
		#endregion

		#region ブラック2・ホワイト2
		/// <summary>ブラック2・ホワイト2</summary>
		public const string NameBlack2White2 = "BLACK-2-WHITE-2";
		#endregion

		#region X・Y
		/// <summary>X・Y</summary>
		public const string NameXY = "X-Y";
		#endregion

		#region オメガルビー・アルファサファイア
		/// <summary>オメガルビー・アルファサファイア</summary>
		public const string NameOmegaRubyAlphaSapphire = "OMEGA-RUBY-ALPHA-SAPPHIRE";
		#endregion

		#region サン・ムーン
		/// <summary>サン・ムーン</summary>
		public const string NameSunMoon = "SUN-MOON";
		#endregion

		#region ウルトラサン・ウルトラムーン
		/// <summary>ウルトラサン・ウルトラムーン</summary>
		public const string NameUltraSunUltraMoon = "ULTRA-SUN-ULTRA-MOON";
		#endregion

		#region ポケモンコロシアム
		/// <summary>コロシアム</summary>
		public const string NameColusseum = "COLUSSEUM";
		#endregion

		#region ポケモンXD 闇の旋風ダーク・ルギア
		/// <summary>ポケモンXD 闇の旋風ダーク・ルギア</summary>
		public const string NameXD = "XD";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroup() : base("version-group")
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
			versionGroupDataIDKey = null;
			versionGroupDataNameKey = null;
		}
		#endregion

		// internal メソッド

		#region バージョングループ情報取得
		/// <summary>
		/// バージョングループ情報取得
		/// </summary>
		/// <param name="name">バージョングループ名</param>
		public void GetVersionGroup(string name)
		{
			// 言語リストの取得
			GetAPIResourceList();

			// 読込済確認
			if(versionGroupDataNameKey.ContainsKey(name)) {
				return;
			}

			// バージョングループAPIリソースURL取得
			string url = APIResourceList.GetURL(name);

			// バージョングループJSON文字列取得
			string json = RunPokeAPI(url);

			// バージョングループJSON文字列解析
			ParseVersionGroupJson(json);
		}
		#endregion

		// private メンバ変数

		#region バージョングループディクショナリ(IDキー)
		/// <summary>バージョングループディクショナリ(IDキー)</summary>
		private Dictionary<int, VersionGroupData> versionGroupDataIDKey = new Dictionary<int, VersionGroupData>();
		#endregion

		#region バージョングループディクショナリ(Nameキー)
		/// <summary>バージョングループディクショナリ(Nameキー)</summary>
		private Dictionary<string, VersionGroupData> versionGroupDataNameKey = new Dictionary<string, VersionGroupData>();
		#endregion

		// private メソッド

		#region バージョングループ JSON解析
		/// <summary>
		/// バージョングループ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseVersionGroupJson(string json)
		{
			JObject obj = JObject.Parse(json);
			VersionGroupData data = new VersionGroupData();

			data.ID = (int)obj["id"];								// ID
			data.Name = (obj["name"] as JValue).ToString();			// 名称
			data.Order = (int)obj["order"];							// ソート順番
			data.Generation = ParseNamedAPIResource(obj);           // 世代

			// 技の習得方法
			data.MoveLearnMethods = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "move_learn_methods", data.MoveLearnMethods);

			// ポケモン図鑑
			data.Pokedexes = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "pokedexes", data.Pokedexes);

			// 地方
			data.Regions = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "regions", data.Regions);

			// バージョン
			data.Versions = new List<NamedAPIResourceData>();
			ParseNamedAPIResourceList(obj, "versions", data.Versions);

			// ディクショナリに追加
			versionGroupDataIDKey.Add(data.ID, data);
			versionGroupDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
