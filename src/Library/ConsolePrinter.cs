using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IPrintable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
}