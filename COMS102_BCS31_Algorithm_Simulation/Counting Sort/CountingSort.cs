using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace COMS102_BCS31_Algorithm_Simulation.Counting_Sort
{
    public partial class CountingSort : Form
    {
        public CountingSort()
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

        private void txtboxInputInt_Click(object sender, EventArgs e)
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

        private void UserSelect(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(txtboxInputInt.Text))
            {
                MessageBox.Show("Input cannot be blank.", "Input Error");
                return;
            }

            try
            {

                string Unsorted = txtboxInputInt.Text.Trim();
                string[] stringArray = Unsorted.Split(null);

                int[] InputtedArray = stringArray.Select(int.Parse).ToArray();

                txtboxDisplayUnsorted.Text = "";
                for (int i = 0; i < InputtedArray.Length; i++)
                {
                    this.txtboxDisplayUnsorted.Text += InputtedArray[i] + " ";
                }

                int[] sortedArray = CountingSortMethod(InputtedArray);
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
                MessageBox.Show("One space between each number please. Numbers only. ", "Input Error");
                Clear();
            }

        }

        public int[] CountingSortMethod(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
        }
        #endregion

        #region btn Chart Sort
        private void SimulateCharacters()
        {
            if (String.IsNullOrEmpty(txtboxInput.Text))
            {
                MessageBox.Show("Please provide a valid input.", "Input Error");
                return;
            }

            try
            {
                //char[] unsortedChar;
                //string Unsorted = txtboxInput.Text.Trim();
                //string[] unsortedA = Unsorted.Split(null);

                //for (int i = 0; i < unsortedA.Length; i++)
                //{
                //    unsortedChar[i] = unsortedA[i].Join(unsortedA.Empty, S).ToCharArray();
                //}
                char[] unsortedArray = txtboxInput.Text.ToCharArray();

                txtboxDisplayUnsorted.Text = "";
                for (int i = 0; i < unsortedArray.Length; i++)
                {
                    this.txtboxDisplayUnsorted.Text += "" + unsortedArray[i];
                }

                char[] sortedArray = CountingSortMethod(unsortedArray);
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
                MessageBox.Show("Please provide a valid input.", "Input Error");
                Clear();
            }

        }

        public char[] CountingSortMethod(char[] array)
        {
            char[] sortedArray = new char[array.Length];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
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
            txtboxAbout.Text = "Counting Sort Algorithm is an integer sorting algorithm. "+
               "It counts the number of objects in an array that have distinct values then using arithmetic "+
               "on those counts to calculate the position of each object in the output sequence."+
               "This program accepts spaces, any positive integer value, special characters, letters, and special letters as well "+
               "and sorts them in the same order as mentioned. (Note: Any capital letters come before the small letters)";
        }
        #endregion

        #region KEYPRESS METHODS
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
