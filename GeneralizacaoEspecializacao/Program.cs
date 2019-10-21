using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralizacaoEspecializacao.Carro;
using GeneralizacaoEspecializacao.Moto;

namespace GeneralizacaoEspecializacao
{

    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] cadastro = new Veiculo [8];

            cadastro[0] = new Picape(2, 150.1, "FGS-1231", "13146", 250.0, "Total");
            cadastro[1] = new Picape(4, 45.1, "QOS-1231", "13896", 450.0, "Parcial");
            cadastro[2] = new Sedan(4,65.6,"QGU-0236","346631", 450.0, "Total");
            cadastro[3] = new Sedan(4, 65.6, "QOU-2039", "346851", 500.0, "Total");
            cadastro[4] = new Motocross("Maynard", "Terra", "VAD-3564", "4642356");
            cadastro[5] = new Motocross("Keystone", "Terra", "QAD-3564", "4698756");
            cadastro[6] = new Scooter("Maynard", "Alumínio", "QAD-3564", "4698756");
            cadastro[7] = new Scooter("Keystone", "Plástico", "QAD-3564", "4698756");

            for(int i=0;i<cadastro.Length;i++)            
                cadastro[i].ImpressaoDados();

            Console.ReadKey();
        }
    }
}
