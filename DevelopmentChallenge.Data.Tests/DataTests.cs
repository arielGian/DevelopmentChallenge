using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        #region Tests Originales

        [Test]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 1));
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 2));
        }

        [Test]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [Test]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };
            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [Test]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [Test]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        #endregion

        #region Tests para Italiano

        [Test]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Italiano));
        }

        [Test]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Italiano);
            Assert.AreEqual("<h1>Rapporto delle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forme Perimetro 20 Area 25", resumen);
        }

        [Test]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);
            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [Test]
        public void TestResumenConVariosCirculosEnItaliano()
        {
            var circulos = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Circulo, 2),
                new FormaGeometrica(FormaGeometrica.Circulo, 4)
            };
            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Italiano);
            Assert.AreEqual("<h1>Rapporto delle forme</h1>2 Cerchi | Area 9,42 | Perimetro 18,85 <br/>TOTAL:<br/>2 forme Perimetro 18,85 Area 9,42", resumen);
        }

        #endregion

        #region Tests de Cálculos Individuales

        [Test]
        public void TestCalculoAreaCuadrado()
        {
            var cuadrado = new FormaGeometrica(FormaGeometrica.Cuadrado, 4);
            Assert.AreEqual(16, cuadrado.CalcularArea());
        }

        [Test]
        public void TestCalculoPerimetroCuadrado()
        {
            var cuadrado = new FormaGeometrica(FormaGeometrica.Cuadrado, 4);
            Assert.AreEqual(16, cuadrado.CalcularPerimetro());
        }

        [Test]
        public void TestCalculoAreaCirculo()
        {
            var circulo = new FormaGeometrica(FormaGeometrica.Circulo, 2);
            Assert.AreEqual(3.14m, decimal.Round(circulo.CalcularArea(), 2));
        }

        [Test]
        public void TestCalculoPerimetroCirculo()
        {
            var circulo = new FormaGeometrica(FormaGeometrica.Circulo, 2);
            Assert.AreEqual(6.28m, decimal.Round(circulo.CalcularPerimetro(), 2));
        }

        [Test]
        public void TestCalculoAreaTriangulo()
        {
            var triangulo = new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 6);
            Assert.AreEqual(15.59m, decimal.Round(triangulo.CalcularArea(), 2));
        }

        [Test]
        public void TestCalculoPerimetroTriangulo()
        {
            var triangulo = new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 6);
            Assert.AreEqual(18, triangulo.CalcularPerimetro());
        }

        #endregion

        #region Tests de Casos Edge

        [Test]
        public void TestCuadradoConLadoCero()
        {
            var cuadrado = new FormaGeometrica(FormaGeometrica.Cuadrado, 0);
            Assert.AreEqual(0, cuadrado.CalcularArea());
            Assert.AreEqual(0, cuadrado.CalcularPerimetro());
        }

        [Test]
        public void TestCirculoConDiametroCero()
        {
            var circulo = new FormaGeometrica(FormaGeometrica.Circulo, 0);
            Assert.AreEqual(0, circulo.CalcularArea());
            Assert.AreEqual(0, circulo.CalcularPerimetro());
        }

        [Test]
        public void TestFormaConDecimalesMuyPequenos()
        {
            var cuadrado = new FormaGeometrica(FormaGeometrica.Cuadrado, 0.1m);
            Assert.AreEqual(0.01m, cuadrado.CalcularArea());
            Assert.AreEqual(0.4m, cuadrado.CalcularPerimetro());
        }

        [Test]
        public void TestFormaConDecimalesGrandes()
        {
            var cuadrado = new FormaGeometrica(FormaGeometrica.Cuadrado, 1000.5m);
            Assert.AreEqual(1001000.25m, cuadrado.CalcularArea());
            Assert.AreEqual(4002m, cuadrado.CalcularPerimetro());
        }

        [Test]
        public void TestIdiomaInvalidoUsaInglesPorDefecto()
        {
            var formas = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(formas, 999);
            Assert.IsTrue(resumen.Contains("<h1>Shapes report</h1>"));
        }

        [Test]
        public void TestFormaInvalidaLanzaExcepcion()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new FormaGeometrica(999, 5));
        }

        #endregion

        #region Tests de Pluralización

        [Test]
        public void TestUnSoloCirculoEnCastellano()
        {
            var circulos = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Circulo, 3) };
            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("1 Círculo"));
        }

        [Test]
        public void TestVariosCirculosEnCastellano()
        {
            var circulos = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Circulo, 2),
                new FormaGeometrica(FormaGeometrica.Circulo, 3)
            };
            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("2 Círculos"));
        }

        [Test]
        public void TestUnSoloTrianguloEnIngles()
        {
            var triangulos = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4) };
            var resumen = FormaGeometrica.Imprimir(triangulos, FormaGeometrica.Ingles);
            Assert.IsTrue(resumen.Contains("1 Triangle"));
        }

        [Test]
        public void TestVariosTriangulosEnIngles()
        {
            var triangulos = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4)
            };
            var resumen = FormaGeometrica.Imprimir(triangulos, FormaGeometrica.Ingles);
            Assert.IsTrue(resumen.Contains("2 Triangles"));
        }

        #endregion

        #region Tests de Formato de Reporte

        [Test]
        public void TestReporteContieneHeader()
        {
            var formas = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.StartsWith("<h1>Reporte de Formas</h1>"));
        }

        [Test]
        public void TestReporteContieneTotal()
        {
            var formas = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("TOTAL:<br/>"));
        }

        [Test]
        public void TestReporteContieneAreaYPerimetro()
        {
            var formas = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("Area"));
            Assert.IsTrue(resumen.Contains("Perimetro"));
        }

        [Test]
        public void TestSaltosDeLineaEnReporte()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            var lineas = resumen.Split(new[] { "<br/>" }, StringSplitOptions.None);
            Assert.GreaterOrEqual(lineas.Length, 3); // Header + 2 formas + Total
        }

        #endregion

        #region Tests de Precisión Numérica

        [Test]
        public void TestPrecisionDecimalEnArea()
        {
            var circulo = new FormaGeometrica(FormaGeometrica.Circulo, 3.5m);
            var area = circulo.CalcularArea();
            Assert.AreEqual(9.62m, decimal.Round(area, 2));
        }

        [Test]
        public void TestSumaDeAreasConDecimales()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2.5m),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3.5m)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("Area 18,5")); // 6.25 + 12.25 = 18.5
        }

        #endregion

        #region Tests de Orden de Formas

        [Test]
        public void TestOrdenDeFormasEnReporte()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3)
            };
            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            var indexCuadrado = resumen.IndexOf("Square");
            var indexCirculo = resumen.IndexOf("Circle");
            var indexTriangulo = resumen.IndexOf("Triangle");

            Assert.Less(indexCuadrado, indexCirculo);
            Assert.Less(indexCirculo, indexTriangulo);
        }

        #endregion

        #region Tests de Múltiples Formas del Mismo Tipo

        [Test]
        public void TestMuchosCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>();
            for (int i = 1; i <= 10; i++)
            {
                cuadrados.Add(new FormaGeometrica(FormaGeometrica.Cuadrado, i));
            }
            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);
            Assert.IsTrue(resumen.Contains("10 Squares"));
        }

        [Test]
        public void TestMuchosCirculos()
        {
            var circulos = new List<FormaGeometrica>();
            for (int i = 1; i <= 5; i++)
            {
                circulos.Add(new FormaGeometrica(FormaGeometrica.Circulo, i * 2));
            }
            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);
            Assert.IsTrue(resumen.Contains("5 Círculos"));
        }

        #endregion
    }
}