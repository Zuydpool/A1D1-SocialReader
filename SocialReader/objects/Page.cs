namespace SocialReader.objects
{
    public class Page
    {
        private int id;
        private string content;
        private int pageNumber;

        public Page(int id, string content, int pageNumber)
        {
            this.id = id;
            this.content = content;
            this.pageNumber = pageNumber;
        }

        public int GetId()
        {
            return id;
        }

        public string GetContent()
        {
            return content;
        }

        public int GetPageNumber()
        {
            return pageNumber;
        }
    }
}