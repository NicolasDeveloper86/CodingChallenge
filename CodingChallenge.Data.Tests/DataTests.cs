using System.Collections.Generic;
using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.FormasGeometricasService;
using CodingChallenge.Data.Idiomas;
using CodingChallenge.Data.Localizador;
using CodingChallenge.Data.Reporteador;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        private ReporteadorService _service;
        private void Init(List<FormaGeometrica> formasGeometricas, Idioma idioma)
        {
            FormaGeometricaService formaGeometricaService = new FormaGeometricaService(formasGeometricas);
            LocalizacionService localizacionService = new LocalizacionService(idioma);
            _service = new ReporteadorService(formaGeometricaService, localizacionService);
        }

        [TestCase]
        public void Resumen_Lista_Vacia_En_Castellano()
        {
            //Arrange
            List<FormaGeometrica> formaGeometricas = new List<FormaGeometrica>();
            Init(formaGeometricas, Idioma.Castellano);

            //Act
            string resultado = _service.Imprimir();

            //Assert
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
        }

        [TestCase]
        public void Resumen_Lista_Vacia_Formas_En_Ingles()
        {
            //Arrange
            List<FormaGeometrica> formaGeometricas = new List<FormaGeometrica>();
            Init(formaGeometricas, Idioma.Ingles);

            //Act
            string resultado = _service.Imprimir();

            //Assert
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado);
        }

        [TestCase]
        public void Resumen_Lista_Con_Un_Cuadrado_En_Castellano()
        {
            //Arrange
            var cuadrados = new List<FormaGeometrica>()
            {
                new Cuadrado(5)
            };
            Init(cuadrados, Idioma.Castellano);

            //Act
            var resumen = _service.Imprimir();

            //Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void Resumen_Lista_Con_Mas_Cuadrados_En_Ingles()
        {
            //Arrange
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            Init(cuadrados, Idioma.Ingles);

            //Act
            var resumen = _service.Imprimir();

            //Assert
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void Resumen_Lista_Con_Mas_Tipos_En_Ingles()
        {
            //Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            Init(formas, Idioma.Ingles);

            //Act
            var resumen = _service.Imprimir();

            //Assert
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Circles | Area 52.03 | Perimeter 36.13 <br/>2 Squares | Area 29 | Perimeter 28 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 115.73 Area 130.67",
                resumen);
        }

        [TestCase]
        public void Resumen_Lista_Con_Mas_Tipos_En_Castellano()
        {
            //Arrange
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            Init(formas, Idioma.Castellano);

            //Act
            var resumen = _service.Imprimir();

            //Assert
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>2 Cuadrados | Area 29 | Perimetro 28 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 115,73 Area 130,67",
                resumen);
        }
    }
}
