using DesignPatternChallengeVisitor.ConcreteElement;

namespace DesignPatternChallengeVisitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Documentos com Padrão Visitor ===\n");

            // Criando um documento com vários elementos
            var doc = new Document("Relatório Anual");

            doc.AddElement(new Paragraph("Este é o relatório anual da empresa."));
            doc.AddElement(new Image("grafico.png", 800, 600));
            doc.AddElement(new Paragraph("Abaixo os resultados financeiros do ano:"));
            doc.AddElement(new Table(3, 4));
            doc.AddElement(new Paragraph("Conclusão do relatório com recomendações."));

            Console.WriteLine($"Documento: {doc.Title}");
            Console.WriteLine($"Elementos: {doc.Elements.Count}\n");

            Console.WriteLine("=== Operações no Documento (usando Visitors) ===");

            // Operação 1: Contar palavras
            var totalWords = doc.CountTotalWords();
            Console.WriteLine($"Total de palavras: {totalWords}");

            // Operação 2: Validar documento
            var isValid = doc.ValidateAll();
            Console.WriteLine($"Documento válido: {isValid}");

            // Operação 3: Calcular tempo de leitura
            var readingTime = doc.CalculateReadingTime();
            Console.WriteLine($"Tempo de leitura estimado: {readingTime} minutos");

            // Operação 4: Exportar para HTML
            Console.WriteLine("\n=== Exportação HTML (amostra) ===");
            var html = doc.ExportToHtml();
            Console.WriteLine(html.Substring(0, Math.Min(200, html.Length)) + "...");

            // Operação 5: Exportar para PDF
            Console.WriteLine("\n=== Exportação PDF (amostra) ===");
            var pdf = doc.ExportToPdf();
            Console.WriteLine(pdf.Substring(0, Math.Min(150, pdf.Length)) + "...");
        }
    }
}