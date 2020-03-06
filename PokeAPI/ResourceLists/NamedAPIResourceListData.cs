using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	public class NamedAPIResourceListData
	{
		// プロパティ

		#region 利用可能なリソース数
		/// <summary>利用可能なリソース数</summary>
		public int Count { get; internal set; } = 0;
		#endregion

		#region リソースリスト
		/// <summary>リソースリスト</summary>
		public List<NamedAPIResourceData> Results { get; internal set; } = null;
		#endregion

		// public メソッド

		#region APIリソースのURLを取得
		/// <summary>
		/// APIリソースのURLを取得
		/// </summary>
		/// <param name="name">名称</param>
		/// <returns>URL</returns>
		public string GetURL(string name)
		{
			string url = Results.FirstOrDefault(x => x.Name == name)?.URL;
			if(string.IsNullOrEmpty(url)) {
				throw new Exception($"{name}のAPIリソースが見つかりません。");
			}

			return url;
		}
		#endregion

	}
}
