using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaPOOQ4
{
    internal class Alimentacao : Pagtos
    {
        //atributos
        private String descricao;
        private double vlfaAliment;

        //metodos
        public Alimentacao() : base()
        {

        }

        public Alimentacao(long _cpf, double _valor, int _cod,
            String _descricao) : base(_cpf, _valor, _cod)
        {
            descricao = _descricao;
        }

        public override void faturar()
        {
            vlfaAliment = valor*0.05;
            valor += vlfaAliment;
            base.faturar();
        }

        public string getDescricao()
        {
            return descricao;
        }

        public double getVlfaAliment()
        {
            return vlfaAliment;
        }

        public void setDescricao(String _descricao)
        {
            descricao = _descricao;
        }

        public void setVlfaAliment(double _vlfaAliment)
        {
            vlfaAliment = _vlfaAliment;
        }

    }
}
