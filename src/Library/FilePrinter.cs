using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintable printable)
        {
            File.WriteAllText("Recipe.txt", printable.GetTextToPrint());
        }
    }
}