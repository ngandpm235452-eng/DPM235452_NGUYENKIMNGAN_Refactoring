using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_18_ChangeValueToReference
{
    public class CustomerAfter
    {
        public string Name { get; }
        public CustomerAfter(string name) => Name = name;
    }

    // Repository quản lý lưu trữ tập trung các đối tượng dùng chung
    public static class CustomerRepository
    {
        private static readonly Dictionary<string, CustomerAfter> _instances = new();

        public static CustomerAfter GetCustomer(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new CustomerAfter(name);
            }
            return _instances[name];
        }
    }

    public class After
    {
        // Tái cấu trúc: Chuyển sang dùng chung tham chiếu đối tượng Customer qua Repository
        public CustomerAfter Customer { get; }

        public After(string customerName)
        {
            Customer = CustomerRepository.GetCustomer(customerName);
        }
    }
}