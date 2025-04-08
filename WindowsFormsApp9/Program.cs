using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Presenter;
using WindowsFormsApp9.View;

namespace WindowsFormsApp9
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IProductView _view = new ProductView();
            ProductPresenter _presenter = new ProductPresenter(_view);
            Application.Run((Form)_view);
        }
    }
}
