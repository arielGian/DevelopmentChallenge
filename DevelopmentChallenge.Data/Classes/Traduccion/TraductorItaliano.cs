using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Traduccion
{
    public class TraductorItaliano : ITraductor
    {
        public string TraducirHeader()
        {
            return "<h1>Rapporto delle forme</h1>";
        }

        public string TraducirListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }

        public string TraducirForma(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case FormaGeometrica.Cuadrado:
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
                case FormaGeometrica.Circulo:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case FormaGeometrica.TrianguloEquilatero:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case FormaGeometrica.Trapecio:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
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
            return "forme";
        }
    }
}
