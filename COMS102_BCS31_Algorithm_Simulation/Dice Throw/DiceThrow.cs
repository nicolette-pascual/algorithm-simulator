using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS102_BCS31_Algorithm_Simulation.Dice_Throw
{
    public partial class DiceThrow : Form
    {
        #region Declaration
        int faces, dice, sum;
        #endregion

        #region Constructor
        public DiceThrow()
        {
            InitializeComponent();
        }
        #endregion

        #region Dice Throw FindWays Method
        public void FindWays()
        {
            getValue();

            int[,] table = new int[dice + 1, sum + 1];

            for (int i = 1; i <= faces && i <= sum; ++i)
                table[1, i] = 1;

            for (int i = 2; i <= dice; ++i)
            {
                for (int j = 1; j <= sum; ++j)
                {
                    for (int k = 1; k <= faces && k < j; ++k)
                    {
                        table[i, j] += table[i - 1, j - k];
                    }
                }
            }
            lblWays.Text = Convert.ToString(table[dice, sum]);
        }
        #endregion

        #region Button Event
        private void btnExecute_Click(object sender, EventArgs e)
        {
            var textBoxes = new TextBox[] { txtFace, txtDice, txtSum };
            if (textBoxes.Any(tb => tb.Text == String.Empty))
            {
                MessageBox.Show("All fields are required.", "Input Error");
                ClearAll();
            }

            else
            {
                getValue();
                FindWays();
                ClearAll();
            }
        }
        #endregion

        #region Get Values of Textboxes
        public void getValue()
        {
            faces = Convert.ToInt32(txtFace.Text);
            dice = Convert.ToInt32(txtDice.Text);
            sum = Convert.ToInt32(txtSum.Text);
        }
        #endregion

        #region Clear All Fields
        private void ClearAll()
        {
            txtFace.Clear();
            txtDice.Clear();
            txtSum.Clear();
        }
        #endregion

        #region For Integer Only KeyPress
        private void IntegerOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
