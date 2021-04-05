using System.Collections.Generic;
using LinqToDB.Mapping;

namespace SocialReader.objects
{
    [Table(Name = "Accounts")]
    public class Account
    {
        [Column(Name = "id"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "email"), NotNull] public string Email { get; set; }
        [Column(Name = "username"), NotNull] public string Username { get; set; }
        [Column(Name = "password"), NotNull] public string Password { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        [Association(
        ThisKey = nameof(Id),
        OtherKey = nameof(User.Id))]
        public List<User> Users { get; set; } = new List<User>();

        /*public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }*/

        public override string ToString()
        {
            return "Account{Id=" + Id + ", Username=" + Username + ", Password=" + Password + "}";
        }
    }
}