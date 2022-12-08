using System;

namespace CryptoWallet.Transactions
{
    public class NonFungibleTransaction : Transaction
    {
        public NonFungibleTransaction(Guid sendingWalletAdress, Guid recievingWalletAdress) : base(sendingWalletAdress,recievingWalletAdress){}
        
    }
}