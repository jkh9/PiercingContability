using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    class Hardware
    {
        /*
         * Clase que controla cosas comunes...
         */

        public Hardware()
        {
            
        }

        //Código para mover la ventana!!

        //Dll para poder mover el formulario conel stripmenu

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void MoveScreen(Form sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(sender.Handle, 0x112, 0xf012, 0);
        }
    }
}
