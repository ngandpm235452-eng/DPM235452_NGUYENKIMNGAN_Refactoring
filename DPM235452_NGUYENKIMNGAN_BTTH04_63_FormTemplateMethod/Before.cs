using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_63_FormTemplateMethod
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class TextArticleExporterBefore
    {
        // Vi phạm: Phương thức Export tự quản lý toàn bộ các bước xuất dữ liệu (Header, Body, Footer)
        // dẫn đến việc trùng lặp luồng xử lý với HtmlArticleExporterBefore
        public string Export(Article article)
        {
            string result = "=== " + article.Title.ToUpper() + " ===\n";
            result += article.Content + "\n";
            result += "--- End of Text Document ---";
            return result;
        }
    }

    public class HtmlArticleExporterBefore
    {
        // Vi phạm: Lặp lại quy trình ghép nối Header -> Body -> Footer hệt như dạng Text
        public string Export(Article article)
        {
            string result = "<h1>" + article.Title + "</h1>\n";
            result += "<p>" + article.Content + "</p>\n";
            result += "<footer>End of HTML Document</footer>";
            return result;
        }
    }
}