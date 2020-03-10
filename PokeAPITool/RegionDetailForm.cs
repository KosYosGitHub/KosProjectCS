using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	/// <summary>
	/// 地方詳細ダイアログ
	/// </summary>
	public partial class RegionDetailForm : DetailForm
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RegionDetailForm(string titleText, string apiName) : base(titleText, apiName)
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
		private void RegionDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 主な世代詳細ボタン クリック
		/// <summary>
		/// 主な世代詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGenerationDetail_Click(object sender, EventArgs e)
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

		#region 地方詳細ボタン クリック
		/// <summary>
		/// 地方詳細ボタン クリック
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
		private void buttonNamesDetail_Click(object sender, EventArgs e)
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
			RegionData data = Singleton<PokeAPIToolModel>.Instance.RegionDetailList.GetRegion(apiName);

			idData.Text = $"{data.ID}";							// ID
			nameData.Text = data.Name;							// 名称
			mainGenerationData.Text = data.MainGeneration.Name;	// 主な世代

			// 言語ごとの名称
			namesDataView.Rows.Clear();
			foreach(NameData language in data.Names) {
				namesDataView.Rows.Add(language.Language.Name, language.Name);
			}

			// 場所
			locationDataView.Rows.Clear();
			foreach(NamedAPIResourceData location in data.Locations) {
				locationDataView.Rows.Add(location.Name);
			}

			// 図鑑
			pokedexDataView.Rows.Clear();
			foreach(NamedAPIResourceData pokedex in data.Pokedexes) {
				pokedexDataView.Rows.Add(pokedex.Name);
			}

			// バージョングループ
			versionGroupDataView.Rows.Clear();
			foreach(NamedAPIResourceData versionGroup in data.VersionGroups) {
				versionGroupDataView.Rows.Add(versionGroup.Name);
			}
		}
		#endregion
	}
}
