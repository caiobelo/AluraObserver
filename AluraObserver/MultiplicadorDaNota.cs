using System;
using System.Collections.Generic;
using System.Text;

namespace AluraObserver
{
    public class MultiplicadorDaNota : IAcaoAposCriarNota
    {
        public double Fator { get; private set; }

        public MultiplicadorDaNota(double fator)
        {
            this.Fator = fator;
        }

        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine(nf.Total * this.Fator);
        }
    }
}
