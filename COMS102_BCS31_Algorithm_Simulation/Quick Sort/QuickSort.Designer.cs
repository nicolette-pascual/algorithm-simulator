namespace COMS102_BCS31_Algorithm_Simulation.Counting_Sort
{
    partial class QuickSort
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
            this.txtboxDisplayUnsorted = new System.Windows.Forms.TextBox();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.txtboxDisplaySorted = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.txtboxAbout = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnNumberSort = new System.Windows.Forms.Button();
            this.btnCharSort = new System.Windows.Forms.Button();
            this.lblChooseType = new System.Windows.Forms.Label();
            this.btnIntSimulate = new System.Windows.Forms.Button();
            this.btnCharSimulate = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.txtboxInputInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxDisplayUnsorted
            // 
            this.txtboxDisplayUnsorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtboxDisplayUnsorted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDisplayUnsorted.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDisplayUnsorted.ForeColor = System.Drawing.Color.Crimson;
            this.txtboxDisplayUnsorted.Location = new System.Drawing.Point(2, 253);
            this.txtboxDisplayUnsorted.Multiline = true;
            this.txtboxDisplayUnsorted.Name = "txtboxDisplayUnsorted";
            this.txtboxDisplayUnsorted.ReadOnly = true;
            this.txtboxDisplayUnsorted.Size = new System.Drawing.Size(713, 55);
            this.txtboxDisplayUnsorted.TabIndex = 13;
            this.txtboxDisplayUnsorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacters.Location = new System.Drawing.Point(101, 53);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(523, 27);
            this.lblCharacters.TabIndex = 7;
            this.lblCharacters.Text = "Type the set of characters you want to sort.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(287, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sorted Array:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(278, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unsorted Array:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Pink;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(365, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 61);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.UserSelect);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(82, 83);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.ReadOnly = true;
            this.txtboxInput.Size = new System.Drawing.Size(564, 32);
            this.txtboxInput.TabIndex = 8;
            this.txtboxInput.Click += new System.EventHandler(this.txtboxInput_Click);
            this.txtboxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharOnly_KeyPress);
            // 
            // txtboxDisplaySorted
            // 
            this.txtboxDisplaySorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtboxDisplaySorted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDisplaySorted.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDisplaySorted.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtboxDisplaySorted.Location = new System.Drawing.Point(3, 347);
            this.txtboxDisplaySorted.Multiline = true;
            this.txtboxDisplaySorted.Name = "txtboxDisplaySorted";
            this.txtboxDisplaySorted.ReadOnly = true;
            this.txtboxDisplaySorted.Size = new System.Drawing.Size(713, 55);
            this.txtboxDisplaySorted.TabIndex = 15;
            this.txtboxDisplaySorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAbout.Location = new System.Drawing.Point(222, 420);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(281, 23);
            this.lblAbout.TabIndex = 22;
            this.lblAbout.Text = "About Quick Sort Algorithm";
            this.lblAbout.Visible = false;
            // 
            // txtboxAbout
            // 
            this.txtboxAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtboxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxAbout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtboxAbout.Location = new System.Drawing.Point(-4, 446);
            this.txtboxAbout.Multiline = true;
            this.txtboxAbout.Name = "txtboxAbout";
            this.txtboxAbout.ReadOnly = true;
            this.txtboxAbout.Size = new System.Drawing.Size(716, 126);
            this.txtboxAbout.TabIndex = 23;
            this.txtboxAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAbout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(461, 123);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(185, 61);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.UserSelect);
            // 
            // btnNumberSort
            // 
            this.btnNumberSort.BackColor = System.Drawing.Color.LightGreen;
            this.btnNumberSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumberSort.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnNumberSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberSort.Location = new System.Drawing.Point(77, 114);
            this.btnNumberSort.Name = "btnNumberSort";
            this.btnNumberSort.Size = new System.Drawing.Size(271, 47);
            this.btnNumberSort.TabIndex = 25;
            this.btnNumberSort.Text = "Click here to sort Numbers only";
            this.btnNumberSort.UseVisualStyleBackColor = false;
            this.btnNumberSort.Click += new System.EventHandler(this.UserChoose);
            // 
            // btnCharSort
            // 
            this.btnCharSort.BackColor = System.Drawing.Color.LightGreen;
            this.btnCharSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharSort.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCharSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharSort.Location = new System.Drawing.Point(366, 114);
            this.btnCharSort.Name = "btnCharSort";
            this.btnCharSort.Size = new System.Drawing.Size(275, 47);
            this.btnCharSort.TabIndex = 26;
            this.btnCharSort.Text = "Click here to sort Characters only";
            this.btnCharSort.UseVisualStyleBackColor = false;
            this.btnCharSort.Click += new System.EventHandler(this.UserChoose);
            // 
            // lblChooseType
            // 
            this.lblChooseType.AutoSize = true;
            this.lblChooseType.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseType.Location = new System.Drawing.Point(199, 83);
            this.lblChooseType.Name = "lblChooseType";
            this.lblChooseType.Size = new System.Drawing.Size(346, 27);
            this.lblChooseType.TabIndex = 27;
            this.lblChooseType.Text = "Choose type of array to sort.";
            // 
            // btnIntSimulate
            // 
            this.btnIntSimulate.BackColor = System.Drawing.Color.LightGreen;
            this.btnIntSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntSimulate.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnIntSimulate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntSimulate.Location = new System.Drawing.Point(82, 123);
            this.btnIntSimulate.Name = "btnIntSimulate";
            this.btnIntSimulate.Size = new System.Drawing.Size(185, 61);
            this.btnIntSimulate.TabIndex = 28;
            this.btnIntSimulate.Text = "Simulate";
            this.btnIntSimulate.UseVisualStyleBackColor = false;
            this.btnIntSimulate.Click += new System.EventHandler(this.btnIntSimulate_Click);
            // 
            // btnCharSimulate
            // 
            this.btnCharSimulate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCharSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharSimulate.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCharSimulate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharSimulate.Location = new System.Drawing.Point(82, 122);
            this.btnCharSimulate.Name = "btnCharSimulate";
            this.btnCharSimulate.Size = new System.Drawing.Size(185, 61);
            this.btnCharSimulate.TabIndex = 29;
            this.btnCharSimulate.Text = "Simulate";
            this.btnCharSimulate.UseVisualStyleBackColor = false;
            this.btnCharSimulate.Click += new System.EventHandler(this.btnCharSimulate_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(106, 53);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(505, 27);
            this.lblNumbers.TabIndex = 30;
            this.lblNumbers.Text = "Type the set of numbers you want to sort.";
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.BackColor = System.Drawing.Color.Pink;
            this.btnClearTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTxt.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnClearTxt.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTxt.Location = new System.Drawing.Point(270, 123);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(93, 61);
            this.btnClearTxt.TabIndex = 31;
            this.btnClearTxt.Text = "Clear";
            this.btnClearTxt.UseVisualStyleBackColor = false;
            this.btnClearTxt.Click += new System.EventHandler(this.UserSelect);
            // 
            // txtboxInputInt
            // 
            this.txtboxInputInt.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInputInt.Location = new System.Drawing.Point(82, 82);
            this.txtboxInputInt.Name = "txtboxInputInt";
            this.txtboxInputInt.ReadOnly = true;
            this.txtboxInputInt.Size = new System.Drawing.Size(564, 32);
            this.txtboxInputInt.TabIndex = 43;
            this.txtboxInputInt.Click += new System.EventHandler(this.txtboxInputInt_Click);
            this.txtboxInputInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerOnly_KeyPress);
            // 
            // QuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(718, 584);
            this.Controls.Add(this.txtboxInputInt);
            this.Controls.Add(this.btnNumberSort);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnCharSimulate);
            this.Controls.Add(this.btnIntSimulate);
            this.Controls.Add(this.lblChooseType);
            this.Controls.Add(this.btnCharSort);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.txtboxAbout);
            this.Controls.Add(this.txtboxDisplaySorted);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtboxDisplayUnsorted);
            this.Controls.Add(this.lblCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxInput);
            this.Location = new System.Drawing.Point(1, 100);
            this.MaximizeBox = false;
            this.Name = "QuickSort";
            this.ShowIcon = false;
            this.Text = "Quick Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtboxDisplayUnsorted;
        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.TextBox txtboxDisplaySorted;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox txtboxAbout;
        private System.Windows.Forms.Button btnNumberSort;
        private System.Windows.Forms.Button btnCharSort;
        private System.Windows.Forms.Label lblChooseType;
        private System.Windows.Forms.Button btnIntSimulate;
        private System.Windows.Forms.Button btnCharSimulate;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.TextBox txtboxInputInt;
    }
}