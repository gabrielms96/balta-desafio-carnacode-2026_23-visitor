using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.Element
{
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}
