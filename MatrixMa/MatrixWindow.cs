using MatrixMa.Helpers;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MatrixMa
{
    public partial class MatrixWindow : Form
    {
        string[,] matrix1;
        string[,] matrix2;

        public MatrixWindow()
        {
            InitializeComponent();
        }

        private Fraction[,] CreateMatrix1()
        {
            Fraction[,] matrix = new Fraction[MatrixPaint1.RowCount, MatrixPaint1.ColumnCount];

            for (int i = 0; i < MatrixPaint1.RowCount; i++)
            {
                for (int j = 0; j < MatrixPaint1.ColumnCount; j++)
                {
                    matrix[i, j] = Fraction.ConvertToFrac(MatrixPaint1.Rows[i].Cells[j].Value);
                }
            }

            return matrix;
        }

        private Fraction[,] CreateMatrix2()
        {
            Fraction[,] matrix = new Fraction[MatrixPaint2.RowCount, MatrixPaint2.ColumnCount];

            for (int i = 0; i < MatrixPaint2.RowCount; i++)
            {
                for (int j = 0; j < MatrixPaint2.ColumnCount; j++)
                {
                    matrix[i, j] = Fraction.ConvertToFrac(MatrixPaint2.Rows[i].Cells[j].Value);
                }
            }

            return matrix;
        }

        public void CopyResultTo(string[,] matrix, int option)
        {
            if (option == 1)
            {
                matrix1 = (string[,])matrix.Clone();

                MatrixPaint1.RowCount = matrix1.GetLength(0);
                MatrixPaint1.ColumnCount = matrix1.GetLength(1);

                for (int i = 0; i < MatrixPaint1.RowCount; i++)
                {
                    for (int j = 0; j < MatrixPaint1.ColumnCount; j++)
                    {
                        MatrixPaint1.Rows[i].Cells[j].Value = matrix1[i, j];
                    }
                }

                MatrixRows1.Value = MatrixPaint1.RowCount;
                MatrixColumns1.Value = MatrixPaint1.ColumnCount;
            }
            else
            {
                matrix2 = (string[,])matrix.Clone();

                MatrixPaint2.RowCount = matrix2.GetLength(0);
                MatrixPaint2.ColumnCount = matrix2.GetLength(1);

                for (int i = 0; i < MatrixPaint2.RowCount; i++)
                {
                    for (int j = 0; j < MatrixPaint2.ColumnCount; j++)
                    {
                        MatrixPaint2.Rows[i].Cells[j].Value = matrix2[i, j];
                    }
                }

                MatrixRows2.Value = MatrixPaint2.RowCount;
                MatrixColumns2.Value = MatrixPaint2.ColumnCount;
            }
        }

        private void BtnChangeMatrixs_Click(object sender, EventArgs e)
        {
            if (matrix1 == null || matrix2 == null) return;

            string[,] aux;
            aux = (string[,])matrix1.Clone();
            matrix1 = (string[,])matrix2.Clone();
            matrix2 = (string[,])aux.Clone();

            int rowCount1 = matrix1.GetLength(0);
            int columnCount1 = matrix1.GetLength(1);

            int rowCount2 = matrix2.GetLength(0);
            int columnCount2 = matrix2.GetLength(1);

            MatrixPaint1.RowCount = rowCount1;
            MatrixPaint1.ColumnCount = columnCount1;

            MatrixPaint2.RowCount = rowCount2;
            MatrixPaint2.ColumnCount = columnCount2;

            for (int i = 0; i < MatrixPaint1.RowCount; i++)
            {
                for (int j = 0; j < MatrixPaint1.ColumnCount; j++)
                {
                    MatrixPaint1.Rows[i].Cells[j].Value = matrix1[i, j];
                }
            }

            for (int i = 0; i < MatrixPaint2.RowCount; i++)
            {
                for (int j = 0; j < MatrixPaint2.ColumnCount; j++)
                {
                    MatrixPaint2.Rows[i].Cells[j].Value = matrix2[i, j];
                }
            }

            MatrixRows1.Value = rowCount1;
            MatrixColumns1.Value = columnCount1;
            MatrixRows2.Value = rowCount2;
            MatrixColumns2.Value = columnCount2;
        }

        private void BtnCreateMatrix1_Click(object sender, EventArgs e)
        {
            int matrixRows = (int)MatrixRows1.Value;
            int matrixColumns = (int)MatrixColumns1.Value;

            if (matrixRows == 0 || matrixColumns == 0)
            {
                MessageBox.Show("No se puede crear la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            matrix1 = new string[matrixRows, matrixColumns];

            MatrixPaint1.RowCount = matrixRows;
            MatrixPaint1.ColumnCount = matrixColumns;
            try
            {
                for (int i = 0; i < matrixRows; i++)
                {
                    for (int j = 0; j < matrixColumns; j++)
                    {
                        matrix1[i, j] = Interaction.InputBox($"Ingrese el dato que quiere en la\n" +
                            $"fila: {i + 1} Columna: {j + 1}", "Ingresando datos");

                        if (string.IsNullOrEmpty(matrix1[i, j]))
                            matrix1[i, j] = "0";
                    }
                }
            }
            catch
            {
                matrix1 = new string[0, 0];
                MatrixPaint1.Rows.Clear();
                MatrixPaint1.Columns.Clear();
                return;
            }

            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColumns; j++)
                {
                    MatrixPaint1.Rows[i].Cells[j].Value = matrix1[i, j];
                }
            }
        }

        private void BtnCreateMatrix2_Click(object sender, EventArgs e)
        {
            int matrixRows = (int)MatrixRows2.Value;
            int matrixColumns = (int)MatrixColumns2.Value;

            if (matrixRows == 0 || matrixColumns == 0)
            {
                MessageBox.Show("No se puede crear la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            matrix2 = new string[matrixRows, matrixColumns];

            MatrixPaint2.RowCount = matrixRows;
            MatrixPaint2.ColumnCount = matrixColumns;

            try
            {
                for (int i = 0; i < matrixRows; i++)
                {
                    for (int j = 0; j < matrixColumns; j++)
                    {
                        matrix2[i, j] = Interaction.InputBox($"Ingrese el dato que quiere en la\n" +
                            $"fila: {i + 1} Columna: {j + 1}");

                        if (string.IsNullOrEmpty(matrix2[i, j]))
                            matrix2[i, j] = "0";
                    }
                }
            }
            catch
            {
                matrix2 = new string[0, 0];
                MatrixPaint2.Rows.Clear();
                MatrixPaint2.Columns.Clear();
                return;
            }

            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColumns; j++)
                {
                    MatrixPaint2.Rows[i].Cells[j].Value = matrix2[i, j];
                }
            }
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint2.RowCount == 0)
            {
                MessageBox.Show("Hay una matriz vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] fMatrix = Fraction.ConvertToFrac(matrix1);
            Fraction[,] SMatrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.SumaMatrix(fMatrix, SMatrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La suma de las matrices es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint2.RowCount == 0)
            {
                MessageBox.Show("Hay una matriz vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] fMatrix = Fraction.ConvertToFrac(matrix1);
            Fraction[,] SMatrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.RestaMatrix(fMatrix, SMatrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La resta de las matrices es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint2.RowCount == 0)
            {
                MessageBox.Show("Hay una matriz vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] fMatrix = Fraction.ConvertToFrac(matrix1);
            Fraction[,] SMatrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.MultMatrix(fMatrix, SMatrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La multiplicación de las matrices es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnTrans1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] fMatrix = Fraction.ConvertToFrac(matrix1);

            try
            {
                matrixResult = OperationsMatrix.TranspuestaMatrix(fMatrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La transpuesta de la primera matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnTrans2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] SMatrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.TranspuestaMatrix(SMatrix);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La transpuesta de la segunda matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void Btnpont1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction[,] helper = CreateMatrix1();

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                matrixResult = OperationsMatrix.PotenciaMatrix((int)NumberPont1.Value, helper);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult($"La potenciación por {NumberPont1.Value} de la primera matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void Btnpont2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction[,] helper = CreateMatrix2();

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                matrixResult = OperationsMatrix.PotenciaMatrix((int)NumberPont2.Value, helper);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult($"La potenciación por {NumberPont2.Value} de la segunda matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnEscalar1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction[,] helper = CreateMatrix1();

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                matrixResult = OperationsMatrix.EscalarMatrix((int)NumberEscalar1.Value, helper);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult($"La multiplicación por {NumberEscalar1.Value} de la primera matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnEscalar2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction[,] helper = CreateMatrix2();

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                matrixResult = OperationsMatrix.EscalarMatrix((int)NumberEscalar2.Value, helper);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult($"La multiplicación por {NumberEscalar2.Value} de la segunda matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void ReduceMatrix1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MatrixPaint1.RowCount > MatrixPaint1.ColumnCount)
            {
                MessageBox.Show("Hasta el momento no podemos resolver ecuaciones que contengan mas filas que columnas, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] fMatrix = Fraction.ConvertToFrac(matrix1);

            try
            {
                matrixResult = OperationsMatrix.MatrizReducida(fMatrix);
            }
            catch
            {
                MessageBox.Show("Algo ha salido mal, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz reducida de la primera matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void ReduceMatrix2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MatrixPaint2.RowCount > MatrixPaint2.ColumnCount)
            {
                MessageBox.Show("Hasta el momento no podemos resolver ecuaciones que contengan mas filas que columnas, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] SMatrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.MatrizReducida(SMatrix);

            }
            catch
            {
                MessageBox.Show("Algo ha salido mal, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz reducida de la segunda matriz es: ", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnDetAndCofactors1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction determinant;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] Matrix = Fraction.ConvertToFrac(matrix1);

            try
            {
                matrixResult = OperationsMatrix.Cofactors(Matrix);
                determinant = OperationsMatrix.DetMatrix(Matrix);
            }
            catch
            {
                MessageBox.Show("Algo ha salido mal, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz de cofactores de la primera matriz es:", matrixResult);
            OperationsMatrix.SetDeterminant(determinant);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnDetAndCofactors2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;
            Fraction determinant;

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] Matrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.Cofactors(Matrix);
                determinant = OperationsMatrix.DetMatrix(Matrix);
            }
            catch
            {
                MessageBox.Show("Algo ha salido mal, perdón", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz de cofactores de la segunda matriz es:", matrixResult);
            OperationsMatrix.SetDeterminant(determinant);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnInvertMatrix1_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint1.RowCount == 0 || MatrixPaint1.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 1 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matrix1.GetLength(0) != matrix1.GetLength(1))
            {
                MessageBox.Show("No se puede invertir matrices no cuadradas", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] Matrix = Fraction.ConvertToFrac(matrix1);

            try
            {
                matrixResult = OperationsMatrix.InvertMatrix(Matrix);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz inversa de la primera matriz es:", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }
        private void BtnInvertMatrix2_Click(object sender, EventArgs e)
        {
            Fraction[,] matrixResult;

            if (MatrixPaint2.RowCount == 0 || MatrixPaint2.ColumnCount == 0)
            {
                MessageBox.Show("La matriz 2 esta vacia", "Matriz vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matrix2.GetLength(0) != matrix2.GetLength(1))
            {
                MessageBox.Show("No se puede invertir matrices no cuadradas", "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction[,] Matrix = Fraction.ConvertToFrac(matrix2);

            try
            {
                matrixResult = OperationsMatrix.InvertMatrix(Matrix);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "No es posible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OperationsMatrix.SetResult("La matriz inversa de la segunda matriz es:", matrixResult);

            ResultFormMatrix resultForm = new();
            resultForm.Show();
        }

        private void BtnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion creada por: \n" +
                "Santiago Mendoza \n", "EL CREADOR😎", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}