using System;
using System.Windows.Forms;

namespace PokeAPITool
{
	/// <summary>
	/// 詳細フォームクラス
	/// </summary>
	public partial class DetailForm : Form
	{
		// public static メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		/// <param name="titleText">タイトル文字列</param>
		/// <param name="apiName">API名</param>
		/// <param name="formType">フォーム型</param>
		/// <param name="parent">親フォーム</param>
		public static void ShowDialog(string titleText, string apiName, Type formType, Form parent)
		{
			DetailForm form = Activator.CreateInstance(formType, titleText, apiName) as DetailForm;

			if(form != null) {
				form.ShowDialog(parent);
			}
		}
		#endregion

		// protected メンバ変数

		#region タイトル文字列
		/// <summary>タイトル文字列</summary>
		protected string titleText = string.Empty;
		#endregion

		#region API名称
		/// <summary>API名称</summary>
		protected string apiName = string.Empty;
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="apiName">API名称</param>
		public DetailForm(string titleText, string apiName)
		{
			// コンポーネントの初期化
			InitializeComponent();

			// データ設定
			this.titleText = titleText;
			this.apiName = apiName;
		}
		#endregion

		// protected メソッド

		#region データの表示
		/// <summary>
		/// データの表示
		/// </summary>
		protected virtual void ShowData()
		{
			Text = titleText;
		}
		#endregion
	}
}
