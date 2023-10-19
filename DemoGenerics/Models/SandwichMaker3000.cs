namespace DemoGenerics.Models
{
    public class SandwichMaker3000<T> : ISandwichMaker<T>
    {
        public List<T> FaireUnSandwich(T exterieur, T interieur)
        {
            var liste = new List<T>();
            
            liste.Add(exterieur);
            liste.Add(interieur);
            liste.Add(exterieur);
            
            return liste;
        }

        public static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker3000();

            string stringPain = "pain";
            string stringGarniture = "garniture";

            var sandwichString = sandwichMaker.FaireUnSandwich(stringPain, stringGarniture);
            for (int i = 0; i < sandwichString.Count; i++)
            {
                string s = sandwichString[i];
                Console.WriteLine(s);
            }

            /*Pain pain = new Pain();
            Relish relish = new Relish();

            var sandwichIngredients = sandwichMaker.FaireUnSandwich(pain, relish);
            for(int i = 0; i < sandwichIngredients.Count; i++)
            {
                Ingredient item = sandwichIngredients[i];
                Console.WriteLine(item);
            }*/


        }
    }
}
