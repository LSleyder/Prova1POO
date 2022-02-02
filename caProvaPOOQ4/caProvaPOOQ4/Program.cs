using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOOQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagtos[] pag = new Pagtos[6];
            Alimentacao a1 = new Alimentacao(99999999999, 10, 1, "Restaruante 1");
            Alimentacao a2 = new Alimentacao(88888888888, 20, 2, "Restaruante 2");
            Alimentacao a3 = new Alimentacao(77777777777, 30, 2, "Restaruante 3");

            Saude s1 = new Saude(66666666666, 10, 1, "Hospital 1");
            Saude s2 = new Saude(55555555555, 20, 2, "Hospital 2");
            Saude s3 = new Saude(44444444444, 30, 2, "Hospital 3");

            pag[0] = a1;
            pag[1] = a2;
            pag[2] = a3;
            pag[3] = s1;
            pag[4] = s2;
            pag[5] = s3;
            Console.WriteLine("Lista de Faturamentos: \n");
            for (int i = 0; i < 6; i++)
            {
                pag[i].faturar();
            }
        }
    }
}