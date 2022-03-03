using ObjectBuilder.Classes;
using System;
using System.Collections.Generic;

namespace ObjectBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> TodosItens = new List<Item>();

            //Declaração normal
            NotaFiscal nfe = new NotaFiscal("Relampago Marquinhos Enterprises", "23.456.789/0001-12", DateTime.Now, 50000, 12000, TodosItens, "Nota final");

            //Declaração com o Builder inicial
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.ParaEmpresa("Relampago Marquinhos Enterprises");
            builder.ComCnpj("23.456.789/0001-12");
            builder.ComItem(new Item("item 1", 200));
            builder.ComItem(new Item("item 2", 2560));
            builder.NaDataAtual();
            builder.ComObservacoes("Nota fiscal mais rapida do mundo.");
            builder.Constroi();



            Console.ReadKey();
        }
    }
}
