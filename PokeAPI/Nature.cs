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
	/// 性格
	/// </summary>
	public class Nature : PokeAPIBase
	{
		// public 定数

		#region 頑張り屋
		/// <summary>頑張り屋</summary>
		public const string NameHardy = "HARDY";
		#endregion

		#region 図太い
		/// <summary>図太い</summary>
		public const string NameBold = "BOLD";
		#endregion

		#region 控え目
		/// <summary>控え目</summary>
		public const string NameModest = "MODEST";
		#endregion

		#region 穏やか
		/// <summary>穏やか</summary>
		public const string NameCalm = "CALM";
		#endregion

		#region 臆病
		/// <summary>臆病</summary>
		public const string NameTimid = "TIMID";
		#endregion

		#region さみしがり
		/// <summary>さみしがり</summary>
		public const string NameLonely = "LONELY";
		#endregion

		#region 素直
		/// <summary>素直</summary>
		public const string NameDocile = "DOCILE";
		#endregion

		#region おっとり
		/// <summary>おっとり</summary>
		public const string NameMild = "MILD";
		#endregion

		#region 大人しい
		/// <summary>大人しい</summary>
		public const string NameGentle = "GENTLE";
		#endregion

		#region せっかち
		/// <summary>せっかち</summary>
		public const string NameHasty = "HASTY";
		#endregion

		#region 意地っ張り
		/// <summary>意地っ張り</summary>
		public const string NameAdamant = "ADAMANT";
		#endregion

		#region わんぱく
		/// <summary>わんぱく</summary>
		public const string NameImpish = "IMPISH";
		#endregion

		#region 照れ屋
		/// <summary>照れ屋</summary>
		public const string NameBashful = "BASHFUL";
		#endregion

		#region 慎重
		/// <summary>慎重</summary>
		public const string NameCareful = "CAREFUL";
		#endregion

		#region うっかりや
		/// <summary>うっかりや</summary>
		public const string NameRash = "RASH";
		#endregion

		#region 陽気
		/// <summary>陽気</summary>
		public const string NameJolly = "JOLLY";
		#endregion

		#region やんちゃ
		/// <summary>やんちゃ</summary>
		public const string NameNaughty = "NAUGHTY";
		#endregion

		#region 能天気
		/// <summary>能天気</summary>
		public const string NameLax = "LAX";
		#endregion

		#region 気まぐれ
		/// <summary>気まぐれ</summary>
		public const string NameQuirky = "QUIRKY";
		#endregion

		#region 無邪気
		/// <summary>無邪気</summary>
		public const string NameNaive = "NAIVE";
		#endregion

		#region 勇敢
		/// <summary>勇敢</summary>
		public const string NameBrave = "BRAVE";
		#endregion

		#region のんき
		/// <summary>のんき</summary>
		public const string NameRelaxed = "RELAXED";
		#endregion

		#region 冷静
		/// <summary>冷静</summary>
		public const string NameQuiet = "QUIET";
		#endregion

		#region 生意気
		/// <summary>生意気</summary>
		public const string NameSassy = "SASSY";
		#endregion

		#region まじめ
		/// <summary>まじめ</summary>
		public const string NameSerious = "SERIOUS";
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Nature() : base("nature")
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
			natureDataIDKey.Clear();
			natureDataNameKey.Clear();
		}
		#endregion

		// internal メソッド

		#region 性格の取得
		/// <summary>
		/// 性格の取得
		/// </summary>
		/// <param name="name">名称</param>
		public void GetNature(string name)
		{
			// 性格リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			if(natureDataNameKey.ContainsKey(name)) {
				return;
			}

			// 性格APIリソースURLの取得
			string url = NamedAPIResourceList.GetURL(name);

			// 性格JSON文字列の取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 性格JSON文字列の解析
			ParseNatureJson(json);
		}
		#endregion

		// private メンバ変数

		#region 性格データ(IDキー)
		/// <summary>性格データ(IDキー)</summary>
		public Dictionary<int, NatureData> natureDataIDKey = new Dictionary<int, NatureData>();
		#endregion

		#region 性格データ(Nameキー)
		/// <summary>性格データ(Nameキー)</summary>
		public Dictionary<string, NatureData> natureDataNameKey = new Dictionary<string, NatureData>();
		#endregion

		// private メソッド

		#region 性格JSON 解析
		/// <summary>
		/// 性格JSON 解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		private void ParseNatureJson(string json)
		{
			JObject obj = JObject.Parse(json);

			NatureData data = new NatureData(obj);

			// ディクショナリに追加
			natureDataIDKey.Add(data.ID, data);
			natureDataNameKey.Add(data.Name.ToUpper(), data);
		}
		#endregion
	}
}
