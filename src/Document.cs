using DesignPatternChallengeVisitor.ConcreteVisitor;
using DesignPatternChallengeVisitor.Element;

namespace DesignPatternChallengeVisitor
{
    public class Document
    {
        public string Title { get; set; }
        public List<IDocumentElement> Elements { get; set; }

        public Document(string title)
        {
            Title = title;
            Elements = new List<IDocumentElement>();
        }

        public void AddElement(IDocumentElement element)
        {
            Elements.Add(element);
        }

        public string ExportToHtml()
        {
            var visitor = new HtmlExportVisitor();

            var html = $"<html><head><title>{Title}</title></head><body>";

            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }

            html += visitor.GetResult();
            html += "</body></html>";

            return html;
        }

        public string ExportToPdf()
        {
            var visitor = new ExportToPdfVisitor();

            var pdf = $"PDF_DOCUMENT({Title}) ";

            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }

            pdf += visitor.GetResult();

            return pdf;
        }

        public int CountTotalWords()
        {
            var visitor = new CountWordsVisitor();

            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }

            return visitor.GetResult();
        }

        public bool ValidateAll()
        {
            var visitor = new ValidationVisitor();

            foreach (var element in Elements)
            {
                element.Accept(visitor);

                if (!visitor.IsValid)
                    return false;
            }

            return visitor.IsValid;
        }

        public int CalculateReadingTime()
        {
            var visitor = new ReadingTimeVisitor();

            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }

            return visitor.TotalMinutes;
        }
    }
}
