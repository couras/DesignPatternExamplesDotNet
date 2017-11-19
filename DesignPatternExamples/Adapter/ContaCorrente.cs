using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternExamples.Adapter.Interfaces;
using System.Linq;

namespace DesignPatternExamples.Adapter
{
    public class ContaCorrente : IContaCorrente
    {
        public String nomeCorrentista;
        List<Lancamentos> lancamentos;

        //LanÃ§amento Ã© um nÃºmero sequencial para ordenar todos os lanÃ§amentos dessa conta corrente
        private int idLancamento;

        //Saldo Ã© uma propriedade criada para impedir que toda busca de saldo nÃ£o seja calculada
        private float saldoContaCorrente;

        public ContaCorrente(String nomeCorrentista)
        {
            this.nomeCorrentista = nomeCorrentista;
            this.idLancamento = 0;
            this.saldoContaCorrente = 0;
            this.lancamentos = new List<Lancamentos>();
        }

        public List<Lancamentos> buscaLancamentoPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public Lancamentos buscaLancamentoPorID(int idLancamento)
        {
            if (idLancamento > this.idLancamento)
                return null;

            return this.lancamentos.ElementAt(idLancamento);
        }

        public int getQuantidadeLancamentos()
        {
            return this.lancamentos.Count;
        }

        public float getSaldo()
        {
            return this.saldoContaCorrente;
        }

        public void insereLancamento(string descricao, float valor)
        {
            idLancamento++;
            this.saldoContaCorrente += valor;
            this.lancamentos.Add(new Lancamentos(idLancamento, descricao, valor));
        }
    }
}
