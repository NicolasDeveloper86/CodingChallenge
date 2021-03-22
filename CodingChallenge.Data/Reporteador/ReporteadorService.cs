using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.FormasGeometricasService;
using CodingChallenge.Data.Localizador;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Reporteador
{
    public class ReporteadorService : IReporteadorService
    {
        private readonly FormaGeometricaService _formasGeometricasService;
        private readonly LocalizacionService _localizacionService;
        private StringBuilder ContenidoReporte = new StringBuilder();
        public ReporteadorService(FormaGeometricaService formasGeometricasService,
            LocalizacionService localizacionService)
        {
            _formasGeometricasService = formasGeometricasService;
            _localizacionService = localizacionService;
        }

        public string Imprimir()
        {
            if (_formasGeometricasService.TotalFiguras == 0)
            {
                ContenidoReporte.Append(_localizacionService.TomarString("ListaVacia"));
            }
            else
            {
                CrearHeader();

                CrearFooter();
            }

            return ContenidoReporte.ToString();
        }

        private string ObtenerLinea(InformacionFormaGeometrica informacionFormaGeometrica)
        {
                return string.Format(_localizacionService.TomarString("Header.ResumenFormaGeometrica"),
                    informacionFormaGeometrica.CantidadTotal,
                    informacionFormaGeometrica.DevolverPluralSingular(_localizacionService),
                    _localizacionService.TomarString("Header.Area"),
                    informacionFormaGeometrica.AreaTotal.ToString("#.##"),
                    _localizacionService.TomarString("Header.Perimetro"),
                    informacionFormaGeometrica.PerimetroTotal.ToString("#.##"),
                    _localizacionService.TomarString("SaltoLinea"));
        }

        private void CrearFooter()
        {
            ContenidoReporte.Append(_localizacionService.TomarString("Footer.Total") + _localizacionService.TomarString("SaltoLinea"));
            ContenidoReporte.Append(_formasGeometricasService.TotalFiguras + " " + _localizacionService.TomarString("Footer.Formas") + " ");
            ContenidoReporte.Append(_localizacionService.TomarString("Header.Perimetro") + " " + (_formasGeometricasService.TotalPerimetro).ToString("#.##") + " ");
            ContenidoReporte.Append(_localizacionService.TomarString("Header.Area") + " " + (_formasGeometricasService.TotalArea).ToString("#.##"));
        }

        private void CrearHeader()
        {
            ContenidoReporte.Append(_localizacionService.TomarString("Header.ReporteFormas"));

            foreach (var infoFormaGeometrica in _formasGeometricasService.InformacionFormasGeometricas.OrderBy(x => x.CantidadTotal))
            {
                if (infoFormaGeometrica.CantidadTotal > 0)
                    ContenidoReporte.Append(ObtenerLinea(infoFormaGeometrica));
            }
        }
    }
}
