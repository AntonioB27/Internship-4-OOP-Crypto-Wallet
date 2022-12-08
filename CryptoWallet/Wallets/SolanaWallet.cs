using System;
using System.Collections.Generic;
using System.Linq;
using CryptoWallet.Assets;

namespace CryptoWallet.Wallets
{
    public class SolanaWallet : Wallet
    {
        public SolanaWallet() : base()
        {
            WalletType = Enums.WalletType.Solana;
        }
        
        protected List<Guid> SupportedFungibleNonfungibleAdress { get; }
        public List<NonFungible> NonFungibleAdress;
        public void AddSupportedAdress(List<Assets.Assets> assetsList)
        {
            foreach (var VARIABLE in assetsList)
            {
                SupportedFungibleNonfungibleAdress.Add(VARIABLE.Adress);
            }
        }
        
        /*
         I know that these next functions could be interfaces but my when I tried to add them my IDE said that my .NET version in to low.
         Please take this into consideration. TotalValueOfAssets and ValueConverter could be in one interface becouse they are used by solana and ethereum wallets but my IDE 
         wouldn't let me do it. Thanks in advance! 
         */

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