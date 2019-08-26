using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS102_BCS31_Algorithm_Simulation.Radix_Sort
{
    public partial class RadixSort : Form
    {
        public RadixSort()
        {
            InitializeComponent();
            HideObjects();
        }

        private void HideObjects()
        {
            lblCharacters.Hide();
            lblNumbers.Hide();

            lblChooseType.Show();

            txtboxInput.Hide();
            txtboxInputInt.Hide();

            btnCharSort.Show();
            btnNumberSort.Show();

            btnIntSimulate.Hide();
            btnCharSimulate.Hide();
            btnClearTxt.Hide();
            btnClear.Hide();
            btnAbout.Hide();
        }


        private void ShowObjectsChar()
        {
            lblChooseType.Hide();

            btnCharSort.Hide();
            btnNumberSort.Hide();
            txtboxInput.Show();

            btnClearTxt.Show();
            btnClear.Show();
            btnAbout.Show();
        }

        private void ShowObjectsInt()
        {
            lblChooseType.Hide();

            btnCharSort.Hide();
            btnNumberSort.Hide();
            txtboxInputInt.Show();

            btnClearTxt.Show();
            btnClear.Show();
            btnAbout.Show();
        }

        private void txtboxInput_Click(object sender, EventArgs e)
        {
            txtboxInput.Clear(); txtboxInput.ReadOnly = false;
        }

        private void textboxInputInt_Click(object sender, EventArgs e)
        {
            txtboxInputInt.Clear(); txtboxInputInt.ReadOnly = false;
        }
       
        private void UserChoose(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "Click here to sort Numbers only":
                    txtboxInput.Hide();
                    txtboxInputInt.Text = "eg. 42 6 5 89 -1";

                    lblNumbers.Show();
                    ShowObjectsInt();
                    btnIntSimulate.Show();
                    break;
                case "Click here to sort Characters only":
                    txtboxInputInt.Hide();
                    txtboxInput.Text = "eg. N A J a i o";

                    lblCharacters.Show();
                    ShowObjectsChar();
                    btnCharSimulate.Show();
                    break;
            }
        }

        private void UsersChoice(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "Clear":
                    Clear();
                    break;
                case "Reset":
                    HideObjects();
                    Clear();
                    break;
                case "About":
                    About();
                    break;
            }
        }

        private void btnIntSimulate_Click(object sender, EventArgs e)
        {
            SimulateNumbers();
        }

        private void btnCharSimulate_Click(object sender, EventArgs e)
        {
            SimulateCharacters();
        }

        #region btn Int Sort
        private void SimulateNumbers()
        {
            if (String.IsNullOrEmpty(txtboxInputInt.Text) || String.IsNullOrWhiteSpace(txtboxInputInt.Text))
            {
                MessageBox.Show("Input cannot be blank.", "Input Error");
                return;
            }
            
            try
            {
                string Unsorted = txtboxInputInt.Text.Trim();
                string[] stringArray = Unsorted.Split(null);
                Int32[] unsortedArray = stringArray.Select(int.Parse).ToArray();

                txtboxDisplayUnsorted.Text = "";

                for (int i = 0; i < unsortedArray.Length; i++)
                {
                    this.txtboxDisplayUnsorted.Text += " " + unsortedArray[i];
                }


                int[] sortedArray = RadixSortMethod(unsortedArray);

                txtboxDisplaySorted.Text = "";
                //print sorted array
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    this.txtboxDisplaySorted.Text += " " + sortedArray[i];
                }
                txtboxDisplaySorted.Text = txtboxDisplaySorted.Text.Trim();

            }
            catch
            {
                MessageBox.Show("One space between each number please. Numbers only.", "Input Error");
                Clear();
            }           
        }

        public int[] RadixSortMethod(int[] array)
        {

            string Unsorted = txtboxInputInt.Text.Trim();
            string[] stringArray = Unsorted.Split(null);
            Int32[] unsortedArray = stringArray.Select(int.Parse).ToArray();
            //Int32[] unsortedArray = txtboxInput.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] sortedArray = new int[stringArray.Length];

            int i, j;
            int[] tmp = new int[unsortedArray.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < unsortedArray.Length; ++i)
                {
                    bool move = (unsortedArray[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        unsortedArray[i - j] = unsortedArray[i];
                    else
                        tmp[j++] = unsortedArray[i];
                }
                Array.Copy(tmp, 0, unsortedArray, unsortedArray.Length - j, j);
            }
            return unsortedArray;
        }
         #endregion

        #region btn Char Sort
        private void SimulateCharacters()
        {
            if (String.IsNullOrEmpty(txtboxInput.Text) || String.IsNullOrWhiteSpace(txtboxInput.Text))
            {
                MessageBox.Show("Input cannot be blank.", "Input Error");
                return;
            }
            
            try
            {
                string Unsorted = txtboxInput.Text.Trim();
                char[] unsortedArray = Unsorted.ToCharArray();

                txtboxDisplayUnsorted.Text = "";

                for (int i = 0; i < unsortedArray.Length; i++)
                {
                    this.txtboxDisplayUnsorted.Text += " " + unsortedArray[i];
                }


                char[] sortedArray = RadixSortMethod(unsortedArray);

                txtboxDisplaySorted.Text = "";
                //print sorted array
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    this.txtboxDisplaySorted.Text += " " + sortedArray[i];
                }
                txtboxDisplaySorted.Text = txtboxDisplaySorted.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Invalid Input. Spaces separates every number. One space between each number only.", "Input Error");
                Clear();
            }
        }

        private char[] RadixSortMethod(char[] array)
        {
            string Unsorted = txtboxInput.Text.Trim();
            char[] unsortedArray = Unsorted.ToCharArray();
            //Int32[] unsortedArray = txtboxInput.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            char[] sortedArray = new char[unsortedArray.Length];

            int i, j;
            char[] tmp = new char[unsortedArray.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < unsortedArray.Length; ++i)
                {
                    bool move = (unsortedArray[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        unsortedArray[i - j] = unsortedArray[i];
                    else
                        tmp[j++] = unsortedArray[i];
                }
                Array.Copy(tmp, 0, unsortedArray, unsortedArray.Length - j, j);
            }
            return unsortedArray;
        }
        #endregion

        #region Reset
        private void Clear()
        {
            txtboxInput.Text = "";
            txtboxInputInt.Text = "";
            txtboxDisplaySorted.Text = "";
            txtboxDisplayUnsorted.Text = "";

            lblAbout.Hide();
            txtboxAbout.Clear();
                      
            txtboxInput.ReadOnly = true;
        }
        #endregion

        #region About
        private void About()
        {
            lblAbout.Show();
            txtboxAbout.Text = "Radix sort is a non-comparative integer sorting algorithm. " +
               "It sorts data with integer keys by grouping keys by the " +
               "individual digits which share the same significant position and value. " +
               "This program accepts spaces, any positive integer value and any negative integer value " +
               "and sorts them in the same order as mentioned. ";
        }
        #endregion
        
        #region KEYPRESS FOR INTEGER ONLY AND CHAR ONLY <3
        private void IntegerOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '-') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CharOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

       

        

       
           

      

       

       

    }
}
