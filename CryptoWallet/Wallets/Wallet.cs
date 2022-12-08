using System;
using System.Collections.Generic;
using CryptoWallet.Assets;

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

        public virtual decimal TotalValueOfAssets()
        {
            return 0;
        }

        protected virtual decimal ValueConverter(NonFungible nonFungible)
        {
            return 0;
        }

        public virtual string ToString()
        {
            return null;
        }
    }
}