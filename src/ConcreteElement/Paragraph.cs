using DesignPatternChallengeVisitor.Element;
using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.ConcreteElement
{
    public class Paragraph : IDocumentElement
    {
        public Paragraph(string text)
        {
            Text = text;
            FontFamily = "Arial";
            FontSize = 12;
        }

        public string Text { get; set; }
        public string FontFamily { get; set; }
        public int FontSize { get; set; }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
