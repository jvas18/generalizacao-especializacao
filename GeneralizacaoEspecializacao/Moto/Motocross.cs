using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizacaoEspecializacao.Moto
{
    public class Motocross : Moto
    {
        protected string tipoPneu;
        public Motocross(string guidon, string tipoPneu, string placa, string renavam)
        {
            this.placa = placa;
            this.guidon = guidon;
            this.tipoPneu = tipoPneu;
            this.renavam = renavam;
        }
       override public void ImpressaoDados()
        {
            Console.WriteLine("MOTOCROSS\n");
            Console.WriteLine("Renavam: " + renavam);
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Tipo Guidon: " + guidon);
            Console.WriteLine("Tipo de Pneu: " + tipoPneu);
            Console.WriteLine("\n");
        }

    }
}
