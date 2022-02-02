using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOOQ4
{
    internal class Pagtos
    {
        //atributos
        protected long cpf;
        protected double valor;
        protected int cod;

        //metodos

        public Pagtos()
        {

        }

        public Pagtos(long _cpf, double _valor, int _cod)
        {
            cpf = _cpf;
            valor = _valor;
            cod = _cod;
        }
        
        public virtual void faturar()
        {
            Console.WriteLine("R$" + valor);
        }

        public long getCpf()
        {
            return cpf;
        }
        
        public int getCod()
        {
            return cod;
        }

        public double getValor()
        {
            return valor;
        }

        public void setCpf(long _cpf)
        {
            cpf = _cpf;
        }

        public void setValor(long _valor)
        {
            valor = _valor;
        }

        public void setCod(int _cod)
        {
            cod = _cod;
        }
    }
}
