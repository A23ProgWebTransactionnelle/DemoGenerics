namespace DemoGenerics.Models
{
    public interface ISandwichMaker<T>
    {
        public List<T> FaireUnSandwich(T exterieur, T interieur);
    }
}
