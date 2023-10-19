namespace DemoGenerics.Models
{
    public class SandwichMaker3000
    {
        public List<object> CreateList(object exterieur, object interieur)
        {
            var liste = new List<object>();
            
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

            var sandwichString = sandwichMaker.CreateList(stringPain, stringGarniture);
            for (int i = 0; i < sandwichString.Count; i++)
            {
                string s = sandwichString[i];
                Console.WriteLine(s);
            }

            Pain pain = new Pain();
            Relish relish = new Relish();

            var sandwichIngredients = sandwichMaker.CreateList(pain, relish);
            for(int i = 0; i < sandwichIngredients.Count; i++)
            {
                Ingredient item = sandwichIngredients[i];
                Console.WriteLine(item);
            }


        }
    }
}
