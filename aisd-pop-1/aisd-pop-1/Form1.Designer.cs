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
            textNumbersM = new TextBox();
            textNumbersSorted = new TextBox();
            checkBox_auto = new CheckBox();
            nmrcNumbersA = new NumericUpDown();
            btnGen = new Button();
            label1 = new Label();
            labelTime = new Label();
            buttonSB = new Button();
            buttonSS = new Button();
            buttonSI = new Button();
            buttonSM = new Button();
            buttonSQ = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrcNumbersA).BeginInit();
            SuspendLayout();
            // 
            // textNumbersM
            // 
            textNumbersM.Location = new Point(37, 40);
            textNumbersM.Margin = new Padding(3, 4, 3, 4);
            textNumbersM.Name = "textNumbersM";
            textNumbersM.Size = new Size(213, 27);
            textNumbersM.TabIndex = 2;
            textNumbersM.TextChanged += textNumbersM_TextChanged;
            // 
            // textNumbersSorted
            // 
            textNumbersSorted.Location = new Point(37, 229);
            textNumbersSorted.Margin = new Padding(3, 4, 3, 4);
            textNumbersSorted.Name = "textNumbersSorted";
            textNumbersSorted.Size = new Size(213, 27);
            textNumbersSorted.TabIndex = 3;
            textNumbersSorted.TextChanged += textNumbersSorted_TextChanged;
            // 
            // checkBox_auto
            // 
            checkBox_auto.AutoSize = true;
            checkBox_auto.Location = new Point(254, 7);
            checkBox_auto.Margin = new Padding(3, 4, 3, 4);
            checkBox_auto.Name = "checkBox_auto";
            checkBox_auto.Size = new Size(144, 24);
            checkBox_auto.TabIndex = 4;
            checkBox_auto.Tag = "";
            checkBox_auto.Text = "Automat/manual";
            checkBox_auto.UseVisualStyleBackColor = true;
            checkBox_auto.CheckedChanged += checkBox_auto_CheckedChanged;
            // 
            // nmrcNumbersA
            // 
            nmrcNumbersA.Location = new Point(385, 41);
            nmrcNumbersA.Margin = new Padding(3, 4, 3, 4);
            nmrcNumbersA.Name = "nmrcNumbersA";
            nmrcNumbersA.Size = new Size(137, 27);
            nmrcNumbersA.TabIndex = 5;
            nmrcNumbersA.ValueChanged += nmrcNumbersA_ValueChanged;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(385, 125);
            btnGen.Margin = new Padding(3, 4, 3, 4);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(86, 31);
            btnGen.TabIndex = 6;
            btnGen.Text = "generuj";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 229);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Czas";
            label1.Click += label1_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(427, 229);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(17, 20);
            labelTime.TabIndex = 8;
            labelTime.Text = "0";
            labelTime.Click += labelTime_Click;
            // 
            // buttonSB
            // 
            buttonSB.Location = new Point(37, 385);
            buttonSB.Margin = new Padding(3, 4, 3, 4);
            buttonSB.Name = "buttonSB";
            buttonSB.Size = new Size(86, 31);
            buttonSB.TabIndex = 9;
            buttonSB.Text = "SB";
            buttonSB.UseVisualStyleBackColor = true;
            buttonSB.Click += buttonSB_Click;
            // 
            // buttonSS
            // 
            buttonSS.Location = new Point(145, 385);
            buttonSS.Margin = new Padding(3, 4, 3, 4);
            buttonSS.Name = "buttonSS";
            buttonSS.Size = new Size(86, 31);
            buttonSS.TabIndex = 10;
            buttonSS.Text = "SS";
            buttonSS.UseVisualStyleBackColor = true;
            buttonSS.Click += buttonSS_Click;
            // 
            // buttonSI
            // 
            buttonSI.Location = new Point(254, 385);
            buttonSI.Margin = new Padding(3, 4, 3, 4);
            buttonSI.Name = "buttonSI";
            buttonSI.Size = new Size(86, 31);
            buttonSI.TabIndex = 11;
            buttonSI.Text = "SI";
            buttonSI.UseVisualStyleBackColor = true;
            // 
            // buttonSM
            // 
            buttonSM.Location = new Point(366, 385);
            buttonSM.Margin = new Padding(3, 4, 3, 4);
            buttonSM.Name = "buttonSM";
            buttonSM.Size = new Size(86, 31);
            buttonSM.TabIndex = 12;
            buttonSM.Text = "SM";
            buttonSM.UseVisualStyleBackColor = true;
            // 
            // buttonSQ
            // 
            buttonSQ.Location = new Point(482, 385);
            buttonSQ.Margin = new Padding(3, 4, 3, 4);
            buttonSQ.Name = "buttonSQ";
            buttonSQ.Size = new Size(86, 31);
            buttonSQ.TabIndex = 13;
            buttonSQ.Text = "SQ";
            buttonSQ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonSQ);
            Controls.Add(buttonSM);
            Controls.Add(buttonSI);
            Controls.Add(buttonSS);
            Controls.Add(buttonSB);
            Controls.Add(labelTime);
            Controls.Add(label1);
            Controls.Add(btnGen);
            Controls.Add(nmrcNumbersA);
            Controls.Add(checkBox_auto);
            Controls.Add(textNumbersSorted);
            Controls.Add(textNumbersM);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrcNumbersA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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