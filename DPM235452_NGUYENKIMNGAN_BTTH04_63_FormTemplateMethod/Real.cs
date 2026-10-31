using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_63_FormTemplateMethod
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Article article = new Article
            {
                Title = "Kiến trúc Tái cấu trúc Mã nguồn C#",
                Content = "Template Method giúp cố định khung thuật toán ở lớp cha và cho phép lớp con ghi đè từng bước cụ thể."
            };

            ArticleExporterAfter textExporter = new TextArticleExporterAfter();
            ArticleExporterAfter htmlExporter = new HtmlArticleExporterAfter();

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG XUẤT BẢO CÁO (TEMPLATE METHOD)       ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("1. ĐỊNH DẠNG TEXT PLAIN:");
            Console.WriteLine(textExporter.Export(article));
            Console.WriteLine();

            Console.WriteLine("2. ĐỊNH DẠNG HTML:");
            Console.WriteLine(htmlExporter.Export(article));
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Luồng tổng thể (Header -> Body -> Footer)");
            Console.WriteLine("được quản lý tập trung ở lớp cha ArticleExporterAfter,");
            Console.WriteLine("tránh lặp lại cấu trúc thuật toán ở từng lớp con.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}