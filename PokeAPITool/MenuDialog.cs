using System;
using System.Windows.Forms;
using Generic;

namespace PokeAPITool
{
	public partial class MenuDialog : Form
	{
		// public イベント

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MenuDialog()
		{
			InitializeComponent();
		}
		#endregion

		// private イベント

		#region 言語ボタン クリック
		/// <summary>
		/// 言語ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLanguage_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleLanguage, typeof(LanguageDetailForm), Singleton<PokeAPIToolModel>.Instance.LanguageList, this);;
		}
		#endregion

		#region バージョングループボタン クリック
		/// <summary>
		/// バージョングループボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersionGroup_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleVersionGroup, typeof(VersionGroupDetailForm), Singleton<PokeAPIToolModel>.Instance.VersionGroupList, this);
		}
		#endregion

		#region バージョンボタン クリック
		/// <summary>
		/// バージョンボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonVersion_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleVersion, typeof(VersionDetailForm), Singleton<PokeAPIToolModel>.Instance.VersionList, this);
		}
		#endregion

		#region 世代ボタン クリック
		/// <summary>
		/// 世代ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGeneration_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleGeneration, typeof(GenerationDetailForm), Singleton<PokeAPIToolModel>.Instance.GenerationList, this);
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
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleRegion, typeof(RegionDetailForm), Singleton<PokeAPIToolModel>.Instance.RegionList, this);
		}
		#endregion

		#region ポケモン図鑑ボタン クリック
		/// <summary>
		/// ポケモン図鑑ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void butonPokedex_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitlePokedex, typeof(PokedexDetailForm), Singleton<PokeAPIToolModel>.Instance.PokedexList, this);
		}
		#endregion

		#region ポケモン種ボタン クリック
		/// <summary>
		/// ポケモン種ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPokemonSpecies_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitlePokemonSpecies, typeof(PokemonSpeciesDetailForm), Singleton<PokeAPIToolModel>.Instance.PokemonSpeciesList, this);
		}
		#endregion

		#region ポケモンボタン クリック
		/// <summary>
		/// ポケモンボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPokemon_Click(object sender, EventArgs e)
		{
			PokemonListDialog dialog = new PokemonListDialog();
			dialog.ShowDialog(this);
		}
		#endregion

		#region アイテムボタン クリック
		/// <summary>
		/// アイテムボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonItem_Click(object sender, EventArgs e)
		{
			ItemListDialog dialog = new ItemListDialog();
			dialog.ShowDialog(this);
		}
		#endregion
	}
}
