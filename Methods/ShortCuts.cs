using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Methods
{
    internal class ShortCuts
    {
        //linking a form to access text label
        static Signin mySignin = Application.OpenForms.OfType<Signin>().FirstOrDefault();

        public static void changText()
        {
            
        }
    }
}
