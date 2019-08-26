using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS102_BCS31_Algorithm_Simulation.Global_Class
{
    class GlobalClass
    {
        public static void CheckMdiChildren(Form form)
        {
            foreach (Form frm in MainForm.ActiveForm.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = MainForm.ActiveForm;
            form.Location = new Point(350, 20);
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }
    }
}
