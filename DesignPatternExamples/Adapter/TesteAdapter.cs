using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Adapter
{
    public class TesteAdapter
    {
        //Realiza a execuÃ§Ã£o do teste de adapter do tipo "Class Type"
        public void iniciarClassTypeTest()
        {

            /*A classe AdapterClassType recebe no construtor o nome do correntista. A classe ObjectTypeAdapter
            recebe o nome como um parÃ¢metro. Isso porque cada uma das abordagens tem formas diferentes de instanciaÃ§Ã£o.
            (verifique a implementaÃ§Ã£o das classes)
             */
            AdapterClassType cc1 = new AdapterClassType("JoÃ£o Carlos");

            //Lista de lanÃ§amentos usados no teste
            cc1.insereLancamento("DepÃ³sito", 2000.0f);
            cc1.insereLancamento("Saque", -110.0f);
            cc1.insereLancamento("Conta de luz", -36.43f);
            cc1.insereLancamento("Conta de Ã¡gua", -25.50f);
            cc1.insereLancamento("Mensalidade Internet", -226.41f);
            cc1.insereLancamento("Pagamento cartÃ£o dÃ©bito - casas bahia", -125.40f);
            cc1.insereLancamento("Pagamento cartÃ£o dÃ©bito - lanchonete", -16.10f);
            cc1.insereLancamento("Pagamento cartÃ£o dÃ©bito - lanchonete", -8.00f);
            cc1.insereLancamento("Emprestimo", -1200.00f);
            cc1.insereLancamento("Saque", -150.00f);
            cc1.insereLancamento("CartÃ£o de crÃ©dito", -459.00f);
            cc1.insereLancamento("DepÃ³sito", 600.00f);
            cc1.insereLancamento("PrestaÃ§Ã£o do Carro", -350.47f);
            cc1.insereLancamento("Pagamento cartÃ£o dÃ©bito - mensalidade", -250.10f);
            cc1.insereLancamento("DepÃ³sito", 800.00f);

            //ExecuÃ§Ã£o do teste de impressÃ£o do extrato com Ãºltimos 12 lanÃ§amentos
            
            Console.WriteLine(cc1.ultimos12Lancamentos());

            //ExecuÃ§Ã£o do teste de histÃ³rico de saldos
            float[] fHistoricoSaldo = cc1.historicoSaldo();
            for (int i = 0; i < fHistoricoSaldo.Length; i++)
            {
                Console.WriteLine("Saldo: " + fHistoricoSaldo[i].ToString());
            }

            Console.WriteLine("Saldo atual: " + cc1.getSaldo());
        }

        //Realiza a execuÃ§Ã£o do teste de adapter do tipo "Object Type"
        public void iniciarObjectTypeTest()
        {
            /*A classe ObjectTypeAdapter recebe o nome como um parÃ¢metro.
            A classe AdapterClassType recebe no construtor o nome do correntista.
            Isso porque cada uma das abordagens tem formas diferentes de instanciaÃ§Ã£o.
            (verifique a implementaÃ§Ã£o das classes)
             */
            AdapterObjectType cc1 = new AdapterObjectType();

            //Lista de lanÃ§amentos usados no teste
            cc1.criarContaCorrente("JoÃ£o Carlos");
            cc1.objContaCorrente.insereLancamento("DepÃ³sito", 2000.0f);
            cc1.objContaCorrente.insereLancamento("Saque", -110.0f);
            cc1.objContaCorrente.insereLancamento("Conta de luz", -36.43f);
            cc1.objContaCorrente.insereLancamento("Conta de Ã¡gua", -25.50f);
            cc1.objContaCorrente.insereLancamento("Mensalidade Internet", -226.41f);
            cc1.objContaCorrente.insereLancamento("Pagamento cartÃ£o dÃ©bito - casas bahia", -125.40f);
            cc1.objContaCorrente.insereLancamento("Pagamento cartÃ£o dÃ©bito - lanchonete", -16.10f);
            cc1.objContaCorrente.insereLancamento("Pagamento cartÃ£o dÃ©bito - lanchonete", -8.00f);
            cc1.objContaCorrente.insereLancamento("Emprestimo", -1200.00f);
            cc1.objContaCorrente.insereLancamento("Saque", -150.00f);
            cc1.objContaCorrente.insereLancamento("CartÃ£o de crÃ©dito", -459.00f);
            cc1.objContaCorrente.insereLancamento("DepÃ³sito", 600.00f);
            cc1.objContaCorrente.insereLancamento("PrestaÃ§Ã£o do Carro", -350.47f);
            cc1.objContaCorrente.insereLancamento("Pagamento cartÃ£o dÃ©bito - mensalidade", -250.10f);
            cc1.objContaCorrente.insereLancamento("DepÃ³sito", 800.00f);

            //ExecuÃ§Ã£o do teste de impressÃ£o do extrato com Ãºltimos 12 lanÃ§amentos
            Console.WriteLine(cc1.ultimos12Lancamentos()); 

            //ExecuÃ§Ã£o do teste de histÃ³rico de saldos
            float[] fHistoricoSaldo = cc1.historicoSaldo();
            for (int i = 0; i < fHistoricoSaldo.Length; i++)
            {
                Console.WriteLine("Saldo: " + fHistoricoSaldo[i].ToString());
            }

            Console.WriteLine("Saldo atual: " + cc1.objContaCorrente.getSaldo());

        }
    }
}
