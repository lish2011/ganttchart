using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridviewCombobox
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                //Application.Run(new Employees());
                Application.Run(new DgvComboboxForm1());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
    }
}
