using System.Data.Linq;
using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Notes")]
    public class Note
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "user_id"), NotNull]
        public int User_Id { get; set; }

        [Column(Name = "text_id"), NotNull]
        public int Text_Id { get; set; }
       
        [Column(Name = "Content"), NotNull]
        public string Content { get; set; }
        public Text Text { get; set; }

        private EntityRef<User> _user = new EntityRef<User>();

        [Association(
            Storage = "_user",
            ThisKey = "Id",
            OtherKey = nameof(User_Id)
            )]
        public User User
        {
            get { return _user.Entity; }
            set { _user.Entity = value; }
        }

        /*public Note(int id, User user, Text text, string content)
        {
            this.id = id;
            this.user = user;
            this.text = text;
            this.content = content;
        }
        
        public int GetId()
        {
            return id;
        }*/

        public override string ToString()
        {
            return "Note{Id=" + Id + ", User=" + User_Id + ", Text=" + Text_Id + ", Content=" + Content + "}";
        }
    }
}