using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class ExecutaAdapter
    {
        public static void go()
        {
            TesteAdapter testeAdapter = new TesteAdapter();
            System.out.println("--------Iniciando teste com adapter do tipo classe-------");
            testeAdapter.iniciarClassTypeTest();
            System.out.println("---------------------------------------------------------");
            System.out.println("--------Iniciando teste com adapter do tipo objeto-------");
            testeAdapter.iniciarObjectTypeTest();
            System.out.println("---------------------------------------------------------");
        }
    }
}
