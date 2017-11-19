using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class Lancamentos
    {
        //contemm o ID do lancamento, gerado pela Conta Corrente.
        int id;
        String sDescricao;
        float fValor;
        DateTime dDataOperacao;

        public Lancamentos(int id, string descricao, float valor)
        {
            this.id = id;
            this.sDescricao = descricao;
            this.fValor = valor;
            this.dDataOperacao = new DateTime();
        }

        //Esse método tem por objetivo formatar a exibição do lançamento no caso de uma impressão
        public String imprimeLancamento()
        {
            return this.dDataOperacao.ToShortDateString() + " # " + this.sDescricao + "  ## " + this.fValor.ToString();
        }
    }
}
