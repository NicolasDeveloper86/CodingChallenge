namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(decimal lado)
        {
            LadoA = lado;
        }

        public override decimal CalcularPerimetro()
        {
            return LadoA * 4;
        }

        public override decimal CalcularArea()
        {
            return LadoA * LadoA;
        }
    }
}
