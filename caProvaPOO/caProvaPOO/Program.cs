using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            NumComplexo z1 = new NumComplexo(1, 1);
            NumComplexo z2 = new NumComplexo(3, -1);

            NumComplexo soma = z1.soma(z2);
            soma.imprimeFormaPolar();

            NumComplexo vezes = z1.vezes(z2);
            vezes.imprimeFormaPolar();
        }
    }
}
