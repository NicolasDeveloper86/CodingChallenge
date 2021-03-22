using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : Triangulo
    {
        public TrianguloEquilatero(decimal lado)
        {
            LadoA = lado;
            LadoB = lado;
            LadoC = lado;
        }

        public override decimal CalcularPerimetro()
        {
            return LadoA * 3;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.Sqrt(3) * (LadoA * LadoA) / 4;
        }
    }
}
