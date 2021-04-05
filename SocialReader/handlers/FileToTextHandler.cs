using System;
using SocialReader.objects;

namespace SocialReader.handlers
{
    public class FileToTextHandler
    {
        public Text textBase;
        public string pathToSource;

        public IFileReader FileReader;

        public FileToTextHandler(Text textBase, string pathToSource)
        {
            this.textBase = textBase;
            
            // U:\Zuyd\Blok 3\Projects\SocialReader\SocialReader\SocialReader\resources
            this.pathToSource = pathToSource;

            if (pathToSource.EndsWith(".pdf"))
            {
                FileReader = new PdfFileReader();
            }
            else
            {
                FileReader = new PlainTextFileReader();
            }
        }

        private string GetText()
        {
            return FileReader.ReadText(pathToSource);
        }

        public Text Convert()
        {
           // split on new line
            var strTexts = GetText().Split('\n');
            int pageNumber = 1;
            foreach (var pageContent in strTexts)
            {
                // TODO: How to define the page id here?
                var page = new Page(-1, pageContent, pageNumber);
                textBase.AddPage(page);
                pageNumber++;
            }
            return textBase;
        }
    }
}