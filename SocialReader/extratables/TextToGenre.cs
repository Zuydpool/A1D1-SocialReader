using LinqToDB.Mapping;

namespace SocialReader.extratables
{
    [Table(Name = "TextToGenre")]
    public class TextToGenre
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "textId"), NotNull]
        public int TextId { get; set; }

        [Column(Name = "genreId"), NotNull]
        public int GenreId { get; set; }
    }
}
