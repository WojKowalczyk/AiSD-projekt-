namespace aisd_pop_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnstart = new System.Windows.Forms.Button();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.textNumbersM = new System.Windows.Forms.TextBox();
            this.textNumbersSorted = new System.Windows.Forms.TextBox();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.nmrcNumbersA = new System.Windows.Forms.NumericUpDown();
            this.btnGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSB = new System.Windows.Forms.Button();
            this.buttonSS = new System.Windows.Forms.Button();
            this.buttonSI = new System.Windows.Forms.Button();
            this.buttonSM = new System.Windows.Forms.Button();
            this.buttonSQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNumbersA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.AccessibleName = "Default";
            this.btnstart.Location = new System.Drawing.Point(413, 384);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(112, 50);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(405, 355);
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(120, 23);
            this.nudN.TabIndex = 1;
            // 
            // textNumbersM
            // 
            this.textNumbersM.Location = new System.Drawing.Point(32, 30);
            this.textNumbersM.Name = "textNumbersM";
            this.textNumbersM.Size = new System.Drawing.Size(187, 23);
            this.textNumbersM.TabIndex = 2;
            this.textNumbersM.TextChanged += new System.EventHandler(this.textNumbersM_TextChanged);
            // 
            // textNumbersSorted
            // 
            this.textNumbersSorted.Location = new System.Drawing.Point(32, 172);
            this.textNumbersSorted.Name = "textNumbersSorted";
            this.textNumbersSorted.Size = new System.Drawing.Size(187, 23);
            this.textNumbersSorted.TabIndex = 3;
            this.textNumbersSorted.TextChanged += new System.EventHandler(this.textNumbersSorted_TextChanged);
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.Location = new System.Drawing.Point(222, 5);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(118, 19);
            this.checkBox_auto.TabIndex = 4;
            this.checkBox_auto.Tag = "";
            this.checkBox_auto.Text = "Automat/manual";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            this.checkBox_auto.CheckedChanged += new System.EventHandler(this.checkBox_auto_CheckedChanged);
            // 
            // nmrcNumbersA
            // 
            this.nmrcNumbersA.Location = new System.Drawing.Point(337, 31);
            this.nmrcNumbersA.Name = "nmrcNumbersA";
            this.nmrcNumbersA.Size = new System.Drawing.Size(120, 23);
            this.nmrcNumbersA.TabIndex = 5;
            this.nmrcNumbersA.ValueChanged += new System.EventHandler(this.nmrcNumbersA_ValueChanged);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(337, 94);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "generuj";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Czas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(374, 172);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 15);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "label2";
            // 
            // buttonSB
            // 
            this.buttonSB.Location = new System.Drawing.Point(32, 289);
            this.buttonSB.Name = "buttonSB";
            this.buttonSB.Size = new System.Drawing.Size(75, 23);
            this.buttonSB.TabIndex = 9;
            this.buttonSB.Text = "SB";
            this.buttonSB.UseVisualStyleBackColor = true;
            this.buttonSB.Click += new System.EventHandler(this.buttonSB_Click);
            // 
            // buttonSS
            // 
            this.buttonSS.Location = new System.Drawing.Point(127, 289);
            this.buttonSS.Name = "buttonSS";
            this.buttonSS.Size = new System.Drawing.Size(75, 23);
            this.buttonSS.TabIndex = 10;
            this.buttonSS.Text = "SS";
            this.buttonSS.UseVisualStyleBackColor = true;
            // 
            // buttonSI
            // 
            this.buttonSI.Location = new System.Drawing.Point(222, 289);
            this.buttonSI.Name = "buttonSI";
            this.buttonSI.Size = new System.Drawing.Size(75, 23);
            this.buttonSI.TabIndex = 11;
            this.buttonSI.Text = "SI";
            this.buttonSI.UseVisualStyleBackColor = true;
            // 
            // buttonSM
            // 
            this.buttonSM.Location = new System.Drawing.Point(320, 289);
            this.buttonSM.Name = "buttonSM";
            this.buttonSM.Size = new System.Drawing.Size(75, 23);
            this.buttonSM.TabIndex = 12;
            this.buttonSM.Text = "SM";
            this.buttonSM.UseVisualStyleBackColor = true;
            // 
            // buttonSQ
            // 
            this.buttonSQ.Location = new System.Drawing.Point(422, 289);
            this.buttonSQ.Name = "buttonSQ";
            this.buttonSQ.Size = new System.Drawing.Size(75, 23);
            this.buttonSQ.TabIndex = 13;
            this.buttonSQ.Text = "SQ";
            this.buttonSQ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSQ);
            this.Controls.Add(this.buttonSM);
            this.Controls.Add(this.buttonSI);
            this.Controls.Add(this.buttonSS);
            this.Controls.Add(this.buttonSB);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.nmrcNumbersA);
            this.Controls.Add(this.checkBox_auto);
            this.Controls.Add(this.textNumbersSorted);
            this.Controls.Add(this.textNumbersM);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNumbersA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnstart;
        private NumericUpDown nudN;
        private TextBox textNumbersM;
        private TextBox textNumbersSorted;
        private CheckBox checkBox_auto;
        private NumericUpDown nmrcNumbersA;
        private Button btnGen;
        private Label label1;
        private Label labelTime;
        private Button buttonSB;
        private Button buttonSS;
        private Button buttonSI;
        private Button buttonSM;
        private Button buttonSQ;
    }
}