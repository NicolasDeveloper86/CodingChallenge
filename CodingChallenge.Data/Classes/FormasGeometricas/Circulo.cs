using System;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        protected decimal Radio { get; set; }

        public Circulo(decimal radio)
        {
            Radio = radio;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * Radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * Radio * Radio;
        }
    }
}
