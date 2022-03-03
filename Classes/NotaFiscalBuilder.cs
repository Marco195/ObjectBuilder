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

        /// <summary>
        /// Monta o objeto de <see cref="NotaFiscal"/>
        /// </summary>
        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todoItens, Observacoes);
        }

        public NotaFiscalBuilder ParaEmpresa(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(Item item)
        {
            todoItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor + 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string Observacoes)
        {
            this.Observacoes = Observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }
    }
}
