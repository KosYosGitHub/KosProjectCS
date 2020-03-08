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
	/// バージョンクラス
	/// </summary>
	public class Version : PokeAPIBase
	{
		// public 定数

		#region 赤
		/// <summary>赤</summary>
		public const string NameRed = "RED";
		#endregion

		#region 緑
		/// <summary>緑</summary>
		public const string NameBlue = "BLUE";
		#endregion

		#region ピカチュウ
		/// <summary>ピカチュウ</summary>
		public const string NameYellow = "YELLOW";
		#endregion

		#region 金
		/// <summary>金</summary>
		public const string NameGold = "GOLD";
		#endregion

		#region 銀
		/// <summary>銀</summary>
		public const string NameSilver = "SILVER";
		#endregion

		#region クリスタル
		/// <summary>クリスタル</summary>
		public const string NameCrystal = "CRYSTAL";
		#endregion

		#region ルビー
		/// <summary>ルビー</summary>
		public const string NameRuby = "RUBY";
		#endregion

		#region サファイア
		/// <summary>サファイア</summary>
		public const string NameSapphire = "SAPPHIRE";
		#endregion

		#region エメラルド
		/// <summary>エメラルド</summary>
		public const string NameEmerald = "EMERALD";
		#endregion

		#region ファイアレッド
		/// <summary>ファイアレッド</summary>
		public const string NameFireRed = "FIRERED";
		#endregion

		#region リーフグリーン
		/// <summary>リーフグリーン</summary>
		public const string NameLeafGreen = "LEAFGREEN";
		#endregion

		#region ダイヤモンド
		/// <summary>ダイヤモンド</summary>
		public const string NameDiamond = "DIAMOND";
		#endregion

		#region パール
		/// <summary>パール</summary>
		public const string NamePearl = "PEARL";
		#endregion

		#region プラチナ
		/// <summary>プラチナ</summary>
		public const string NamePlutinum = "PLUTINUM";
		#endregion

		#region ハートゴールド
		/// <summary>ハートゴールド</summary>
		public const string NameHeartGold = "HEARTGOLD";
		#endregion

		#region ソウルシルバー
		/// <summary>ソウルシルバー</summary>
		public const string NameSoulSilver = "SOULSILVER";
		#endregion

		#region ブラック
		/// <summary>ブラック</summary>
		public const string NameBlack = "BLACK";
		#endregion

		#region ホワイト
		/// <summary>ホワイト</summary>
		public const string NameWhite = "WHITE";
		#endregion

		#region ブラック2
		/// <summary>ブラック2</summary>
		public const string NameBlack2 = "BLACK-2";
		#endregion

		#region ホワイト2
		/// <summary>ホワイト2</summary>
		public const string NameWhite2 = "WHITE-2";
		#endregion

		#region X
		/// <summary>X</summary>
		public const string NameX = "X";
		#endregion

		#region Y
		/// <summary>Y</summary>
		public const string NameY = "Y";
		#endregion

		#region オメガルビー
		/// <summary>オメガルビー</summary>
		public const string NameOmegaRuby = "OMEGA-RUBY";
		#endregion

		#region アルファサファイア
		/// <summary>アルファサファイア</summary>
		public const string NameAlphaSapphire = "ALPHA-SAPPHIRE";
		#endregion

		#region サン
		/// <summary>サン</summary>
		public const string NameSun = "SUN";
		#endregion

		#region ムーン
		/// <summary>ムーン</summary>
		public const string NameMoon = "MOON";
		#endregion

		#region ウルトラサン
		/// <summary>ウルトラサン</summary>
		public const string NameUltraSun = "ULTRA-SUN";
		#endregion

		#region ウルトラムーン
		/// <summary>ウルトラムーン</summary>
		public const string NameUltraMoon = "ULTRA-MOON";
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
		public Version() : base("version")
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
			versionDataIDKey.Clear();
			versionDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region バージョン情報取得
		/// <summary>
		/// バージョン情報取得
		/// </summary>
		/// <param name="name">バージョン名</param>
		public void GetVersion(string name)
		{
			// バージョンリストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(versionDataNameKey.ContainsKey(name)) {
				return;
			}

			// バージョンAPIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// バージョンJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// バージョンJSON文字列解析
			ParseVersionJson(json);
		}
		#endregion

		// private メンバ変数

		#region バージョンディクショナリ(IDキー)
		/// <summary>バージョンディクショナリ(IDキー)</summary>
		private Dictionary<int, VersionData> versionDataIDKey = new Dictionary<int, VersionData>();
		#endregion

		#region バージョンディクショナリ(Nameキー)
		/// <summary>バージョンディクショナリ(Nameキー)</summary>
		private Dictionary<string, VersionData> versionDataNameKey = new Dictionary<string, VersionData>();
		#endregion

		// private メソッド

		#region バージョン JSON解析
		/// <summary>
		/// バージョン JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseVersionJson(string json)
		{
			JObject obj = JObject.Parse(json);

			VersionData data = new VersionData(obj);

			// ディクショナリに追加
			versionDataIDKey.Add(data.ID, data);
			versionDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
