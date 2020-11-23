using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_3___Interfaces_Graficas.Views;
using Aula_3___Interfaces_Graficas.Models;

namespace Aula_3___Interfaces_Graficas
{
    static class Program
    {
        public static List<Jogador> jogadores = new List<Jogador>();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroJogadores());
        }
    }
}
