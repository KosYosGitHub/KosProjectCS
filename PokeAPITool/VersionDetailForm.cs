using System;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class VersionDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionDetailForm(string titleText, string apiName) : base(titleText, apiName)
		{
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
		private void VersionDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region バージョングループ詳細ボタン クリック
		/// <summary>
		/// バージョングループ詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroupDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region 言語詳細ボタン クリック
		/// <summary>
		/// 言語詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLanguageDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		protected override void ShowData()
		{
			base.ShowData();

			VersionData data = Singleton<PokeAPIToolModel>.Instance.VersionDetailList.GetVersion(apiName);

			idData.Text = $"{data.ID}";						// ID
			nameData.Text = data.Name;						// 名称
			versionGroupData.Text = data.VersionGroup.Name;	// バージョングループ

			// 言語ごとの名称
			languageNameView.Rows.Clear();
			foreach(NameData language in data.Names) {
				languageNameView.Rows.Add(language.Language.Name, language.Name);
			}
		}
		#endregion
	}
}
