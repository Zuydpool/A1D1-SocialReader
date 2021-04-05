using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class AuthorDao
    {
        public int Create(Author author)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Author
                            where a.Id == author.Id
                            select a;

                if (query.Any()) return -1;
                db.Insert(author);
                // Apply Id on account object.
                var lastId = (from a in db.Account orderby a.Id select a.Id).Max();

                author.Id = lastId;
                return lastId;
            }
        }

        // Nullable
        public Author Read(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Author
                            where a.Id == id
                            select a;

                return query.FirstOrDefault();
            }
        }

        public Author GetById(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Author
                            where a.Id == id
                            select a;

                return query.FirstOrDefault();
            }
        }

        public Author GetByName(string name)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Author
                            where a.Name == name
                            select a;

                return query.FirstOrDefault();
            }
        }

        public void Update(Author author)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(author);
            }
        }

        public void Delete(Author author)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(author);
            }
        }

        /**
         * 
         * Get all authors from database
         * 
         */
        public List<Author> GetAuthors()
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Author
                            select a;

                return query.ToList();
            }
        }
    }
}