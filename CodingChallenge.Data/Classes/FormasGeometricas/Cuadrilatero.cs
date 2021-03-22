namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class Cuadrilatero : FormaGeometrica
    {
        protected decimal LadoA { get; set; }
        protected decimal LadoB { get; set; }
        protected decimal LadoC { get; set; }
        protected decimal LadoD { get; set; }
        protected decimal Altura { get; set; }
    }
}
