namespace MatrixMa.Helpers
{
    internal class Fraction
    {
        public int Numerador { get; private set; }
        public int Denomidador { get; private set; }

        public Fraction(int numerador, int denominador)
        {
            Numerador = numerador;
            Denomidador = denominador;

            SimplyFrac(this);
        }

        #region Auxiliar

        public static Fraction SimplyFrac(Fraction frac)
        {
            if (frac.Numerador % frac.Denomidador == 0)
            {
                frac.Numerador /= frac.Denomidador;
                frac.Denomidador = 1;
                return frac;
            }

            int max = Math.Max(frac.Numerador, frac.Denomidador);
            int div = 1;

            for (int i = max; i >= 2; i--)
            {
                if (frac.Numerador % i == 0 && frac.Denomidador % i == 0)
                {
                    div = i;
                    break;
                }
            }

            frac.Numerador /= div;
            frac.Denomidador /= div;
            return frac;
        }

        public static Fraction Reciproco(Fraction x)
            => new(x.Denomidador, x.Numerador);

        #endregion

        #region Converters
        public static Fraction ConvertToFrac(int numerador)
        {
            return new Fraction(numerador, 1);
        }

        public static Fraction ConvertToFrac(int numerador, int denomidador)
        {
            return new Fraction(numerador, denomidador);
        }

        public static Fraction ConvertToFrac(string numerador)
        {
            return new Fraction(int.Parse(numerador), 1);
        }

        public static Fraction ConvertToFrac(string numerador, string denomidador)
        {
            return new Fraction(int.Parse(numerador), int.Parse(denomidador));
        }

        public static Fraction[,] ConvertToFrac(int[,] matrix)
        {
            Fraction[,] aux = new Fraction[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    aux[i, j] = ConvertToFrac(matrix[i, j]);
                }
            }

            return aux;
        }

        public static Fraction[,] ConvertToFrac(string[,] stringMatrix)
        {
            Fraction[,] aux = new Fraction[stringMatrix.GetLength(0), stringMatrix.GetLength(1)];

            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(1); j++)
                {
                    string[] numbers = stringMatrix[i, j].Split("/");

                    if (numbers.Length == 1)
                    {
                        aux[i, j] = ConvertToFrac(numbers[0]);
                    }
                    else
                    {
                        aux[i, j] = ConvertToFrac(numbers[0], numbers[1]);
                    }
                }
            }

            return aux;
        }

        public static string[,] ConvertToStringMatrix(Fraction[,] frac)
        {
            string[,] result = new string[frac.GetLength(0), frac.GetLength(1)];

            for (int i = 0; i < frac.GetLength(0); i++)
            {
                for (int j = 0; j < frac.GetLength(1); j++)
                {
                    if (frac[i, j].Denomidador != 1)
                    {
                        if (frac[i, j].Numerador < 0 && frac[i, j].Denomidador < 0)
                        {
                            frac[i, j] = new(-frac[i, j].Numerador, -frac[i, j].Denomidador);
                        }
                        else if (frac[i, j].Denomidador < 0)
                        {
                            frac[i, j] = new(-frac[i, j].Numerador, -frac[i, j].Denomidador);
                        }

                        frac[i, j] = SimplyFrac(frac[i, j]);

                        result[i, j] = $"{frac[i, j].Numerador}/{frac[i, j].Denomidador}";
                    }
                    else
                    {
                        result[i, j] = $"{frac[i, j].Numerador}";
                    }
                }
            }

            return result;
        }

        public static Fraction ConvertToFrac(object obj)
        {
            string? number = obj.ToString();
            string[] numbers = number.Split("/");
            Fraction frac;

            if (numbers.Length == 1)
            {
                frac = ConvertToFrac(numbers[0]);
            }
            else
            {
                frac = ConvertToFrac(numbers[0], numbers[1]);
            }

            return frac;
        }

        public static string ConvertToString(Fraction frac)
        {
            string result;

            if (frac.Denomidador != 1)
            {
                if (frac.Numerador < 0 && frac.Denomidador < 0)
                {
                    frac = new(-frac.Numerador, frac.Denomidador);
                }
                else if (frac.Denomidador < 0)
                {
                    frac = new(-frac.Numerador, -frac.Denomidador);
                }

                frac = SimplyFrac(frac);

                result = $"{frac.Numerador}/{frac.Denomidador}";
            }
            else
            {
                result = $"{frac.Numerador}";
            }

            return result;
        }
        #endregion

        #region Operators

        #region SumYResta
        public static Fraction operator +(Fraction x) => x;
        public static Fraction operator +(Fraction x, Fraction y)
            => new(x.Numerador * y.Denomidador + y.Numerador * x.Denomidador, x.Denomidador * y.Denomidador);
        public static Fraction operator +(Fraction x, int number)
            => new(x.Numerador + x.Denomidador * number, x.Denomidador);
        public static Fraction operator +(int number, Fraction x)
            => new(x.Numerador + x.Denomidador * number, x.Denomidador);
        public static Fraction operator ++(Fraction x)
            => new(x.Numerador + x.Denomidador * 1, x.Denomidador);

        public static Fraction operator -(Fraction x) => new(-x.Numerador, x.Denomidador);
        public static Fraction operator -(Fraction x, Fraction y)
            => new(x.Numerador * y.Denomidador - y.Numerador * x.Denomidador, x.Denomidador * y.Denomidador);
        public static Fraction operator -(Fraction x, int number)
            => new(x.Numerador - x.Denomidador * number, x.Denomidador);

        public static Fraction operator --(Fraction x)
            => new(x.Numerador - x.Denomidador * 1, x.Denomidador);

        public static Fraction operator -(int number, Fraction x)
            => new(x.Numerador - x.Denomidador * number, x.Denomidador);
        #endregion

        #region Mult

        public static Fraction operator *(Fraction x, Fraction y)
            => new(x.Numerador * y.Numerador, x.Denomidador * y.Denomidador);
        public static Fraction operator *(Fraction x, int number) => new(x.Numerador * number, x.Denomidador);
        public static Fraction operator *(int number, Fraction x) => new(x.Numerador * number, x.Denomidador);

        #endregion

        #region Logic

        public static bool operator ==(Fraction x, Fraction y)
            => x.Numerador == y.Numerador && x.Denomidador == y.Denomidador;

        public static bool operator !=(Fraction x, Fraction y)
            => !(x.Numerador == y.Numerador && x.Denomidador == y.Denomidador);
        public static bool operator ==(Fraction x, int y)
        {
            return x == new Fraction(y, 1);
        }

        public static bool operator !=(Fraction x, int y)
        {
            return x != new Fraction(y, 1);
        }

        public static bool operator ==(int x, Fraction y)
        {
            return y == new Fraction(x, 1);
        }

        public static bool operator !=(int x, Fraction y)
        {
            return y == new Fraction(x, 1);
        }


        #endregion

        #endregion
    }
}
