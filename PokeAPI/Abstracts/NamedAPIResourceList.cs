using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	/// <summary>
	/// 名前付きリソースリストクラス
	/// </summary>
	public abstract class NamedAPIResourceList : APIResourceListBase
	{
		// protected メンバ変数

		#region 結果リスト
		/// <summary>結果リスト</summary>
		protected NamedAPIResourceItems results = null;
		#endregion

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
		/// <param name="endPoint">APIリソース エンドポイント</param>
		public NamedAPIResourceList(string endPoint) : base(endPoint)
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
			string url = results.Results.FirstOrDefault(x => x.Name == name)?.URL;

			if(string.IsNullOrWhiteSpace(url)) {
				return string.Empty;
			}

			return url;
		}
		#endregion

		// private メソッド

		#region 名前付きAPIリソースリスト
		/// <summary>
		/// 名前付きAPIリソースリスト
		/// </summary>
		private void GetNamedAPIResourceList()
		{
			// 取得済確認
			if(results != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = GetAPIResourceListJson();

			// 取得したJSON文字列を解析
			results = new NamedAPIResourceItems(json);
		}
		#endregion

		#region 名称リストの作成
		/// <summary>
		/// 名称リストの作成
		/// </summary>
		/// <returns>名称リスト</returns>
		private List<string> MakeNames()
		{
			return results.Results.Select(x => x.Name).ToList();
		}
		#endregion
	}
}
