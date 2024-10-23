//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Recipe:IRecipe
    {
        private List<Step> steps = new List<Step>();
        public Product FinalProduct { get; set; }

        // Método para agregar un paso a la receta
        public void AddStep(Product product, int quantity, Equipment equipment, int time)
        {
            steps.Add(new ProductStep(product, quantity, equipment, time));
        }

        // Método para agregar un paso de espera
        public void AddStep(string action, int time)
        {
            steps.Add(new WaitStep(action, time));
        }

        // Método para calcular el costo total de producción
        public int GetProductionCost()
        {
            int totalCost = 0;
            foreach (var step in steps)
            {
                totalCost += step.GetCost();
            }

            return totalCost;
        }

        // Método para obtener el texto de la receta
        public string GetTextToPrint()
        {
            string description = $"Receta para: {FinalProduct.Name}\n";
            foreach (var step in steps)
            {
                description += step.GetDescription() + "\n";
            }

            description += $"Costo total de producción: {GetProductionCost()}";
            return description;
        }
    }
}