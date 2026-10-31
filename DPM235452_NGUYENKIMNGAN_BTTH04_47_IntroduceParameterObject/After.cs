using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_47_IntroduceParameterObject
{
    // Tái cấu trúc: Gom nhóm các tham số có liên quan thành Parameter Object
    public class DateRange
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public bool Includes(DateTime date)
        {
            return date >= Start && date <= End;
        }
    }

    public class AccountAfter
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void AddTransaction(Transaction t) => _transactions.Add(t);

        // Tái cấu trúc: Truyền Parameter Object DateRange thay cho truyền các tham số ngày lẻ
        public double GetFlowBetween(DateRange range)
        {
            double sum = 0;
            foreach (var t in _transactions)
            {
                if (range.Includes(t.Date))
                {
                    sum += t.Amount;
                }
            }
            return sum;
        }
    }
}