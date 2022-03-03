using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectBuilder.Classes
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime Data { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public List<Item> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime data, double valorBruto, double impostos, List<Item> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Data = data;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }
    }
}
