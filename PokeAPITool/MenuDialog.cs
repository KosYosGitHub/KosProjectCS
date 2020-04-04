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

		#region 場所ボタン クリック
		/// <summary>
		/// 場所ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLocation_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleLocation, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.LocationList, this);
		}
		#endregion

		#region 場所エリアボタン クリック
		/// <summary>
		/// 場所エリアボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonLocationArea_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleLocationArea, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.LocationAreaList, this);
		}
		#endregion

		#region パルパークエリアボタン クリック
		/// <summary>
		/// パルパークエリアボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPalParkArea_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitlePalParkArea, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.PalParkAreaList, this);
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
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitlePokemon, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.PokemonList, this);
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
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleItem, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.ItemList, this);
		}
		#endregion

		#region アイテム属性ボタン クリック
		/// <summary>
		/// アイテム属性ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonItemAttribute_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleItemAttribute, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.ItemAttributeList, this);
		}
		#endregion

		#region アイテムカテゴリボタン クリック
		/// <summary>
		/// アイテムカテゴリボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonItemCategory_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleItemCategory, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.ItemCategoryList, this);
		}
		#endregion

		#region アイテムポケットボタン クリック
		/// <summary>
		/// アイテムポケットボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonItemPocket_Click(object sender, EventArgs e)
		{
			NamedAPIResourceListForm.ShowDialog(PokeAPIToolModel.TitleItemPocket, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.ItemPocketList, this);
		}
		#endregion

		#region 技マシンボタン クリック
		/// <summary>
		/// 技マシンボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMachine_Click(object sender, EventArgs e)
		{
			APIResourceListForm.ShowDialog(PokeAPIToolModel.TitleMachine, typeof(DetailForm), Singleton<PokeAPIToolModel>.Instance.MachineList, this);
		}
		#endregion
	}
}
