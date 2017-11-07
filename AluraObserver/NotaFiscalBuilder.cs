using System;
using System.Collections.Generic;

namespace AluraObserver
{
    public class NotaFiscalBuilder
    {
        private string RazaoSocial;
        private double Total;
        private string Observacoes;
        private string CNPJ;
        private IList<ItemDaNota> Itens;
        private IList<IAcaoAposCriarNota> Acoes;
        private DateTime DataDeCriacao;
        
        public NotaFiscalBuilder(IList<IAcaoAposCriarNota> acoes)
        {
            Acoes = acoes;
            Itens = new List<ItemDaNota>();
        }
        
        public NotaFiscalBuilder NaDataAtual()
        {
            this.DataDeCriacao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComObservacao(string observacao)
        {
            this.Observacoes = observacao;
            return this;
        }

        public NotaFiscalBuilder ComCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota novoItem)
        {
            Total += novoItem.Valor;

            Itens.Add(novoItem);
            return this;
        }

        public NotaFiscalBuilder ExecutarAposCriacao(IAcaoAposCriarNota novaAcao)
        {
            Acoes.Add(novaAcao);
            return this;
        }

        public void Construir()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Observacoes, Total);

            foreach (var i in Itens)
            {
                nf.AdicionarItem(i);
            }

            foreach (var a in Acoes)
            {
                a.Executar(nf);
            }

            Console.WriteLine("NF criada com sucesso...");
        }
    }
}
