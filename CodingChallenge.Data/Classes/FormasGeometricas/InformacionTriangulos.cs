using CodingChallenge.Data.Localizador;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class InformacionTriangulos : InformacionFormaGeometrica
    {
        public List<Triangulo> ListaDeTriangulos { get; set; }

        public override string DevolverPluralSingular(LocalizacionService localizacion)
        {
            return CantidadTotal == 1 ? localizacion.TomarString("Header.Triangulo") : localizacion.TomarString("Header.Triangulos");
        }
    }
}
