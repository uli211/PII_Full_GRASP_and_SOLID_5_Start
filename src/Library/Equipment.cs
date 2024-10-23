//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public string Name { get; set; }
        public int HourlyCost { get; set; }

        public Equipment(string name, int hourlyCost)
        {
            Name = name;
            HourlyCost = hourlyCost;
        }
    }
}