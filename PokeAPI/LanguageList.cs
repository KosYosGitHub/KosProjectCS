using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	/// <summary>
	/// 言語リストクラス
	/// </summary>
	public class LanguageList : PokeAPIBase
	{
		// public プロパティ

		#region 言語名称リスト
		/// <summary>言語名称リスト</summary>
		public List<string> Names => MakeNames();
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageList() : base("language")
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

		// private 関数

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
