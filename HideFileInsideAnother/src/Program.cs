using System;
using System.Windows.Forms;

namespace HideFileInsideAnother.src {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.FRM_Main());
        }
    }
}
