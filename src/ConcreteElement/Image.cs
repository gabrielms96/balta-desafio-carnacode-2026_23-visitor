using DesignPatternChallengeVisitor.Element;
using DesignPatternChallengeVisitor.Visitor;

namespace DesignPatternChallengeVisitor.ConcreteElement
{
    public class Image : IDocumentElement
    {
        public Image(string url, int width, int height)
        {
            Url = url;
            Width = width;
            Height = height;
            Alt = string.Empty;
        }

        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Alt { get; set; }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
