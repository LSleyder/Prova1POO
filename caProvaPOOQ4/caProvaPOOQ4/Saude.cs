using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOOQ4
{
    internal class Saude : Pagtos
    {
        //atributos
        private String estabelecimento;
        private double vlfaSaude;

        //metodos
        public Saude() : base()
        {

        }

        public Saude(long _cpf, double _valor, int _cod,
            String _estabelecimento) : base(_cpf, _valor, _cod)
        {
            estabelecimento = _estabelecimento;
        }

        public override void faturar()
        {
            vlfaSaude = valor * 0.12;
            valor += vlfaSaude;
            base.faturar();
        }

        public string getEstabelecimento()
        {
            return estabelecimento;
        }

        public double getVlfaSaude()
        {
            return vlfaSaude;
        }

        public void setEstabelecimento(String _estabelecimento)
        {
            estabelecimento= _estabelecimento;  
        }

        public void setVlfaSaude(double _vlfaSaude)
        {
            vlfaSaude = _vlfaSaude;
        }

    }
}
