using MatrixMa.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMa
{
    public partial class ResultFormMatrix : Form
    {
        private string Operation;
        private Fraction[,] MatrixResult;
        private string[,] StringResult;
        private string? Determinant;
        private readonly MatrixWindow? mainPage = Application.OpenForms.OfType<MatrixWindow>().FirstOrDefault();

        public ResultFormMatrix()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Operation = OperationsMatrix.OperationName;
            MatrixResult = OperationsMatrix.MatrixResult;
            StringResult = Fraction.ConvertToStringMatrix(MatrixResult);
            Determinant = OperationsMatrix.Determinant;

            TextResult.Text = Operation;

            if (Determinant != null)
            {
                DetText.Visible = true;
                DetValue.Text = Determinant;
                DetValue.Visible = true;
                OperationsMatrix.CleanDeterminant();
            }
            else
            {
                DetText.Visible = false;
                DetValue.Visible = false;
            }

            MatrixResultPaint.RowCount = MatrixResult.GetLength(0);
            MatrixResultPaint.ColumnCount = MatrixResult.GetLength(1);

            for (int i = 0; i < MatrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixResult.GetLength(1); j++)
                {
                    MatrixResultPaint.Rows[i].Cells[j].Value = StringResult[i, j];
                }
            }
        }

        private void BtnCopyToMatrix1_Click(object sender, EventArgs e)
        {
            mainPage.CopyResultTo(StringResult, 1);
            MessageBox.Show("La matriz resultante fue copiada a la primera matriz", "Hecho!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCopyToMatrix2_Click(object sender, EventArgs e)
        {
            mainPage.CopyResultTo(StringResult, 0);
            MessageBox.Show("La matriz resultante fue copiada a la segunda matriz", "Hecho!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
