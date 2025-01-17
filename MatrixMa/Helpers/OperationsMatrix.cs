namespace MatrixMa.Helpers
{
    internal class OperationsMatrix
    {

        private static Fraction CoFactor(Fraction[,] matrix, int row, int column)
        {
            int n = matrix.GetLength(0) - 1;
            Fraction[,] subMatrix = new Fraction[n, n];
            Fraction result;

            int x = 0, y = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != row && j != column)
                    {
                        subMatrix[x, y] = matrix[i, j];
                        y++;

                        if (y >= n)
                        {
                            x++;
                            y = 0;
                        }
                    }
                }
            }

            result = (int)Math.Pow(-1, row + column) * DetMatrix(subMatrix);
            return result;
        }

        public static string OperationName { get; private set; }

        public static string? Determinant { get; private set; }

        public static Fraction[,] MatrixResult { get; private set; }

        public static Fraction[,] MatrixCreator(int rows, int columns)
        {
            return new Fraction[rows, columns];
        }

        public static Fraction[,] SumaMatrix(Fraction[,] matrix1, Fraction[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new Exception("No se pueden sumar dos matrices de diferentes tamaños");

            Fraction[,] matrixResult = MatrixCreator(matrix1.GetLength(0), matrix1.GetLength(1));

            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return matrixResult;
        }

        public static Fraction[,] RestaMatrix(Fraction[,] matrix1, Fraction[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new Exception("No se pueden restar dos matrices de diferentes tamaños");

            Fraction[,] matrixResult = MatrixCreator(matrix1.GetLength(0), matrix1.GetLength(1));

            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return matrixResult;
        }

        public static Fraction[,] MultMatrix(Fraction[,] matrix1, Fraction[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new Exception("\nEl numero de columnas de la primera matriz deber ser el mismo numero de filas de la segunda matriz" +
                    "\nPara poder multiplicarlos");

            Fraction[,] matrixResult = MatrixCreator(matrix1.GetLength(0), matrix2.GetLength(1));
            Fraction result = new(0, 1);
            Fraction[] results = new Fraction[matrixResult.Length];
            int pos = 0;
            int auxPos = 0;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result += matrix1[i, k] * matrix2[k, j];
                    }

                    results[auxPos] = result;
                    result = new(0, 1);
                    auxPos++;
                }
            }

            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = results[pos];
                    pos++;
                }
            }

            return matrixResult;
        }

        public static Fraction[,] EscalarMatrix(int escalar, Fraction[,] matrix)
        {
            Fraction[,] matrixResult = MatrixCreator(matrix.GetLength(0), matrix.GetLength(1));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix[i, j] * escalar;
                }
            }

            return matrixResult;
        }

        public static Fraction[,] PotenciaMatrix(int potencia, Fraction[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception("No se pueden potenciar matrices no cuadradas");

            Fraction[,] matrixResult = MatrixCreator(matrix.GetLength(0), matrix.GetLength(1));
            Fraction[,] matrixOriginal = (Fraction[,])matrix.Clone();
            Fraction result = new(0, 1);
            List<Fraction> results = new();
            int pos = 0;

            for (int f = 1; f < potencia; f++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            result += matrix[i, k] * matrixOriginal[k, j];
                        }

                        results.Add(result);
                        result = new(0, 1);
                    }
                }

                for (int i = 0; i < matrixResult.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixResult.GetLength(1); j++)
                    {
                        matrix[i, j] = results[pos];
                        pos++;
                    }
                }

                pos = 0;
                results.Clear();

            }

            matrixResult = matrix;

            return matrixResult;
        }

        public static Fraction[,] TranspuestaMatrix(Fraction[,] matrix)
        {
            Fraction[,] matrixResult = MatrixCreator(matrix.GetLength(1), matrix.GetLength(0));

            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix[j, i];
                }
            }

            return matrixResult;
        }

        public static Fraction[,] MatrizReducida(Fraction[,] matrix)
        {
            Fraction number;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] != 1)
                {
                    if (matrix[i, i] == 0)
                    {
                        if (i + 1 >= matrix.GetLength(0)) break;

                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            (matrix[i + 1, j], matrix[i, j]) = (matrix[i, j], matrix[i + 1, j]);
                        }
                    }

                    Fraction reciproco = Fraction.Reciproco(matrix[i, i]);

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] *= reciproco;
                    }

                    for (int k = i + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[k, i] != 0)
                        {
                            number = -matrix[k, i];

                            for (int r = 0; r < matrix.GetLength(1); r++)
                            {
                                matrix[k, r] = matrix[i, r] * number + matrix[k, r];
                            }
                        }
                    }
                }
                if (matrix[i, i] == 1)
                {
                    for (int k = i + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[k, i] != 0)
                        {
                            number = -matrix[k, i];

                            for (int r = 0; r < matrix.GetLength(1); r++)
                            {
                                matrix[k, r] = matrix[i, r] * number + matrix[k, r];
                            }
                        }
                    }
                }
            }

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (matrix[k, i] != 0)
                    {
                        number = -matrix[k, i];

                        for (int r = matrix.GetLength(1) - 1; r > 0; r--)
                        {
                            matrix[k, r] = matrix[i, r] * number + matrix[k, r];
                        }
                    }
                }
            }
            return matrix;
        }

        public static Fraction[,] Cofactors(Fraction[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception("No se pueden sacar los cofactores a matrices no cuadradas");

            int rows = matrix.GetLength(0);
            int collumns = matrix.GetLength(1);
            Fraction[,] result = new Fraction[rows, collumns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumns; j++)
                {
                    result[i, j] = CoFactor(matrix, i, j);
                }
            }

            return result;
        }

        public static Fraction DetMatrix(Fraction[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception("No se puede sacar el determinante a matrices no cuadradas");

            int rows = matrix.GetLength(0);
            int collumns = matrix.GetLength(1);

            if (rows == 1 && collumns == 1)
                return matrix[0, 0];

            Fraction det = new(0, 1);

            for (int j = 0; j < collumns; j++)
            {
                det += matrix[0, j] * CoFactor(matrix, 0, j);
            }

            return det;
        }

        public static Fraction[,] InvertMatrix(Fraction[,] matrix)
        {
            Fraction determinant;
            try
            {
                determinant = Fraction.Reciproco(DetMatrix(matrix));
            }
            catch
            {
                throw new Exception("El determinante es 0, por ende, no tiene matriz inversa");
            }

            Fraction[,] result = new Fraction[matrix.GetLength(0), matrix.GetLength(1)];
            Fraction[,] coFactors = TranspuestaMatrix(Cofactors(matrix));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = determinant * coFactors[i, j];
                }
            }

            return result;
        }

        public static void SetResult(string operation, Fraction[,] matrix)
        {
            OperationName = operation;
            MatrixResult = matrix;
        }

        public static void SetDeterminant(Fraction determinant)
        {
            try
            {
                Determinant = Fraction.ConvertToString(determinant);
            }
            catch
            {
                Determinant = null;
            }
        }

        public static void CleanDeterminant()
        {
            Determinant = null;
        }
    }
}
