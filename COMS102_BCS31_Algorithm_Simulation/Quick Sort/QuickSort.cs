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
    public partial class QuickSort : Form
    {
        public QuickSort()
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
            if (String.IsNullOrEmpty(txtboxInputInt.Text) || String.IsNullOrWhiteSpace(txtboxInputInt.Text))
            {
                MessageBox.Show("Input cannot be blank.", "Input Error");
                return;
            }
            try
            {
                string Unsorted = txtboxInputInt.Text.Trim();
                string[] stringArray = Unsorted.Split(null);

                int[] InputtedArray = stringArray.Select(int.Parse).ToArray();

                txtboxDisplayUnsorted.Text = string.Join(" ", InputtedArray);
                quickSort(InputtedArray, 0, InputtedArray.Length - 1);

                string SortedArray = string.Join(" ", InputtedArray);
                txtboxDisplaySorted.Text = SortedArray.Trim();
            }
            catch
            {
                MessageBox.Show("One space between each number please. Numbers only.", "Input Error");
                Clear();
            }
        }

        public static void quickSort(int[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = Partition(A, left, right);

            if (index != -1)
            {
                quickSort(A, left, index - 1);
                quickSort(A, index + 1, right);
            }
        }

        private static int Partition(int[] A, int left, int right)
        {
            if (left > right) return -1;
            int end = left;

            int pivot = A[right];    // choose last one to pivot
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    swap(A, i, end);
                    end++;
                }
            }

            swap(A, end, right);
            return end;
        }

        private static void swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }
        #endregion

        #region btn Character sort
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
                char[] InputtedArray = Unsorted.ToCharArray();

                txtboxDisplayUnsorted.Text = string.Join("", InputtedArray);
                quickSort(InputtedArray, 0, InputtedArray.Length - 1);

                string SortedArray = string.Join(" ", InputtedArray);
                txtboxDisplaySorted.Text = SortedArray.Trim();
            }
            catch
            {
                MessageBox.Show("Please provide a valid input.", "Input Error");
                Clear();
            }
        
        }

        public static void quickSort(char[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = Partition(A, left, right);

            if (index != -1)
            {
                quickSort(A, left, index - 1);
                quickSort(A, index + 1, right);
            }
        }

        private static int Partition(char[] A, int left, int right)
        {
            if (left > right) return -1;
            int end = left;

            int pivot = A[right];    // choose last one to pivot
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    swap(A, i, end);
                    end++;
                }
            }

            swap(A, end, right);
            return end;
        }

        private static void swap(char[] A, int left, int right)
        {
            char tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }
        #endregion

        #region Reset Button
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

        #region About Button
        private void About()
        {
            lblAbout.Show();
            txtboxAbout.Text = "Quicksort is a Divide and Conquer sorting algorithm. " +
                            "The algorithm starts by choosing a pivot value. It proceeds by partitioning the elements. " +
                            "Elements larger than the pivot are partitioned on the right side of the pivot and element smaller than the pivot are partitioned on the left side of the pivot. " +
                            "It then recursively applies the algorithm on the partitions.";
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

