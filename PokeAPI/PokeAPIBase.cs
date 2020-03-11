using Generic;

namespace PokeAPI
{
	/// <summary>
	/// PokeAPI 基本用クラス
	/// </summary>
	public abstract class PokeAPIBase
	{
		// protected メンバ変数

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected APIResourceListData apiResourceList = null;
		#endregion

		// protected プロパティ

		#region APIエンドポイント
		/// <summary>APIエンドポイント</summary>
		protected string APIEndPoint => apiEndPoint;
		#endregion

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected APIResourceListData APIResourceList => apiResourceList;
		#endregion

		// protected メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="apiEndPoint">APIエンドポイント</param>
		protected PokeAPIBase(string apiEndPoint)
		{
			this.apiEndPoint = apiEndPoint;
		}
		#endregion

		#region APIリソースの取得
		/// <summary>
		/// APIリソースの取得
		/// </summary>
		protected void GetAPIResourceList()
		{
			// 取得済確認
			if(apiResourceList != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetAPIResourceListEndPoint(apiEndPoint);

			// 取得したJSON文字列を解析
			apiResourceList = new APIResourceListData(json);
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		protected void Clear()
		{
			apiResourceList = null;
		}
		#endregion

		// private メンバ変数

		#region APIエンドポイント
		/// <summary>APIエンドポイント</summary>
		private string apiEndPoint = null;
		#endregion
	}
}
