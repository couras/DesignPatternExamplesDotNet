using DesignPatternExamples.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class AdapterObjectType : INovaContaCorrente
    {
        //InstanciaÃ§Ã£o da classe adaptada para ser usada na adaptaÃ§Ã£o
        public ContaCorrente objContaCorrente;

        public void criarContaCorrente(String nomeCorrentista)
        {
            objContaCorrente = new ContaCorrente(nomeCorrentista);
        }

        public float[] historicoSaldo()
        {
            List<float> list = new List<float>();

            float saldo = 0;

            foreach (Lancamentos item in objContaCorrente.lancamentos)
            {
                saldo += item.FValor;
                list.Add(saldo);
            }

            float[] retorno = new float[list.Count];
            for (int i = 0; i < retorno.Length; i++)
            {
                retorno[i] = list.ElementAt(i);
            }

            return retorno;
        }

        public string ultimos12Lancamentos()
        {
            String retorno = "";

            int numLancamentos = objContaCorrente.getQuantidadeLancamentos();
            int numLimite = 12;

            if (numLancamentos <= 12)
                numLimite = numLancamentos;

            for (int i = (numLancamentos - numLimite); i < numLancamentos; i++)
            {
                retorno += objContaCorrente.buscaLancamentoPorID(i).imprimeLancamento() + "\n";
            }

            return retorno;
        }
    }
}
