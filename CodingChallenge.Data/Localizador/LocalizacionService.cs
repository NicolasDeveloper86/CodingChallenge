using CodingChallenge.Data.Idiomas;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace CodingChallenge.Data.Localizador
{
    public class LocalizacionService : ILocalizacionService
    {
        private ResourceManager resourceManager;

        public LocalizacionService(Idioma idioma)
        {
            CambiarIdioma(idioma);
        }

        private void CambiarIdioma(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    CultureInfo.CurrentCulture = new CultureInfo("ES-es");
                    resourceManager = new ResourceManager("CodingChallenge.Data.Resources.strings", Assembly.GetAssembly(typeof(LocalizacionService)));
                    break;
                case Idioma.Ingles:
                    CultureInfo.CurrentCulture = new CultureInfo("EN-us");
                    resourceManager = new ResourceManager("CodingChallenge.Data.Resources.strings", Assembly.GetAssembly(typeof(LocalizacionService)));
                    break;
                case Idioma.Frances:
                    CultureInfo.CurrentCulture = new CultureInfo("fr");
                    resourceManager = new ResourceManager("CodingChallenge.Data.Resources.strings", Assembly.GetAssembly(typeof(LocalizacionService)));
                    break;
                default:
                    CultureInfo.CurrentCulture = new CultureInfo("ES-es");
                    resourceManager = new ResourceManager("CodingChallenge.Data.Resources.strings", Assembly.GetAssembly(typeof(LocalizacionService)));
                    break;
            }
        }

        public string TomarString(string valor)
        {
            return resourceManager.GetString(valor, CultureInfo.CurrentCulture);
        }
    }
}
