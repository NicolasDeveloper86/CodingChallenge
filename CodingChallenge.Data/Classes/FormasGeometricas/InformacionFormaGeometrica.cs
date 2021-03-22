using CodingChallenge.Data.Localizador;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class InformacionFormaGeometrica
    {
        public decimal PerimetroTotal { get; set; }
        public decimal AreaTotal { get; set; }
        public int CantidadTotal { get; set; }

        public abstract string DevolverPluralSingular(LocalizacionService localizacion);
    }
}
