using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_46_ReplaceParameterWithMethodCall
{
    public class ShoppingCartItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public ShoppingCartItem(string name, int quantity, double unitPrice)
        {
            ItemName = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<ShoppingCartItem> items = new List<ShoppingCartItem>
            {
                new ShoppingCartItem("Tai nghe Bluetooth", 50, 20.0),   // Số lượng <= 100 -> Chiết khấu 5%
                new ShoppingCartItem("Bàn phím Cơ", 150, 50.0)          // Số lượng > 100 -> Chiết khấu 10%
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG TÍNH GIÁ ĐƠN HÀNG MUA SẮM SỐ LƯỢNG LỚN  ");
            Console.WriteLine("==================================================\n");

            foreach (var item in items)
            {
                OrderAfter order = new OrderAfter(item.Quantity, item.UnitPrice);
                double finalPrice = order.GetFinalPrice();

                Console.WriteLine($"Sản phẩm   : {item.ItemName}");
                Console.WriteLine($"  - Số lượng : {item.Quantity}");
                Console.WriteLine($"  - Đơn giá  : ${item.UnitPrice:N2}");
                Console.WriteLine($"  -> Tổng tiền sau chiết khấu: ${finalPrice:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}