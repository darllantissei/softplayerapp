using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softplayerclient
{
    /// <summary>
    /// Classe program de inicialização da aplicação
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Inicialização da aplicação
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }        
    }
}
