using System;
using System.Collections.Concurrent;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_18_ChangeValueToReference
{
    // Ứng dụng thực tế: Thread-safe Repository, định danh khách hàng qua ID duy nhất và kiểm tra tham số hợp lệ
    public class CustomerReal
    {
        public string Id { get; }
        public string Name { get; }

        public CustomerReal(string id, string name)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }

    public static class CustomerRegistry
    {
        private static readonly ConcurrentDictionary<string, CustomerReal> _customers = new();

        public static CustomerReal GetOrCreate(string id, string name)
        {
            return _customers.GetOrAdd(id, key => new CustomerReal(key, name));
        }
    }

    public class Real
    {
        public string OrderId { get; }
        public CustomerReal Customer { get; }

        public Real(string orderId, string customerId, string customerName)
        {
            if (string.IsNullOrWhiteSpace(orderId))
                throw new ArgumentException("Mã đơn hàng không được để trống.", nameof(orderId));

            OrderId = orderId;
            Customer = CustomerRegistry.GetOrCreate(customerId, customerName);
        }
    }
}
