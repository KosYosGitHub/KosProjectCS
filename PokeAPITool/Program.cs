using System;
using System.Windows.Forms;

namespace PokeAPITool
{
	static class Program
	{
		#region エントリポイント
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MenuDialog());
		}
		#endregion
	}
}
