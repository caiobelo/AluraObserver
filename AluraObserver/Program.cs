using System;
using System.Collections.Generic;

namespace AluraObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IAcaoAposCriarNota> acoes = new List<IAcaoAposCriarNota>
            {
                new Email(),
                new MultiplicadorDaNota(5),
                new MultiplicadorDaNota(2.5),
                new MultiplicadorDaNota(10),
                new NotaFiscalDao()
            };

            NotaFiscalBuilder notaFiscal = new NotaFiscalBuilder(acoes);

            notaFiscal
                .ComCNPJ("20.656.325/0001-80")
                .ComItem(new ItemDaNota("mouse gamer", 100.0))
                .ComObservacao("obs de uma nota fiscal")
                .NaDataAtual()
                .Construir();

            Console.ReadKey();

        }
    }
}
