using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	public class Region : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Region() : base("region")
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
			regionDataIDKey.Clear();
			regionDataNameKey.Clear();
		}
		#endregion

		public RegionData GetRegion(string name)
		{
			// 地方リストの取得
			GetNamedAPIResourceList();

			// 読込済確認
			RegionData data;
			if(regionDataNameKey.TryGetValue(name.ToUpper(), out data)) {
				return data;
			}

			// 地方APIリソースURL取得
			string url = NamedAPIResourceList.GetURL(name);

			// 地方JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 地方JSON文字列解析
			return ParseRegionData(json);
		}

		// private メンバ変数

		#region 地方データ(IDキー)
		/// <summary>地方データ(IDキー)</summary>
		private Dictionary<int, RegionData> regionDataIDKey = new Dictionary<int, RegionData>();
		#endregion

		#region 地方データ(Nameキー)
		/// <summary>地方データ(Nameキー)</summary>
		private Dictionary<string, RegionData> regionDataNameKey = new Dictionary<string, RegionData>();
		#endregion

		// private メソッド

		#region 地方 JSON解析
		/// <summary>
		/// 地方 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		private RegionData ParseRegionData(string json)
		{
			JObject obj = JObject.Parse(json);

			RegionData data = new RegionData(obj);

			// ディクショナリに追加
			regionDataIDKey.Add(data.ID, data);
			regionDataNameKey.Add(data.Name.ToUpper(), data);

			return data;
		}
		#endregion
	}
}
