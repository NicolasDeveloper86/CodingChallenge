namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio(decimal ladoA, decimal ladoB, decimal ladoC, decimal ladoD, decimal altura) 
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            LadoD = ladoD;
            Altura = altura;
        }

        public override decimal CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC + LadoD;
        }

        public override decimal CalcularArea()
        {
            return ((LadoA + LadoB) / 2) * Altura;
        }
    }
}
