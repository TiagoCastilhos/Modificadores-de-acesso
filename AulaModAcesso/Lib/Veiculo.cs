using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaModAcesso.Lib {
    class Veiculo {

        //Private: Acessível apenas pela classe
        private string modelo;

        //Protected: Acessível pela classe e pelas classes herdadas
        protected string marca;
        protected DateTime AnoDeFabricacao;

        public void InfoVeiculo()
        {
            marca = "Fiat";
            Console.WriteLine(marca);

           
        }
    }
}
