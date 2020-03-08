using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	/// <summary>
	/// 地方リスト
	/// </summary>
	public class RegionList : PokeAPIBase
	{
		// public プロパティ

		#region 名称リスト
		/// <summary>名称リスト</summary>
		public List<string> Names => MakeNames();
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RegionList() : base("region")
		{
			GetNamedAPIResourceList();
		}
		#endregion

		#region URLの取得
		/// <summary>
		/// URLの取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>URL</returns>
		public string GetURL(string name)
		{
			string url = NamedAPIResourceList.Results.FirstOrDefault(x => x.Name == name)?.URL;

			if(url == null) {
				return string.Empty;
			}

			return url;
		}
		#endregion

		// private メソッド

		#region 名称リストの作成
		/// <summary>
		/// 名称リストの作成
		/// </summary>
		/// <returns>名称リスト</returns>
		private List<string> MakeNames()
		{
			return NamedAPIResourceList.Results.Select(x => x.Name).ToList();
		}
		#endregion
	}
}
