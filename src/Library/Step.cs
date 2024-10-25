//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public abstract class Step
    {
        public abstract int GetCost();
        public abstract string GetDescription();
    }

// Clase para un paso que utiliza un producto y un equipo
    public class ProductStep : Step
    {
        private Product product;
        private int quantity;
        private Equipment equipment;
        private int time; // en minutos

        public ProductStep(Product product, int quantity, Equipment equipment, int time)
        {
            this.product = product;
            this.quantity = quantity;
            this.equipment = equipment;
            this.time = time;
        }

        public override int GetCost()
        {
            int equipmentCost = (time / 60) * equipment.HourlyCost; 
            return (quantity * product.UnitCost) + equipmentCost;
        }

        public override string GetDescription()
        {
            return $"{quantity} de '{product.Name}' usando '{equipment.Name}' durante {time}";
        }
    }
}
