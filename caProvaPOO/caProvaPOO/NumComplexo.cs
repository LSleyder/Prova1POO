using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOO
{
    class NumComplexo
    {
        // atributos
        public double Re;
        public double Im;

        // metodos
        public NumComplexo()
        {

        }
        public NumComplexo(double a, double b)
        {
            Re = a; 
            Im = b; 
        }

        public void setRe(double _Re)
        {
            this.Re = _Re;
        }

        public double getRe()
        {
            return Re;
        }

        public void setIm(double _Im)
        {
            this.Re = _Im;
        }

        public double getIm()
        {
            return Im;
        }

        public NumComplexo soma(NumComplexo z)
        {
            NumComplexo s = new NumComplexo();
            s.Re = Re + z.Re;
            s.Im = Im + z.Im;
            return s;
        }

        public NumComplexo vezes(NumComplexo z)
        {
            NumComplexo v = new NumComplexo();
            v.Re = Re * z.Re - Im * z.Im;
            v.Im = Re * z.Im + Im * z.Re;
            return v;
        }

        public double Modulo()
        {
            double mod = Math.Sqrt(Math.Pow(Re,2) + Math.Pow(Im,2));
            return mod;
        }

        public double Argumento()
        {
            double fase = Math.Asin(Im / Modulo());
            return fase;
        }

        public void imprimeFormaPolar()
        {
            double mod = Modulo();
            double fase = Argumento();
            Console.WriteLine(mod + "|_" + fase + "°");
        }
    }
}
