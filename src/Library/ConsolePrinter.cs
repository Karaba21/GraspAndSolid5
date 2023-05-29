using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeToPrint recipeToPrint)
        {
            Console.WriteLine(recipeToPrint.GetTextToPrint());
        }
    }
}