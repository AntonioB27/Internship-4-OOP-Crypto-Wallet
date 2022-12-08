using System;
using System.Collections.Generic;

namespace CryptoWallet.Wallets
{
    public class BitcoinWallet : Wallet
    {
        private List<Guid> FungibleAdress { get; set; }

        public BitcoinWallet() : base()
        {
            WalletType = Enums.WalletType.Bitcoin;
        }

        public void SetFungibleAdress(List<Assets.Assets> assets)
        {
            foreach (var VARIABLE in assets)
            {
                if(VARIABLE.IsFungible)
                    FungibleAdress.Add(VARIABLE.Adress);
            }
        }
    }
}