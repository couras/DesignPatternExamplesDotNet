using DesignPatternExamples.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class AdapterClassType : ContaCorrente, INovaContaCorrente
    {
        public AdapterClassType(string nomeCorrentista) : base(nomeCorrentista)
        {

        }

        public float[] historicoSaldo()
        {
            List<float> list = new List<float>();

            float saldo = 0;

            foreach (Lancamentos item in lancamentos)
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

            int numLancamentos = getQuantidadeLancamentos();
            int numLimite = 12;

            if (numLancamentos <= 12)
                numLimite = numLancamentos;

            for (int i = (numLancamentos - numLimite); i < numLancamentos; i++)
            {
                retorno += buscaLancamentoPorID(i).imprimeLancamento() + "\n";
            }

            return retorno;
        }
    }
}
