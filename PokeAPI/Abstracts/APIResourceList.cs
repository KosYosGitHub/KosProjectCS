using System.Collections.Generic;
using System.Linq;

namespace PokeAPI
{
	/// <summary>
	/// リソースリストクラス
	/// </summary>
	public abstract class APIResourceList : APIResourceListBase
	{
		// protected メンバ変数

		#region 結果リスト
		/// <summary>結果リスト</summary>
		protected APIResourceItems results = null;
		#endregion

		// public プロパティ

		#region URLリスト
		/// <summary>
		/// URLリスト
		/// </summary>
		public List<string> URLList => MakeURLs();
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="endPoint">エンドポイント</param>
		public APIResourceList(string endPoint) : base(endPoint)
		{
			GetAPIResourceList();
		}
		#endregion

		// private メソッド

		#region APIリソースリスト
		/// <summary>
		/// APIリソースリスト
		/// </summary>
		private void GetAPIResourceList()
		{
			// 取得済確認
			if(results != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = GetAPIResourceListJson();

			// 取得したJSON文字列を解析
			results = new APIResourceItems(json);
		}
		#endregion

		#region URLリスト作成
		/// <summary>
		/// URLリスト作成
		/// </summary>
		/// <returns>URLリスト</returns>
		private List<string> MakeURLs()
		{
			return results.Results.Select(x => x.URL).ToList();
		}
		#endregion
	}
}
