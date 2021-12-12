using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_1
{
    public class RationalNumb
    {
        private int _numerator;
        private int _denominator;

        public int Numer
        {
            get => _numerator;
            set => _numerator = value;
        }

        // В случае, если знаменатель оказывается отрицательным, сокращаем на "-1"
        public int Denom
        {
            get => _denominator;
            set
            {
                if (value < 0)
                {
                    _numerator *= -1;
                    _denominator = -value;
                }
                else
                {
                    _denominator = value;
                }
            }
        }

        public RationalNumb()
        { }
        public RationalNumb(int numerator, int denominator)
        {
            Numer = numerator;
            Denom = denominator;
        }

        // Переопределение операторов
        // Равно:
        public static bool operator ==(RationalNumb numb1, RationalNumb numb2)
        {
            if ((numb1.Numer * numb2.Denom) == (numb2.Numer * numb1.Denom)) return true;
            else return false;
        }
        // Не Равно:
        public static bool operator !=(RationalNumb numb1, RationalNumb numb2)
        {
            if ((numb1.Numer * numb2.Denom) != (numb2.Numer * numb1.Denom)) return true;
            else return false;
        }
        // Больше:
        public static bool operator >(RationalNumb numb1, RationalNumb numb2)
        {
            if (numb1.Numer >= 0 && numb2.Numer < 0) return true;
            if (numb1.Numer < 0 && numb2.Numer >= 0) return false;
            if (numb1.Numer >= 0 && numb2.Numer >= 0)
                if ((numb1.Numer * numb2.Denom) > (numb2.Numer * numb1.Denom)) return true;
                else return false;
            else if (numb1.Numer <= 0 && numb2.Numer <= 0)
                if ((-numb1.Numer * numb2.Denom) < (-numb2.Numer * numb1.Denom)) return true;
                else return false;
            else return false;
        }
        // Меньше:
        public static bool operator <(RationalNumb numb1, RationalNumb numb2)
        {
            if (numb1.Numer >= 0 && numb2.Numer < 0) return false;
            if (numb1.Numer < 0 && numb2.Numer >= 0) return true;
            if (numb1.Numer >= 0 && numb2.Numer >= 0)
                if ((numb1.Numer * numb2.Denom) < (numb2.Numer * numb1.Denom)) return true;
                else return false;
            else if (numb1.Numer <= 0 && numb2.Numer <= 0)
                if ((-numb1.Numer * numb2.Denom) > (-numb2.Numer * numb1.Denom)) return true;
                else return false;
            else return false;
        }
        // Больше или Равно:
        public static bool operator >=(RationalNumb numb1, RationalNumb numb2)
        {
            if (numb1.Numer >= 0 && numb2.Numer < 0) return true;
            if (numb1.Numer < 0 && numb2.Numer >= 0) return false;
            if (numb1.Numer >= 0 && numb2.Numer >= 0)
                if ((numb1.Numer * numb2.Denom) >= (numb2.Numer * numb1.Denom)) return true;
                else return false;
            else if (numb1.Numer <= 0 && numb2.Numer <= 0)
                if ((-numb1.Numer * numb2.Denom) <= (-numb2.Numer * numb1.Denom)) return true;
                else return false;
            else return false;
        }
        // Меньше или Равно:
        public static bool operator <=(RationalNumb numb1, RationalNumb numb2)
        {
            if (numb1.Numer >= 0 && numb2.Numer < 0) return false;
            if (numb1.Numer < 0 && numb2.Numer >= 0) return true;
            if (numb1.Numer >= 0 && numb2.Numer >= 0)
                if ((numb1.Numer * numb2.Denom) <= (numb2.Numer * numb1.Denom)) return true;
                else return false;
            else if (numb1.Numer <= 0 && numb2.Numer <= 0)
                if ((-numb1.Numer * numb2.Denom) >= (-numb2.Numer * numb1.Denom)) return true;
                else return false;
            else return false;
        }
        // Сложение:
        public static RationalNumb operator +(RationalNumb numb1, RationalNumb numb2)
        {
            var result = new RationalNumb();
            result.Numer = (numb1.Numer * numb2.Denom) + (numb2.Numer * numb1.Denom);
            result.Denom = numb1.Denom * numb2.Denom;
            return result;
        }
        // Вычитание:
        public static RationalNumb operator -(RationalNumb numb1, RationalNumb numb2)
        {
            var result = new RationalNumb();
            result.Numer = (numb1.Numer * numb2.Denom) - (numb2.Numer * numb1.Denom);
            result.Denom = numb1.Denom * numb2.Denom;
            return result;
        }
        // Инкремент:
        public static RationalNumb operator ++(RationalNumb numb)
        {
            var value = new RationalNumb(1, 1);
            var result = numb + value;
            return result;
        }
        // Декремент:
        public static RationalNumb operator --(RationalNumb numb)
        {
            var value = new RationalNumb(1, 1);
            var result = numb - value;
            return result;
        }
        // Умножение:
        public static RationalNumb operator *(RationalNumb numb1, RationalNumb numb2)
        {
            var result = new RationalNumb();
            result.Numer = numb1.Numer * numb2.Numer;
            result.Denom = numb1.Denom * numb2.Denom;
            return result;
        }
        // Деление:
        public static RationalNumb operator /(RationalNumb numb1, RationalNumb numb2)
        {
            var result = new RationalNumb();
            result.Numer = numb1.Numer * numb2.Denom;
            result.Denom = numb1.Denom * numb2.Numer;
            return result;
        }
        // Остаток от деления:
        public static RationalNumb operator %(RationalNumb numb1, RationalNumb numb2)
        {
            var result = new RationalNumb();
            result = numb1 / numb2;
            int newNumer = 0;
            while (result.Numer > result.Denom)
            {
                newNumer++;
                result.Numer--;
            }
            result.Numer = newNumer;
            return result;
        }

        // Приведение типов
        // Явное Float:
        public static explicit operator float(RationalNumb numb)
        {
            return (float)(numb.Numer / numb.Denom);
        }
        // Явное Int32:
        public static explicit operator int(RationalNumb numb)
        {
            return (int)(numb.Numer / numb.Denom);
        }

        public override string ToString()
        {
            NumbSimplification();
            return new string(Numer.ToString() + "/" + Denom.ToString());
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Упрощение дробей перед выводом
        private void NumbSimplification()
        {
            var lcf = LCF(Numer, Denom);
            Numer = Numer / lcf;
            Denom = Denom / lcf;
        }

        // Нахождение наименьшего общего делителя
        private int LCF(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            if (x == 0) return 1;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
    }
}