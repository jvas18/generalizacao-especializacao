using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizacaoEspecializacao.Moto
{
    public class Scooter : Moto
    {
        protected string tipoAssoalho;

        public Scooter(string guidon, string tipoAssoalho, string placa, string renavam)
        {
            this.placa = placa;
            this.guidon = guidon;
            this.tipoAssoalho = tipoAssoalho;
            this.renavam = renavam;
        }
       override public void ImpressaoDados()
        {
            Console.WriteLine("SCOOTER\n");
            Console.WriteLine("Renavam: " + renavam);
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Tipo Guidon: " + guidon);
            Console.WriteLine("Tipo de Assoalho: " + tipoAssoalho);
            Console.WriteLine("\n");
        }
    }
}
