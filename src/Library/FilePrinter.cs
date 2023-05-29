using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeToPrint recipeToPrint)
        {
            File.WriteAllText("Recipe.txt", recipeToPrint.GetTextToPrint());
        }
    }
}