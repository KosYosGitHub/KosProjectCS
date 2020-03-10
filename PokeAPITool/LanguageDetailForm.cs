using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// 言語詳細画面
	/// </summary>
	public partial class LanguageDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageDetailForm(string titleText, string apiName) : base(titleText, apiName)
		{
			// コンポーネントの初期化
			InitializeComponent();
		}
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LanguageDetail_Load(object sender, EventArgs e)
		{
			// データの表示
			ShowData();
		}
		#endregion

		#region 言語詳細ボタン クリック
		/// <summary>
		/// 言語詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void languageDetailButton_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(languageNameView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = languageNameView.SelectedRows[0];

			// 選択言語の情報表示
			DetailForm.ShowDialog(titleText, row.Cells[0].Value.ToString(), typeof(LanguageDetailForm), this);
		}
		#endregion

		// private メソッド

		#region 画面にデータ表示
		/// <summary>
		/// 画面にデータ表示
		/// </summary>
		protected override void ShowData()
		{
			base.ShowData();

			// 言語詳細情報の取得
			LanguageData data = Singleton<PokeAPIToolModel>.Instance.LanguageDetailList.GetLanguage(apiName);

			idData.Text = $"{data.ID}";             // ID
			nameData.Text = data.Name;              // 名称
			officialData.Text = $"{data.Official}"; // 公式言語
			iso639Data.Text = data.ISO639;          // ISO639
			iso3166Data.Text = data.ISO3166;        // ISO3166

			// 言語別名称
			languageNameView.Rows.Clear();
			foreach(NameData name in data.Names) {
				languageNameView.Rows.Add(name.Language.Name, name.Name);
			}
		}
		#endregion
	}
}
