using System;
using System.Collections.Generic;

namespace CryptoWallet.Wallets
{
    public class EtheriumWallet : Wallet
    {
        public EtheriumWallet() : base()
        {
            WalletType = Enums.WalletType.Ethereum;
        }
        
        public Guid NonFungibleAdress;
        public List<Guid> SupportedFungibleNonfungibleAdress { get; }
        
        public void AddSupportedAdress(List<Assets.Assets> assetsList)
        {
            foreach (var VARIABLE in assetsList)
            {
                SupportedFungibleNonfungibleAdress.Add(VARIABLE.Adress);
            }
        }
    }
}