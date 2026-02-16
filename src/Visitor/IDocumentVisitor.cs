using DesignPatternChallengeVisitor.ConcreteElement;

namespace DesignPatternChallengeVisitor.Visitor
{
    public interface IDocumentVisitor
    {
        void Visit(Table table);
        void Visit(Image image);
        void Visit(Paragraph paragraph);
    }
}


