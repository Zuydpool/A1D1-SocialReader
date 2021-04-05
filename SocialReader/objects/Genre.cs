using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Genres")]
    public class Genre
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }
        [Column(Name = "name"), NotNull]
        public string Name { get; set; }
        [Column(Name = "description"), NotNull]
        public string Description { get; set; }

        /*public Genre(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }*/

        /*public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }*/
        
        public override string ToString()
        {
            return "Genre{Id=" + Id + ", Name=" + Name + ", Description=" + Description + "}";
        }
    }
}