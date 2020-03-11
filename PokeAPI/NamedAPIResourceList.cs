using System.Collections.Generic;
using System.Linq;
using Generic;

namespace PokeAPI
{
	/// <summary>
	/// 名前付きリソースリストクラス
	/// </summary>
	public abstract class NamedAPIResourceList : PokeAPIBase
	{
		// protected メンバ変数

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		protected NamedAPIResourceListData namedAPIResourceList = null;
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
		/// <param name="apiEndPoint">APIリソース エンドポイント</param>
		public NamedAPIResourceList(string apiEndPoint) : base(apiEndPoint)
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
			string url = namedAPIResourceList.Results.FirstOrDefault(x => x.Name == name)?.URL;

			if(url == null) {
				return string.Empty;
			}

			return url;
		}
		#endregion

		#region 名前付きAPIリソースの取得
		/// <summary>
		/// 名前付きAPIリソースの取得
		/// </summary>
		private void GetNamedAPIResourceList()
		{
			// 取得済確認
			if(namedAPIResourceList != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetAPIResourceListEndPoint(APIEndPoint);

			// 取得したJSON文字列を解析
			namedAPIResourceList = new NamedAPIResourceListData(json);
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			namedAPIResourceList = null;
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
			return namedAPIResourceList.Results.Select(x => x.Name).ToList();
		}
		#endregion
	}
}
