using System;
using System.Collections.Generic;

namespace CryptoWallet.Wallets
{
    public class SolanaWallet : Wallet
    {
        public SolanaWallet() : base()
        {
            WalletType = Enums.WalletType.Solana;
        }
        
        protected List<Guid> SupportedFungibleNonfungibleAdress { get; }
        public Guid NonFungibleAdress;
        public void AddSupportedAdress(List<Assets.Assets> assetsList)
        {
            foreach (var VARIABLE in assetsList)
            {
                SupportedFungibleNonfungibleAdress.Add(VARIABLE.Adress);
            }
        }

    }
}