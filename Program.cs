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

            /*Declaração utilizando o NotaFiscalBuilder, onde os parametros são instanciados em partes. 
             *Objeto NotaFiscal é criado em Constroi() e retorna o obj criado.*/
            NotaFiscalBuilder builder = new NotaFiscalBuilder()
            .ParaEmpresa("Relampago Marquinhos Enterprises")
            .ComCnpj("23.456.789/0001-12")
            .ComItem(new Item("item 1", 200))
            .ComItem(new Item("item 2", 2560))
            .NaDataAtual()
            .ComObservacoes("Nota fiscal mais rapida do mundo.");

            NotaFiscal nf = builder.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
    
            Console.ReadKey();
        }
    }
}
