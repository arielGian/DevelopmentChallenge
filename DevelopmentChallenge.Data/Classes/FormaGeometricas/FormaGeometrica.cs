/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.Traduccion;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{

    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int Circulo = 2;
        public const int TrianguloEquilatero = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        private readonly IFormaGeometrica _forma;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _forma = CrearForma(tipo, ancho);
        }

        private IFormaGeometrica CrearForma(int tipo, decimal ancho)
        {
            switch (tipo)
            {
                case Cuadrado:
                    return new Cuadrado(ancho);
                case Circulo:
                    return new Circulo(ancho);
                case TrianguloEquilatero:
                    return new TrianguloEquilatero(ancho);
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), "Forma desconocida");
            }
        }

        public decimal CalcularArea()
        {
            return _forma.CalcularArea();
        }

        public decimal CalcularPerimetro()
        {
            return _forma.CalcularPerimetro();
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var traductor = ObtenerTraductor(idioma);
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(traductor.TraducirListaVacia());
            }
            else
            {
                sb.Append(traductor.TraducirHeader());

                var grupos = formas.GroupBy(f => f.Tipo)
                    .Select(g => new
                    {
                        Tipo = g.Key,
                        Cantidad = g.Count(),
                        Area = g.Sum(f => f.CalcularArea()),
                        Perimetro = g.Sum(f => f.CalcularPerimetro())
                    })
                    .OrderBy(g => g.Tipo)
                    .ToList();

                foreach (var grupo in grupos)
                {
                    sb.Append(ObtenerLinea(grupo.Cantidad, grupo.Area, grupo.Perimetro, grupo.Tipo, traductor));
                }

                var totalFormas = grupos.Sum(g => g.Cantidad);
                var totalPerimetro = grupos.Sum(g => g.Perimetro);
                var totalArea = grupos.Sum(g => g.Area);

                sb.Append("TOTAL:<br/>");
                sb.Append($"{totalFormas} {traductor.TraducirFormas()} ");
                sb.Append($"{traductor.TraducirPerimetro()} {totalPerimetro:#.##} ");
                sb.Append($"Area {totalArea:#.##}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, ITraductor traductor)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {traductor.TraducirForma(tipo, cantidad)} | Area {area:#.##} | {traductor.TraducirPerimetro()} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static ITraductor ObtenerTraductor(int idioma)
        {
            switch (idioma)
            {
                case Castellano:
                    return new TraductorCastellano();
                case Ingles:
                    return new TraductorIngles();
                case Italiano:
                    return new TraductorItaliano();
                default:
                    return new TraductorIngles();
            }
        }
    }
}