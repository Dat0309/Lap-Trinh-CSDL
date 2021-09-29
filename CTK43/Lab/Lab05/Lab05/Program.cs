using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.Data;

namespace Lab05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ISVDataSource dataSource = new SVTextData("Data\\DSSV.txt");
            ISVDataSource jsonData = new SVJsonData("Data\\DSSV.json");
            Context context = Context.getInstance(jsonData);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(context));
        }
    }
}
