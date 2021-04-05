using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Texts")]
    public class Text
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }
        [Column(Name = "title"), NotNull]
        public string Title { get; set; }
        [Column(Name = "yearOfPublishing"), NotNull]
        public DateTime YearOfPublishing { get; set; }
        [Column(Name = "version"), Nullable]
        public string Version { get; set; }
        [Column(Name = "summary"), Nullable]
        public string Summary { get; set; }

        private List<Genre> genres = new List<Genre>();
        private List<User> users = new List<User>();
        private List<Note> notes = new List<Note>();
        private List<Score> scores = new List<Score>();
        private List<Author> authors = new List<Author>();
        private List<Page> pages = new List<Page>();

        // Used for ObjectListView
        public string AuthorsAsString { get { return getAuthorsAsString(); } }
        public string GenresAsString { get { return getGenresAsString(); } }
        public int AverageScore { get { return GetAverageScore(); } }

        /*public Text(int id, string title, Genre genre, DateTime yearOfPublishing, List<Author> authors)
        {
            this.id = id;
            this.title = title;
            this.genre = genre;
            this.yearOfPublishing = yearOfPublishing;

            this.authors = authors;

            // Add this text class to author(s)
            foreach (var author in authors)
            {
                author.AddText(this);
            }
        }*/

        public List<Author> GetAuthors()
        {
            return authors;
        }

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void AddAuthors(List<Author> authors)
        {
            this.authors.AddRange(authors);
        }

        public void AddGenres(List<Genre> genres)
        {
            this.genres.AddRange(genres);
        }

        public void AddPage(Page page)
        {
            if (pages.Contains(page)) return;
            pages.Add(page);
        }

        public Page GetPage(int page)
        {
            if (pages.Count > page)
            {
                // Throw exception...
            }

            return pages[page - 1];
        }

        public void AddGenre(Genre genre)
        {
            if (genres.Contains(genre)) return;
            genres.Add(genre);
        }

        public void AddAuthor(Author author)
        {
            if (authors.Contains(author)) return;
            authors.Add(author);
        }

        public string getAuthorsAsString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var author in authors)
            {
                sb.Append(author.Name).Append(", ");
            }

            if (sb.Length == 0) return "Unknown";
            return sb.ToString().Substring(0, sb.Length - 2);
        }

        public string getGenresAsString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var genre in genres)
            {
                sb.Append(genre.Name).Append(", ");
            }
            
            if (sb.Length == 0) return "None";
            return sb.ToString().Substring(0, sb.Length - 2);
        }

        public int GetAverageScore()
        {
            var totalScore = 0;
            foreach (var score in scores)
            {
                totalScore += score.ScoreValue;
            }
            if (totalScore == 0) return totalScore;
            return totalScore / scores.Count();
        }
        
        public override string ToString()
        {
            return "Text{Id=" + Id + ", Title=" + Title + ", YearOfPublishing=" + YearOfPublishing + ", Version=" + Version + ", Summary=" + Summary + "}";
        }
    }
}