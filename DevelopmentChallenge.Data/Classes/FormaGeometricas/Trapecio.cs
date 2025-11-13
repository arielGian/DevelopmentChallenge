using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _lado1;
        private readonly decimal _lado2;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }

        public decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) * _altura / 2;
        }

        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _lado1 + _lado2;
        }

        public int ObtenerTipo()
        {
            return FormaGeometrica.Trapecio;
        }
    }
}
