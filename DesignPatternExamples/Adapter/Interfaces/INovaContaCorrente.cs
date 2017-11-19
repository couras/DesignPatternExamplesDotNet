using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter.Interfaces
{
    public interface INovaContaCorrente
    {
        String ultimos12Lancamentos();
        float[] historicoSaldo();
    }
}
