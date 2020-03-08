using System.Collections.Generic;
using System.Net.Http;
using Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// PokeAPI 基本用クラス
	/// </summary>
	public abstract class PokeAPIBase
	{
		// protected メンバ変数

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		protected NamedAPIResourceListData namedAPIResourceList = null;
		#endregion

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		protected APIResourceListData apiResourceList = null;
		#endregion

		// protected プロパティ

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		protected NamedAPIResourceListData NamedAPIResourceList => namedAPIResourceList;
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

		#region 名前付きAPIリソースの取得
		/// <summary>
		/// 名前付きAPIリソースの取得
		/// </summary>
		protected void GetNamedAPIResourceList()
		{
			// 取得済確認
			if(namedAPIResourceList != null) {
				return;
			}

			// APIリソースのJSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetAPIResourceListEndPoint(apiEndPoint);

			// 取得したJSON文字列を解析
			namedAPIResourceList = new NamedAPIResourceListData(json);
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
			namedAPIResourceList = null;
			apiResourceList = null;
		}
		#endregion

		// private メンバ変数

		#region APIエンドポイント
		/// <summary>APIエンドポイント</summary>
		string apiEndPoint = null;
		#endregion
	}
}
