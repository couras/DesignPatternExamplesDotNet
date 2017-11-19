using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter.Interfaces
{
    public interface IContaCorrente
    {
        float getSaldo();
        int getQuantidadeLancamentos();
        void insereLancamento(String descricao, float valor);
        Lancamentos buscaLancamentoPorID(int idLancamento);
        List<Lancamentos> buscaLancamentoPorData(DateTime data);
    }
}
