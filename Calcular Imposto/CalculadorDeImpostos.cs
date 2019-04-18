using System;

namespace Design_Patterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double iss = imposto.Calcula(orcamento);
            Console.WriteLine(iss);
        }
    }
}