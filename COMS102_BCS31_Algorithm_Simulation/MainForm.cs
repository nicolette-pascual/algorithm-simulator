using COMS102_BCS31_Algorithm_Simulation.Counting_Sort;
using COMS102_BCS31_Algorithm_Simulation.Dice_Throw;
using COMS102_BCS31_Algorithm_Simulation.Global_Class;
using COMS102_BCS31_Algorithm_Simulation.Radix_Sort;
using COMS102_BCS31_Algorithm_Simulation.Travelling_Salesman_Problem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////////////////////////////////////////
//////////// ONE CHAR. 2 INT ///////////
////////////////////////////////////////

namespace COMS102_BCS31_Algorithm_Simulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void btn123(object sender, EventArgs e)
        {
            switch((sender as Button).Text){
                case "Quick Sort Algorithm Simulation": 
                    QuickSort frmquick = new QuickSort();
                    GlobalClass.CheckMdiChildren(frmquick);
                    break;

                case "Counting Sort Algorithm Simulation": 
                    CountingSort frmcount = new CountingSort();
                    GlobalClass.CheckMdiChildren(frmcount);
                    break;
                case "Radix Sort Algorithm Simulation":
                    RadixSort frmradix = new RadixSort();
                    GlobalClass.CheckMdiChildren(frmradix);
                    break;
                case "Dice Throw Problem":
                    DiceThrow frmdicethrow = new DiceThrow();
                    GlobalClass.CheckMdiChildren(frmdicethrow);
                    break;
                case "Travelling Salesman Problem":
                    TSP frmTSP = new TSP();
                    GlobalClass.CheckMdiChildren(frmTSP);
                    break;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

       
    }
}
