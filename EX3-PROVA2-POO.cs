using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova2ex3

{
    class pilhapeça
    {

        string[] produto;
        string[] peçasseparadas;

        public pilhapeça(string[] produto)
        {
            this.produto = produto;
        }

        public void Trocar(string peçavelha, string peçanova)
        {
            while(produto.Length > 0) 
            {
                if (produto[0] == peçavelha)
                {
                    produto[0] = peçanova;
                    Console.WriteLine("trocando" + produto[0]);

                    for(int i = peçasseparadas.Length ; peçasseparadas.Length > 0; i--)
                    {




                        List<string> produtoslista = new List<string>(produto);
                        produtoslista.Insert(0, peçasseparadas[i-1]);
                        Console.WriteLine("voltando" + peçasseparadas[i-1]);

                        List<string> list = new List<string>(peçasseparadas);
                        list.RemoveAt(i-1);
                        peçasseparadas = list.ToArray();
                        produto = produtoslista.ToArray();
                    }

                }
                else
                {
                    Console.WriteLine("retirando" + produto[0]);
                    peçasseparadas.Append(produto[0]);
                    List<string> list = new List<string>(produto);
                    list.RemoveAt(0);
                    produto = list.ToArray();
                }
            }
        }
    }
}
