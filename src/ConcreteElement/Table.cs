using DesignPatternChallengeVisitor.Element;
using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.ConcreteElement
{
    public class Table : IDocumentElement
    {
        public Table(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new List<List<string>>();

            for (int i = 0; i < rows; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < columns; j++)
                {
                    row.Add($"Cell {i},{j}");
                }
                Cells.Add(row);
            }
        }

        public List<List<string>> Cells { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
