using System;

namespace CryptoWallet.Transactions
{
    public class Transaction
    {
        private Guid Id;
        public Guid Adress { get; }
        public DateTime DateOfTransaction { get; }
        public Guid SendingWalletAdress { get; }
        public Guid RecievingWalletAdress { get; }
        public bool IsVoid { get; }

        public Transaction(Guid sendingWalletAdress, Guid recievingWalletAdress)
        {
            Id = Guid.NewGuid();
            Adress = Guid.NewGuid();
            DateOfTransaction = DateTime.Now;
            IsVoid = false;
            SendingWalletAdress = sendingWalletAdress;
            RecievingWalletAdress = recievingWalletAdress;
        }
    }
}