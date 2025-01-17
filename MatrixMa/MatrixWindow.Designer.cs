namespace MatrixMa
{
    partial class MatrixWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixWindow));
            MatrixPaint1 = new DataGridView();
            MatrixRows1 = new NumericUpDown();
            MatrixColumns1 = new NumericUpDown();
            label1 = new Label();
            BtnCreateMatrix1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnCreateMatrix2 = new Button();
            label6 = new Label();
            MatrixColumns2 = new NumericUpDown();
            MatrixRows2 = new NumericUpDown();
            MatrixPaint2 = new DataGridView();
            MatrixName1 = new Label();
            MatrixName2 = new Label();
            BtnSuma = new Button();
            BtnResta = new Button();
            BtnMult = new Button();
            BtnTrans1 = new Button();
            BtnTrans2 = new Button();
            Btnpont1 = new Button();
            Btnpont2 = new Button();
            NumberPont2 = new NumericUpDown();
            NumberPont1 = new NumericUpDown();
            NumberEscalar1 = new NumericUpDown();
            BtnEscalar1 = new Button();
            NumberEscalar2 = new NumericUpDown();
            BtnEscalar2 = new Button();
            ReduceMatrix1 = new Button();
            ReduceMatrix2 = new Button();
            BtnCredits = new Button();
            BtnDetAndCofactors1 = new Button();
            BtnDetAndCofactors2 = new Button();
            BtnInvertMatrix1 = new Button();
            BtnInvertMatrix2 = new Button();
            BtnChangeMatrixs = new Button();
            ((System.ComponentModel.ISupportInitialize)MatrixPaint1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixRows1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixColumns1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixColumns2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixRows2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixPaint2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberPont2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberPont1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberEscalar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberEscalar2).BeginInit();
            SuspendLayout();
            // 
            // MatrixPaint1
            // 
            MatrixPaint1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixPaint1.Location = new Point(84, 97);
            MatrixPaint1.Name = "MatrixPaint1";
            MatrixPaint1.ReadOnly = true;
            MatrixPaint1.RowHeadersWidth = 51;
            MatrixPaint1.RowTemplate.Height = 29;
            MatrixPaint1.Size = new Size(266, 204);
            MatrixPaint1.TabIndex = 0;
            // 
            // MatrixRows1
            // 
            MatrixRows1.Location = new Point(67, 390);
            MatrixRows1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MatrixRows1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MatrixRows1.Name = "MatrixRows1";
            MatrixRows1.Size = new Size(127, 27);
            MatrixRows1.TabIndex = 1;
            MatrixRows1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MatrixColumns1
            // 
            MatrixColumns1.Location = new Point(230, 390);
            MatrixColumns1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MatrixColumns1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MatrixColumns1.Name = "MatrixColumns1";
            MatrixColumns1.Size = new Size(150, 27);
            MatrixColumns1.TabIndex = 2;
            MatrixColumns1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 390);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // BtnCreateMatrix1
            // 
            BtnCreateMatrix1.Location = new Point(161, 454);
            BtnCreateMatrix1.Name = "BtnCreateMatrix1";
            BtnCreateMatrix1.Size = new Size(94, 29);
            BtnCreateMatrix1.TabIndex = 4;
            BtnCreateMatrix1.Text = "Crear";
            BtnCreateMatrix1.UseVisualStyleBackColor = true;
            BtnCreateMatrix1.Click += BtnCreateMatrix1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 359);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 5;
            label2.Text = "Filas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(252, 359);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 6;
            label3.Text = "Columnas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(953, 359);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 13;
            label4.Text = "Columnas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(805, 359);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 12;
            label5.Text = "Filas";
            // 
            // BtnCreateMatrix2
            // 
            BtnCreateMatrix2.Location = new Point(862, 454);
            BtnCreateMatrix2.Name = "BtnCreateMatrix2";
            BtnCreateMatrix2.Size = new Size(94, 29);
            BtnCreateMatrix2.TabIndex = 11;
            BtnCreateMatrix2.Text = "Crear";
            BtnCreateMatrix2.UseVisualStyleBackColor = true;
            BtnCreateMatrix2.Click += BtnCreateMatrix2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(901, 390);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 10;
            label6.Text = "X";
            // 
            // MatrixColumns2
            // 
            MatrixColumns2.Location = new Point(931, 390);
            MatrixColumns2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MatrixColumns2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MatrixColumns2.Name = "MatrixColumns2";
            MatrixColumns2.Size = new Size(150, 27);
            MatrixColumns2.TabIndex = 9;
            MatrixColumns2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MatrixRows2
            // 
            MatrixRows2.Location = new Point(768, 390);
            MatrixRows2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MatrixRows2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MatrixRows2.Name = "MatrixRows2";
            MatrixRows2.Size = new Size(127, 27);
            MatrixRows2.TabIndex = 8;
            MatrixRows2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MatrixPaint2
            // 
            MatrixPaint2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixPaint2.Location = new Point(785, 97);
            MatrixPaint2.Name = "MatrixPaint2";
            MatrixPaint2.ReadOnly = true;
            MatrixPaint2.RowHeadersWidth = 51;
            MatrixPaint2.RowTemplate.Height = 29;
            MatrixPaint2.Size = new Size(266, 204);
            MatrixPaint2.TabIndex = 7;
            // 
            // MatrixName1
            // 
            MatrixName1.AutoSize = true;
            MatrixName1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MatrixName1.Location = new Point(151, 31);
            MatrixName1.Name = "MatrixName1";
            MatrixName1.Size = new Size(118, 38);
            MatrixName1.TabIndex = 14;
            MatrixName1.Text = "Matriz 1";
            // 
            // MatrixName2
            // 
            MatrixName2.AutoSize = true;
            MatrixName2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MatrixName2.Location = new Point(850, 31);
            MatrixName2.Name = "MatrixName2";
            MatrixName2.Size = new Size(118, 38);
            MatrixName2.TabIndex = 15;
            MatrixName2.Text = "Matriz 2";
            // 
            // BtnSuma
            // 
            BtnSuma.Location = new Point(515, 97);
            BtnSuma.Name = "BtnSuma";
            BtnSuma.Size = new Size(105, 45);
            BtnSuma.TabIndex = 16;
            BtnSuma.Text = "Suma";
            BtnSuma.UseVisualStyleBackColor = true;
            BtnSuma.Click += BtnSuma_Click;
            // 
            // BtnResta
            // 
            BtnResta.Location = new Point(515, 172);
            BtnResta.Name = "BtnResta";
            BtnResta.Size = new Size(105, 45);
            BtnResta.TabIndex = 17;
            BtnResta.Text = "Resta";
            BtnResta.UseVisualStyleBackColor = true;
            BtnResta.Click += BtnResta_Click;
            // 
            // BtnMult
            // 
            BtnMult.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMult.Location = new Point(515, 247);
            BtnMult.Name = "BtnMult";
            BtnMult.Size = new Size(105, 45);
            BtnMult.TabIndex = 18;
            BtnMult.Text = "Multiplicación";
            BtnMult.UseVisualStyleBackColor = true;
            BtnMult.Click += BtnMult_Click;
            // 
            // BtnTrans1
            // 
            BtnTrans1.Location = new Point(49, 522);
            BtnTrans1.Name = "BtnTrans1";
            BtnTrans1.Size = new Size(105, 45);
            BtnTrans1.TabIndex = 19;
            BtnTrans1.Text = "Transpuesta";
            BtnTrans1.UseVisualStyleBackColor = true;
            BtnTrans1.Click += BtnTrans1_Click;
            // 
            // BtnTrans2
            // 
            BtnTrans2.Location = new Point(1006, 522);
            BtnTrans2.Name = "BtnTrans2";
            BtnTrans2.Size = new Size(105, 45);
            BtnTrans2.TabIndex = 20;
            BtnTrans2.Text = "Transpuesta";
            BtnTrans2.UseVisualStyleBackColor = true;
            BtnTrans2.Click += BtnTrans2_Click;
            // 
            // Btnpont1
            // 
            Btnpont1.Location = new Point(49, 593);
            Btnpont1.Name = "Btnpont1";
            Btnpont1.Size = new Size(105, 45);
            Btnpont1.TabIndex = 21;
            Btnpont1.Text = "Potenciación";
            Btnpont1.UseVisualStyleBackColor = true;
            Btnpont1.Click += Btnpont1_Click;
            // 
            // Btnpont2
            // 
            Btnpont2.Location = new Point(1006, 593);
            Btnpont2.Name = "Btnpont2";
            Btnpont2.Size = new Size(105, 45);
            Btnpont2.TabIndex = 22;
            Btnpont2.Text = "Potenciación";
            Btnpont2.UseVisualStyleBackColor = true;
            Btnpont2.Click += Btnpont2_Click;
            // 
            // NumberPont2
            // 
            NumberPont2.Location = new Point(931, 603);
            NumberPont2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumberPont2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberPont2.Name = "NumberPont2";
            NumberPont2.Size = new Size(69, 27);
            NumberPont2.TabIndex = 23;
            NumberPont2.ThousandsSeparator = true;
            NumberPont2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumberPont1
            // 
            NumberPont1.Location = new Point(173, 603);
            NumberPont1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumberPont1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberPont1.Name = "NumberPont1";
            NumberPont1.Size = new Size(69, 27);
            NumberPont1.TabIndex = 24;
            NumberPont1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumberEscalar1
            // 
            NumberEscalar1.Location = new Point(173, 678);
            NumberEscalar1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumberEscalar1.Name = "NumberEscalar1";
            NumberEscalar1.Size = new Size(69, 27);
            NumberEscalar1.TabIndex = 26;
            NumberEscalar1.ThousandsSeparator = true;
            // 
            // BtnEscalar1
            // 
            BtnEscalar1.Location = new Point(49, 668);
            BtnEscalar1.Name = "BtnEscalar1";
            BtnEscalar1.Size = new Size(105, 45);
            BtnEscalar1.TabIndex = 25;
            BtnEscalar1.Text = "Escalar";
            BtnEscalar1.UseVisualStyleBackColor = true;
            BtnEscalar1.Click += BtnEscalar1_Click;
            // 
            // NumberEscalar2
            // 
            NumberEscalar2.Location = new Point(931, 678);
            NumberEscalar2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumberEscalar2.Name = "NumberEscalar2";
            NumberEscalar2.Size = new Size(69, 27);
            NumberEscalar2.TabIndex = 28;
            NumberEscalar2.ThousandsSeparator = true;
            // 
            // BtnEscalar2
            // 
            BtnEscalar2.Location = new Point(1006, 668);
            BtnEscalar2.Name = "BtnEscalar2";
            BtnEscalar2.Size = new Size(105, 45);
            BtnEscalar2.TabIndex = 27;
            BtnEscalar2.Text = "Escalar";
            BtnEscalar2.UseVisualStyleBackColor = true;
            BtnEscalar2.Click += BtnEscalar2_Click;
            // 
            // ReduceMatrix1
            // 
            ReduceMatrix1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ReduceMatrix1.Location = new Point(294, 522);
            ReduceMatrix1.Name = "ReduceMatrix1";
            ReduceMatrix1.Size = new Size(105, 45);
            ReduceMatrix1.TabIndex = 29;
            ReduceMatrix1.Text = "Reducir Matriz";
            ReduceMatrix1.UseVisualStyleBackColor = true;
            ReduceMatrix1.Click += ReduceMatrix1_Click;
            // 
            // ReduceMatrix2
            // 
            ReduceMatrix2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ReduceMatrix2.Location = new Point(750, 522);
            ReduceMatrix2.Name = "ReduceMatrix2";
            ReduceMatrix2.Size = new Size(105, 45);
            ReduceMatrix2.TabIndex = 30;
            ReduceMatrix2.Text = "Reducir Matriz";
            ReduceMatrix2.UseVisualStyleBackColor = true;
            ReduceMatrix2.Click += ReduceMatrix2_Click;
            // 
            // BtnCredits
            // 
            BtnCredits.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCredits.Location = new Point(515, 686);
            BtnCredits.Name = "BtnCredits";
            BtnCredits.Size = new Size(105, 45);
            BtnCredits.TabIndex = 31;
            BtnCredits.Text = "Creditos";
            BtnCredits.UseVisualStyleBackColor = true;
            BtnCredits.Click += BtnCredits_Click;
            // 
            // BtnDetAndCofactors1
            // 
            BtnDetAndCofactors1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDetAndCofactors1.Location = new Point(294, 593);
            BtnDetAndCofactors1.Name = "BtnDetAndCofactors1";
            BtnDetAndCofactors1.Size = new Size(105, 45);
            BtnDetAndCofactors1.TabIndex = 32;
            BtnDetAndCofactors1.Text = "Determinante y cofactores";
            BtnDetAndCofactors1.UseVisualStyleBackColor = true;
            BtnDetAndCofactors1.Click += BtnDetAndCofactors1_Click;
            // 
            // BtnDetAndCofactors2
            // 
            BtnDetAndCofactors2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDetAndCofactors2.Location = new Point(750, 593);
            BtnDetAndCofactors2.Name = "BtnDetAndCofactors2";
            BtnDetAndCofactors2.Size = new Size(105, 45);
            BtnDetAndCofactors2.TabIndex = 33;
            BtnDetAndCofactors2.Text = "Determinante y cofactores";
            BtnDetAndCofactors2.UseVisualStyleBackColor = true;
            BtnDetAndCofactors2.Click += BtnDetAndCofactors2_Click;
            // 
            // BtnInvertMatrix1
            // 
            BtnInvertMatrix1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInvertMatrix1.Location = new Point(294, 668);
            BtnInvertMatrix1.Name = "BtnInvertMatrix1";
            BtnInvertMatrix1.Size = new Size(105, 45);
            BtnInvertMatrix1.TabIndex = 34;
            BtnInvertMatrix1.Text = "Matriz inversa";
            BtnInvertMatrix1.UseVisualStyleBackColor = true;
            BtnInvertMatrix1.Click += BtnInvertMatrix1_Click;
            // 
            // BtnInvertMatrix2
            // 
            BtnInvertMatrix2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInvertMatrix2.Location = new Point(750, 668);
            BtnInvertMatrix2.Name = "BtnInvertMatrix2";
            BtnInvertMatrix2.Size = new Size(105, 45);
            BtnInvertMatrix2.TabIndex = 35;
            BtnInvertMatrix2.Text = "Matriz inversa";
            BtnInvertMatrix2.UseVisualStyleBackColor = true;
            BtnInvertMatrix2.Click += BtnInvertMatrix2_Click;
            // 
            // BtnChangeMatrixs
            // 
            BtnChangeMatrixs.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnChangeMatrixs.Location = new Point(515, 322);
            BtnChangeMatrixs.Name = "BtnChangeMatrixs";
            BtnChangeMatrixs.Size = new Size(105, 45);
            BtnChangeMatrixs.TabIndex = 36;
            BtnChangeMatrixs.Text = "--->\r\n<---\r\n\r\n";
            BtnChangeMatrixs.UseVisualStyleBackColor = true;
            BtnChangeMatrixs.Click += BtnChangeMatrixs_Click;
            // 
            // MatrixWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1173, 743);
            Controls.Add(BtnChangeMatrixs);
            Controls.Add(BtnInvertMatrix2);
            Controls.Add(BtnInvertMatrix1);
            Controls.Add(BtnDetAndCofactors2);
            Controls.Add(BtnDetAndCofactors1);
            Controls.Add(BtnCredits);
            Controls.Add(ReduceMatrix2);
            Controls.Add(ReduceMatrix1);
            Controls.Add(NumberEscalar2);
            Controls.Add(BtnEscalar2);
            Controls.Add(NumberEscalar1);
            Controls.Add(BtnEscalar1);
            Controls.Add(NumberPont1);
            Controls.Add(NumberPont2);
            Controls.Add(Btnpont2);
            Controls.Add(Btnpont1);
            Controls.Add(BtnTrans2);
            Controls.Add(BtnTrans1);
            Controls.Add(BtnMult);
            Controls.Add(BtnResta);
            Controls.Add(BtnSuma);
            Controls.Add(MatrixName2);
            Controls.Add(MatrixName1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(BtnCreateMatrix2);
            Controls.Add(label6);
            Controls.Add(MatrixColumns2);
            Controls.Add(MatrixRows2);
            Controls.Add(MatrixPaint2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnCreateMatrix1);
            Controls.Add(label1);
            Controls.Add(MatrixColumns1);
            Controls.Add(MatrixRows1);
            Controls.Add(MatrixPaint1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MatrixWindow";
            Text = "MatrixMa";
            ((System.ComponentModel.ISupportInitialize)MatrixPaint1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixRows1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixColumns1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixColumns2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixRows2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixPaint2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberPont2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberPont1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberEscalar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberEscalar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MatrixPaint1;
        private NumericUpDown MatrixRows1;
        private NumericUpDown MatrixColumns1;
        private Label label1;
        private Button BtnCreateMatrix1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnCreateMatrix2;
        private Label label6;
        private NumericUpDown MatrixColumns2;
        private NumericUpDown MatrixRows2;
        private DataGridView MatrixPaint2;
        private Label MatrixName1;
        private Label MatrixName2;
        private Button BtnSuma;
        private Button BtnResta;
        private Button BtnMult;
        private Button BtnTrans1;
        private Button BtnTrans2;
        private Button Btnpont1;
        private Button Btnpont2;
        private NumericUpDown NumberPont2;
        private NumericUpDown NumberPont1;
        private NumericUpDown NumberEscalar1;
        private Button BtnEscalar1;
        private NumericUpDown NumberEscalar2;
        private Button BtnEscalar2;
        private Button ReduceMatrix1;
        private Button ReduceMatrix2;
        private Button BtnCredits;
        private Button BtnDetAndCofactors1;
        private Button BtnDetAndCofactors2;
        private Button BtnInvertMatrix1;
        private Button BtnInvertMatrix2;
        private Button BtnChangeMatrixs;
    }
}