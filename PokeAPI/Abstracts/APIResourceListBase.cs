using Generic;

namespace PokeAPI
{
	/// <summary>
	/// APIリソースリストベース
	/// </summary>
	public abstract class APIResourceListBase
	{
		// private メンバ変数

		#region エンドポイント
		/// <summary>エンドポイント</summary>
		private readonly string endPoint = null;
		#endregion

		// protected メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="endPoint">エンドポイント</param>
		protected APIResourceListBase(string endPoint)
		{
			this.endPoint = endPoint;
		}
		#endregion

		#region APIリソースリストのJSON文字列取得
		/// <summary>
		/// APIリソースリストのJSON文字列取得
		/// </summary>
		/// <returns>JSON文字列</returns>
		protected string GetAPIResourceListJson()
		{
			return Singleton<PokeAPIClient>.Instance.GetAPIResourceListEndPoint(endPoint);
		}
		#endregion
	}
}
