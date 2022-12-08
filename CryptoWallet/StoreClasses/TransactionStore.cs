using System;
using System.Collections.Generic;
using CryptoWallet.Transactions;

namespace CryptoWallet
{
    public class TransactionStore
    {
        public List<Transaction> ListOfTransactions = new List<Transaction>() { };

        public void Add(Transaction transaction)
        {
            ListOfTransactions.Add(transaction);
        }

        public void Print()
        {
            foreach (var VARIABLE in ListOfTransactions)
            {
                Console.WriteLine(VARIABLE.Adress);
            }
        }
    }
}