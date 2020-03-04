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
				LivedoorWeatherService livedoorWeather = new LivedoorWeatherService();

				livedoorWeather.LoadWeatherInfo();

				MessageBox.Show(livedoorWeather.LivedoorWeatherData.Description.Text);
			}
			catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			this.Close();
		}
	}
}
