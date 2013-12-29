using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbMegaSEna
{
    class Sorteio
    {
        public Numeros _Numeros { get; set; }
        public int NumSorteio { get; set; }
        public DateTime DataSorteio { get; set; }
        public List<Numeros> ListNumeros { get; set; }
        public Sorteio()
        {
            _Numeros = new Numeros();
            ListNumeros = new List<Numeros>();
        }
    }
    class Numeros
    {
        public int Num { get; set; }
    }

    class Frequencia
    {
        public int Numero { get; set; }
        public int Quantidade { get; set; }
    }
}
