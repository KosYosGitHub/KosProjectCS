using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivedoorWeather;
using PokeAPI;

namespace testApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try {
				PokeAPIConnection api = new PokeAPIConnection();

				MessageBox.Show(api.Connect("pokemon/801"));
			}
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			this.Close();
		}
	}
}
