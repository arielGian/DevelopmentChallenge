using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TraductorIngles : ITraductor
    {
        public string TraducirHeader()
        {
            return "<h1>Shapes report</h1>";
        }

        public string TraducirListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string TraducirForma(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case FormaGeometrica.Cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case FormaGeometrica.Circulo:
                    return cantidad == 1 ? "Circle" : "Circles";
                case FormaGeometrica.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case FormaGeometrica.Trapecio:
                    return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                default:
                    return string.Empty;
            }
        }

        public string TraducirPerimetro()
        {
            return "Perimeter";
        }

        public string TraducirFormas()
        {
            return "shapes";
        }
    }
}
