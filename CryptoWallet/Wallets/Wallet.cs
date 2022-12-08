using System;
using System.Collections.Generic;

namespace CryptoWallet.Wallets
{
    public class Wallet
    {
        public Guid Adress;
        public Dictionary<Guid,int> FungibleBalance { get; }
        public Guid TransactionAdress { get; } 
        public Enum WalletType { get; set; }
        
        public Wallet()
        {
            Adress = Guid.NewGuid();
        }
    }
}