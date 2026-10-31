using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_31_DecomposeConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DateTime winterDate = new DateTime(2026, 11, 15);
            DateTime summerDate = new DateTime(2026, 7, 20);
            int quantity = 3;

            // Kiểm thử lớp Before
            StadiumTicketBefore beforeService = new StadiumTicketBefore();
            Console.WriteLine("--- BEFORE REFACTORING ---");
            Console.WriteLine($"Giá vé mùa đông ({winterDate:dd/MM/yyyy}): ${beforeService.CalculateTicketPrice(winterDate, quantity)}");
            Console.WriteLine($"Giá vé mùa hè   ({summerDate:dd/MM/yyyy}): ${beforeService.CalculateTicketPrice(summerDate, quantity)}");

            Console.WriteLine();

            // Kiểm thử lớp After
            StadiumTicketAfter afterService = new StadiumTicketAfter();
            Console.WriteLine("--- AFTER REFACTORING ---");
            Console.WriteLine($"Giá vé mùa đông ({winterDate:dd/MM/yyyy}): ${afterService.CalculateTicketPrice(winterDate, quantity)}");
            Console.WriteLine($"Giá vé mùa hè   ({summerDate:dd/MM/yyyy}): ${afterService.CalculateTicketPrice(summerDate, quantity)}");

            Console.ReadLine();
        }
    }
}