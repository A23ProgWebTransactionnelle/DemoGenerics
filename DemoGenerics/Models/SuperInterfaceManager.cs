using System.Security.Cryptography.X509Certificates;

namespace DemoGenerics.Models
{
    public class SuperInterfaceManager
    {
        public static IScore? RetourneObjetAvecLePlusPetitScore(IScore a, IScore b)
        {
            int difference = a.GetScore() - b.GetScore();
            if (difference > 0)
                return a;
            if (difference < 0)
                return b;
            return null;
        }

        public static void Main()
        {
            Partie score1 = new Partie(3);
            Partie score2 = new Partie(4);

            Partie? objetAvecPlusPetitScore = (Partie?) RetourneObjetAvecLePlusPetitScore(score1, score2);
        }
    }



}
