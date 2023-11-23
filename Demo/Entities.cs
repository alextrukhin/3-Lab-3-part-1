﻿using System.Text.Json.Serialization;

namespace Demo
{
    public enum Currency
    {
        USD,
        EUR
    }
    [Serializable]
    public class Account : IComparable<Account>
    {
        public int OwnerCode { get; set; }
        public double Amount { get; set; }
        public Account() { }
        [JsonConstructor]
        public Account(int ownerCode, double amount)
        {
            OwnerCode = ownerCode;
            Amount = amount;
        }
        public void TopUp(double AmountToTopup)
        {
            Amount += AmountToTopup;
        }
        public void Withdraw(double WithdrawalAmount)
        {
            Amount -= WithdrawalAmount;
        }
        public void TransferTo(double AmountToSend, Account Receiver)
        {
            Receiver.Amount += AmountToSend;
            Amount -= AmountToSend;
        }
        public double ConvertTo(Currency TargetCurrency, IDictionary<Currency, double> ExchangeRate)
        {
            return Amount * ExchangeRate[TargetCurrency];
        }
        public int CompareTo(Account? other)
        {
            return OwnerCode.CompareTo(other?.OwnerCode);
        }
        public override string ToString()
        {
            return $"Account {OwnerCode} has {Amount}";
        }
    }
}