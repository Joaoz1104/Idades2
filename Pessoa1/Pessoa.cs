using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa1
{
    class Pessoa
    {
        public string Nome1 { get; set; }
        public byte Idade1 { get; set; }
        public string Nome2 { get; set; }
        public byte Idade2 { get; set; }

        public string Maior()
        {
           if (Idade1 > Idade2)
           {
               return Nome1;
           }
           else
           {
               return Nome2;
           }
        }

        public override string ToString()
        {
            return $"Pessoa mais velha: {Maior()}";
        }
    }
}
