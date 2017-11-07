using System;
using System.Collections.Generic;
using System.Text;

namespace AluraObserver
{
    public class NotaFiscalDao : IAcaoAposCriarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Salvando NF no banco de dados...");
        }
    }
}
