using CodingChallenge.Data.Localizador;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class InformacionCuadrados : InformacionFormaGeometrica
    {
        public List<Cuadrado> ListaDeCuadrados { get; set; }

        public override string DevolverPluralSingular(LocalizacionService localizacion)
        {
            return CantidadTotal == 1 ? localizacion.TomarString("Header.Cuadrado") : localizacion.TomarString("Header.Cuadrados");
        }
    }
}
