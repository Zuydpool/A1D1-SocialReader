namespace SocialReader.handlers
{
    public class PlainTextFileReader : IFileReader
    {
        public string ReadText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }
    }
}