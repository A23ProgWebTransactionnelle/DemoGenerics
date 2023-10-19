namespace DemoGenerics.Models
{
    public class IngredientManager : SandwichMaker3000<Ingredient>, IIngredientManager
    {

        public Pain FaireDuPainBrun()
        {
            return new Pain() { EstBrun = true };
        }

        public Relish FaireDeLaRelishSucree()
        {
            return new Relish() { EstSucree = true };
        }

        public static void Main(string[] args)
        {
            var ingredientManager = new IngredientManager();

            Pain pain = ingredientManager.FaireDuPainBrun();
            Relish relish = ingredientManager.FaireDeLaRelishSucree();

            List<Ingredient> sandwichIngredients = ingredientManager.FaireUnSandwich(pain, relish);
            for (int i = 0; i < sandwichIngredients.Count; i++)
            {
                Ingredient item = sandwichIngredients[i];
                Console.WriteLine(item);
            }
        }

        /*private IReadOnlyList<Ingredient> _sandwichParfait;
        public IReadOnlyList<Ingredient> SandwichParfait { get { return _sandwichParfait; } }
        
        public IngredientManager() {
            var painBlanc = new Pain();
            var relishNonSucree = new Relish();
            _sandwichParfait = FaireUnSandwich(painBlanc, relishNonSucree);
        }*/
    }
}
