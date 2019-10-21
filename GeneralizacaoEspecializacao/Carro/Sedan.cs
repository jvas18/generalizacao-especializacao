using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizacaoEspecializacao.Carro
{
    class Sedan : Carro
    {
        protected double portaMala;

        public Sedan(int portas, double portaMala, string placa, string renavam, double valor, string categoria)
        {
            this.placa = placa;
            this.portas = portas;
            this.portaMala =portaMala;
            this.renavam = renavam;
            this.valor = valor;
            this.categoria = categoria;
        }
        override public void ImpressaoDados()
        {
            Console.WriteLine("SEDAN\n");
            Console.WriteLine("Renavam: " + renavam);
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Qtde. de Portas: " + portas);
            Console.WriteLine("Tamanho do Porta-Mala: " + portaMala);
            Console.WriteLine("DADOS DO SEGURO:");
            Console.WriteLine("Valor: R$" + valor);
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("\n");
        }

    }
}
