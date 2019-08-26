namespace COMS102_BCS31_Algorithm_Simulation.Radix_Sort
{
    partial class RadixSort
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
            this.txtboxDisplaySorted = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.txtboxAbout = new System.Windows.Forms.TextBox();
            this.txtboxDisplayUnsorted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblunsorted = new System.Windows.Forms.Label();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btnNumberSort = new System.Windows.Forms.Button();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblChooseType = new System.Windows.Forms.Label();
            this.btnCharSort = new System.Windows.Forms.Button();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCharSimulate = new System.Windows.Forms.Button();
            this.btnIntSimulate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtboxInputInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxDisplaySorted
            // 
            this.txtboxDisplaySorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtboxDisplaySorted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDisplaySorted.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDisplaySorted.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtboxDisplaySorted.Location = new System.Drawing.Point(3, 431);
            this.txtboxDisplaySorted.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxDisplaySorted.Multiline = true;
            this.txtboxDisplaySorted.Name = "txtboxDisplaySorted";
            this.txtboxDisplaySorted.ReadOnly = true;
            this.txtboxDisplaySorted.Size = new System.Drawing.Size(955, 81);
            this.txtboxDisplaySorted.TabIndex = 19;
            this.txtboxDisplaySorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAbout.Location = new System.Drawing.Point(285, 545);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(366, 32);
            this.lblAbout.TabIndex = 20;
            this.lblAbout.Text = "About Radix Sort Algorithm";
            this.lblAbout.Visible = false;
            // 
            // txtboxAbout
            // 
            this.txtboxAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtboxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxAbout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtboxAbout.Location = new System.Drawing.Point(3, 591);
            this.txtboxAbout.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAbout.Multiline = true;
            this.txtboxAbout.Name = "txtboxAbout";
            this.txtboxAbout.ReadOnly = true;
            this.txtboxAbout.Size = new System.Drawing.Size(957, 140);
            this.txtboxAbout.TabIndex = 21;
            this.txtboxAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxDisplayUnsorted
            // 
            this.txtboxDisplayUnsorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtboxDisplayUnsorted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDisplayUnsorted.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDisplayUnsorted.ForeColor = System.Drawing.Color.Crimson;
            this.txtboxDisplayUnsorted.Location = new System.Drawing.Point(3, 297);
            this.txtboxDisplayUnsorted.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxDisplayUnsorted.Multiline = true;
            this.txtboxDisplayUnsorted.Name = "txtboxDisplayUnsorted";
            this.txtboxDisplayUnsorted.ReadOnly = true;
            this.txtboxDisplayUnsorted.Size = new System.Drawing.Size(955, 81);
            this.txtboxDisplayUnsorted.TabIndex = 17;
            this.txtboxDisplayUnsorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(383, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sorted Array:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(371, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Unsorted Array:";
            // 
            // lblunsorted
            // 
            this.lblunsorted.AutoSize = true;
            this.lblunsorted.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunsorted.Location = new System.Drawing.Point(-328, 160);
            this.lblunsorted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblunsorted.Name = "lblunsorted";
            this.lblunsorted.Size = new System.Drawing.Size(0, 23);
            this.lblunsorted.TabIndex = 14;
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(109, 102);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.ReadOnly = true;
            this.txtboxInput.Size = new System.Drawing.Size(751, 38);
            this.txtboxInput.TabIndex = 11;
            this.txtboxInput.Click += new System.EventHandler(this.txtboxInput_Click);
            this.txtboxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharOnly_KeyPress);
            // 
            // btnNumberSort
            // 
            this.btnNumberSort.BackColor = System.Drawing.Color.LightGreen;
            this.btnNumberSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumberSort.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnNumberSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberSort.Location = new System.Drawing.Point(103, 140);
            this.btnNumberSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumberSort.Name = "btnNumberSort";
            this.btnNumberSort.Size = new System.Drawing.Size(361, 58);
            this.btnNumberSort.TabIndex = 34;
            this.btnNumberSort.Text = "Click here to sort Numbers only";
            this.btnNumberSort.UseVisualStyleBackColor = false;
            this.btnNumberSort.Click += new System.EventHandler(this.UserChoose);
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.BackColor = System.Drawing.Color.Pink;
            this.btnClearTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTxt.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnClearTxt.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTxt.Location = new System.Drawing.Point(360, 149);
            this.btnClearTxt.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(124, 75);
            this.btnClearTxt.TabIndex = 38;
            this.btnClearTxt.Text = "Clear";
            this.btnClearTxt.UseVisualStyleBackColor = false;
            this.btnClearTxt.Click += new System.EventHandler(this.UsersChoice);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(141, 65);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(630, 37);
            this.lblNumbers.TabIndex = 37;
            this.lblNumbers.Text = "Type the set of numbers you want to sort.";
            // 
            // lblChooseType
            // 
            this.lblChooseType.AutoSize = true;
            this.lblChooseType.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseType.Location = new System.Drawing.Point(265, 102);
            this.lblChooseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseType.Name = "lblChooseType";
            this.lblChooseType.Size = new System.Drawing.Size(433, 37);
            this.lblChooseType.TabIndex = 36;
            this.lblChooseType.Text = "Choose type of array to sort.";
            // 
            // btnCharSort
            // 
            this.btnCharSort.BackColor = System.Drawing.Color.LightGreen;
            this.btnCharSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharSort.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCharSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharSort.Location = new System.Drawing.Point(488, 140);
            this.btnCharSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnCharSort.Name = "btnCharSort";
            this.btnCharSort.Size = new System.Drawing.Size(367, 58);
            this.btnCharSort.TabIndex = 35;
            this.btnCharSort.Text = "Click here to sort Characters only";
            this.btnCharSort.UseVisualStyleBackColor = false;
            this.btnCharSort.Click += new System.EventHandler(this.UserChoose);
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacters.Location = new System.Drawing.Point(135, 65);
            this.lblCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(653, 37);
            this.lblCharacters.TabIndex = 32;
            this.lblCharacters.Text = "Type the set of characters you want to sort.";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Pink;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(487, 149);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 75);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.UsersChoice);
            // 
            // btnCharSimulate
            // 
            this.btnCharSimulate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCharSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharSimulate.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCharSimulate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharSimulate.Location = new System.Drawing.Point(111, 148);
            this.btnCharSimulate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCharSimulate.Name = "btnCharSimulate";
            this.btnCharSimulate.Size = new System.Drawing.Size(247, 75);
            this.btnCharSimulate.TabIndex = 40;
            this.btnCharSimulate.Text = "Simulate";
            this.btnCharSimulate.UseVisualStyleBackColor = false;
            this.btnCharSimulate.Click += new System.EventHandler(this.btnCharSimulate_Click);
            // 
            // btnIntSimulate
            // 
            this.btnIntSimulate.BackColor = System.Drawing.Color.LightGreen;
            this.btnIntSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntSimulate.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnIntSimulate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntSimulate.Location = new System.Drawing.Point(111, 149);
            this.btnIntSimulate.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntSimulate.Name = "btnIntSimulate";
            this.btnIntSimulate.Size = new System.Drawing.Size(247, 75);
            this.btnIntSimulate.TabIndex = 39;
            this.btnIntSimulate.Text = "Simulate";
            this.btnIntSimulate.UseVisualStyleBackColor = false;
            this.btnIntSimulate.Click += new System.EventHandler(this.btnIntSimulate_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAbout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(615, 149);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(247, 75);
            this.btnAbout.TabIndex = 41;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.UsersChoice);
            // 
            // txtboxInputInt
            // 
            this.txtboxInputInt.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInputInt.Location = new System.Drawing.Point(109, 102);
            this.txtboxInputInt.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxInputInt.Name = "txtboxInputInt";
            this.txtboxInputInt.ReadOnly = true;
            this.txtboxInputInt.Size = new System.Drawing.Size(751, 38);
            this.txtboxInputInt.TabIndex = 42;
            this.txtboxInputInt.Click += new System.EventHandler(this.textboxInputInt_Click);
            this.txtboxInputInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerOnly_KeyPress);
            // 
            // RadixSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(957, 719);
            this.Controls.Add(this.txtboxInputInt);
            this.Controls.Add(this.btnNumberSort);
            this.Controls.Add(this.btnCharSort);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCharSimulate);
            this.Controls.Add(this.btnIntSimulate);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblChooseType);
            this.Controls.Add(this.lblCharacters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxDisplaySorted);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.txtboxAbout);
            this.Controls.Add(this.txtboxDisplayUnsorted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblunsorted);
            this.Controls.Add(this.txtboxInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RadixSort";
            this.ShowIcon = false;
            this.Text = "Radix Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxDisplaySorted;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox txtboxAbout;
        private System.Windows.Forms.TextBox txtboxDisplayUnsorted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblunsorted;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Button btnNumberSort;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblChooseType;
        private System.Windows.Forms.Button btnCharSort;
        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCharSimulate;
        private System.Windows.Forms.Button btnIntSimulate;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtboxInputInt;
    }
}