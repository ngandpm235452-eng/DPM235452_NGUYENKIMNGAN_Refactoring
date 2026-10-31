using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_63_FormTemplateMethod
{
    // Lớp trừu tượng cha định nghĩa khung thuật toán (Template Method)
    public abstract class ArticleExporterAfter
    {
        // Tái cấu trúc: Template Method Export() cố định thứ tự các bước thực hiện
        public string Export(Article article)
        {
            string result = FormatHeader(article.Title) + "\n";
            result += FormatBody(article.Content) + "\n";
            result += FormatFooter();
            return result;
        }

        // Các bước chi tiết được giao cho các lớp con tự triển khai
        protected abstract string FormatHeader(string title);
        protected abstract string FormatBody(string content);
        protected abstract string FormatFooter();
    }

    public class TextArticleExporterAfter : ArticleExporterAfter
    {
        protected override string FormatHeader(string title)
        {
            return $"=== {title.ToUpper()} ===";
        }

        protected override string FormatBody(string content)
        {
            return content;
        }

        protected override string FormatFooter()
        {
            return "--- End of Text Document ---";
        }
    }

    public class HtmlArticleExporterAfter : ArticleExporterAfter
    {
        protected override string FormatHeader(string title)
        {
            return $"<h1>{title}</h1>";
        }

        protected override string FormatBody(string content)
        {
            return $"<p>{content}</p>";
        }

        protected override string FormatFooter()
        {
            return "<footer>End of HTML Document</footer>";
        }
    }
}