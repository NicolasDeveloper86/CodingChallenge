using CodingChallenge.Data.Idiomas;
using CodingChallenge.Data.Localizador;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class LocalizacionServiceTests
    {
        [TestMethod]
        public void Localizacion_Deberia_Devolver_String_Ingles()
        {
            //Arrange
            LocalizacionService _service = new LocalizacionService(Idioma.Ingles);

            //Act
            string noHayFormasIngles = _service.TomarString("ListaVacia");

            //Assert
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", noHayFormasIngles);
        }

        [TestMethod]
        public void Localizacion_Deberia_Devolver_String_Castellano()
        {
            //Arrange
            LocalizacionService _service = new LocalizacionService(Idioma.Castellano);

            //Act
            string noHayFormasIngles = _service.TomarString("ListaVacia");

            //Assert
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", noHayFormasIngles);
        }

        [TestMethod]
        public void Localizacion_Deberia_Devolver_Valor_Numerico_En_Separador_Coma_Decimal_Castellano()
        {
            //Arrange Act
            LocalizacionService _service = new LocalizacionService(Idioma.Castellano);
            decimal numeroDecimal = 5.5m;

            //Assert
            Assert.AreEqual("5,5", numeroDecimal.ToString("#.#"));
        }

        [TestMethod]
        public void Localizacion_Deberia_Devolver_Valor_Numerico_En_Separador_Punto_Decimal_Ingles()
        {
            //Arrange Act
            LocalizacionService _service = new LocalizacionService(Idioma.Ingles);
            decimal numeroDecimal = 5.5m;

            //Assert
            Assert.AreEqual("5.5", numeroDecimal.ToString("#.#"));
        }
    }
}
