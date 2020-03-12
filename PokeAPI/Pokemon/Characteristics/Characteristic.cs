using System.Collections.Generic;
using Generic;
using Newtonsoft.Json.Linq;

//--- MITライセンスに基づくコメント ---
// Newtonsoft.Json 使用
// 作成: James Newton-King
//-------------------------------------

namespace PokeAPI
{
	/// <summary>
	/// 個性クラス
	/// </summary>
	public class Characteristic// : PokeAPIBase
	{
		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Characteristic()// : base("characteristic")
		{
		}
		#endregion

		// internal メソッド

		#region 個性情報取得
		/// <summary>
		/// 個性情報取得
		/// </summary>
		/// <param name="id"></param>
		public void GetCharacteristic(int id)
		{
			// 個性リストの取得
// URLしかないからAPIリソースリスト読み込む必要なくね？			GetAPIResourceList();

			// 読込済確認
			if(!characteristicDataIDKey.ContainsKey(id)) {
				return;
			}

			// 個性APIリソースURLの取得
// URLしかないからどうやって特定すんの？			string url = APIResourceList.GetURL();
			string url = $"characteric/{id}/";

			// 個性JSON文字列取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 個性JSON文字列解析
			ParseCharacteristicJson(json);
		}
		#endregion

		// private メンバ変数

		#region 個性ディクショナリ(IDキー)
		/// <summary>個性ディクショナリ(IDキー)</summary>
		private Dictionary<int, CharacteristicData> characteristicDataIDKey = new Dictionary<int, CharacteristicData>();
		#endregion

		// private メソッド

		#region 個性 JSON解析
		/// <summary>
		/// 個性 JSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		/// <returns>解析データ</returns>
		private CharacteristicData ParseCharacteristicJson(string json)
		{
			JObject obj = JObject.Parse(json);

			return new CharacteristicData(obj);
		}
		#endregion
	}
}
