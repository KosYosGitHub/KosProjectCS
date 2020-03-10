using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	public class ItemList : PokeAPIBase
	{
		// public プロパティ

		#region アイテム名称リスト
		/// <summary>アイテム名称リスト</summary>
		public List<string> Names => MakeNames();
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ItemList() : base("item")
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

		#region 言語名称リストの作成
		/// <summary>
		/// 言語名称リストの作成
		/// </summary>
		/// <returns>名称リスト</returns>
		private List<string> MakeNames()
		{
			return NamedAPIResourceList.Results.Select(x => x.Name).ToList();
		}
		#endregion
	}
}
