using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// バージョングループ詳細画面
	/// </summary>
	public partial class VersionGroupDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroupDetailForm(string titleText, string apiName) : base(titleText, apiName)
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
		private void VersionGroupDetail_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 世代詳細ボタン クリック
		/// <summary>
		/// 世代詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGenerationDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region バージョン詳細ボタン クリック
		/// <summary>
		/// バージョン詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region 地方詳細ボタン クリック
		/// <summary>
		/// 地方詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRegionDetail_Click(object sender, EventArgs e)
		{
		}
		#endregion

		#region 図鑑詳細ボタン クリック
		/// <summary>
		/// 図鑑詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPokedexDetail_Click(object sender, EventArgs e)
		{
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

			VersionGroupData data = Singleton<PokeAPIToolModel>.Instance.VersionGroupDetailList.GetVersionGroup(apiName);

			idData.Text = $"{data.ID}";                     // ID
			nameData.Text = data.Name;                      // 名称
			orderData.Text = $"{data.Order}";               // ソート順番
			generationData.Text = data.Generation.Name;     // 世代

			// バージョン
			versionDataView.Rows.Clear();
			foreach(NamedAPIResourceData version in data.Versions) {
				versionDataView.Rows.Add(version.Name);
			}

			// 地方
			regionsDataView.Rows.Clear();
			foreach(NamedAPIResourceData region in data.Regions) {
				regionsDataView.Rows.Add(region.Name);
			}

			// 図鑑
			pokedexDataView.Rows.Clear();
			foreach(NamedAPIResourceData pokedex in data.Pokedexes) {
				pokedexDataView.Rows.Add(pokedex.Name);
			}

			// 技の習得方法
			moveLearnMethodDataView.Rows.Clear();
			foreach(NamedAPIResourceData moveLearnMethod in data.MoveLearnMethods) {
				moveLearnMethodDataView.Rows.Add(moveLearnMethod.Name);
			}
		}
		#endregion

	}
}
