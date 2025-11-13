using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traduccion
{
    public class TraductorCastellano : ITraductor
    {
        public string TraducirHeader()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string TraducirListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string TraducirForma(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case FormaGeometrica.Cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case FormaGeometrica.Circulo:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case FormaGeometrica.TrianguloEquilatero:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case FormaGeometrica.Trapecio:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                default:
                    return string.Empty;
            }
        }

        public string TraducirPerimetro()
        {
            return "Perimetro";
        }

        public string TraducirFormas()
        {
            return "formas";
        }
    }
}
