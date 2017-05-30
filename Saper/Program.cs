using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saper.Boundary;
using Saper.Control;
namespace Saper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            /*
             Creator (ILLEGAL)
            GameControl gameControl = new GameControl();
            GameForm gameForm = new GameForm();
            gameForm.gameControl = gameControl;
            gameControl.GameForm = gameForm;
            Application.Run(gameForm);
            */

            // CREATOR: Right Way
            GameControl gameControl = new GameControl();

            Application.Run(gameControl.GameForm as Form);

        }
    }
}
