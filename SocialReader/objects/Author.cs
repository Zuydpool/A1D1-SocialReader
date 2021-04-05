using System.Collections.Generic;
using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Authors")]
    public class Author
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }
        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
        [Column(Name = "firstName"), NotNull]
        public string FirstName { get; set; }
        [Column(Name = "title"), NotNull]
        public string Title { get; set; }
        
        
        private List<Text> texts = new List<Text>();

        /*public Author(int id, string name, string firstName, string title)
        {
            this.id = id;
            this.name = name;
            this.firstName = firstName;
            this.title = title;
        }*/

        public void AddText(Text text)
        {
            if (texts.Contains(text) || texts.Find(match => match.Id == text.Id) != null)
            {
                // Don't add duplicates.
                return;
            }
            texts.Add(text);
        }
        
        public override string ToString()
        {
            return "Author{Id=" + Id + ", Name=" + Name + ", FirstName=" + FirstName + ", Title=" + Title + "}";
        }
    }
}