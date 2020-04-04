using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// APIリソースリスト画面
	/// </summary>
	public partial class APIResourceListForm : Form
	{
		// public static メソッド

		#region 画面を表示
		/// <summary>
		/// 画面を表示
		/// </summary>
		/// <param name="titleText">タイトル文字列</param>
		/// <param name="detailFormType">詳細フォーム型</param>
		/// <param name="namedAPIResourceList">名前付きAPIリソースリスト</param>
		/// <param name="parent">親フォーム</param>
		public static void ShowDialog(string titleText, Type detailFormType, APIResourceList aPIResourceList, Form parent)
		{
			APIResourceListForm form = new APIResourceListForm(titleText, detailFormType, aPIResourceList);

			form.ShowDialog(parent);
		}
		#endregion

		// メンバ変数

		#region タイトル文字列
		/// <summary>タイトル文字列</summary>
		private string titleText = string.Empty;
		#endregion

		#region 詳細フォーム型
		/// <summary>詳細フォーム型</summary>
		private Type detailFormType = null;
		#endregion

		#region APIリソースリスト
		/// <summary>APIリソースリスト</summary>
		private APIResourceList aPIResourceList = null;
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public APIResourceListForm(string titleText, Type detailFormType, APIResourceList aPIResourceList)
		{
			// コンポーネントの初期化
			InitializeComponent();

			// メンバ設定
			this.titleText = titleText;
			this.detailFormType = detailFormType;
			this.aPIResourceList = aPIResourceList;
		}
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void APIResourceListForm_Load(object sender, EventArgs e)
		{
			Clear();
		}
		#endregion

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void APIResourceListForm_Shown(object sender, EventArgs e)
		{
			// データを表示
			ShowData();
		}
		#endregion

		// private メソッド

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		private void Clear()
		{
			listDataView.Rows.Clear();
		}
		#endregion

		#region データ表示
		/// <summary>
		/// データ表示
		/// </summary>
		private void ShowData()
		{
			// タイトルバー
			this.Text = titleText;

			// データ
			listDataView.Rows.Clear();
			foreach(string url in aPIResourceList.URLList) {
				listDataView.Rows.Add(url);
			}
		}
		#endregion
	}
}
