using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.extratables;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class TextDao
    {
        public int Create(Text text)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Text
                            where a.Id == text.Id
                            select a;

                if (query.Any()) return -1;
                db.Insert(text);
                // Apply Id on account object.
                var lastId = (from a in db.Text orderby a.Id select a.Id).Max();

                text.Id = lastId;

                // To-Do: Apply Bulk insert
                if (text.GetAuthors().Count > 0)
                {
                    foreach (var author in text.GetAuthors())
                    {
                        var textToAuthor = new TextToAuthor { TextId = text.Id, AuthorId = author.Id };
                        db.Insert(textToAuthor);
                    }
                }

                // To-Do: Apply Bulk insert
                if (text.GetGenres().Count > 0)
                {
                    foreach (var genre in text.GetGenres())
                    {
                        var textToGenre = new TextToGenre { TextId = text.Id, GenreId = genre.Id };
                        db.Insert(textToGenre);
                    }
                }

                return lastId;
            }
        }

        // Nullable
        public Text GetById(int id)
        {
            using (var db = new DbSocialReader())
            {
                var query = from text in db.Text
                            join textToAuthor in db.TextToAuthor on text.Id equals textToAuthor.TextId
                            join author in db.Author on textToAuthor.AuthorId equals author.Id
                            where text.Id == id
                            select new { text, author };

                if (query.Count() == 0) return null;
                
                var result = query.First().text;
                foreach (var arr in query.ToArray())
                {
                    Console.WriteLine(arr);
                    result.AddAuthor(arr.author);
                }
                
                return result;
            }
        }

        public void Update(Text text)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(text);
            }
        }

        public void Delete(Text text)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(text);
            }
        }

        public List<Text> GetTexts()
        {
            using (var db = new DbSocialReader())
            {
                /*var query = from text in db.Text
                            join textToAuthor in db.TextToAuthor on text.Id equals textToAuthor.TextId
                            //join textToGenre in db.TextToGenre on text.Id equals textToGenre.TextId
                            join author in db.Author on textToAuthor.AuthorId equals author.Id
                            //join genre in db.Genre on textToGenre.GenreId equals genre.Id
                            select new { text, author };*/

                // TODO: Fix issue with double authors and/or genres
                var query = from text in db.Text
                            join textToAuthor in db.TextToAuthor on text.Id equals textToAuthor.TextId
                            join textToGenre in db.TextToGenre on text.Id equals textToGenre.TextId
                            join author in db.Author on textToAuthor.AuthorId equals author.Id
                            join genre in db.Genre on textToGenre.GenreId equals genre.Id
                            select new { text, author, genre };

                if (query.Count() == 0) return null;
                var result = new HashSet<Text>();

                //var result = query.First().text;
                foreach (var arr in query.ToArray())
                {
                    if (result.Any(text => text.Id == arr.text.Id)) 
                    //if (result.Contains(arr.text))
                    {
                        var temp = result.First(text => text.Id == arr.text.Id);
                        Console.WriteLine(temp);
                        temp.AddAuthor(arr.author);
                        temp.AddGenre(arr.genre);
                    } else
                    {
                        var temp = arr.text;
                        Console.WriteLine("new text " + temp.Title);
                        temp.AddAuthor(arr.author);
                        temp.AddGenre(arr.genre);
                        result.Add(temp);
                    }
                }

                return result.ToList();
            }
            //return texts;
        }
    }
}