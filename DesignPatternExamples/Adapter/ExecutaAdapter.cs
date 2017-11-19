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
            Console.WriteLine("--------Iniciando teste com adapter do tipo classe-------");
            testeAdapter.iniciarClassTypeTest();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("--------Iniciando teste com adapter do tipo objeto-------");
            testeAdapter.iniciarObjectTypeTest();
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
