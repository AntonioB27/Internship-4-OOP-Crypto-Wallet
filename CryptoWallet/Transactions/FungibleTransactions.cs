using System;
using System.Runtime.InteropServices;

namespace CryptoWallet.Transactions
{
    public class FungibleTransactions : Transaction
    {
        public decimal sendingWalletStartBalance { get; }
        public decimal sendingWalletEndBalance { get; }
        public decimal recievingWalletStartBalance { get;}
        public decimal recievingWalletEndBalance { get;}

        public FungibleTransactions(Guid sendingWalletAdress, Guid recievingWalletAdress) : base(sendingWalletAdress,
            recievingWalletAdress){}
        

    }
}