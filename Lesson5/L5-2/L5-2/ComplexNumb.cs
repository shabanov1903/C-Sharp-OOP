using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_2
{
    public class ComplexNumb
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public ComplexNumb()
        { }
        public ComplexNumb(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        // Переопределение операторов
        // Равно:
        public static bool operator == (ComplexNumb numb1, ComplexNumb numb2)
        {
            if ((numb1.Real == numb2.Real) && (numb2.Imag == numb1.Imag)) return true;
            else return false;
        }
        // Не Равно:
        public static bool operator != (ComplexNumb numb1, ComplexNumb numb2)
        {
            if ((numb1.Real != numb2.Real) || (numb2.Imag != numb1.Imag)) return true;
            else return false;
        }
        // Сложение:
        public static ComplexNumb operator + (ComplexNumb numb1, ComplexNumb numb2)
        {
            var result = new ComplexNumb();
            result.Real = numb1.Real + numb2.Real;
            result.Imag = numb1.Imag + numb2.Imag;
            return result;
        }
        // Вычитание:
        public static ComplexNumb operator - (ComplexNumb numb1, ComplexNumb numb2)
        {
            var result = new ComplexNumb();
            result.Real = numb1.Real - numb2.Real;
            result.Imag = numb1.Imag - numb2.Imag;
            return result;
        }
        // Умножение:
        public static ComplexNumb operator * (ComplexNumb numb1, ComplexNumb numb2)
        {
            var result = new ComplexNumb();
            result.Real = numb1.Real*numb2.Real - numb1.Imag*numb2.Imag;
            result.Imag = numb1.Real*numb2.Imag + numb2.Real*numb1.Imag;
            return result;
        }

        public override string ToString()
        {
            return new string(Real.ToString() + " + j(" + Imag.ToString()+")");
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}