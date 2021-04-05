using LinqToDB.Mapping;

namespace SocialReader.extratables
{
    [Table(Name = "TextToAuthor")]
    public class TextToAuthor
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "textId"), NotNull]
        public int TextId { get; set; }

        [Column(Name = "authorId"), NotNull]
        public int AuthorId { get; set; }
    }
}
