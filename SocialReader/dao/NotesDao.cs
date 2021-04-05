using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class NotesDao
    {
        public void Create(Note note)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Note
                            where a.Id == note.Id
                            select a;

                if (query.Any()) return;
                db.Insert(note);
                // Apply Id on note object.
                var lastId = (from a in db.Note orderby a.Id select a.Id).Max();
                note.Id = lastId;
            }
        }
        
        // Nullable
        public Note Read(int id)
        {
            using (var db = new DbSocialReader())
            {
                var q = from t in db.Note.LoadWith(prop => prop.User) where t.Id == id select t;
                return q.FirstOrDefault();
            }
        }

        public void Update(Note note)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(note);
            }
        }

        public void Delete(Note note)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(note);
            }
        }

        public List<Note> GetNotes()
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Note select a;
                return query.ToList();
            }
        }
    }
}