using System;
using System.Collections.Generic;
using CryptoWallet.Assets;

namespace CryptoWallet.Wallets
{
    public class EtheriumWallet : Wallet
    {
        public EtheriumWallet() : base()
        {
            WalletType = Enums.WalletType.Ethereum;
        }
        
        public List<NonFungible> NonFungibleAdress;
        public List<Guid> SupportedFungibleNonfungibleAdress { get; }
        
        public void AddSupportedAdress(List<Assets.Assets> assetsList)
        {
            foreach (var VARIABLE in assetsList)
            {
                SupportedFungibleNonfungibleAdress.Add(VARIABLE.Adress);
            }
        }
        
        public override decimal TotalValueOfAssets()
        {
            decimal total = 0;
            foreach (var nonFungible in NonFungibleAdress)
            {
                total += ValueConverter(nonFungible);
            }

            foreach (var fungible in FungibleBalance.Values)
            {
                total += fungible;
            }

            return total;
        }

        protected override decimal ValueConverter(NonFungible nonFungible)
        {
            return nonFungible.Value * FungibleBalance[nonFungible.Adress];
        }
        
        public override string ToString()
        {
            return ($"Type: {WalletType}\n" +
                    $"Adress: {Adress}\n" +
                    $"Value in USD {TotalValueOfAssets()}\n");
        }
    }
}