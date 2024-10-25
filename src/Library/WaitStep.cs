//-------------------------------------------------------------------------------
// <copyright file="WaitStep.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class WaitStep : Step
    {
        private string action;
        private int time; // en minutos

        public WaitStep(string action, int time)
        {
            this.action = action;
            this.time = time;
        }

        public override int GetCost()
        {
            return 0;
        }

        public override string GetDescription()
        {
            return $"Esperando '{action}' durante {time}";
        }
    }
}