using System;
using System.Collections.Generic;
using Generic;

namespace PokeAPI
{
	public abstract class NamedAPIResourceListItem : PokeAPIBase
	{
		// private メンバ変数

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		private NamedAPIResourceList namedAPIResourceList = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="apiEndPoint">APIエンドポイント</param>
		public NamedAPIResourceListItem(string apiEndPoint, NamedAPIResourceList list) : base(apiEndPoint)
		{
			namedAPIResourceList = list;
		}
		#endregion

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		public new void Clear()
		{
			base.Clear();
			resourceKeyName.Clear();
		}
		#endregion

		// protected メソッド

		#region リソースの取得
		/// <summary>
		/// リソースの取得
		/// </summary>
		/// <param name="name">リソース名</param>
		/// <returns>APIリソース</returns>
		protected APIResource GetResource(string name)
		{
			// 読込済確認
			if(resourceKeyName.TryGetValue(name.ToUpper(), out APIResource resource)) {
				return resource;
			}

			// APIリソースURL取得
			string url = namedAPIResourceList.GetURL(name);

			// JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// JSON文字列解析
			APIResource result = ParseJson(json);

			// リソース追加
			resourceKeyName.Add(result.Name.ToUpper(), result);

			return result;
		}
		#endregion

		#region JSON文字列の解析
		/// <summary>
		/// JSON文字列の解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		protected virtual APIResource ParseJson(string json)
		{
			throw new NotImplementedException();
		}
		#endregion

		// private メソッド

		#region リソースディクショナリ(Nameキー)
		/// <summary>リソースディクショナリ(Nameキー)</summary>
		private Dictionary<string, APIResource> resourceKeyName = new Dictionary<string, APIResource>();
		#endregion
	}
}
