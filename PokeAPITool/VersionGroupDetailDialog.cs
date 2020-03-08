﻿using System;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class VersionGroupDetailDialog : Form
	{
		// public プロパティ

		#region バージョングループ名
		/// <summary>バージョングループ名</summary>
		public string VersionGroupName { set { versionGroupName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public VersionGroupDetailDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private メンバ変数

		#region バージョングループ名
		/// <summary>バージョングループ名</summary>
		private string versionGroupName = string.Empty;
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
			GenerationDetailDialog dialog = new GenerationDetailDialog();
			dialog.GenerationName = generationData.Text;
			dialog.ShowDialog(this);
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
			// 対象行確認
			if(versionDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionDataView.SelectedRows[0];

			// 選択行の情報表示
			VersionDetailDialog dialog = new VersionDetailDialog();
			dialog.VersionName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region 画面にデータ表示
		/// <summary>
		/// 画面にデータ表示
		/// </summary>
		private void ShowData()
		{
			VersionGroupData data = Singleton<PokeAPIToolModel>.Instance.VersionGroupDetailList.GetVersionGroup(versionGroupName);

			idData.Text = $"{data.ID}";						// ID
			nameData.Text = data.Name;						// 名称
			orderData.Text = $"{data.Order}";				// ソート順番
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