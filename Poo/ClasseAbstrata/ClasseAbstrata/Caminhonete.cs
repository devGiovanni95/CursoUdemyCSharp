using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    //para nao poder ser herdada-so serve para instanciar objetos
    sealed class Caminhonete : Carro
    {
        public bool CabineExtendida { get; set; }
    }
}
