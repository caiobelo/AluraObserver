using System;
using System.Collections.Generic;
using System.Text;

namespace AluraObserver
{
    public class Email : IAcaoAposCriarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Enviando e-mail...");
        }
    }
}
