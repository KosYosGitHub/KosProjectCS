using System;
using System.Windows.Forms;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// 名前付きAPIリソースリスト画面
	/// </summary>
	/// <typeparam name="T">詳細フォームクラス</typeparam>
	public partial class NamedAPIResourceListForm : Form
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
		public static void ShowDialog(string titleText, Type detailFormType, NamedAPIResourceList namedAPIResourceList, Form parent)
		{
			Cursor cursor = Cursor.Current;

			try {
				Cursor.Current = Cursors.WaitCursor;

				NamedAPIResourceListForm form = new NamedAPIResourceListForm(titleText, detailFormType, namedAPIResourceList);

				form.ShowDialog(parent);
			}
			finally {
				Cursor.Current = cursor;
			}
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

		#region 名前付きAPIリソースリスト
		/// <summary>名前付きAPIリソースリスト</summary>
		private NamedAPIResourceList namedAPIResourceList = null;
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public NamedAPIResourceListForm(string titleText, Type detailFormType, NamedAPIResourceList namedAPIResourceList)
		{
			// コンポーネント初期化
			InitializeComponent();

			// データ設定
			this.titleText = titleText;
			this.detailFormType = detailFormType;
			this.namedAPIResourceList = namedAPIResourceList;
		}
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NamedAPIResourceListDialog_Load(object sender, EventArgs e)
		{
			Clear();
		}
		#endregion

		#region 画面表示
		/// <summary>
		/// 画面表示時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NamedAPIResourceListForm_Shown(object sender, EventArgs e)
		{
			Cursor cursor = Cursor.Current;

			try {
				// カーソルをウェイトに変更
				Cursor.Current = Cursors.WaitCursor;

				// データを表示
				ShowData();
			}
			finally {
				// カーソルを戻す
				Cursor.Current = cursor;
			}
		}
		#endregion

		#region リスト 選択変更
		/// <summary>
		/// リスト 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listDataView_SelectionChanged(object sender, EventArgs e)
		{
			if(listDataView.SelectedRows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = listDataView.SelectedRows[0];

			nameData.Text = row.Cells[0].Value.ToString();
			urlData.Text = namedAPIResourceList.GetURL(nameData.Text);
		}
		#endregion

		#region 詳細ボタン クリック
		/// <summary>
		/// 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void detailButton_Click(object sender, EventArgs e)
		{
			DetailForm.ShowDialog(titleText, nameData.Text, detailFormType, this);

		}
		#endregion

		// private メソッド

		#region クリア
		/// <summary>
		/// クリア
		/// </summary>
		private void Clear()
		{
			this.Text = "読込中...";
			listDataView.Columns[0].HeaderText = string.Empty;
			listDataView.Rows.Clear();
		}
		#endregion

		#region データ表示
		/// <summary>
		/// データの表示
		/// </summary>
		private void ShowData()
		{
			// タイトルバー
			this.Text = titleText;

			// リストヘッダ
			listDataView.Columns[0].HeaderText = titleText;

			// データ
			listDataView.Rows.Clear();
			foreach(string name in namedAPIResourceList.Names) {
				listDataView.Rows.Add(name);
			}
		}
		#endregion
	}
}
