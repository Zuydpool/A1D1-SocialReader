using System;
using System.Collections.Generic;
using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }
        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
        [Column(Name = "dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [Column(Name = "registered")]
        public DateTime Registered { get; set; }
        [Column(Name = "language")]
        public string Language { get; set; }

        [Column(Name = "accountId"), NotNull]
        public int AccountId { get; set; }

        private List<Note> notes = new List<Note>();
        private List<Score> scores = new List<Score>();
        private List<Text> texts = new List<Text>();

        /*public User(int id, string name, DateTime dateOfBirth, DateTime registered)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.registered = registered;
        }*/

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public void AddScore(Score score)
        {
            scores.Add(score);
        }

        public void AddText(Text text)
        {
            texts.Add(text);
        }
        
        public override string ToString()
        {
            return "User{Id=" + Id + ", Name=" + Name + ", DateOfBirth=" + DateOfBirth + ", Registered=" + Registered + ", Language=" + Language + "}";
        }
    }
}