using DesignPatternChallengeVisitor.ConcreteElement;
using DesignPatternChallengeVisitor.Visitor;
using System.Text;

namespace DesignPatternChallengeVisitor.ConcreteVisitor
{
    public class ExportToPdfVisitor : IDocumentVisitor
    {
        private StringBuilder _pdf;

        public ExportToPdfVisitor()
        {
            _pdf = new StringBuilder();
        }

        public string GetResult() => _pdf.ToString();
        public void Visit(Paragraph paragraph)
        {
            _pdf.AppendLine($"PDF_TEXT({paragraph.Text}, {paragraph.FontFamily}, {paragraph.FontSize})");
        }

        public void Visit(Image image)
        {
            _pdf.AppendLine($"PDF_IMAGE({image.Url}, {image.Width}, {image.Height}, {image.Alt})");
        }

        public void Visit(Table table)
        {
            _pdf.AppendLine($"PDF_TABLE({table.Rows}, {table.Columns}, data...)");
        }
    }
}
