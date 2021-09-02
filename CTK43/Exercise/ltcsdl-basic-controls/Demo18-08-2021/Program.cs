using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo18_08_2021
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ICategoryData categorySource = new IO.CategoryDataSource("Data\\CategoryData.txt");
			IDataSource dataSource = new IO.JsonDataSource("Data\\data.json");
			Contex context = new Contex(dataSource, categorySource);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain(context));
		}
	}
}
