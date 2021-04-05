using System;
using System.Net.Mail;
using System.Windows.Forms;
using SocialReader.dao;
using SocialReader.Forms;
using SocialReader.objects;

namespace SocialReader
{
	public class Program
	{
		public readonly AccountDao AccountDao = new AccountDao();
		public readonly AuthorDao AuthorDao = new AuthorDao();
		public readonly GenreDao GenreDao = new GenreDao();
		public readonly NotesDao NotesDao = new NotesDao();
		public readonly ScoreDao ScoreDao = new ScoreDao();
		public readonly TextDao TextDao = new TextDao();
		public readonly UserDao UserDao = new UserDao();

        public readonly Session session = new Session();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public void Start()
		{
            using (var db = new DbSocialReader())
            {
                db.CheckTables();
            }
            //AccountDao.GetById(2);


            /*var genre = new Genre { Id = 1, Name = "Literaire fictie", Description = "" };
            var author = new Author { Name = "Arjen Lubach", FirstName = "Arjen", Title = "" };
            var text = new Text { Title = "Stoorzender", YearOfPublishing = new DateTime(2020, 8, 19), Version = "1.0.0", Summary = "" };
            AuthorDao.Create(author);
            Console.WriteLine("Author: " + author);
            text.AddGenre(genre);
            text.AddAuthor(author);
            TextDao.Create(text);
            Console.WriteLine("Text: " + text);*/
            var texts = TextDao.GetTexts();
            Console.WriteLine(texts);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm(this));
		}

        /**
         * Used to check if input is a valid email address.
         * 
         * @return true if email is valid. false if email is invalid.
         */
        public bool IsValidEmail(string emailaddress)
        {
            if (string.IsNullOrEmpty(emailaddress)) return false;
            try
            {
                var mailAddress = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
