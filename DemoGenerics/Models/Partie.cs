namespace DemoGenerics.Models
{
    public class Partie : IScore
    {
        public int Score { get; set; } 
        // De nombreux autres champs pour l'information de ma partie!

        public Partie(int score) {
            Score = score;
        }

        public int GetScore()
        {
            return Score;
        }
    }
}
