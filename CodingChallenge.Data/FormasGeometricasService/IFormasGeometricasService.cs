using CodingChallenge.Data.Classes.FormasGeometricas;
using System.Collections.Generic;

namespace CodingChallenge.Data.FormasGeometricasService
{
    public interface IFormaGeometricaService<T> where T : FormaGeometrica
    {
        List<T> DevolverListaDeFormasGeometricas<T>();
    };
}
