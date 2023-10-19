namespace DemoGenerics.Models
{
    public interface IIngredientManager : ISandwichMaker<Ingredient>
    {
        public Pain FaireDuPainBrun();

        public Relish FaireDeLaRelishSucree();
    }
}
