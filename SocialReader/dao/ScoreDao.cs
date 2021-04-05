using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class ScoreDao
    {
        public void Create(Score score)
        {
            using (var db = new DbSocialReader())
            {
                var query = from s in db.Score
                            where s.Id == score.Id
                            select s;

                if (query.Any()) return;
                db.Insert(score);
                // Apply Id on note object.
                var lastId = (from s in db.Score orderby s.Id select s.Id).Max();
                score.Id = lastId;
            }
        }

        // Nullable
        public Score Read(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from s in db.Score
                            where s.Id == id
                            select s;

                return query.FirstOrDefault();
            }
        }

        public void Update(Score score)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(score);
            }
        }

        public void Delete(Score score)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(score);
            }
        }

        public List<Score> GetScores()
        {
            using (var db = new DbSocialReader())
            {
                var query = from s in db.Score
                            select s;

                return query.ToList();
            }
        }
    }
}