using CodingChallenge.Data.Classes.FormasGeometricas;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.FormasGeometricasService
{
    public class FormaGeometricaService : IFormaGeometricaService<FormaGeometrica>
    {
        #region Propiedades Privadas
        private List<Triangulo> Triangulos { get; set; }
        private List<Cuadrado> Cuadrados { get; set; }
        private List<Circulo> Circulos { get; set; }
        #endregion

        #region Propiedades Publicas
        public InformacionCirculos InformacionCirculos { get; set; }
        public InformacionCuadrados InformacionCuadrados { get; set; }
        public InformacionTriangulos InformacionTriangulos { get; set; }
        public List<FormaGeometrica> FormasGeometricas { get; private set; }
        public List<InformacionFormaGeometrica> InformacionFormasGeometricas { get; private set; } = new List<InformacionFormaGeometrica>();

        public int TotalFiguras { get; private set; }
        public decimal TotalArea { get; private set; }
        public decimal TotalPerimetro { get; private set; }
        #endregion

        #region Constructor
        public FormaGeometricaService(List<FormaGeometrica> formasGeometricas)
        {
            FormasGeometricas = formasGeometricas;
            Triangulos = DevolverListaDeFormasGeometricas<Triangulo>();
            Cuadrados = DevolverListaDeFormasGeometricas<Cuadrado>();
            Circulos = DevolverListaDeFormasGeometricas<Circulo>();

            InformacionCirculos = new InformacionCirculos()
            {
                AreaTotal = Circulos.Sum(x => x.CalcularArea()),
                PerimetroTotal = Circulos.Sum(x => x.CalcularPerimetro()),
                CantidadTotal = Circulos.Count(),
                ListaDeCirculos = Circulos
            };

            InformacionCuadrados = new InformacionCuadrados()
            {
                AreaTotal = Cuadrados.Sum(x => x.CalcularArea()),
                PerimetroTotal = Cuadrados.Sum(x => x.CalcularPerimetro()),
                CantidadTotal = Cuadrados.Count(),
                ListaDeCuadrados = Cuadrados
            };

            InformacionTriangulos = new InformacionTriangulos()
            {
                AreaTotal = Triangulos.Sum(x => x.CalcularArea()),
                PerimetroTotal = Triangulos.Sum(x => x.CalcularPerimetro()),
                CantidadTotal = Triangulos.Count(),
                ListaDeTriangulos = Triangulos
            };

            InformacionFormasGeometricas.Add(InformacionCirculos);
            InformacionFormasGeometricas.Add(InformacionCuadrados);
            InformacionFormasGeometricas.Add(InformacionTriangulos);
            TotalFiguras = FormasGeometricas.Count();
            TotalArea = InformacionCirculos.AreaTotal + InformacionCuadrados.AreaTotal + InformacionTriangulos.AreaTotal;
            TotalPerimetro = InformacionCirculos.PerimetroTotal + InformacionCuadrados.PerimetroTotal + InformacionTriangulos.PerimetroTotal;
        }
        #endregion

        #region Metodos Publicos

        public List<FormaGeometrica> DevolverListaDeFormasGeometricas<FormaGeometrica>()
        {
            var elements = FormasGeometricas.OfType<FormaGeometrica>().ToList();
            return elements;
        }

        #endregion
    }
}
