using System;
using System.Collections.Generic;

namespace ObjectBuilder.Classes
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime Data { get; set; }
        public string Observacoes { get; set; }
        private double valorTotal = 0;
        private double impostos = 0;
        private List<Item> todoItens = new List<Item>();

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todoItens, Observacoes);
        }

        public void ParaEmpresa(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
        }

        public void ComCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
        }

        public void ComItem(Item item)
        {
            todoItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor + 0.05;
        }

        public void ComObservacoes(string Observacoes)
        {
            this.Observacoes = Observacoes;
        }

        public void NaDataAtual()
        {
            this.Data = DateTime.Now;
        }
    }
}
