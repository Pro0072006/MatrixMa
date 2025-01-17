namespace MatrixMa
{
    partial class ResultFormMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultFormMatrix));
            MatrixResultPaint = new DataGridView();
            TextResult = new Label();
            DetText = new Label();
            DetValue = new Label();
            BtnCopyToMatrix1 = new Button();
            BtnCopyToMatrix2 = new Button();
            TextCopyTo = new Label();
            ((System.ComponentModel.ISupportInitialize)MatrixResultPaint).BeginInit();
            SuspendLayout();
            // 
            // MatrixResultPaint
            // 
            MatrixResultPaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixResultPaint.Location = new Point(195, 120);
            MatrixResultPaint.Name = "MatrixResultPaint";
            MatrixResultPaint.ReadOnly = true;
            MatrixResultPaint.RowHeadersWidth = 51;
            MatrixResultPaint.RowTemplate.Height = 29;
            MatrixResultPaint.Size = new Size(532, 423);
            MatrixResultPaint.TabIndex = 0;
            // 
            // TextResult
            // 
            TextResult.AutoSize = true;
            TextResult.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextResult.Location = new Point(106, 28);
            TextResult.Name = "TextResult";
            TextResult.Size = new Size(140, 45);
            TextResult.TabIndex = 1;
            TextResult.Text = "Cambiar";
            // 
            // DetText
            // 
            DetText.AutoSize = true;
            DetText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetText.Location = new Point(754, 143);
            DetText.Name = "DetText";
            DetText.Size = new Size(176, 28);
            DetText.TabIndex = 2;
            DetText.Text = "El determinante es:";
            DetText.Visible = false;
            // 
            // DetValue
            // 
            DetValue.AutoSize = true;
            DetValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetValue.Location = new Point(809, 185);
            DetValue.Name = "DetValue";
            DetValue.Size = new Size(56, 28);
            DetValue.TabIndex = 3;
            DetValue.Text = "0000";
            DetValue.Visible = false;
            // 
            // BtnCopyToMatrix1
            // 
            BtnCopyToMatrix1.Location = new Point(785, 388);
            BtnCopyToMatrix1.Name = "BtnCopyToMatrix1";
            BtnCopyToMatrix1.Size = new Size(105, 45);
            BtnCopyToMatrix1.TabIndex = 17;
            BtnCopyToMatrix1.Text = "Matriz 1";
            BtnCopyToMatrix1.UseVisualStyleBackColor = true;
            BtnCopyToMatrix1.Click += BtnCopyToMatrix1_Click;
            // 
            // BtnCopyToMatrix2
            // 
            BtnCopyToMatrix2.Location = new Point(785, 462);
            BtnCopyToMatrix2.Name = "BtnCopyToMatrix2";
            BtnCopyToMatrix2.Size = new Size(105, 45);
            BtnCopyToMatrix2.TabIndex = 18;
            BtnCopyToMatrix2.Text = "Matriz 2";
            BtnCopyToMatrix2.UseVisualStyleBackColor = true;
            BtnCopyToMatrix2.Click += BtnCopyToMatrix2_Click;
            // 
            // TextCopyTo
            // 
            TextCopyTo.AutoSize = true;
            TextCopyTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextCopyTo.Location = new Point(783, 317);
            TextCopyTo.Name = "TextCopyTo";
            TextCopyTo.Size = new Size(107, 31);
            TextCopyTo.TabIndex = 19;
            TextCopyTo.Text = "Copiar A:";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 620);
            Controls.Add(TextCopyTo);
            Controls.Add(BtnCopyToMatrix2);
            Controls.Add(BtnCopyToMatrix1);
            Controls.Add(DetValue);
            Controls.Add(DetText);
            Controls.Add(TextResult);
            Controls.Add(MatrixResultPaint);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResultForm";
            Text = "Resultado";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)MatrixResultPaint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MatrixResultPaint;
        private Label TextResult;
        private Label DetText;
        private Label DetValue;
        private Button BtnCopyToMatrix1;
        private Button BtnCopyToMatrix2;
        private Label TextCopyTo;
    }
}