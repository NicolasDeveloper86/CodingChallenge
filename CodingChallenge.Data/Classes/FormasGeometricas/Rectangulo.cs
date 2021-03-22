namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo(decimal lado, decimal altura)
        {
            LadoA = lado;
            LadoB = altura;
        }

        public override decimal CalcularPerimetro()
        {
            return (2 * LadoA) + (2 * LadoB);
        }

        public override decimal CalcularArea()
        {
            return LadoA * LadoB;
            
        }
    }
}
