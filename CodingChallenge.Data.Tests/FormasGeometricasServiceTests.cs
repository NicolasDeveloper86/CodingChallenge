using CodingChallenge.Data.Classes.FormasGeometricas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodingChallenge.Data.FormasGeometricasService;
using System;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class FormasGeometricasServiceTests
    {
        [TestMethod]
        public void Deberia_Retornar_5_Cuadrados()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Circulo(3),
                new TrianguloEquilatero(2),
                new Cuadrado(10),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.DevolverListaDeFormasGeometricas<Cuadrado>();

            //Assert
            Assert.AreEqual(5, resultado.Count);
        }

        [TestMethod]
        public void Deberia_Retornar_2_Circulos()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Circulo(3),
                new TrianguloEquilatero(2),
                new Cuadrado(10),
                new Cuadrado(1),
                new Cuadrado(3),
                new Circulo(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.DevolverListaDeFormasGeometricas<Circulo>();

            //Assert
            Assert.AreEqual(2, resultado.Count);
        }

        [TestMethod]
        public void Deberia_Retornar_1_Triangulo()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Circulo(3),
                new TrianguloEquilatero(2),
                new Cuadrado(10),
                new Cuadrado(1),
                new Cuadrado(3),
                new Circulo(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.DevolverListaDeFormasGeometricas<Triangulo>();

            //Assert
            Assert.AreEqual(1, resultado.Count);
        }

        [TestMethod]
        public void Deberia_Retornar_50_Area_Cuadrados()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionCuadrados.AreaTotal;

            //Assert
            Assert.AreEqual(50, resultado);
        }

        [TestMethod]
        public void Deberia_Retornar_Area_Circulos()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Circulo(5),
                new Cuadrado(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionCirculos.AreaTotal;

            //Assert
            Assert.AreEqual((decimal)78.54, Math.Round(resultado, 2));
        }

        [TestMethod]
        public void Deberia_Retornar_Area_Triangulos()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Circulo(5),
                new TrianguloEquilatero(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionTriangulos.AreaTotal;

            //Assert
            Assert.AreEqual((decimal)10.83, Math.Round(resultado,2));
        }

        [TestMethod]
        public void Deberia_Retornar_Perimetro_Cuadrados()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Cuadrado(5),
                new Cuadrado(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionCuadrados.PerimetroTotal;

            //Assert
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void Deberia_Retornar_Perimetro_Circulos()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Circulo(2),
                new Cuadrado(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionCirculos.PerimetroTotal;

            //Assert
            Assert.AreEqual((decimal)12.57, Math.Round(resultado, 2));
        }

        [TestMethod]
        public void Deberia_Retornar_Perimetro_Triangulo()
        {
            //Arrange
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>()
            {
                new Circulo(2),
                new Cuadrado(5),
                new TrianguloEquilatero(5)
            };

            FormaGeometricaService _service = new FormaGeometricaService(formasGeometricas);

            //Act
            var resultado = _service.InformacionTriangulos.PerimetroTotal;

            //Assert
            Assert.AreEqual(15, resultado);
        }
    }
}
