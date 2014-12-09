using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyNoteBook_v1._0
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new MainForm());
           // Application.Run(new ForTestingOutputValues());
            
        }
    }
}
