using DesignPatternChallengeVisitor.ConcreteElement;
using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.ConcreteVisitor
{
    public class ReadingTimeVisitor : IDocumentVisitor
    {
        public int TotalMinutes { get; private set; }

        public void Visit(Paragraph paragraph)
        {
            int words = paragraph.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            TotalMinutes += words / 200;
        }

        public void Visit(Image image) { }

        public void Visit(Table table)
        {
            int words = 0;
            foreach (var row in table.Cells)
            {
                foreach (var cell in row)
                {
                    words += cell.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                }
            }
            TotalMinutes += words / 200;
        }
    }
}
