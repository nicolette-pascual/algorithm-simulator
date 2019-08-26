using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMS102_BCS31_Algorithm_Simulation.Travelling_Salesman_Problem
{
    public partial class TSP : Form
    {
        private int number_of_nodes, NumberofNodes, ctr = 1, j = 1;
        public Stack<int> stack = new Stack<int>();
        int[,] adjacency_matrix = new int[0, 0];

        public TSP()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            switch ((sender as Button).Text) 
            { 
                case "Go":
                    startAlgorithm();
                    break;
                case "Insert":
                    insertToMatrix(adjacency_matrix);
                    break;
                case "Cancel":
                    cancelAndRestart();
                    break;
                case "Restart":
                    cancelAndRestart();
                    break;
                case "Show Route":
                    startTSP();
                    break;
            }
        }

        private void startTSP()
        {
            for (int i = 1; i <= NumberofNodes; i++)
            {
                for (j = 1; j <= NumberofNodes; j++)
                {
                    if (adjacency_matrix[i, j] == 1 && adjacency_matrix[j, i] == 0)
                    {
                        adjacency_matrix[j, i] = 1;
                    }
                }
            }
            btnTSP.Enabled = false;
            btnRestart.Enabled = true;
            tsp(adjacency_matrix);
        }

        private void tsp(int[,] adjacencyMatrix)
        {
            number_of_nodes = adjacencyMatrix.GetLength(0) - 1;
            int[] visited = new int[number_of_nodes + 1];
            visited[1] = 1;
            stack.Push(1);
            int element, dst = 0, i;
            int min = Int32.MinValue;
            bool minFlag = false;
            txtStep.Text = "> Select point 1 as the starting point." + "\r\n";
            txtboxOutput.Text = (1 + "-");

            while (!(stack.Count == 0))
            {
                element = stack.Peek();
                i = 1;
                min = Int32.MaxValue;
                while (i <= number_of_nodes)
                {
                    if (adjacencyMatrix[element, i] > 1 && visited[i] == 0)
                    {
                        if (min > adjacencyMatrix[element, i])
                        {
                            min = adjacencyMatrix[element, i];
                            dst = i;
                            minFlag = true;
                        }
                    }
                    i++;
                }
                if (minFlag)
                {
                    visited[dst] = 1;
                    stack.Push(dst);
                    txtboxCost.Text += Convert.ToString(adjacencyMatrix[element, dst]) + "+";
                    txtStep.Text += "> Select the unvisited point " + dst + " as the next destination"+
                                    " since its distance of " + adjacencyMatrix[element, dst]+
                                    " from point " + element + " is the closest point " + dst +
                                    "\r\r\n\n";
                    txtboxOutput.Text += (dst + "-");
                    minFlag = false;
                    continue;
                }
                stack.Pop();
            }
            txtboxCost.Text += Convert.ToString(adjacencyMatrix[1, dst]);
            txtboxOutput.Text += "1";
            txtStep.Text += "> Return to point 1 and add its distance of " +adjacencyMatrix[1, dst]+ 
                                    " from point "+ dst+
                                    "\r\r\n\n";
            travellingCost();
        }

        private void travellingCost()
        {
            Int32[] travelCost = txtboxCost.Text.Split('+').Select(s => Int32.Parse(s)).ToArray();
                txtboxTotalCost.Text = Convert.ToString(travelCost.Sum());
        }

        private void cancelAndRestart()
        {
            txtMatrix.Clear();
            ctr = 1; j = 1;
            label2.Text = "Enter distance:";
            txtboxCost.Clear();
            txtboxOutput.Clear();
            txtboxTotalCost.Clear();
            txtboxDistance.Clear();
            txtStep.Clear();
            btnGo.Enabled = true; txtboxNode.Enabled = true;
            txtboxDistance.Enabled = false;
            btnInsert.Enabled = false;
            btnCancel.Enabled = false;
            btnRestart.Enabled = false;
        }

        private void insertToMatrix(int[,] adjacency_matrix)
        {
            try
            {
                #region Insert to Matrix
                if (j <= NumberofNodes)
                {
                    if (ctr == j)
                    {
                        adjacency_matrix[ctr, j] = 0;
                        j++;
                    }

                    adjacency_matrix[ctr, j] = Convert.ToInt32(txtboxDistance.Text);
                    adjacency_matrix[j, ctr] = Convert.ToInt32(txtboxDistance.Text);

                    if (j + 1 <= NumberofNodes) { j++; } else { ctr++; j = ctr + 1; }

                }
                txtboxDistance.Clear();
                displayMatrix(adjacency_matrix);
                if (j <= NumberofNodes)
                {
                    label2.Text = "Enter distance of point " + (ctr) + " to point " + (j);
                }
                else
                {
                    txtboxDistance.Enabled = false;
                    btnInsert.Enabled = false;
                    btnCancel.Enabled = false;
                    btnTSP.Enabled= true;
                    btnTSP.Visible = true;
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Wrong input Format");
            }
        }

        private void displayMatrix(int[,] adjacency_matrix)
        {
            txtMatrix.Clear();

            #region for Column Header

            this.txtMatrix.Text += "\t";
            for (int i = 0; i <= NumberofNodes; i++)
            {
                this.txtMatrix.Text += i + "\t";
            }
            this.txtMatrix.Text += "\r\n\n";
            this.txtMatrix.Text += "\r\n\n";
            #endregion

            for (int i = 0; i < adjacency_matrix.GetLength(0); i++)
            {
                this.txtMatrix.Text += i + "\t";
                for (int j = 0; j < adjacency_matrix.GetLength(1); j++)
                {

                    this.txtMatrix.Text += adjacency_matrix[i, j] + "\t";
                }
                this.txtMatrix.Text += "\r\n";
            }
        }

        private void startAlgorithm()
        {
            try
            {
                #region Check Input
                NumberofNodes = Convert.ToInt32(txtboxNode.Text);
                if (NumberofNodes < 5)
                {
                    MessageBox.Show("Number of locations cannot be less than 5", "Invalid Input");

                }
                else
                {
                    #region Valid Input Node
                    btnGo.Enabled = false;
                    txtboxNode.Enabled = false;
                    adjacency_matrix = new int[NumberofNodes + 1, NumberofNodes + 1];
                    if (ctr == j)
                    {
                        adjacency_matrix[ctr, j] = 0;
                        adjacency_matrix[j, ctr] = 0; j++;
                    }
                    txtboxDistance.Enabled = true;
                    btnInsert.Enabled = true;
                    btnCancel.Enabled = true;


                    label2.Text = "Enter distance of point " + (ctr) + " to point " + (j);
                    #endregion
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Wrong Input Format", "Invalid Input");
            }
        }

    }
}
