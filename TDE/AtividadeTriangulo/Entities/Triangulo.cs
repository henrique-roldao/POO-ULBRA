using System;

namespace AtividadeTriangulo.Entities
{
    public class Triangulo
    {
        decimal altura;
        decimal baseTriangulo;
        decimal area;

        public Triangulo(decimal altura, decimal baseTriangulo)
        {
            this.altura = altura;
            this.baseTriangulo = baseTriangulo;
        }
        public decimal AreaTriangulo(decimal altura, decimal baseTriangulo)
        {
            decimal area = (baseTriangulo * altura) / 2;
            return area;
        }
    }
}