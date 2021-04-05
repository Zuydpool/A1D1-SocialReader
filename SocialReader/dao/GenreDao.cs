using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class GenreDao
    {
        public int Create(Genre genre)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Genre
                            where a.Id == genre.Id
                            select a;

                if (query.Any()) return -1;
                db.Insert(genre);
                // Apply Id on account object.
                var lastId = (from a in db.Account orderby a.Id select a.Id).Max();

                genre.Id = lastId;
                return lastId;
            }
        }

        // Nullable
        public Genre GetById(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from g in db.Genre
                            where g.Id == id
                            select g;

                return query.FirstOrDefault();
            }
        }

        public Genre GetByName(string name)
        {
            using (var db = new DbSocialReader())
            {
                var query = from g in db.Genre
                            where g.Name == name
                            select g;

                return query.FirstOrDefault();
            }
        }

        public void Update(Genre genre)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(genre);
            }
        }

        public void Delete(Genre genre)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(genre);
            }
        }

        public List<Genre> GetGenres()
        {
            using (var db = new DbSocialReader())
            {
                var query = from g in db.Genre select g;
                return query.ToList();
            }
        }
    }
}