using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaModAcesso.Lib {
    class Carro:Veiculo {

        //Internal: Acessível apenas por essa solução, não é possível reaproveitar o código
        internal byte QtdeRodas = 4;

        void InfoVeiculo()
        {
            marca = "Fiat";
            Console.WriteLine(marca);

            //Inacessível, pois é um objeto com modificador de acesso do tipo "Private"
            modelo = "Palio";
        }
    }
}
