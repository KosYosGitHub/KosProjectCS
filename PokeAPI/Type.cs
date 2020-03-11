using Newtonsoft.Json.Linq;
using Generic;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------


namespace PokeAPI
{
	internal class Type : NamedAPIResourceListItem
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Type() : base("type", Singleton<TypeList>.Instance)
		{
		}
		#endregion

		#region タイプ情報取得
		/// <summary>
		/// タイプ情報取得
		/// </summary>
		/// <param name="name">タイプ名</param>
		/// <returns>タイプ</returns>
		public TypeData GetType(string name)
		{
			return GetResource(name) as TypeData;
		}
		#endregion

		// private メソッド

		#region タイプ JSON解析
		/// <summary>
		/// タイプ JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>データ</returns>
		protected override APIResource ParseJson(string json)
		{
			return new TypeData(JObject.Parse(json));
		}
		#endregion
	}
}
