﻿using SGM.WindowsForms.Fomularios.Login;
using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormResolve.Wire(FormModule.Create());
            Application.Run(FormResolve.Resolve<FrmLogin>());
        }
    }
}