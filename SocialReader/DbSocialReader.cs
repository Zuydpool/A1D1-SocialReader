using System;
using System.Linq;
using LinqToDB;
using LinqToDB.Data;
using SocialReader.extratables;
using SocialReader.objects;

namespace SocialReader
{
    public class DbSocialReader : DataConnection
    {
        public DbSocialReader() : base("SqlServer",
            @"Server=FS02.Cremers.local\SchoolProjects;Database=SocialReader;User Id=sa;Password=SchoolProjects1;")
        {
        }

        public void CheckTables()
        {
            var sp = DataProvider.GetSchemaProvider();
            var dbSchema = sp.GetSchema(this);
            
            // Create tables is they don't exist.
            if (dbSchema.Tables.Any(t => t.TableName == "Accounts") == false)
            {
                this.CreateTable<Account>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "Authors") == false)
            {
                this.CreateTable<Author>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "Genres") == false)
            {
                this.CreateTable<Genre>();
            }
            if(dbSchema.Tables.Any(t => t.TableName == "Notes") == false)
            {
                this.CreateTable<Note>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "Scores") == false)
            {
                this.CreateTable<Score>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "Texts") == false)
            {
                this.CreateTable<Text>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "Users") == false)
            {
                this.CreateTable<User>();
            }

            // Relation tables
            if (dbSchema.Tables.Any(t => t.TableName == "TextToAuthor") == false)
            {
                this.CreateTable<TextToAuthor>();
            }
            if (dbSchema.Tables.Any(t => t.TableName == "TextToGenre") == false)
            {
                this.CreateTable<TextToGenre>();
            }

        }

        // Define the tables here
        public ITable<Account> Account => GetTable<Account>();
        
        public ITable<Author> Author => GetTable<Author>();
        public ITable<Genre> Genre => GetTable<Genre>();
        public ITable<Note> Note => GetTable<Note>();
        public ITable<Score> Score => GetTable<Score>();
        public ITable<Text> Text => GetTable<Text>();
        public ITable<User> User => GetTable<User>();

        public ITable<TextToAuthor> TextToAuthor => GetTable<TextToAuthor>();
        public ITable<TextToGenre> TextToGenre => GetTable<TextToGenre>();
    }
}