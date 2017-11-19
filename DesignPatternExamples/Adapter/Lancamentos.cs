using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class Lancamentos
    {
        //contemm o ID do lancamento, gerado pela Conta Corrente.
        private int id;
        private String sDescricao;
        private float fValor;
        private DateTime dDataOperacao;

        public Lancamentos(int id, string descricao, float valor)
        {
            this.Id = id;
            this.SDescricao = descricao;
            this.FValor = valor;
            this.DDataOperacao = new DateTime();
        }

        public int Id { get => id; set => id = value; }
        public string SDescricao { get => sDescricao; set => sDescricao = value; }
        public float FValor { get => fValor; set => fValor = value; }
        public DateTime DDataOperacao { get => dDataOperacao; set => dDataOperacao = value; }

        //Esse método tem por objetivo formatar a exibição do lançamento no caso de uma impressão
        public String imprimeLancamento()
        {
            return this.DDataOperacao.ToShortDateString() + " # " + this.SDescricao + "  ## " + this.FValor.ToString();
        }
    }
}
