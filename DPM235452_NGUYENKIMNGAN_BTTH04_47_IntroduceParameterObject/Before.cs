using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_47_IntroduceParameterObject
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }

    public class AccountBefore
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void AddTransaction(Transaction t) => _transactions.Add(t);

        // Vi phạm: Nhận 2 tham số start và end tách rời nhưng luôn được dùng chung cùng nhau
        public double GetFlowBetween(DateTime start, DateTime end)
        {
            double sum = 0;
            foreach (var t in _transactions)
            {
                if (t.Date >= start && t.Date <= end)
                {
                    sum += t.Amount;
                }
            }
            return sum;
        }
    }
}