//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public string Name { get; set; }
        public int UnitCost { get; set; }

        public Product(string name, int unitCost)
        {
            Name = name;
            UnitCost = unitCost;
        }
    }
}