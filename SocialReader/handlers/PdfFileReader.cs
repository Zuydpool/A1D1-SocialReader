using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace SocialReader.handlers
{
    public class PdfFileReader : IFileReader
    {
        public string ReadText(string path)
        {
            var pdfDocument = new PdfDocument(new PdfReader(path));
            var strategy = new LocationTextExtractionStrategy();
            var processed = new StringBuilder();

            for (var i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page, strategy);
                processed.Append(text);
            }

            pdfDocument.Close();
            return processed.ToString();
        }
    }
}