using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Scores")]
    public class Score
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }
        [Column(Name = "user_id"), NotNull]
        public int User_Id { get; set; }
        [Column(Name = "text_id"), NotNull]
        public int Text_Id { get; set; }
        [Column(Name = "score"), NotNull]
        public int ScoreValue  { get; set; }
        [Column(Name = "reason"), NotNull]
        public string Reason { get; set; }

        public User User { get; set; }
        public Text Text { get; set; }

        /*public Score(int id, User user, Text text, int score, string reason)
        {
            this.id = id;
            this.user = user;
            this.text = text;

            // Score can't ben higher then 10.
            // Correct if it is.
            this.score = score > 10 ? 10 : score;
            this.reason = reason;
        }
        public int GetId()
        {
            return id;
        }*/

        public override string ToString()
        {
            return "Score{Id=" + Id + ", User=" + User + ", Text=" + Text + ", ScoreValue=" + ScoreValue + ", Reason=" + Reason + "}";
        }
    }
}