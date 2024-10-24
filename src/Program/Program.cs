//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product cafe = new Product("Café", 100);
            Product leche = new Product("Leche", 50);

            Equipment cafetera = new Equipment("Cafetera", 50);
            Equipment hervidor = new Equipment("Hervidor", 40);

            IPrintable receta = new Recipe();
            receta.FinalProduct = new Product("Café con leche", 0);

            receta.AddStep(cafe, 100, cafetera, 120);
            receta.AddStep(leche, 200, hervidor, 60);
            receta.AddStep("Dejar enfriar", 60);

            string recetaTexto = receta.GetTextToPrint();
            Console.WriteLine(recetaTexto);

            int costoProduccion = receta.GetProductionCost();
            Console.WriteLine($"El costo total de producción es: {costoProduccion}");
        }
    }
}