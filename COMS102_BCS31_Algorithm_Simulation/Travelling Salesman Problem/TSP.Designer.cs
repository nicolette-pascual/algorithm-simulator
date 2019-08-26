namespace COMS102_BCS31_Algorithm_Simulation.Travelling_Salesman_Problem
{
    partial class TSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRestart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxTotalCost = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.btnTSP = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxOutput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtboxDistance = new System.Windows.Forms.TextBox();
            this.txtboxNode = new System.Windows.Forms.TextBox();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestart.Enabled = false;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.Location = new System.Drawing.Point(58, 577);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(137, 23);
            this.btnRestart.TabIndex = 37;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Point";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(94, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total Travelling Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Travelling Cost Breakdown:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Route:";
            // 
            // txtboxTotalCost
            // 
            this.txtboxTotalCost.BackColor = System.Drawing.Color.PowderBlue;
            this.txtboxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalCost.Location = new System.Drawing.Point(12, 525);
            this.txtboxTotalCost.Name = "txtboxTotalCost";
            this.txtboxTotalCost.ReadOnly = true;
            this.txtboxTotalCost.Size = new System.Drawing.Size(231, 22);
            this.txtboxTotalCost.TabIndex = 31;
            this.txtboxTotalCost.TabStop = false;
            this.txtboxTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxCost
            // 
            this.txtboxCost.BackColor = System.Drawing.Color.PowderBlue;
            this.txtboxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCost.Location = new System.Drawing.Point(9, 460);
            this.txtboxCost.Multiline = true;
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.ReadOnly = true;
            this.txtboxCost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxCost.Size = new System.Drawing.Size(270, 37);
            this.txtboxCost.TabIndex = 30;
            this.txtboxCost.TabStop = false;
            // 
            // btnTSP
            // 
            this.btnTSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTSP.Location = new System.Drawing.Point(29, 192);
            this.btnTSP.Name = "btnTSP";
            this.btnTSP.Size = new System.Drawing.Size(137, 23);
            this.btnTSP.TabIndex = 6;
            this.btnTSP.Text = "Show Route";
            this.btnTSP.UseVisualStyleBackColor = false;
            this.btnTSP.Visible = false;
            this.btnTSP.Click += new System.EventHandler(this.btnClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnInsert.Enabled = false;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInsert.Location = new System.Drawing.Point(13, 145);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter distance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter number of locations:";
            // 
            // txtboxOutput
            // 
            this.txtboxOutput.BackColor = System.Drawing.Color.PowderBlue;
            this.txtboxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxOutput.Location = new System.Drawing.Point(9, 397);
            this.txtboxOutput.Multiline = true;
            this.txtboxOutput.Name = "txtboxOutput";
            this.txtboxOutput.ReadOnly = true;
            this.txtboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxOutput.Size = new System.Drawing.Size(270, 34);
            this.txtboxOutput.TabIndex = 24;
            this.txtboxOutput.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.LightGreen;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGo.Location = new System.Drawing.Point(55, 63);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnClick);
            // 
            // txtboxDistance
            // 
            this.txtboxDistance.BackColor = System.Drawing.Color.PowderBlue;
            this.txtboxDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxDistance.Enabled = false;
            this.txtboxDistance.Location = new System.Drawing.Point(13, 111);
            this.txtboxDistance.Name = "txtboxDistance";
            this.txtboxDistance.Size = new System.Drawing.Size(163, 20);
            this.txtboxDistance.TabIndex = 3;
            this.txtboxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxNode
            // 
            this.txtboxNode.BackColor = System.Drawing.Color.PowderBlue;
            this.txtboxNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNode.Location = new System.Drawing.Point(10, 37);
            this.txtboxNode.MaxLength = 1000;
            this.txtboxNode.Name = "txtboxNode";
            this.txtboxNode.Size = new System.Drawing.Size(174, 20);
            this.txtboxNode.TabIndex = 1;
            this.txtboxNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatrix
            // 
            this.txtMatrix.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatrix.Location = new System.Drawing.Point(285, 21);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(948, 562);
            this.txtMatrix.TabIndex = 28;
            this.txtMatrix.TabStop = false;
            this.txtMatrix.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tracing:";
            // 
            // txtStep
            // 
            this.txtStep.BackColor = System.Drawing.Color.PowderBlue;
            this.txtStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStep.Location = new System.Drawing.Point(9, 247);
            this.txtStep.Multiline = true;
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStep.Size = new System.Drawing.Size(270, 119);
            this.txtStep.TabIndex = 38;
            this.txtStep.TabStop = false;
            // 
            // TSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1026, 647);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxTotalCost);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.btnTSP);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxOutput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtboxDistance);
            this.Controls.Add(this.txtboxNode);
            this.Controls.Add(this.txtMatrix);
            this.Name = "TSP";
            this.ShowIcon = false;
            this.Text = "Travelling Salesman Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxTotalCost;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Button btnTSP;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtboxDistance;
        private System.Windows.Forms.TextBox txtboxNode;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStep;
    }
}