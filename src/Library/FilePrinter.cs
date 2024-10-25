using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void Print(IPrintable printable)
        {
            File.WriteAllText("Recipe.txt", printable.GetTextToPrint());
        }
    }
}