using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Orcamento orcamento = new Orcamento(500.0);

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms); 
        }
    }
}
