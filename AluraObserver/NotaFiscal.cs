using System.Collections.Generic;

namespace AluraObserver
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Observacao { get; private set; }
        public string CNPJ { get; private set; }

        public IList<ItemDaNota> Itens { get; private set; }
        public double Total { get; private set; }

        public NotaFiscal(string razaoSocial, string observacao, double total)
        {
            this.RazaoSocial = razaoSocial;
            this.Observacao = observacao;
            this.Total = total;
            Itens = new List<ItemDaNota>();
        }

        public void AdicionarItem(ItemDaNota novoItem)
        {
            this.Itens.Add(novoItem);
        }
    }
}
