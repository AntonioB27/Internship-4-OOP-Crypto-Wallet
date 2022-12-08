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

        public override decimal TotalValueOfAssets()
        {
            int total = 0;
            foreach (var value in FungibleBalance.Values)
            {
                total += value;
            }

            return total;
        }
        
        public override string ToString()
        {
            return ($"Type: {WalletType}\n" +
                    $"Adress: {Adress}\n" +
                    $"Value in USD {TotalValueOfAssets()}\n");
        }
    }
}