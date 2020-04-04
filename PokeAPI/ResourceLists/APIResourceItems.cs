using System.Collections.Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// APIリソースリスト
	/// </summary>
	public class APIResourceItems : APIResourceItesmBase
	{
		// プロパティ
		#region リソースリスト
		/// <summary>リソースリスト</summary>
		public List<APIResourceData> Results { get; internal set; } = null;
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="json">JSON文字列</param>
		public APIResourceItems(string json) : base(json)
		{
		}
		#endregion

		// private メソッド

		#region JSON解析
		/// <summary>
		/// JSON解析
		/// </summary>
		/// <param name="obj">JSONオブジェクト</param>
		/// <param name="name">名称</param>
		protected override void Parse(JObject obj, string name)
		{
			if(Results == null) {
				Results = new List<APIResourceData>();
			}

			APIResourceData.ParseList(obj, "results", Results);
		}
		#endregion
	}
}
