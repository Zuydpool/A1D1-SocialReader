using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class UserDao
    {
        public void Create(User user)
        {
            using (var db = new DbSocialReader())
            {
                var query = from u in db.User
                            where u.Id == user.Id || u.Name == user.Name
                            select u;

                if (query.Any()) return;
                db.Insert(user);
                // Apply Id on account object.
                var lastId = (from u in db.User orderby u.Id select u.Id).Max();
                user.Id = lastId;
            }
        }
        
        // Nullable
        public User GetById(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from u in db.User
                            where u.Id == id
                            select u;

                return query.FirstOrDefault();
            }
        }

        // Nullable
        public User GetByName(string name)
        {
            using (var db = new DbSocialReader())
            {
                var query = from u in db.User
                            where u.Name == name
                            select u;

                return query.FirstOrDefault();
            }
        }

        public void Update(User user)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(user);
            }
        }

        public void Delete(User user)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(user);
            }
        }

        public static List<User> All()
        {
            using (var db = new DbSocialReader())
            {
                var query = from u in db.User select u;
                return query.ToList();
            }
        }
    }
}