using DesignPatternChallengeVisitor.ConcreteElement;
using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.ConcreteVisitor
{
    public class CountWordsVisitor : IDocumentVisitor
    {
        private int _result = 0;
        public int GetResult() => _result;

        public void Visit(Paragraph paragraph)
        {
            _result = paragraph.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public void Visit(Image image) { }

        public void Visit(Table table)
        {
            foreach (var row in table.Cells)
            {
                foreach (var cell in row)
                {
                    _result += cell.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                }
            }
        }
    }
}
