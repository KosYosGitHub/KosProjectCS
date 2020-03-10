﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generic;
using PokeAPI;

namespace PokeAPITool
{
	public partial class PokedexDetailDialog : Form
	{
		// public プロパティ

		#region 図鑑名
		/// <summary>図鑑名</summary>
		public string PokedexName { set { pokedexName = value; } }
		#endregion

		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokedexDetailDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private メンバ変数

		#region 図鑑名
		/// <summary>図鑑名</summary>
		private string pokedexName = string.Empty;
		#endregion

		// private イベント

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PokedexDetailDialog_Load(object sender, EventArgs e)
		{
			ShowData();
		}
		#endregion

		#region 地方ボタン クリック
		/// <summary>
		/// 地方ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRegion_Click(object sender, EventArgs e)
		{
			if(regionData.Text == string.Empty) {
				return;
			}

			RegionDetailDialog dialog = new RegionDetailDialog();
			dialog.RegionName = regionData.Text;
			dialog.ShowDialog(this);
		}
		#endregion

		#region 言語ごとの名称 詳細ボタン クリック
		/// <summary>
		/// 言語ごとの名称 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonNameLanguageDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(namesDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = namesDataView.SelectedRows[0];

			// 選択言語の情報表示
			LanguageDetailDialog dialog = new LanguageDetailDialog();
			dialog.LanguageName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		#region 言語ごとの説明 詳細ボタン
		/// <summary>
		/// 言語ごとの説明 詳細ボタン
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDescriptionLanguageDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(descriptionsDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = descriptionsDataView.SelectedRows[0];

			// 選択言語の情報表示
			LanguageDetailDialog dialog = new LanguageDetailDialog();
			dialog.LanguageName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		#region バージョングループ 詳細ボタン
		/// <summary>
		/// バージョングループ 詳細ボタン
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroupDetail_Click(object sender, EventArgs e)
		{
			// 対象行確認
			if(versionGroupDataView.Rows.Count <= 0) {
				return;
			}

			// 選択行取得
			DataGridViewRow row = versionGroupDataView.SelectedRows[0];

			// 選択言語の情報表示
			VersionGroupDetailDialog dialog = new VersionGroupDetailDialog();
			dialog.VersionGroupName = row.Cells[0].Value.ToString();
			dialog.ShowDialog(this);
		}
		#endregion

		// private メソッド

		#region 画面表示
		/// <summary>
		/// 画面表示
		/// </summary>
		private void ShowData()
		{
			PokedexData data = Singleton<PokeAPIToolModel>.Instance.PokedexDetailList.GetPokedex(pokedexName);

			idData.Text = $"{data.ID}";
			nameData.Text = data.Name;
			isMainSeriesData.Text = $"{data.IsMainSeries}";
			regionData.Text = data.Region.Name;

			// ポケモン
			pokemonDataView.Rows.Clear();
			foreach(PokemonEntryData entry in data.PokemonEntries) {
				pokemonDataView.Rows.Add($"{entry.EntryNumber}", entry.PokemonSpecies.Name);
			}

			// 言語ごとの名称
			namesDataView.Rows.Clear();
			foreach(NameData language in data.Names) {
				namesDataView.Rows.Add(language.Language.Name, language.Name);
			}

			// 言語ごとの説明
			descriptionsDataView.Rows.Clear();
			foreach(DescriptionData language in data.Descriptions) {
				descriptionsDataView.Rows.Add(language.Language.Name, language.Description);
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
