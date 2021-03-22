using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class Triangulo : FormaGeometrica
    {
        protected decimal LadoA { get; set; }
        protected decimal LadoB { get; set; }
        protected decimal LadoC { get; set; }
    }
}
